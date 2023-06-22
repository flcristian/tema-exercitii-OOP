using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Chair : Furniture
    {
        private Leg _leg;

        // Constructors

        public Chair(Leg leg, Material material) : base(material)
        {
            _leg = leg;
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

        // Methods

        public override string ToString()
        {
            string desc = "CHAIR :\n";
            desc += $"LEG :\n{_leg}";
            desc += $"MATERIAL :\n{base.Material}";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && ((obj as Chair)._leg.Equals(_leg));
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
