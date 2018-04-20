using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace OjoMoscaBueno
{
    class Drawing
    {
        //Form1 form = new Form1();
        int diametro = 600;
        float angulo;
        double arcLenght;
        Dictionary<double, double> coords = new Dictionary<double, double>();

        private void createCircle(Panel panel1, Point center, Form form)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Purple, 5);
            System.Drawing.Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            formGraphics.Clear(form.BackColor);
            formGraphics.DrawEllipse(myPen, new Rectangle(center.X - 300, center.Y - 300, 600, 600));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void drawWithCircleThreads(Panel panel1, Point center, int puntos)
        {
            //createCircle(puntos);
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Purple, 5);
            System.Drawing.Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(center.X - 300, center.Y - 300, diametro, diametro));
            myPen.Dispose();
            formGraphics.Dispose();
            MessageBox.Show("diametro: " + diametro + "Angulo: " + angulo);
        }

        public void testNoThreadCircle(Panel panel1, Point center, int puntos, Form form)
        {
            int cx = center.X, cy = center.Y;
            int puntosLeft = puntos;
            PointF firstPoint, secondPoint, NextPoint;
            double  θ = Math.PI * (Convert.ToDouble(360 / puntosLeft)/180);

            System.Drawing.Pen linePen = new System.Drawing.Pen(System.Drawing.Color.LightGreen, 2);
            System.Drawing.Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            formGraphics.Clear(form.BackColor);
            createCircle(panel1, center, form);
           
            firstPoint = new PointF(430, 50);
            NextPoint = firstPoint;

            for (int i = 0; i < puntos; i++)
            {
                //MessageBox.Show(" Primer punto: " + firstPoint);
                for (int j = 0; j < puntosLeft; j++)
                {

                    double xrot = Math.Cos(θ * j) * (firstPoint.X - cx) - Math.Sin(θ * j) * (firstPoint.Y - cy) + cx;
                    double yrot = Math.Sin(θ * j) * (firstPoint.X - cx) + Math.Cos(θ * j) * (firstPoint.Y - cy) + cy;
                    secondPoint = new PointF(Convert.ToSingle(xrot), Convert.ToSingle(yrot));

                    if (j == 1)
                    {
                        NextPoint = secondPoint;
                        //MessageBox.Show("Ya tengo el punto carnal: " + NextPoint);
                    }

                    if (puntos % 2 == 0)
                    {
                        //firstPoint.X + (puntos / 2) != secondPoint.X && firstPoint.Y + (puntos / 2) != secondPoint.Y
                        if (puntos/2 != j)
                        {
                            formGraphics.DrawLine(linePen, firstPoint, secondPoint);
                            //MessageBox.Show("i " + (i + puntos / 2) + " j "+j);
                        }
                    }
                    else
                    {
                        formGraphics.DrawLine(linePen, firstPoint, secondPoint);
                    }
                    //firstPoint = secondPoint;
                }
                firstPoint = NextPoint;
                puntosLeft--;
            }

            //Pen blackPen = new Pen(Color.Black, 3);
            linePen.Dispose();

            formGraphics.Dispose();
        }
    }
}
