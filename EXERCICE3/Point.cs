using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2

{

    class Point

    {

        // Attribut

        private int x;

        private int y;

        // Constructeur

        public Point()

        {

            x = 0;

            y = 0;

        }

        public Point(int x, int y)

        {

            this.x = x;

            this.y = y;

        }

        public void SetX(int x)

        {

            this.x = x;

        }

        public int GetX()

        {

            return x;

        }

        public void SetY(int y)

        {

            this.y = y;

        }

        public int GetY()

        {

            return y;

        }

         // ----------------------Methode----------------------


        public double Distance(Point p)

        {

            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));

        }


        public bool Egalite(Point p)

        {

            return x == p.x && y == p.y;

        }


        public void Translation(int dx, int dy)

        {

            x += dx;

            y += dy;

        }


        public static bool Linearite(Point P1, Point P2, Point P3)

        {

            return (P2.x - P1.x) * (P3.y - P1.y) == (P3.x - P1.x) * (P2.y - P1.y);

        }

    }

}
