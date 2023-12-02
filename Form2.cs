using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGlobos
{
    public partial class Form2 : Form
    {  // Método de cierre del Form2
        private void Form2ClosedEventHandler(object sender, EventArgs e)
        {
            // Cierre del Form1
            this.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
