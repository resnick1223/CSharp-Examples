using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEasyMath
{
    public class Vector
    {
        private double x;
        private double y;


        #region 建構式
        /// <summary>
        /// 建構式，輸入兩個參數 範圍是100~200之間
        /// </summary>
        /// <param name="x">x 分量</param>
        /// <param name="y">y 分量</param>
        public Vector(double x, double y)
        {
            this.SetX(x);
            this.SetY(y);
        }

        /// <summary>
        /// 建構式，產生x, y分量相同的向量
        /// </summary>
        /// <param name="value"></param>
        public Vector(double value) : this(value, value)
        {

        }

        /// <summary>
        /// 建構式，產生0向量
        /// </summary>
        public Vector() : this(0)
        {
        }



        #endregion

        #region x, y的 Getter, Setter
        public void SetX(double x)
        {
            if (x > 200)
            {
                this.x = 200;
            }
            else if (x < -200)
            {
                this.x = -200;
            }
            else
            {
                this.x = x;
            }
        }

        public double GetX()
        {
            return this.x;
        }

        public void SetY(double y)
        {
            if (y > 200)
            {
                this.y = 200;
            }
            else if (y < -200)
            {
                this.y = -200;
            }
            else
            {
                this.y = y;
            }
        }

        public double GetY()
        {
            return this.y;
        }
        #endregion

        #region 縮放方法

        #region 縮放x方向
        public void ScaleX(double factor)
        {
            this.SetX(this.x * factor);
        }
        #endregion

        #region 縮放y方向
        public void ScaleY(double factor)
        {
            this.SetY(this.y * factor);
        }
        #endregion

        #region 給定兩個方向的縮放倍率
        public void Scale(double factorX, double factorY)
        {
            this.ScaleX(factorX);
            this.ScaleY(factorY);
        }

        #endregion

        #endregion

        #region 向量長度計算

        public double GetLength()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        #endregion


    }
}
