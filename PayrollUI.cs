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
    }
}
