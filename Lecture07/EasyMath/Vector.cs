using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector
    {
        public double x;
        public double y;

        private static int count;

        public static int Count
        {
            set
            {
                Vector.count = value >= 0 ? value : 0;
            }
            get
            {
                return Vector.count;
            }
        }

        public double theta;

        /// <summary>
        ///
        /// </summary>
        public Vector()
            : this(0, 0)
        {
        }

        /// <summary>
        /// 透過給定x, y分量產生一個向量
        /// </summary>
        /// <param name="x">x分量</param>
        /// <param name="y">y分量</param>
        public Vector(double x, double y)

        {
            count++;
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// 透過給定一個value,產生一個x,  y分量??
        /// </summary>
        /// <param name="value"></param>
        public Vector(double value)
            : this(value, value)
        {
            this.x = value;
            this.y = value;
        }

        /// <summary>
        /// 取得向量長度
        /// </summary>
        /// <returns>回傳值為向量長度</returns>
        public double GetLength()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double GetTheta()
        {
            if (x == 0 && y == 0)
                return 0.0;
            else if (y == 0)
                return x > 0 ? 0 : 180;
            else if (x == 0.0)
                return y > 0 ? 90 : 270;
            else
                return Math.Atan(y / x) * 180.0 / Math.PI;
        }

        public void ScaleX(double factor)
        {
            this.x *= factor;
        }

        public void ScaleY(double factor)
        {
            y *= factor;
        }

        public void Scale(double factorX, double factorY)
        {
            ScaleX(factorX);
            ScaleY(factorY);
        }

        public void Scale(double factor)
        {
            ScaleX(factor);
            ScaleY(factor);
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        /// <summary>
        /// 列印向量的基本資訊
        /// </summary>
        public void Print()
        {
            Console.WriteLine("(x,y) = ({0}, {1}) Length = {2} Theta = {3}"
                , x, y, GetLength(), GetTheta());
        }
    }
}