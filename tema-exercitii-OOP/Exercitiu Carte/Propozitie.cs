using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Exercitiu_Carte
{
    public class Propozitie : Text
    {
        private string _text;

        // Constructors

        public Propozitie(string text)
        {
            _text = text;
        }

        // Accessors

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "TEXT :\n";
            desc += _text + "\n";
            return desc;
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Propozitie)._text.Equals(_text));
        }

        public override void AdaugaText(string text)
        {
            _text = _text + " " + text;
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override Propozitie Duplicate()
        {
            return new Propozitie(_text);
        }
    }
}
