using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOROSKOP_Zadiakalniy
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((dateTimePicker1.Value.Day >= 22 && dateTimePicker1.Value.Month == 12) || (dateTimePicker1.Value.Day <= 20 && dateTimePicker1.Value.Month == 1))
            {    
                
                richTextBox1.LoadFile ("Козерог.rtf");
                label3.Text = ("Вы Козерог");
                pictureBox1.Image = Image.FromFile("PicKoz.png");

            }

            if ((dateTimePicker1.Value.Day >= 21 && dateTimePicker1.Value.Month == 1) || (dateTimePicker1.Value.Day <= 18 && dateTimePicker1.Value.Month == 2))
            {
               
                richTextBox1.LoadFile("Водолей.rtf");
                label3.Text = ("Вы Водолей");
                pictureBox1.Image = Image.FromFile("PicVod.jpg");
            }
            
            if ((dateTimePicker1.Value.Day >= 19 && dateTimePicker1.Value.Month == 2) || (dateTimePicker1.Value.Day <= 20 && dateTimePicker1.Value.Month == 3))
            {
                richTextBox1.LoadFile("Рыбы.rtf");
                label3.Text = ("Вы Рыбы");
                pictureBox1.Image = Image.FromFile("PicFish.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 21 && dateTimePicker1.Value.Month == 3) || (dateTimePicker1.Value.Day <= 19 && dateTimePicker1.Value.Month == 4))
            {
                richTextBox1.LoadFile("Овен.rtf");
                label3.Text = ("Вы Овен");
                pictureBox1.Image = Image.FromFile("PicOven.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 21 && dateTimePicker1.Value.Month == 4) || (dateTimePicker1.Value.Day <= 21 && dateTimePicker1.Value.Month == 5))
            {
                richTextBox1.LoadFile("Телец.rtf");
                label3.Text = ("Вы Телец");
                pictureBox1.Image = Image.FromFile("PicTelec.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 22 && dateTimePicker1.Value.Month == 5) || (dateTimePicker1.Value.Day <= 21 && dateTimePicker1.Value.Month == 6))
            {
                richTextBox1.LoadFile("Близнецы.rtf");
                label3.Text = ("Вы Близнецы");
                pictureBox1.Image = Image.FromFile("PicTwins.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 22 && dateTimePicker1.Value.Month == 6) || (dateTimePicker1.Value.Day <= 22 && dateTimePicker1.Value.Month == 7))
            {
                richTextBox1.LoadFile("Рак.rtf");
                label3.Text = ("Вы Рак");
                pictureBox1.Image = Image.FromFile("PicCancer.jpeg");
            }

            if ((dateTimePicker1.Value.Day >= 23 && dateTimePicker1.Value.Month == 7) || (dateTimePicker1.Value.Day <= 23 && dateTimePicker1.Value.Month == 8))
            {
                richTextBox1.LoadFile("Лев.rtf");
                label3.Text = ("Вы Лев");
                pictureBox1.Image = Image.FromFile("PicLion.jpeg");
            }

            if ((dateTimePicker1.Value.Day >= 24 && dateTimePicker1.Value.Month == 8) || (dateTimePicker1.Value.Day <= 22 && dateTimePicker1.Value.Month == 9))
            {
                richTextBox1.LoadFile("Дева.rtf");
                label3.Text = ("Вы Дева");
                pictureBox1.Image = Image.FromFile("PicDeva.jpeg");
            }

            if ((dateTimePicker1.Value.Day >= 23 && dateTimePicker1.Value.Month == 9) || (dateTimePicker1.Value.Day <= 23 && dateTimePicker1.Value.Month == 10))
            {
                richTextBox1.LoadFile("Весы.rtf");

                label3.Text = ("Вы Весы");
                pictureBox1.Image = Image.FromFile("PicVes.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 24 && dateTimePicker1.Value.Month == 10) || (dateTimePicker1.Value.Day <= 22 && dateTimePicker1.Value.Month == 11))
            {
                richTextBox1.LoadFile("Скорпион.rtf");
                label3.Text = ("Вы Скорпион");
                pictureBox1.Image = Image.FromFile("PicScorp.jpg");
            }

            if ((dateTimePicker1.Value.Day >= 23 && dateTimePicker1.Value.Month == 11) || (dateTimePicker1.Value.Day <= 21 && dateTimePicker1.Value.Month == 12))
            {
                richTextBox1.LoadFile("Стрелец.rtf");
                label3.Text = ("Вы Стрелец");
                pictureBox1.Image = Image.FromFile("PicStrelec.jpg");
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
