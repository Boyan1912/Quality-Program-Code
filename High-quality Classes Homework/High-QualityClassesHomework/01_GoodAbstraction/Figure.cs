using System;

namespace Abstraction
{
    abstract class Figure : IFigure
    {
        private double width;
        private double height;
        private double radius;

        public double Width
        {
            get
            {
                if (this.width == 0)
                {
                    throw new ArgumentException(string.Format("{0} cannot have property width", this));
                }
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive");
                }
                this.width = value;
            }
        }

        public double Height 
        { 
            get
            {
                if (this.height == 0)
                {
                    throw new ArgumentException(string.Format("{0} cannot have property height", this));
                }
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive");
                }
                this.height = value;
            }
        }

        public double Radius
        {
            get
            {
                if (this.radius == 0)
                {
                    throw new ArgumentException(string.Format("{0} cannot have property radius", this));
                }
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive");
                }
                this.radius = value;
            }
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.radius = 0;
        }

        public Figure(double radius)
        {
            this.Radius = radius;
            this.width = 0;
            this.height = 0;
        }

        public virtual double CalcPerimeter()
        {
            return -1;
        }

        public virtual double CalcSurface()
        {
            return -1;
        }
    }
}