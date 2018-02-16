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
    public partial class StockUI : UserControl
    {
        private static StockUI _instance;
        public static StockUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StockUI();
                }
                return _instance;
            }
        }
        public StockUI()
        {
            InitializeComponent();
        }

        private void StockUI_Load(object sender, EventArgs e)
        {
            //UI code
            SetToolTip(owner, "Follow at twitter @Job_Getabu ;)");

            //load up the gui
            LoadUpGui();
        }

        private async void LoadUpGui()
        {
            using (var context = new KimathiEntities())
            {
                var stoklist = await Task.Factory.StartNew(() =>
                {
                    return context.Stocks
                    .OrderBy(x => x.Id)
                    .ToList();
                });

                var temp1 = stoklist.Where(x => x.RawMaterial.Equals("cement"));
                var temp2 = stoklist.Where(x => x.RawMaterial.Equals("water"));
                var temp3 = stoklist.Where(x => x.RawMaterial.Equals("brick"));

                tbcementreg.Text = temp1.FirstOrDefault().AmountIn.ToString();
                tbwaterreg.Text = temp2.FirstOrDefault().AmountIn.ToString();
                tbbrickreg.Text = temp1.FirstOrDefault().AmountIn.ToString();

                //notifications
                Notifications();

                //remaining
                lbltu.Text = temp1.FirstOrDefault().Quantity.ToString() +" Kg";
                lblWtr.Text = temp2.FirstOrDefault().Quantity.ToString() + " ltr";
                lblBricks.Text = temp3.FirstOrDefault().Quantity.ToString() + " pieces";

            }
        }

        private async void Notifications()
        {
            using (var context = new KimathiEntities())
            {
                var stoklist = await Task.Factory.StartNew(() =>
                {
                    return context.Stocks
                    .OrderBy(x => x.Id)
                    .ToList();
                });

                var temp1 = stoklist.Where(x => x.RawMaterial.Equals("cement"));
                var temp2 = stoklist.Where(x => x.RawMaterial.Equals("water"));
                var temp3 = stoklist.Where(x => x.RawMaterial.Equals("brick"));

                tbcementreg.Text = temp1.FirstOrDefault().AmountIn.ToString();
                tbwaterreg.Text = temp2.FirstOrDefault().AmountIn.ToString();
                tbbrickreg.Text = temp1.FirstOrDefault().AmountIn.ToString();

                //cement
                if (temp1.FirstOrDefault().Quantity < 50)
                {
                    not1.Text = "Low Cement"; //Low Cement
                    not1.ForeColor = Color.Crimson;
                }
                else
                {
                    not1.Text = "Cement Available"; //Low Cement
                    not1.ForeColor = Color.Black;
                }
                if (temp1.FirstOrDefault().Quantity < 40)
                {
                    not1.Text = "Very Low Cement"; //Low Cement
                    not1.ForeColor = Color.Crimson;
                }
                if (temp1.FirstOrDefault().Quantity < 5 | temp1.FirstOrDefault().Quantity == 0)
                {
                    not1.Text = "No Usable Cement"; //Low Cement
                    not1.ForeColor = Color.Crimson;
                }
                //water
                if (temp2.FirstOrDefault().Quantity < 500)
                {
                    not2.Text = "Water Low"; //Low Cement
                    not2.ForeColor = Color.Crimson;
                }
                else
                {
                    not2.Text = "Water Available"; //Low Cement
                    not2.ForeColor = Color.Black;
                }
                if (temp2.FirstOrDefault().Quantity < 400)
                {
                    not2.Text = "Very Low water level"; //Low Cement
                    not2.ForeColor = Color.Crimson;
                }
                if (temp2.FirstOrDefault().Quantity < 200 | temp2.FirstOrDefault().Quantity == 0)
                {
                    not2.Text = "No Usable Water"; //Low Cement
                    not2.ForeColor = Color.Crimson;
                }

                //bricks
                if (temp3.FirstOrDefault().Quantity < 50)
                {
                    not3.Text = "Less Bricks"; //Low Cement
                    not3.ForeColor = Color.Crimson;
                }
                else
                {
                    not3.Text = "Bricks Available"; //Low Cement
                    not3.ForeColor = Color.Black;
                }
                if (temp3.FirstOrDefault().Quantity < 40)
                {
                    not3.Text = "Minimal Bricks"; //Low Cement
                    not3.ForeColor = Color.Crimson;
                }
                if (temp3.FirstOrDefault().Quantity < 5 | temp3.FirstOrDefault().Quantity == 0)
                {
                    not1.Text = "No Bricks"; //Low Cement
                    not1.ForeColor = Color.Crimson;
                }
            }
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

        private void tbcementreg_OnValueChanged(object sender, EventArgs e)
        {
            btnSave1.Visible = true;
            lbltu.Visible = false;
        }

        private void tbwaterreg_OnValueChanged(object sender, EventArgs e)
        {
            btnSave2.Visible = true;
            lbltu2.Visible = false;
        }

        private void tbbrickreg_OnValueChanged(object sender, EventArgs e)
        {
            btnSave3.Visible = true;
            lbltu3.Visible = false;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            btnSave1.Visible = false;
            lbltu.Visible = true;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            btnSave2.Visible = false;
            lbltu2.Visible = true;
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            btnSave3.Visible = false;
            lbltu3.Visible = true;
        }
    }
}
