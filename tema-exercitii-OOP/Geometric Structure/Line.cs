using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class Line : GeometricObject
    {
        private int _length;

        // Constructors

        public Line(int length, string color) : base(color)
        {
            _length = length;
        }

        // Accessors

        public int Lenght
        {
            get { return _length; }
            set
            {
                _length = value;
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
            string desc = "LINE :\n";
            desc += $"Length: {_length}\nColor: {base.Color}\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && ((obj as Line)._length == _length);
        }

        public override void ModifyLength(int length)
        {
            _length = _length + length;
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override void ChangeColor(string color)
        {
            base.ChangeColor(color);
        }
    }
}
