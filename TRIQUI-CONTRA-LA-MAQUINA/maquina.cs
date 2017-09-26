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
    public partial class Form6 : Form
    {


        //variables globales
    public string humano,oponente;
    public double turno=0, resultado=0,aux=2;
    public int turjugador=0, turmaquina=0, turempate=0;

    public String triunfo="";// para saber quien fue en el ganador y sumar al score, lo compara con el index del ComboBox

   public void modofacil()//funcion para colocar la ficha de la pc en cualquier parte disponible
    {
        if (btn1.Text.Equals("")) { btn1.Text = oponente; btn1.Enabled = false; aux++; turno++; }
        else if (btn2.Text.Equals("")) { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }
        else if (btn3.Text.Equals("")) { btn3.Text = oponente; btn3.Enabled = false; aux++; turno++; }
        else if (btn4.Text.Equals("")) { btn4.Text = oponente; btn4.Enabled = false; aux++; turno++; }
        else if (btn5.Text.Equals("")) { btn5.Text = oponente; btn5.Enabled = false; aux++; turno++; }
        else if (btn6.Text.Equals("")) { btn6.Text = oponente; btn6.Enabled = false; aux++; turno++; }
        else if (btn7.Text.Equals("")) { btn7.Text = oponente; btn7.Enabled = false; aux++; turno++; }
        else if (btn8.Text.Equals("")) { btn8.Text = oponente; btn8.Enabled = false; aux++; turno++; }
        else if (btn9.Text.Equals("")) { btn9.Text = oponente; btn9.Enabled = false; aux++; turno++; }

    }


        public Form6()
        {
            InitializeComponent();
        }

        public void limpiar_controles() //funcion para limpiar los botones del tablero 
        {
            
            this.btn1.Text = "";      
          
            this.btn2.Text = "";
          
            this.btn3.Text = "";
          
            this.btn4.Text = "";
          
            this.btn5.Text = "";
          
            this.btn6.Text = "";
          
            this.btn7.Text = "";
          
            this.btn8.Text = "";
          
            this.btn9.Text = "";
          
        }
        public void apagar_controles() //funcion para apagar los botones
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
        public void encender_controles() // funcion para encender los botones
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



        public void IA() {
            //si en el primer movimiento de la maquina estalibre el del centro,lo ocupara
            if (btn5.Text == "") { btn5.Text = oponente; turno++; aux++; btn5.Enabled = false; }
            else if (btn5.Text == humano && btn1.Text == humano && btn9.Text == "") { btn9.Text = oponente; btn9.Enabled = false; aux++; turno++; }
            else if (btn5.Text == humano && btn3.Text == humano && btn7.Text == "") { btn7.Text = oponente; btn7.Enabled = false; aux++; turno++; }
            else if (btn5.Text == humano && btn7.Text == humano && btn3.Text == "") { btn3.Text = oponente; btn3.Enabled = false; aux++; turno++; }
            else if (btn5.Text == humano && btn9.Text == humano && btn1.Text == "") { btn1.Text = oponente; btn1.Enabled = false; aux++; turno++; }

            else//si el de la mitad estavacio colocar marca en esa 
                if (btn5.Text == humano && btn8.Text == humano && btn7.Text == humano && btn1.Text == oponente && btn3.Text == oponente && btn2.Text == "") { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }else
            
            //---------------------------------------------------------------------------------------
            //cubrir horizontales
                if (btn1.Text == humano && btn3.Text == humano && btn2.Text == "") { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }//fila 1
                else if (btn1.Text == humano && btn2.Text == humano && btn3.Text == "") { btn3.Text = oponente; btn3.Enabled = false; aux++; turno++; }
                else if (btn2.Text == humano && btn3.Text == humano && btn1.Text == "") { btn1.Text = oponente; btn1.Enabled = false; aux++; turno++; }
                else
            //fila 2
                    if (btn4.Text == humano && btn6.Text == humano && btn5.Text == "") { btn5.Text = oponente; btn5.Enabled = false; aux++; turno++; }
                    else if (btn4.Text == humano && btn5.Text == humano && btn6.Text == "") { btn6.Text = oponente; btn6.Enabled = false; aux++; turno++; }
                    else if (btn5.Text == humano && btn6.Text == humano && btn4.Text == "") { btn4.Text = oponente; btn4.Enabled = false; aux++; turno++; }
                    else
            //fila 3
                        if (btn7.Text == humano && btn9.Text == humano && btn8.Text == "") { btn8.Text = oponente; btn8.Enabled = false; aux++; turno++; }
                        else if (btn7.Text == humano && btn8.Text == humano && btn9.Text == "") { btn9.Text = oponente; btn9.Enabled = false; aux++; turno++; }
                        else if (btn8.Text == humano && btn9.Text == humano && btn7.Text == "") { btn7.Text = oponente; btn7.Enabled = false; aux++; turno++; }
                        else

            //cubrir verticales 
            //columna 1
                            if (btn1.Text == humano && btn7.Text == humano && btn4.Text == "") { btn4.Text = oponente; btn4.Enabled = false; aux++; turno++; }
                            else if (btn1.Text == humano && btn4.Text == humano && btn7.Text == "") { btn7.Text = oponente; btn7.Enabled = false; aux++; turno++; }
                            else if (btn7.Text == humano && btn4.Text == humano && btn1.Text == "") { btn1.Text = oponente; btn1.Enabled = false; aux++; turno++; }
                            else
               
             //columna 2
                                if (btn2.Text == humano && btn8.Text == humano && btn5.Text == "") { btn5.Text = oponente; btn5.Enabled = false; aux++; turno++; }
                                else if (btn2.Text == humano && btn5.Text == humano && btn8.Text == "") { btn8.Text = oponente; btn8.Enabled = false; aux++; turno++; }
                                else if (btn8.Text == humano && btn5.Text == humano && btn2.Text == "") { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }
                                else
            //columna 3
                                    if (btn3.Text == humano && btn9.Text == humano && btn6.Text == "") { btn6.Text = oponente; btn6.Enabled = false; aux++; turno++; }
                                    else if (btn3.Text == humano && btn6.Text == humano && btn9.Text == "") { btn9.Text = oponente; btn9.Enabled = false; aux++; turno++; }
                                    else if (btn9.Text == humano && btn6.Text == humano && btn3.Text == "") { btn3.Text = oponente; btn3.Enabled = false; aux++; turno++; }
                                    else
           
            //Diagonales        
                                        if (btn1.Text == humano && btn9.Text == humano && btn5.Text == "") { btn5.Text = oponente; btn5.Enabled = false; aux++; turno++; }
                                        else if (btn3.Text == humano && btn7.Text == humano && btn5.Text == "") { btn5.Text = oponente; btn5.Enabled = false; aux++; turno++; }
            //validacion de (izqu a der) para saber si la maquina tiene el centro pero humano tiene 2 esquinas y mayor probabilidad de ganar
                                        else if (btn1.Text == humano && btn9.Text == humano && btn5.Text == oponente && btn2.Text == "") { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }
                                        else if (btn1.Text == humano && btn9.Text == humano && btn5.Text == oponente && btn4.Text == "") { btn4.Text = oponente; btn4.Enabled = false; aux++; turno++; }
                                        else if (btn1.Text == humano && btn9.Text == humano && btn5.Text == oponente && btn6.Text == "") { btn6.Text = oponente; btn6.Enabled = false; aux++; turno++; }
                                        else if (btn1.Text == humano && btn9.Text == humano && btn5.Text == oponente && btn8.Text == "") { btn8.Text = oponente; btn8.Enabled = false; aux++; turno++; }

            //validacion de (der a izq) para saber si la maquina tiene el centro pero humano tiene 2 esquinas y mayor probabilidad de ganar
                                        else if (btn3.Text == humano && btn7.Text == humano && btn5.Text == oponente && btn2.Text == "") { btn2.Text = oponente; btn2.Enabled = false; aux++; turno++; }
                                        else if (btn3.Text == humano && btn7.Text == humano && btn5.Text == oponente && btn4.Text == "") { btn4.Text = oponente; btn4.Enabled = false; aux++; turno++; }
                                        else if (btn3.Text == humano && btn7.Text == humano && btn5.Text == oponente && btn6.Text == "") { btn6.Text = oponente; btn6.Enabled = false; aux++; turno++; }
                                        else if (btn3.Text == humano && btn7.Text == humano && btn5.Text == oponente && btn8.Text == "") { btn8.Text = oponente; btn8.Enabled = false; aux++; turno++; }
                                        else if (btn3.Text == "") { btn3.Text = oponente; btn3.Enabled = false; aux++; turno++; }
                                        else { modofacil(); }


        }

        bool ganar() {//verifica cuando hay un ganador y quien es el ganador

            if (//gana en horizontal
                btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
               btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
                //gana en vertical
                btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
                //gana en diagonal
                btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"
                )
            {
                triunfo = "X"; MessageBox.Show("  GANA X  ", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Information); apagar_controles(); return true; 

            }
            else if (//este es el else para comparar si gana "O"
                //gana en horizontal
             btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
            btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
             btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" ||
                //gana en vertical
             btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
             btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
             btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
                //gana en diagonal
             btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
             btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"
             )
            {
                triunfo = "O"; MessageBox.Show("  GANA O  ", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Information); apagar_controles(); return true; 
            }
                //cuando se da el caso del empate
            else if (turno == 9) { MessageBox.Show("  ES UN EMPATE  ", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Information); apagar_controles(); return true; }
            else return false;
        }


 
     

        private void Form6_Load(object sender, EventArgs e)
        {
            apagar_controles();
           // this.npartida.Enabled = false;
        }
        private void btn1_Click_1(object sender, EventArgs e) //boton 1
        {
            //ganar();//llama funcion de validacion de si alguien ya gano
          

                resultado = aux % 2;
                turno++;


                aux++;
                btn1.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano  && oponente!=triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if(turno==9 && triunfo!="O" && triunfo!="X" ) { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn1.Enabled = false;
        }

        private void btn2_Click_1(object sender, EventArgs e) //boton 2
        {
           // ganar();//llama funcion de validacion de si alguien ya gano
           

                resultado = aux % 2;
                turno++;


                aux++;
                btn2.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn2.Enabled = false;

        }


        private void btn3_Click_1(object sender, EventArgs e) // boton 3
        {
            //ganar();//llama funcion de validacion de si alguien ya gano
         

                resultado = aux % 2;
                turno++;


                aux++;
                btn3.Text = humano;
                if (facil.Checked == true && dificil.Checked==false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate

            btn3.Enabled = false;
        }
        private void btn4_Click(object sender, EventArgs e)

        {

           // ganar();//llama funcion de validacion de si alguien ya gano
      
                resultado = aux % 2;
                turno++;


                aux++;
                btn4.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }


                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           // ganar();//llama funcion de validacion de si alguien ya gano
    
                resultado = aux % 2;
                turno++;


                aux++;
                btn5.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn5.Enabled = false;
       
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //ganar();//llama funcion de validacion de si alguien ya gano
       

                resultado = aux % 2;
                turno++;


                aux++;
                btn6.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }
               

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn6.Enabled = false;
        
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //ganar();//llama funcion de validacion de si alguien ya gano
          

                resultado = aux % 2;
                turno++;


                aux++;
                btn7.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
           // ganar();//llama funcion de validacion de si alguien ya gano
         

                resultado = aux % 2;
                turno++;


                aux++;
                btn8.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }


                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn8.Enabled = false;
       
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           // ganar();//llama funcion de validacion de si alguien ya gano
       
                resultado = aux % 2;
                turno++;


                aux++;
                btn9.Text = humano;
                if (facil.Checked == true && dificil.Checked == false)
                {
                    modofacil();
                }
                else if (dificil.Checked == true && facil.Checked == false) { IA(); }

                ganar();
                if (triunfo == humano && oponente != triunfo) { scorex.Text = Convert.ToString(turjugador = turjugador + 1); }//si quien gano es igual al indice que eligio el usuario se suma al score del usuario
                else if (triunfo == oponente && humano != triunfo) { scoreo.Text = Convert.ToString(turmaquina = turmaquina + 1); }// si quien gano es igual al indice que le toco a la maquina suma al score de la maquina
                else if (turno == 9 && triunfo != "O" && triunfo != "X") { empates.Text = Convert.ToString(turempate = turempate + 1); }//si no se dan las dos anteriores se suma al score del empate
            btn9.Enabled = false;
         
        }

        private void iniciar_Click(object sender, EventArgs e) // boton iniciar 
        {
            if (cbo.SelectedIndex == -1) { MessageBox.Show("SELECCIONE PRIMERO" + Environment.NewLine + " CON QUE FICHA DESEA JUGAR", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            if (cbo.SelectedIndex != -1)
            {
                if (cbo.SelectedIndex == 0) { humano = "X"; oponente = "O"; }
                else { humano = "O"; oponente = "X"; }
                if (facil.Checked == false && dificil.Checked == false) { MessageBox.Show("ESCOGE UNA DIFICULTAD", "DIFICULTAD", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (facil.Checked == true || dificil.Checked == true)
                {
                    encender_controles();
                }// valida si ya se eligio una ficha para jugar y si ya se eligio una dificultad 
                if (facil.Checked == true && dificil.Checked == false)
                {
                    dificil.Enabled = false;
                }
                else {  if (facil.Checked==false && dificil.Checked==true){facil.Enabled = false;} }
            }
                
        }

        private void npartida_Click(object sender, EventArgs e) // funcion de nuevo juego sin reiniciar el score
        {
            if (ganar()==true)
            {
                triunfo = "";
            turno = 0;
            resultado = 0;
            aux = 0;
            limpiar_controles();
          
                encender_controles();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jugador_Click(object sender, EventArgs e)
        {
        
        }

        private void facil_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        

       

      
        
    }
}
