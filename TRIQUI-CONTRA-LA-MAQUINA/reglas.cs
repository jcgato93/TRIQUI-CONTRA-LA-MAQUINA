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
    public partial class reglas : Form
    {
        public reglas()
        {
            InitializeComponent();
        }

        private void ingresar1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
                     
            this.Hide(); //oculta la forma actual
            //this.Close(); //cierra el formulario actual
            frm.ShowDialog(); 

        }
    }
}
