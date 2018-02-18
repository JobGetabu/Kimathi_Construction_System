using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace Kimathi_Construction
{
    public partial class StatsUI : UserControl
    {
        private static StatsUI _instance;
        private ChartValues<double> cIncome;

        double incDay0 = 0; double incDay5 = 0; double incDay10 = 0;
        double incDay15 = 0; double incDay20 = 0; double incDay25 = 0;
        double incDayLast = 0;


        public static StatsUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StatsUI();
                }
                return _instance;
            }
        }
        public StatsUI()
        {
            InitializeComponent();

            MonthlyUISet();

            cartesianChart1.DataClick += CartesianChart1OnDataClick;
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        public void Global_StatsUI_Load()
        {
            //update chart or not
        }
        private void StatsUI_Load(object sender, EventArgs e)
        {
            //UI code
            SetToolTip(owner, "Follow at twitter @Job_Getabu ;)");
        }
        private void SetToolTip(Control ctl, string message)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.UseFading = true;
            toolTip1.UseAnimation = true;
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(ctl, message);
        }

        private void owner_Click(object sender, EventArgs e)
        {
            //UI code
            SetToolTip(owner, "Follow at twitter @Job_Getabu ;)");
            string fbPage = "https://twitter.com/job_getabu";
            try
            {
                System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(fbPage);
                System.Diagnostics.Process.Start(sInfo);
            }
            catch (Exception) { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        public void MonthlyUISet()
        {
            using (var context = new KimathiEntities())
            {


                var GMonth = DateTime.Now.Month;
                var GYear = DateTime.Now.Year;

                var firstDayOfMonth = new DateTime(GYear, GMonth, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);




                #region var init



                var incomeListAsync =
                    context.Works.ToList();

                //Days for income
                incDay0 = incomeListAsync.Where(x => x.TimeIn == firstDayOfMonth | x.TimeIn.Value.Day == 1)
                    .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();


                incDay5 = incomeListAsync.Where(x => x.TimeIn.Value.Day > 1 & x.TimeIn.Value.Day < 6)
                    .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();
                incDay10 = incomeListAsync.Where(x => x.TimeIn.Value.Day > 5 & x.TimeIn.Value.Day < 11)
                    .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();
                incDay15 = incomeListAsync.Where(x => x.TimeIn.Value.Day > 10 & x.TimeIn.Value.Day < 16)
                     .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();
                incDay20 = incomeListAsync.Where(x => x.TimeIn.Value.Day > 15 & x.TimeIn.Value.Day < 26)
                     .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();
                incDay25 = incomeListAsync.Where(x => x.TimeIn.Value.Day > 25 & x.TimeIn.Value.Day < 31)
                     .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();
                incDayLast = incomeListAsync.Where(x => x.TimeIn.Value.Day == lastDayOfMonth.Day)
                     .Select(
                        item =>
                        {
                            var hrs = item.TimeOut.Value - item.TimeIn.Value;
                            return hrs.TotalHours * int.Parse(PayrollUI.Instance.tbRate.Text);
                        }
                    ).FirstOrDefault();


                #endregion

                cIncome = new ChartValues<double> { incDay0, incDay5, incDay10, incDay15, incDay20, incDay25, incDayLast };

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Payment",
                        Values = cIncome
                    },

                };

                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Days",
                    Labels = new[] { "0", "5", "10", "15", "20", "25", "30" }
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Amount",
                    LabelFormatter = value => $"KES {String.Format("{0:0,0}", value)}"
                    //value.ToString("C3", CultureInfo.CreateSpecificCulture("sw-KE"))
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
        }

        private class hrs
        {
        }
    }
}
