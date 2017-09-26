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
    public partial class Form4 : Form
    {
        public string aux = "", jugador1 = "Jugador [x]", jugador2 = "Jugador [O]";

        public int jugadas, X = 0, O = 0,empate=0;

        public Form4()
        {
            InitializeComponent();
        }


        public void limpiar_controles()
        {
            //this.cbo.ComboBox.clear();
            //((TextBox)tex1).Clear();//limpiar la caja de textBox
            this.btn1.Text = "";      //limpiar el button
            //((TextBox)tex2).Clear();
            this.btn2.Text = "";
            //((TextBox)tex3).Clear();
            this.btn3.Text = "";
            //((TextBox)tex4).Clear();
            this.btn4.Text = "";
            //((TextBox)tex5).Clear();
            this.btn5.Text = "";
            //((TextBox)tex6).Clear();
            this.btn6.Text = "";
            //((TextBox)tex7).Clear();
            this.btn7.Text = "";
            //((TextBox)tex8).Clear();
            this.btn8.Text = "";
            //((TextBox)tex9).Clear();
            this.btn9.Text = "";
            //((TextBox)textBox1).Clear();
            //this.J2.Text = "";
            //this.J1.Text = "";
        }
        public void apagar_controles()
        {
            this.btn1.Enabled = false;
            this.btn2.Enabled = false;
            this.btn3.Enabled = false;
            this.btn4.Enabled = false;
            this.btn5.Enabled = false;
            this.btn6.Enabled = false;
            this.btn7.Enabled = false;
            this.btn8.Enabled = false;
            this.btn9.Enabled = false;

        }
        public void encender_controles()
        {
            this.btn1.Enabled = true;
            this.btn2.Enabled = true;
            this.btn3.Enabled = true;
            this.btn4.Enabled = true;
            this.btn5.Enabled = true;
            this.btn6.Enabled = true;
            this.btn7.Enabled = true;
            this.btn8.Enabled = true;
            this.btn9.Enabled = true;
            this.cbo.Enabled = false;
            this.iniciar.Enabled = false;

        }

        public void ganar()
        {
            if (this.btn1.Text == "X" && this.btn2.Text == "X" && this.btn3.Text == "X" || this.btn4.Text == "X" && this.btn5.Text == "X" && this.btn6.Text == "X"
                || this.btn7.Text == "X" && this.btn8.Text == "X" && this.btn9.Text == "X" || this.btn1.Text == "X" && this.btn5.Text == "X" && this.btn9.Text == "X"
                || this.btn3.Text == "X" && this.btn5.Text == "X" && this.btn7.Text == "X" || this.btn1.Text == "X" && this.btn4.Text == "X" && this.btn7.Text == "X"
                || this.btn2.Text == "X" && this.btn5.Text == "X" && this.btn8.Text == "X" || this.btn3.Text == "X" && this.btn6.Text == "X" && this.btn9.Text == "X"
               )

            // if (this.tex1.Text == "X" && this.tex2.Text == "X" && this.tex3.Text == "X" || this.tex4.Text == "X" && this.tex5.Text == "X" && this.tex6.Text == "X"
            // || this.tex7.Text == "X" && this.tex8.Text == "X" && this.tex9.Text == "X" || this.tex1.Text == "X" && this.tex5.Text == "X" && this.tex9.Text == "X"
            // || this.tex3.Text == "X" && this.tex5.Text == "X" && this.tex7.Text == "X" || this.tex1.Text == "X" && this.tex4.Text == "X" && this.tex7.Text == "X"
            // || this.tex2.Text == "X" && this.tex5.Text == "X" && this.tex8.Text == "X" || this.tex3.Text == "X" && this.tex6.Text == "X" && this.tex9.Text == "X"
            //)
            {
                MessageBox.Show("EL JUGADOR " + jx + " GANO LA PARTIDA", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
                limpiar_controles();
                apagar_controles();
                this.npartida.Enabled = true;

                X++;
                scorex.Text = Convert.ToString(X);
            }
            else
            {
                if (this.btn1.Text == "O" && this.btn2.Text == "O" && this.btn3.Text == "O" || this.btn4.Text == "O" && this.btn5.Text == "O" && this.btn6.Text == "O"
                 || this.btn7.Text == "O" && this.btn8.Text == "O" && this.btn9.Text == "O" || this.btn1.Text == "O" && this.btn5.Text == "O" && this.btn9.Text == "O"
                 || this.btn3.Text == "O" && this.btn5.Text == "O" && this.btn7.Text == "O" || this.btn1.Text == "O" && this.btn4.Text == "O" && this.btn7.Text == "O"
                 || this.btn2.Text == "O" && this.btn5.Text == "O" && this.btn8.Text == "O" || this.btn3.Text == "O" && this.btn6.Text == "O" && this.btn9.Text == "O"
                )

                //if (   this.tex1.Text == "O" && this.tex2.Text == "O" && this.tex3.Text == "O" || this.tex4.Text == "O" && this.tex5.Text == "O" && this.tex6.Text == "O"
                //    || this.tex7.Text == "O" && this.tex8.Text == "O" && this.tex9.Text == "O" || this.tex1.Text == "O" && this.tex5.Text == "O" && this.tex9.Text == "O"
                //    || this.tex3.Text == "O" && this.tex5.Text == "O" && this.tex7.Text == "O" || this.tex1.Text == "O" && this.tex4.Text == "O" && this.tex7.Text == "O"
                //    || this.tex2.Text == "O" && this.tex5.Text == "O" && this.tex8.Text == "O" || this.tex3.Text == "O" && this.tex6.Text == "O" && this.tex9.Text == "O"
                //   )
                {
                    MessageBox.Show("EL JUGADOR "+ jo +" GANO LA PARTIDA", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
                    limpiar_controles();
                    apagar_controles();
                    this.npartida.Enabled = true;

                    O++;
                    scoreo.Text = Convert.ToString(O);

                }
                else
                {
                    if (jugadas == 9)
                    {
                        MessageBox.Show(" HAY EMPATE", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        apagar_controles();
                        limpiar_controles();
                        this.npartida.Enabled = true;
                        empate++;
                        empates.Text = Convert.ToString(empate);
                    }
                }

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            apagar_controles();
            this.npartida.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn1.Text = aux;
            this.btn1.Enabled = false;

            jugadas = jugadas + 1;

            ganar();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn2.Text = aux;
            this.btn2.Enabled = false;

            jugadas = jugadas + 1;

            ganar();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn3.Text = aux;
            this.btn3.Enabled = false;
            jugadas = jugadas + 1;
            ganar();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn4.Text = aux;
            this.btn4.Enabled = false;
            jugadas = jugadas + 1;
            ganar();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn5.Text = aux;
            this.btn5.Enabled = false;
            jugadas = jugadas + 1;
            ganar();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn6.Text = aux;
            this.btn6.Enabled = false;
            jugadas = jugadas + 1;
            ganar();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn7.Text = aux;
            this.btn7.Enabled = false;

            jugadas = jugadas + 1;

            ganar();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn8.Text = aux;
            this.btn8.Enabled = false;

            jugadas = jugadas + 1;

            ganar();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (aux == "X") { aux = "O"; } else { aux = "X"; }

            //this.tex1.Text = aux;
            this.btn9.Text = aux;
            this.btn9.Enabled = false;

            jugadas = jugadas + 1;

            ganar();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.cbo.Text))//COMPARANDO LA CAJA DEL COMBOBOX PARA ENCENDER CONTROLES
            {
                MessageBox.Show("SELECCIONE ITEM !!", "INFORMACION GENERAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbo.Focus();
                return;
            }
            if (cbo.Text == "[X]")
            {
                this.n1.Text = cbo.Text;
                this.n2.Text = "[O]";
            }
            else
            {
                if (cbo.Text == "[O]")
                {
                    this.n1.Text = cbo.Text;
                    this.n2.Text = "[X]";
                }

            }

            encender_controles();
            this.npartida.Enabled = false;
            //aux = this.cbo.SelectedItem.ToString(); //ASIGNANDOLE LA LETRA DEL COMBOBOX A LA VARIABLE GLOBAL AUX

            aux = cbo.SelectedItem.ToString();
            if (aux == "X") { aux = "O"; } else { aux = "X"; }
        }

        private void npartida_Click(object sender, EventArgs e)
        {
            jugadas = 0;
            //((ComboBox)cbo).SelectedIndex = -1;
            //this.cbo.Enabled = true;
            apagar_controles();
            if (this.cbo.SelectedIndex == 1)
            {
                iniciar.Enabled = false;
                encender_controles();


            }
            this.iniciar.Enabled = true;
            limpiar_controles();
        }

       
    }
}
