using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Leg : Furniture
    {
        private int _height;

        // Constructors

        public Leg(int height, Material material) : base(material)
        {
            _height = height;
        }

        // Accessors

        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
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

        // Methods

        public override string ToString()
        {
            string desc = "LEG :";
            desc += $"MATERIAL :\n{base.Material}";
            desc += $"HEIGHT :\n{_height}\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && ((obj as Leg)._height == _height);
        }

        public override void ChangeMaterial(Material material)
        {
            base.ChangeMaterial(material);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }
    }
}
