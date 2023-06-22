using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Exercitiu_Carte
{
    public class Pagina : Text
    {
        private List<Paragraf> _paragrafe;

        // Constructors

        public Pagina(List<Paragraf> paragrafe)
        {
            _paragrafe = paragrafe;
        }

        // Accessors

        public List<Paragraf> Paragrafe
        {
            get { return _paragrafe; }
            set
            {
                _paragrafe = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "PAGINA :\n";

            foreach (Paragraf paragraf in _paragrafe)
            {
                desc += $"{paragraf}";
            }

            return desc;
        }

        public override bool Equals(object? obj)
        {
            Pagina check = obj as Pagina;
            for (int i = 0; i < _paragrafe.Count(); i++)
            {
                if (!_paragrafe[i].Equals(check._paragrafe[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override void AdaugaText(string text)
        {
            foreach (Paragraf paragraf in _paragrafe)
            {
                paragraf.AdaugaText(text);
            }
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override Pagina Duplicate()
        {
            List<Paragraf> paragrafe = new List<Paragraf>();
            foreach (Paragraf paragraf in _paragrafe)
            {
                paragrafe.Add(paragraf.Duplicate());
            }
            return new Pagina(paragrafe);
        }
    }
}
