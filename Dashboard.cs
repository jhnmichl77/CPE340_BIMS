using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE340_BIMS
{
    public partial class Dashboard: MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();
            Shared.Set(this);
        }
    }
}
