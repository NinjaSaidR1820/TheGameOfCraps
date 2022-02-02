using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class TheGameOfScrap : Form
    {
        Dados p = new Dados();

    
        public TheGameOfScrap()
        {
            InitializeComponent();

            p = new Dados();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Dados juego = new Dados();
   
            juego.jugar();
            

        }
    }
}
