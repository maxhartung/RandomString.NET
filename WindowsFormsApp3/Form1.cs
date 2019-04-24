using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        string fisier;
        string text;
        public void GenString()
        {
            textBox3.Clear();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[1024];
            var random = new Random();

            for (var i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            textBox3.AppendText(finalString);
            text = finalString;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenString();
        
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var i=0;
            var c=0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (fisier == null) { }

            // DO STUFF and that means nothing

            else

                for (i = 0; i <= 1023; i++)
                {
                    if (fisier[i] == textBox1.Text[0])
                        c++;
                    // out of bound because we need sizeof or something like that

                }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            textBox2.AppendText("Caracterul a fost gasit de " + c);
            textBox2.AppendText(" ori");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            var c = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (i=0; i <= 1023; i++)
            {
                if (text[i] == textBox1.Text[0])
                    c++;
                // out of bound because we need sizeof or something like that
      
                 //Clasele au propietati sau campuri si metode
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            textBox2.AppendText("Caracterul a fost gasit de " +c);
            textBox2.AppendText(" ori");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                fisier = System.IO.File.ReadAllText(openFileDialog1.FileName);
                textBox3.AppendText(fisier);
            }

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
