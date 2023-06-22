using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Table : Furniture
    {
        private Leg _leg;
        private string _shape;

        // Constructors

        public Table(Leg leg, Material material, string shape) : base(material)
        {
            _leg = leg;
            _shape = shape;
        }

        // Accessors

        public Leg Leg
        {
            get { return _leg; }
            set
            {
                _leg = value;
            }
        }

        public Material Material
        {
            get { return base.Material; }
            set
            {
                base.Material = value;
            }
        }

        public string Shape
        {
            get { return _shape; }
            set
            {
                _shape = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "TABLE :\n";
            desc += $"LEG :\n{_leg}";
            desc += $"MATERIAL :\n{base.Material}";
            desc += $"SHAPE :\n{_shape}\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && ((obj as Table)._leg.Equals(_leg)) && ((obj as Table)._shape.Equals(_shape));
        }

        public override void ChangeMaterial(Material material)
        {
            _leg.ChangeMaterial(material);
            base.ChangeMaterial(material);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }
    }
}
