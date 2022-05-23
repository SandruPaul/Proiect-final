using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proiect_final
{
    public partial class Form1 : Form
    {
        //VARIABILE   !!!!!!!!!!!


        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        string nume2;
        string copie = string.Empty;
        string[] text = new string[100];
        
        

        string adresa = @"D:\Proiecte\Csharp\Proiect final\Intrebari.txt";
        //string adresa3= @"D:\Proiecte\Csharp\Proiect final\Scoruri.txt";

        public Form1(string nume)
        {
            
            InitializeComponent();
            
            askQuestion(questionNumber);

            totalQuestions = 10;
            nume2 = nume;
            
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            // Aici verificam raspunsul!!!!!!
            var senderObject = (Button)sender;

            int ButtonTag = Convert.ToInt32(senderObject.Tag);

            if (ButtonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // aici prelucram procentajul!!!!!!!!
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to exit ");

                // SCRIERE NUME SI SCOR !!!!!!!!
                Form2 form2 = new Form2();
                //string numee = form2.GetNume();
                string linie = String.Format(nume2 + " " + score);
               
                using (StreamWriter streamWriterFisierText = new StreamWriter("Scoruri.txt", true))
                {
                    streamWriterFisierText.WriteLine(linie);
                    
                }

                score = 0;
                questionNumber = 0;
                Application.Exit();
            }






            questionNumber++;
            askQuestion(questionNumber);
        }

      
        
        
        //Aici vedem intrebarile !!!!!!!!!!!!
        private void askQuestion(int qnum)
        {

            // PRELUCRARE FISIER INTREBARI!!!!


            StreamReader citireFisier = new StreamReader(adresa, true);

            copie = citireFisier.ReadToEnd();
            text = copie.Trim().Split('|');
            Console.WriteLine(text);

            // INTREBARI !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1


            switch (qnum)
            {
                case 1: // INTREBAREA 1 !!!!!!!!!!!!!!
                         pictureBox1.Image = Properties.Resources.Fluviu;

                    label1.Text = text[0];
                    button1.Text = text[1];
                    button2.Text = text[2];
                    button3.Text = text[3];
                    button4.Text = text[4];

                    correctAnswer = 2;

                    break;

                case 2:// INTREBAREA 2 !!!!!!!!!!!!!!
                        pictureBox1.Image = Properties.Resources.question;

                    label1.Text = text[5];
                    button1.Text = text[6];
                    button2.Text = text[7];
                    button3.Text = text[8];
                    button4.Text = text[9];

                    correctAnswer = 1;

                    break;

                case 3:// INTREBAREA 3 !!!!!!!!!!!!!!
                        pictureBox1.Image = Properties.Resources.question;

                    label1.Text = text[10];
                    button1.Text = text[11];
                    button2.Text = text[12];
                    button3.Text = text[13];
                    button4.Text = text[14];

                    correctAnswer = 4;


                    break;

                case 4:// INTREBAREA 4 !!!!!!!!!!!!!!
                        pictureBox1.Image = Properties.Resources.Munte;

                    label1.Text = text[15];
                    button1.Text = text[16];
                    button2.Text = text[17];
                    button3.Text = text[18];
                    button4.Text = text[19];

                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.question;

                    label1.Text = text[20];
                    button1.Text = text[21];
                    button2.Text = text[22];
                    button3.Text = text[23];
                    button4.Text = text[24];

                    correctAnswer = 2;

                    break;
                case 6:
                     pictureBox1.Image = Properties.Resources.Middle_Earth_Shadow_of_War_12;

                    label1.Text = text[25];
                    button1.Text = text[26];
                    button2.Text = text[27];
                    button3.Text = text[28];
                    button4.Text = text[29];

                    correctAnswer = 4;


                    break;


                case 7:
                      pictureBox1.Image = Properties.Resources.question;

                    label1.Text = text[30];
                    button1.Text = text[31];
                    button2.Text = text[32];
                    button3.Text = text[33];
                    button4.Text = text[34];

                    correctAnswer = 1;
                    break;



                case 8:
                     pictureBox1.Image = Properties.Resources.Angel_Falls;

                    label1.Text = text[35];
                    button1.Text = text[36];
                    button2.Text = text[37];
                    button3.Text = text[38];
                    button4.Text = text[39];

                    correctAnswer = 2;
                    break;


                case 9:
                     pictureBox1.Image = Properties.Resources.FullMoon2010;

                    label1.Text = text[40];
                    button1.Text = text[41];
                    button2.Text = text[42];
                    button3.Text = text[43];
                    button4.Text = text[44];

                    correctAnswer = 4;
                    break;


                case 10:
                      pictureBox1.Image = Properties.Resources.Roman;

                    label1.Text = text[45];
                    button1.Text = text[46];
                    button2.Text = text[47];
                    button3.Text = text[48];
                    button4.Text = text[49];

                    correctAnswer = 2;
                    break;

            }
        }
    }
}
