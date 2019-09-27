using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var pizza=new pizza();
            MessageBox.Show("Pizza con queso Creado!!");

            var refresco = new refresco();
            var soda = new soda();
            pizza.refresco = refresco;

        }
    }
}
