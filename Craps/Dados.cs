using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Craps
{
    public class Dados
    {

       

        private Random numerosAleatorios = new Random();


        private int dadoI;
        private int dadoII;
        private int ronda = 0;
        public int Ronda { get; set; }

        public int DadoI { get; set; }
        public int DadoII { get; set; }
        public NameofCraps Nombrededados { get; set; } 

        

        public int LanzamientoDeDados()
        {

            int DadoI = numerosAleatorios.Next(1, 7);

            int DadoII = numerosAleatorios.Next(1, 7);


            int SumaDeDados = DadoI + DadoII;


            MessageBox.Show("\r\n Dado I: "+DadoI
                + "\r\n Dado II: " + DadoII
                + "\r\n La suma de los Dados Es: " + SumaDeDados , "Lanzamiento de Dados");

            


            return SumaDeDados  ;

        }


        public void jugar()
        {

            Ronda++;

            Estado estadodejuego = Estado.Continua;

            int misPuntos = 0;

            int sumaDeDados = LanzamientoDeDados();

            switch ((NameofCraps)sumaDeDados)
            {

                case NameofCraps.SIETE:
                    if (ronda == 0)
                    {
                        estadodejuego = Estado.Gano;
                    }
                    else estadodejuego = Estado.perdio;



                    break;

                case NameofCraps.ONCE: // gana con 11 en el primer tiro
                    if (ronda == 0)
                    {
                        estadodejuego = Estado.Gano;
                    }
                    else estadodejuego = Estado.Continua;





                    break;

                case NameofCraps.DOS_UNOS:
                    estadodejuego = Estado.perdio;
                    break;   // pierde con 2 en el primer tiro


                case NameofCraps.TRES: estadodejuego = Estado.perdio; break; // pierde con 3 en el primer tiro


                case NameofCraps.DOCE: // pierde con 12 en el primer tiro
                    estadodejuego = Estado.perdio;
                    break;


                default:                                   
                    estadodejuego = Estado.Continua;      
                    misPuntos = sumaDeDados;

                    MessageBox.Show("La suma De sus Dados " + misPuntos.ToString()+ "\r\n \r\n \r\n \r\n Usted Continua Jugando", "Estado de Puntos"); 
                    

                    break;
            }


            while (estadodejuego == Estado.Continua)
            {
                sumaDeDados = LanzamientoDeDados(); 

               
                if(sumaDeDados == misPuntos) 
                    estadodejuego = Estado.Gano;
                else
               
                if (sumaDeDados == (int)NameofCraps.SIETE)
                    estadodejuego = Estado.perdio;
            } 

            
            if (estadodejuego == Estado.Gano)


                MessageBox.Show("Nice, Epic Win Dude  ", "Resultados Del Jugador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("Sorry You Lost \r\n \r\n   Try Again.....     :C   ", "Resultados Del Jugador        :'C  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }

    }
}

