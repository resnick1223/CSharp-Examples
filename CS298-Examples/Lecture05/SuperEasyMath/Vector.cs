using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEasyMath
{
    public class Vector
    {
        #region 欄位

        private double x;
        private double y;

        #endregion 欄位

        #region 屬性

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value > 200)
                {
                    this.x = 200;
                }
                else if (value < -200)
                {
                    this.x = -200;
                }
                else
                {
                    this.x = value;
                }
            }
        }

        public double Y
        {
            get { return this.y; }

            set
            {
                if (value > 200)
                {
                    this.y = 200;
                }
                else if (value < -200)
                {
                    this.y = -200;
                }
                else
                {
                    this.y = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        #endregion 屬性

        #region 建構式

        /// <summary>
        /// 建構式，輸入兩個參數 範圍是100~200之間
        /// </summary>
        /// <param name="x">x 分量</param>
        /// <param name="y">y 分量</param>
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
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

        #endregion 建構式

        #region 縮放方法

        #region 縮放x方向

        public void ScaleX(double factor)
        {
            this.X *= factor;
        }

        #endregion 縮放x方向

        #region 縮放y方向

        public void ScaleY(double factor)
        {
            this.Y *= factor;
        }

        #endregion 縮放y方向

        #region 給定兩個方向的縮放倍率

        public void Scale(double factorX, double factorY)
        {
            this.ScaleX(factorX);
            this.ScaleY(factorY);
        }

        #endregion 給定兩個方向的縮放倍率

        #endregion 縮放方法
    }
}