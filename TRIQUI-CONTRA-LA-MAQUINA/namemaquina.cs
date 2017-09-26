using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIQUI_CONTRA_LA_MAQUINA
{
    public partial class maquina : Form
    {
        public maquina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();

            frm.jugador.Text = namex.Text;
           
            this.Hide(); //oculta la forma actual
            //this.Close(); //cierra el formulario actual
            frm.ShowDialog();
        }

        private void maquina_Load(object sender, EventArgs e)
        {

        }

        
    }
}
