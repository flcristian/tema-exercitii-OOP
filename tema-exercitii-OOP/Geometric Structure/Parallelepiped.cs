using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema_exercitii_OOP.Geometric_Structure;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class Parallelepiped : GeometricObject
    {
        private Parallelogram _base;
        private Rectangle _side;

        // Constructors

        public Parallelepiped(Parallelogram shapeBase, Rectangle shapeSide, string color) : base(color)
        {
            _base = shapeBase;
            _side = shapeSide;
        }

        // Accessors

        public Parallelogram Base
        {
            get { return _base; }
            set
            {
                _base = value;
            }
        }

        public Rectangle Side
        {
            get { return _side; }
            set
            {
                _side = value;
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
            string desc = "PARALLELEPIPED :\n";
            desc += $"COLOR :\n{base.Color}\n";
            desc += $"BASE :\n{_base}";
            desc += $"SIDE :\n{_side}";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Parallelepiped)._base.Equals(_base)) && ((obj as Parallelepiped)._side.Equals(_side)) && base.Equals(obj);
        }

        public override void ModifyLength(int length)
        {
            _base.ModifyLength(length);
            _side.ModifyLength(length);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override void ChangeColor(string color)
        {
            _base.ChangeColor(color);
            _side.ChangeColor(color);
            base.ChangeColor(color);
        }
    }
}
