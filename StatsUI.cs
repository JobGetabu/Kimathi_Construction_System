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
    public partial class StatsUI : UserControl
    {
    private static StatsUI _instance;
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
        }
    }
}
