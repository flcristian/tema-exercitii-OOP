using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Room : Furniture
    {
        private List<Furniture> _furniture;

        // Constructors

        public Room(Material material) : base(material) { }

        public Room(List<Furniture> furniture, Material material) : base(material)
        {
            _furniture = furniture;
        }

        // Accessors

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
            string desc = "ROOM :\n";
            desc += $"MATERIAL :\n{base.Material}\n";
            
            foreach(Furniture furniture in _furniture)
            {
                desc += $"{furniture}";
            }

            return desc;
        }

        public override bool Equals(object? obj)
        {
            bool flag = true;
            Room check = obj as Room;
            for (int i = 0; i < _furniture.Count(); i++)
            {
                if (!_furniture[i].Equals(check._furniture[i]))
                {
                    flag = false;
                    break;
                }
            }
            return flag && base.Equals(obj); 
        }

        public override void ChangeMaterial(Material material)
        {
            foreach(Furniture furniture in _furniture)
            {
                furniture.ChangeMaterial(material);
            }
            base.ChangeMaterial(material);
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }
    }
}
