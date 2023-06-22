using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Geometric_Structure
{
    public class GeometricStructure : GeometricObject
    {
        private List<GeometricObject> _geometricObjects;

        // Constructors

        public GeometricStructure(string color) : base(color)
        {
            _geometricObjects = new List<GeometricObject>();
        }

        public GeometricStructure(List<GeometricObject> geometricObjects, string color) : base(color)
        {
            _geometricObjects = geometricObjects;
        }

        // Accessors

        public string Color
        {
            get { return base.Color; }
            set
            {
                base.Color = value;
            }
        }

        // Methods

        public void AddObject(GeometricObject geometricObject)
        {
            _geometricObjects.Add(geometricObject);
        }

        public override string ToString()
        {
            string desc = "";
            desc += $"COLOR :\n{base.Color}\n";
            foreach(GeometricObject geometricObject in _geometricObjects)
            {
                desc += $"{geometricObject}\n";
            }

            return desc;
        }

        public override bool Equals(object? obj)
        {
            GeometricStructure check = obj as GeometricStructure;
            for(int i = 0; i < _geometricObjects.Count(); i++)
            {
                if (!_geometricObjects[i].Equals(check._geometricObjects[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override void ModifyLength(int length)
        {
            foreach(GeometricObject geometricObject in _geometricObjects)
            {
                geometricObject.ModifyLength(length);
            }
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override void ChangeColor(string color)
        {
            foreach (GeometricObject geometricObject in _geometricObjects)
            {
                geometricObject.ChangeColor(color);
            }
            base.ChangeColor(color);
        }
    }
}
