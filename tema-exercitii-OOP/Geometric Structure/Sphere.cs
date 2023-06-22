using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class Sphere : GeometricObject
    {
        private Line _radius;

        // Constructors

        public Sphere(Line radius, string color) : base(color)
        {
            _radius = radius;
        }

        public Sphere(int radius, string radiusLineColor, string color) : base(color)
        {
            _radius = new Line(radius, radiusLineColor);
        }

        // Accessors

        public Line Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
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
            string desc = "SPHERE :\n";
            desc += $"COLOR :\n{base.Color}\n";
            desc += $"RADIUS :\n{_radius}";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Sphere)._radius.Equals(_radius)) && base.Equals(obj);
        }

        public override void ModifyLength(int length)
        {
            _radius.ModifyLength(length);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override void ChangeColor(string color)
        {
            base.ChangeColor(color);
            _radius.ChangeColor(color);
        }
    }
}
