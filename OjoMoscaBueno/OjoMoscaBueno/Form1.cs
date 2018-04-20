using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OjoMoscaBueno
{
    public partial class Form1 : Form
    {
        Drawing drawFunct = new Drawing();
        Point center;
        
        public Form1()
        {
            InitializeComponent();
            center = new Point(panel1.Width / 2, panel1.Height / 2);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

           int puntos = Convert.ToInt32(textBox1.Text);
           drawFunct.testNoThreadCircle(panel1, center, puntos, this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int puntos = Convert.ToInt32(textBox1.Text);
            drawFunct.drawWithCircleThreads(panel1, center, puntos);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
