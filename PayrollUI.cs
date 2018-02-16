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
    }
}
