using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Furniture
    {
        private Material _material;

        // Constructors

        public Furniture(Material material)
        {
            _material = material;
        }

        // Accessors

        public Material Material
        {
            get { return _material; }
            set
            {
                _material = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = $"MATERIAL : {_material}\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Furniture)._material.Equals(_material));
        }

        public virtual void ChangeMaterial(Material material)
        {
            _material = material;
        }

        public virtual void Display()
        {
            Console.WriteLine("Furniture base display function.");
        }
    }
}
