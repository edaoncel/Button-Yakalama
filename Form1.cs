using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYakala_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            btnYakala.Left = r.Next(0, 501);
            btnYakala.Top = r.Next(0, 501);
        }
    }
}
