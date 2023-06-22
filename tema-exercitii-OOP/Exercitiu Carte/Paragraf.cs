using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Exercitiu_Carte
{
    public class Paragraf : Text
    {
        private List<Propozitie> _propozitii;

        // Constructors

        public Paragraf(List<Propozitie> propozitii)
        {
            _propozitii = propozitii;
        }

        public Paragraf(string[] propozitii)
        {
            foreach(string propozitie in propozitii)
            {
                _propozitii.Add(new Propozitie(propozitie));
            }
        }

        public Paragraf(Propozitie[] propozitii)
        {
            _propozitii = propozitii.ToList();
        }

        // Accessors

        public List<Propozitie> Propozitii
        {
            get { return _propozitii; }
            set
            {
                _propozitii = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "PARAGRAF :\n";

            foreach(Propozitie propozitie in _propozitii)
            {
                desc += $"{propozitie}";
            }

            return desc;
        }

        public override bool Equals(object? obj)
        {
            Paragraf check = obj as Paragraf;
            for(int i = 0; i < _propozitii.Count(); i++)
            {
                if (!_propozitii[i].Equals(check._propozitii[i])){
                    return false;
                }
            }
            return true;
        }

        public override void AdaugaText(string text)
        {
            foreach(Propozitie propozitie in _propozitii)
            {
                propozitie.AdaugaText(text);
            }
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }

        public override Paragraf Duplicate()
        {
            List<Propozitie> propozitii = new List<Propozitie>();
            foreach(Propozitie propozitie in _propozitii)
            {
                propozitii.Add(propozitie.Duplicate());
            }
            return new Paragraf(propozitii);
        }
    }
}
