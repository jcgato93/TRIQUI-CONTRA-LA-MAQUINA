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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ingresar2_Click(object sender, EventArgs e)
        {
            if (this.amigo.Checked == true)
            {

                amigo frm = new amigo();
                this.Hide(); //oculta la forma actual
                //this.Close(); //cierra el formulario actual
                frm.ShowDialog();
            }
            else
            {
                if (this.maquina.Checked == true)
                {
                    maquina frm = new maquina();
                    this.Hide(); //oculta la forma actual
                    //this.Close(); //cierra el formulario actual
                    frm.ShowDialog();
                }

            }
         
    }

        }
        }

        

