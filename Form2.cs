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
    public partial class Form2 : Form
    {
        string adresa2 = @"D:\Proiecte\Csharp\Proiect final\ListaUseri.txt";
        string linie = string.Empty;
        string[] text = new string[20];
        public string nume;
        
        //public string nume = string.Empty;
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(adresa2,true);

                linie = sr.ReadToEnd().Trim();
                text = linie.Split(' ');
                bool varianta = false;
            

                for (int i = 0; i < text.Length; i++)
                {
                    
                    if (txtUserName.Text == text[i] && txtPassWord.Text == text[i+1])
                    {
                         
                         varianta = true;
                         nume = string.Copy(txtUserName.Text.ToString());
                         
                         break;

                    }
                    else
                    {
                    
                    varianta = false;

                    }

                }
                if (varianta)
                 {
                    new Form1(nume).Show();
                    this.Hide();
                    
                   
                     
                 }
                else
                {
                    MessageBox.Show("The user name or password you entered is incorrect. Try again!");
                    txtUserName.Clear();
                    txtPassWord.Clear();
                    txtUserName.Focus();
                }


        }
       // public string GetNume()
       //// {
       //      string nume = txtUserName.Text;
       //     Console.WriteLine(nume);
       //     return nume;
       // }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
