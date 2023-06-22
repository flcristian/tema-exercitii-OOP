using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class Parallelogram : GeometricObject
    {
        private Line _width;
        private Line _height;

        // Constructors

        public Parallelogram(Line width, Line height, string color) : base(color)
        {
            _width = width;
            _height = height;
        }

        public Parallelogram(int width, string widthLineColor, int height, string heightLineColor, string color) : base(color)
        {
            _width = new Line(width, widthLineColor);
            _height = new Line(height, heightLineColor);
        }

        // Accessors

        public Line Width
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        public Line Height
        {
            get { return _height; }
            set
            {
                _height = value;
            }
        }

        public string Color
        {
            get { return base.Color; }
            set
            {
                base.Color = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "PARALLELOGRAM :\n";
            desc += $"COLOR :\n{base.Color}\n";
            desc += $"WIDTH :\n{_width}";
            desc += $"HEIGHT :\n{_height}";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Parallelogram)._width.Equals(_width)) && ((obj as Parallelogram)._height.Equals(_height)) && base.Equals(obj);
        }

        public override void ModifyLength(int length)
        {
            _width.ModifyLength(length);
            _height.ModifyLength(length);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override void ChangeColor(string color)
        {
            _width.ChangeColor(color);
            _height.ChangeColor(color);
            base.ChangeColor(color);
        }
    }
}
