using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimathi_Construction
{
    public partial class Home : Form
    {
        private static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Home();
                }
                return _instance;
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetToolTip(Control ctl, string message)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.UseFading = true;
            toolTip1.UseAnimation = true;
            //toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(ctl, message);
        }

        private void TabSwitcher(Control UIinstance)
        {
            if (!this.containerUIs.Controls.Contains(UIinstance))
            {
                this.containerUIs.Controls.Add(UIinstance);
                UIinstance.Dock = DockStyle.Fill;
                UIinstance.Visible = false;
                UIinstance.BringToFront();

                try
                {
                    using (BunifuAnimatorNS.BunifuTransition ss = new BunifuAnimatorNS.BunifuTransition())
                    {
                        ss.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
                        //this.bunifuTransitionUIs
                        ss.ShowSync(UIinstance);
                    }
                }
                catch (InvalidOperationException)
                {

                    //this exception occurs when the transition is not complete ;(
                }
                catch (System.Reflection.TargetInvocationException exp)
                {
                   // MessageBox.Show(exp.Message + " \n" + exp.InnerException.Message);
                }
                catch (Exception exx)
                {
                   // MessageBox.Show(exx.Message, "Try again");
                }
            }
            else
            {
                UIinstance.Visible = false;
                UIinstance.BringToFront();
                try
                {
                    using (BunifuAnimatorNS.BunifuTransition ss = new BunifuAnimatorNS.BunifuTransition())
                    {
                        ss.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
                        //this.bunifuTransitionUIs
                        ss.ShowSync(UIinstance);
                    }
                }
                catch (InvalidOperationException)
                {
                    //this exception occurs when the transition is not complete ;(
                }
                catch (System.Reflection.TargetInvocationException exp)
                {
                    // MessageBox.Show(exp.Message + " \n" + exp.InnerException.Message);
                }
                catch (Exception exx)
                {
                    // MessageBox.Show(exx.Message, "Try again");
                }
                finally
                {
                    //incase of transition bug
                    UIinstance.Visible = true;
                    UIinstance.BringToFront();
                }
            }

            containerUIs.Refresh();
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            //UI code
            bunifuSeparator1.Width = tab1.Width;
            bunifuSeparator1.Left = tab1.Left;

            //Show FeePayment
            TabSwitcher(EmployeeUI.Instance);
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            //UI code
            bunifuSeparator1.Width = tab2.Width;
            bunifuSeparator1.Left = tab2.Left;

            //Show FeePayment
            TabSwitcher(StockUI.Instance);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //tab1 selected =true;

            //Show FeeemploymentPayment
            tab1_Click(sender, e);
            
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            //UI code
            bunifuSeparator1.Width = tab3.Width;
            bunifuSeparator1.Left = tab3.Left;

            //Show FeePayment
            TabSwitcher(PayrollUI.Instance);
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            //UI code
            bunifuSeparator1.Width = tab4.Width;
            bunifuSeparator1.Left = tab4.Left;

            //Show FeePayment
            TabSwitcher(StatsUI.Instance);
        }
    }
}
