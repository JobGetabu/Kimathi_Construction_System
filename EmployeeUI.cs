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

namespace Kimathi_Construction
{
    public partial class EmployeeUI : UserControl
    {
        private static EmployeeUI _instance;
        public static EmployeeUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeUI();
                }
                return _instance;
            }
        }
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            //UI code
            SetToolTip(owner, "Follow at twitter @Job_Getabu ;)");

            CheckInPrep();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //using (var context = new kimathiEntities())
            //{
            //    context.Database.Connection.Open();
            //    if (context.Database.Connection.State == ConnectionState.Open)
            //    {
            //        MessageBox.Show("Connected");
            //    }
            //}

            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Name !", alert.AlertType.warnig);
                return;
            }
            if (string.IsNullOrEmpty(tbDept.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Department !", alert.AlertType.warnig);
                return;
            }
            if (string.IsNullOrEmpty(tbTypeOfemployee.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Employee Type !", alert.AlertType.warnig);
                return;
            }
            if (string.IsNullOrEmpty(tbIdReg.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Employee ID !", alert.AlertType.warnig);
                return;
            }

            try
            {
                Employee my = new Employee();
                my.IdNum = int.Parse(tbId.Text);
                my.Name = tbFullName.Text;
                my.TypeOfEmployee = tbTypeOfemployee.Text;
                my.Department = tbDept.Text;

                using (var context = new kimathiEntities())
                {
                    context.Employees.Add(my);
                    context.SaveChanges();
                    alert.Show("Saved !", alert.AlertType.success);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Employee ID !", alert.AlertType.warnig);
                return;
            }

            Employee yy = empFound(tbId.Text);

            if (yy != null)
            {
                lblVerificationReport.Text = "Employee Found";
                alert.Show("Employee Found !", alert.AlertType.success);
               
            }
            else
            {
                lblVerificationReport.Text = "Employee not Found";
                alert.Show("Employee not Found !", alert.AlertType.error);
            }
        }
        private Employee empFound(string idnum)
        {
            using (var context = new kimathiEntities())
            {
                var userList = context.Employees.ToList();

                foreach (var ss in userList.Where(a => a.IdNum.Equals(idnum)))
                {
                    return ss;

                }
                return null;
            }
        }

        private void CheckInPrep()
        {

            if (string.IsNullOrEmpty(tbDateIn.Text))
            {
                //UI code  

                alert.Show("Required info \n Date In !", alert.AlertType.warnig);
                return;
            }
            if (string.IsNullOrEmpty(tbDateOut.Text))
            {
                //UI code  

                alert.Show("Required info \n Date Out !", alert.AlertType.warnig);
                return;
            }

            Employee yy = empFound(tbId.Text);
            Work dowork = new Work();
            if (yy != null)
            {

                int xx = yy.IdNum;
                using (var context = new kimathiEntities())
                {
                    var wList = context.Works
                        .Where(a=>a.Id == xx)
                        .ToList();

                    foreach (var ss in wList.Where(a => a.Id.Equals(xx)))
                    {
                        dowork = ss;

                    }

                    if (dowork != null)
                    {
                        //tbDateIn.Text = dowork.TimeIn.Value.ToShortTimeString();
                        //tbDateOut.Text = dowork.TimeIn.Value.ToShortTimeString();

                        dowork.TimeIn = DateTime.Parse(tbDateIn.Text);
                        dowork.TimeOut = DateTime.Parse(tbDateOut.Text);
                        dowork.Employee = yy;
                        context.Entry<Work>(dowork).State = EntityState.Modified;
                        try
                        {
                            context.SaveChanges();
                            alert.Show("Updated !", alert.AlertType.success);
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        //tbDateIn.Text = DateTime.Now.ToShortTimeString();
                        //tbDateOut.Text = "";

                        Work doworkk = new Work();
                        doworkk.TimeIn = DateTime.Parse(tbDateIn.Text);
                        doworkk.TimeOut = DateTime.Parse(tbDateOut.Text);
                        doworkk.Employee = yy;
                        context.Works.Add(doworkk);

                        try
                        {
                            context.SaveChanges();
                            alert.Show("Updated !", alert.AlertType.success);
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee yy = empFound(tbId.Text);
            Work dowork = new Work();
            if (yy != null)
            {

                int xx = yy.IdNum;
                using (var context = new kimathiEntities())
                {
                    var wList = context.Works
                        .Where(a => a.Id == xx)
                        .ToList();

                    foreach (var ss in wList.Where(a => a.Id.Equals(xx)))
                    {
                        dowork = ss;

                    }

                    if (dowork != null)
                    {
                        tbDateIn.Text = dowork.TimeIn.Value.ToShortTimeString();
                        tbDateOut.Text = dowork.TimeIn.Value.ToShortTimeString();
                    }
                    else
                    {
                        tbDateIn.Text = DateTime.Now.ToShortTimeString();
                        tbDateOut.Text = "";
                    }
                }
            }
        }
    }
}
