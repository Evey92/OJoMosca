using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjoMoscaBueno
{
    class Circulo
    {

        int diametro = 600, angulo, puntos;

        Circulo(int Puntos)
        {
            puntos = Puntos;
        }

        void calcularAngulo()
        {
           angulo = 360 / puntos;

        }


    }
//    using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Threading;

//namespace OjoMoscaBueno
//    {
//        class Drawing
//        {
//            Form1 form = new Form1();
//            public void drawWithCircleThreads(Panel panel1, Point center)
//            {
//                System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Purple, 5);
//                System.Drawing.Graphics formGraphics;
//                formGraphics = panel1.CreateGraphics();
//                formGraphics.DrawEllipse(myPen, new Rectangle(center.X - 300, center.Y - 300, 600, 600));
//                myPen.Dispose();
//                formGraphics.Dispose();

//            }

//            public void drawCircleWithouthThreads(Panel panel1, Point center, int puntos)
//            {

//                float anguloRot = 360 / puntos;

//                System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Purple, 5);
//                System.Drawing.Graphics formGraphics;
//                formGraphics = panel1.CreateGraphics();
//                formGraphics.Clear(form.BackColor);
//                formGraphics.DrawEllipse(myPen, new Rectangle(center.X - 300, center.Y - 300, 600, 600));
//                System.Drawing.Pen linePen = new System.Drawing.Pen(System.Drawing.Color.LightGreen, 5);
//                //Point punto1 = new Point(430, 50);
//                PointF firstPoint = new PointF(430, 50);

//                double newX = (firstPoint.X * Math.Cos(anguloRot)) - (firstPoint.Y * Math.Sin(anguloRot));
//                double newY = (firstPoint.Y * Math.Cos(anguloRot)) + (firstPoint.X * Math.Sin(anguloRot));

//                PointF secondPoint = new PointF(Convert.ToSingle(newX), Convert.ToSingle(newY));
//                formGraphics.DrawLine(linePen, firstPoint, secondPoint);

//                //Pen blackPen = new Pen(Color.Black, 3);
//                myPen.Dispose();

//                formGraphics.Dispose();
//            }
//        }
//    }
}
