using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioners
{
    public partial class Dell : Form , IDell
    {
        public Dell()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Login;
    }
}
