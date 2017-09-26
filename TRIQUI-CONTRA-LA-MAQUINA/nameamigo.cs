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
    public partial class amigo : Form
    {
        public amigo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();

           frm.jx.Text = namex.Text;
           frm.jo.Text = nameo.Text;
          
            this.Hide(); //oculta la forma actual
            //this.Close(); //cierra el formulario actual
            frm.ShowDialog();
        }

            

        
    }
}
