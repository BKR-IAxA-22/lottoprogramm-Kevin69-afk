using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       
        

        private void label1_Click(object sender, EventArgs e)// Überschrift
        {

        }

        private void karteA_TextChanged(object sender, EventArgs e)// Zahl 1
        {

        }

        private void karteB_TextChanged(object sender, EventArgs e)// Zahl 2
        {

        }

        private void karteC_TextChanged(object sender, EventArgs e)// Zahl 3
        {

        }

        private void karteD_TextChanged(object sender, EventArgs e)// Zahl 4
        {

        }

        private void KarteE_TextChanged(object sender, EventArgs e)// Zahl 5
        {

        }

        private void KarteF_TextChanged(object sender, EventArgs e)// Zahl 6
        {

        }

        private void Superzahl1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Randomstarter_Click_1(object sender, EventArgs e)
        {
            Random generator = new Random();// randomizer generiert

            int randomzahl; // Variable zur Ausgabe der Lottozahlen
            int randomsuperzahl; // Variable zur Ausgabe der Superzahl
            bool gelandet = false;
            int siegeszahl; 
            randomzahl = generator.Next(1, 49); // Von Wo bis wo soll eine Random Zahl ausgegeben werden 
            randomsuperzahl = generator.Next(1, 9); // Von Wo bis wo soll eine Random Zahl ausgegeben werden 
            int x = randomzahl; // zur ausgabe der Zahl
            int y = randomsuperzahl;// zur Ausgabe der Superzahl
            karteA.Text = (x.ToString());// Augabe von Karte 1 bis 6
            karteB.Text = (x.ToString());
            karteC.Text = (x.ToString());
            karteD.Text = (x.ToString());
            KarteE.Text = (x.ToString());
            KarteF.Text = (x.ToString());
            Superzahl1.Text = (y.ToString()); // Ausgabe der Superzahl

            //Fehler: Falscher Screen wird augegeben und der richtige Screen kann nicht benutzt werden 

            for (int i = 0; i < 6; i++)// die 6 zahlen sollen immer um einen der Zahl der Vorherigen Karte erhöht werden, damit immer "Random" Zahlen ausgegeben werden 
            {
                x = +1;
            }

            for(int d = 0; d < randomzahl; d++)// wenn irgendeine Zahl von denen die random ausgegeben werden 
            {
                for(int e = 0; e < siegeszahl; e++)// eine Zahl ist, die man gelegt hat 
                {

                }
                if(randomzahl == siegeszahl)// wenn inrgendeine Zahl von randomzahl mit einer von siegeszahl übereinstimmt
                {
                    gelandet = true;// dann soll gelandet auf true gegeben werden und die die übereinstimmen sollen dann markiert werden
                }
                gelandet = false;// sonst sollen wenn die Zahlen nicht übereinanderstimmen, nicht mairkiert werden
            }
          
            
           
      
        }
    }
}
