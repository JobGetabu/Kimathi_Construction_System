using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using custom_alert_notifications;
using MetroFramework;

namespace Kimathi_Construction
{
    public partial class PayrollUI : UserControl
    {
        private static PayrollUI _instance;
        private Bitmap value;
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
            SetToolTip(owner, "Follow twitter @Job_Getabu ;)");

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
            int cAmount; //might use it later
            int.TryParse(t2, out cAmount);

            //styling
            this.gData.Rows[e.RowIndex].Cells[3].Style = new DataGridViewCellStyle { ForeColor = Color.DeepPink };
            this.gData.Rows[e.RowIndex].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            this.gData.Rows[e.RowIndex].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Blue };


            //add the 

            //if (cAmount == 0)
            //{
            //    rPic.Value = Res._1pending;
            //}
            //else
            //{
            //    rPic.Value = Res._1pending;               
            //}

            this.gData.Rows[e.RowIndex].Cells[0].Value = Res.ok80;
            this.gData.Rows[e.RowIndex].Cells[7].Value = Res.Trash_Can_50px;
            rPic.Value = value;
        }

        private async void gData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    if ((await GridDelImageAsync(e.RowIndex)) != null)
                    {
                        using (var context = new KimathiEntities())
                        {
                            try
                            {
                                context.Entry<Work>(await GridDelImageAsync(e.RowIndex)).State = EntityState.Deleted;
                                context.SaveChanges();

                                //short Custom Notification
                                alert.Show("Deleted", alert.AlertType.warnig);
                                gData.Rows[e.RowIndex].Visible = false;
                                //Load the grid again
                                GridInitializer(dTimePickerGrid.Value);                             
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show("Something went wrong" + exp.Message, "Unsuccessful");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == 0)
                {
                    if (MetroMessageBox.Show(this, "Payment", $"Hi do you want to pay {this.gData.Rows[e.RowIndex].Cells[1].Value.ToString()} {this.gData.Rows[e.RowIndex].Cells[5].Value.ToString()}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //this employee wages have been payed
                        //get instance of employee and pay
                        var xx = await GridDelImageAsync(e.RowIndex));
                        xx.Payed = 1;
                        try
                        {
                            using (var context = new KimathiEntities())
                            {
                                context.Entry<Work>(await GridDelImageAsync(e.RowIndex)).State = EntityState.Modified;
                                context.SaveChanges();
                                //short Custom Notification
                                alert.Show("Payment Successfull", alert.AlertType.info);
                            }
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private async void GridInitializer(DateTime leo)
        {
            //change color of INX to green
            //gData.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;

            var bb = leo.Date.ToShortDateString();

            var workListAsync = await Task.Factory.StartNew(() =>
            {
                using (var context = new KimathiEntities())
                {
                    return context.Works
                    .OrderBy(x => x.Id)
                    //.Where(t => t.TimeIn.Value.Date.ToShortDateString() == bb)
                    .ToList();
                }
            });

            gData.Rows.Clear();

            try
            {
                foreach (var item in workListAsync)
                {
                    if (item.TimeIn.Value.Date.ToShortDateString().Equals(bb))
                    {
                        var hrs = item.TimeOut.Value - item.TimeIn.Value;
                        var pay = hrs.TotalHours * int.Parse(tbRate.Text);
                        value = item.Payed == 0 ? Res._1pending : Res._1paid;



                        gData.Rows.Add(new string[]
                            {
                          null,
                          $"{empFound(item.IdNum_fk).IdNum}",
                          $"{empFound(item.IdNum_fk).Name}",
                          $"{item.TimeIn.Value.ToShortTimeString()}",
                          $"{item.TimeOut.Value.ToShortTimeString()}",
                          $"KES {String.Format("{0:0,0}", pay)}",
                          null,
                           null
                            });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private Employee empFound(long idnum)
        {
            using (var context = new KimathiEntities())
            {
                var userList = context.Employees.ToList();

                foreach (var ss in userList.Where(a => a.IdNum == (idnum)))
                {
                    if (ss.IdNum == idnum)
                    {
                        return ss;
                    }

                }
                return null;
            }
        }
        private void dTimePickerGrid_ValueChanged(object sender, EventArgs e)
        {
            //set up the GridInitilizer
            var dt = dTimePickerGrid.Value;
            GridInitializer(dt);
        }

        private async Task<Work> GridDelImageAsync(int rowIndex)
        {
            List<Work> wkList = await Task.Factory.StartNew(() =>
            {
                using (var context = new KimathiEntities())
                {
                    return context.Works.ToList();
                }
            });

            string details;
            details = $"{(string)this.gData.Rows[rowIndex].Cells[1].Value} {(string)this.gData.Rows[rowIndex].Cells[3].Value} {(string)this.gData.Rows[rowIndex].Cells[4].Value}";

            foreach (var fi in wkList)
            {
                string id = $"{fi.IdNum_fk} {fi.TimeIn.Value.ToShortTimeString()} {fi.TimeOut.Value.ToShortTimeString()}";
                if (id.Equals(details))
                {
                    return fi;
                }
            }
            return null;
        }
    }
}
