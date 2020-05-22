using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace WindowsForms40
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
            Centralita centralita1 = new Centralita("Telefonica Santiago");
        }

        private void button1GenerarLlamada_Click(object sender, EventArgs e)
        {

        }
    }
}
