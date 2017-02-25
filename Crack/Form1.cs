using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crack
{
    public partial class Form1 : Form
    {
        int numbers = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string crackpassstring = Convert.ToString(numbers);
            numbers += 1;
            SendKeys.Send(crackpassstring);
            SendKeys.Send("{Enter}");
            SendKeys.Send("{Enter}");
        }
    }
    }
