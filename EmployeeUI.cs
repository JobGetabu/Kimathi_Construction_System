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
        Employee theemp;
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

            Employee yy = empFound(long.Parse(tbIdReg.Text));
            theemp = yy;

            if (yy != null)
            {
                //UI code  

                alert.Show("Error \n Employee ID Found!", alert.AlertType.warnig);
                return;
            }

            try
            {
                Employee my = new Employee();
                my.IdNum = long.Parse(tbIdReg.Text);
                my.Name = tbFullName.Text;
                my.TypeOfEmployee = tbTypeOfemployee.Text;
                my.Department = tbDept.Text;

                using (var context = new KimathiEntities())
                {
                    try
                    {
                        context.Employees.Add(my);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }

                    alert.Show("Saved !", alert.AlertType.success);
                    CheckInPrep();
                }

            }
            catch (Exception) { }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                //UI code  

                alert.Show("Required info \n Enter Employee ID !", alert.AlertType.warnig);
                return;
            }

            Employee yy = empFound(long.Parse(tbId.Text));
            theemp = yy;
            if (yy != null)
            {
                lblVerificationReport.Text = "Employee Found";
                lblVerificationReport.ForeColor = Color.Black;
                alert.Show("Employee Found !", alert.AlertType.success);
                theemp = yy;
                CheckInPrep();
                UICode();
            }
            else
            {
                lblVerificationReport.Text = "Employee not Found";
                lblVerificationReport.ForeColor = Color.Crimson;
                alert.Show("Employee not Found !", alert.AlertType.error);
                theemp = yy;
                CheckInPrep();
                UICode();
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

        private void UICode()
        {
            try
            {
                tbFullName.Text = theemp.Name;
                tbIdReg.Text = theemp.IdNum.ToString();
                tbDept.Text = theemp.Department;
                tbTypeOfemployee.Text = theemp.TypeOfEmployee;
            }
            catch (Exception) { }

        }

        private void CheckInPrep()
        {
            lblDate.Text = DateTime.Now.ToString("dd MMM yyy");

            Work dowork = null;
            if (theemp != null)
            {

                long xx = theemp.IdNum;
                using (var context = new KimathiEntities())
                {
                    var wList = context.Works
                        .OrderBy(a => a.TimeIn)
                        .Where(a => a.IdNum_fk == xx)
                        .ToList();

                    foreach (var ss in wList.Where(a => a.Employee == theemp))
                    {
                        if (ss.Id == theemp.IdNum)
                        {
                            //returns the latest work entry
                            dowork = ss;
                            break;
                        }
                    }

                    if (dowork != null)
                    {
                        dTimePickerIn.Value = dowork.TimeIn.Value;
                        dTimePickerOut.Value = dowork.TimeOut.Value;
                    }
                    else
                    {
                        dTimePickerIn.Value = DateTime.Now;
                        dTimePickerOut.Value = DateTime.Now;
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Work dowork = null;
            if (theemp != null)
            {

                long xx = theemp.IdNum;
                using (var context = new KimathiEntities())
                {
                    var wList = context.Works
                         .OrderBy(a => a.TimeOut)
                        .Where(a => a.IdNum_fk == xx)
                        .ToList();

                    foreach (var ss in wList.Where(a => a.Employee == theemp))
                    {
                        if (ss.Id == theemp.IdNum)
                        {
                            //returns the latest work entry
                            dowork = ss;
                            break;
                        }
                    }

                    if (dowork != null)
                    {
                        dowork.TimeIn = dTimePickerIn.Value;
                        dowork.TimeOut = dTimePickerOut.Value;
                        dowork.IdNum_fk = theemp.IdNum;

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

                        Work d = new Work();
                        
                        d.IdNum_fk = theemp.IdNum;
                        d.TimeIn = dTimePickerIn.Value;
                        d.TimeOut = dTimePickerOut.Value;
                        // d.Employee = theemp;

                        try
                        {
                            context.Works.Add(d);
                            context.SaveChanges();
                            alert.Show("Saved !", alert.AlertType.success);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }
                }
            }
        }
    }
}
