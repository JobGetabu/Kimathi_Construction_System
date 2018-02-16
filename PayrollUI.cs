using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimathi_Construction
{
    public partial class PayrollUI : UserControl
    {
        private static PayrollUI _instance;
        public static PayrollUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PayrollUI();
                }
                return _instance;
            }
        }
        public PayrollUI()
        {
            InitializeComponent();
        }

        private void PayrollUI_Load(object sender, EventArgs e)
        {
            //UI code
            SetToolTip(owner, "Follow at twitter @Job_Getabu ;)");

            GridInitializer(DateTime.Now);
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

        private void gData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GridIconPicker(this.gData.Rows[e.RowIndex].Cells[6], this.gData.Rows[e.RowIndex].Cells[5], e);
        }

        private void GridIconPicker(DataGridViewCell rPic, DataGridViewCell pay, DataGridViewRowsAddedEventArgs e)
        {
            string test = (string)pay.Value;
            string t1 = test.Remove(0, 4);
            string t2 = t1.Replace(",", "");
            int cAmount;
            int.TryParse(t2, out cAmount);


            if (cAmount == 0)
            {
                rPic.Value = Res._1pending;

                this.gData.Rows[e.RowIndex].Cells[3].Style = new DataGridViewCellStyle { ForeColor = Color.Cyan };
                this.gData.Rows[e.RowIndex].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                this.gData.Rows[e.RowIndex].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Blue };

            }
            else
            {
                rPic.Value = Res._1pending;

                this.gData.Rows[e.RowIndex].Cells[3].Style = new DataGridViewCellStyle { ForeColor = Color.Cyan };
                this.gData.Rows[e.RowIndex].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                this.gData.Rows[e.RowIndex].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Blue };
            }
            this.gData.Rows[e.RowIndex].Cells[0].Value = Res.ok80;
            this.gData.Rows[e.RowIndex].Cells[7].Value = Res.Trash_Can_50px;
        }

        private void gData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void GridInitializer(DateTime leo)
        {
            //change color of INX to green
            //gData.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;

            var bb = leo.Day;

            var workListAsync = await Task.Factory.StartNew(() =>
            {
                using (var context = new KimathiEntities())
                {
                    return context.Works
                    .OrderBy(x => x.Id)
                    .Where(t => t.TimeIn.Value.Day == bb)
                    .ToList();
                }
            });

            gData.Rows.Clear();

            try
            {
                foreach (var item in workListAsync)
                {
                    var hrs = item.TimeOut.Value - item.TimeIn.Value;
                    var pay = hrs.TotalHours * int.Parse(tbRate.Text);

                    gData.Rows.Add(new string[]
                        {
                          null,
                          $"{item.Employee.IdNum}",
                          $"{item.Employee.Name}",
                          $"{item.TimeIn.Value.ToShortTimeString()}",
                          $"{item.TimeOut.Value.ToShortTimeString()}",
                          $"KES {String.Format("{0:0,0}", pay)}",
                           null,
                           null                          
                        });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
