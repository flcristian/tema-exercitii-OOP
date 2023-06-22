using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class GeometricObject
    {
        private string _color;

        // Constructors

        public GeometricObject(string color)
        {
            _color = color;
        }

        // Accessors

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        // Methods

        public virtual void ModifyLength(int length)
        {
            Console.WriteLine("Modify lenght base function.");
        }

        public virtual void Display()
        {
            Console.WriteLine("Display base function.");
        }

        public virtual void ChangeColor(string color)
        {
            Console.WriteLine("Modify lenght base function.");
        }
    }
}
