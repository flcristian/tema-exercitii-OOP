using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Room_Furniture
{
    public class Material
    {
        public string _name;
        public string _texture;
        public string _color;

        // Constructors

        public Material(string name, string texture, string color)
        {
            _name = name;
            _texture = texture;
            _color = color;
        }

        // Accessors

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Texture
        {
            get { return _texture; }
            set
            {
                _texture = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "";
            desc += $"NAME : {_name}\n";
            desc += $"TEXTURE : {_texture}\n";
            desc += $"COLOR : {_color}\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Material)._name.Equals(_name)) && ((obj as Material)._texture.Equals(_texture)) && ((obj as Material)._color.Equals(_color));
        }
    }
}
