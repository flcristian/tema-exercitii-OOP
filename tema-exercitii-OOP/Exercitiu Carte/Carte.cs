using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Exercitiu_Carte
{
    public class Carte : Text
    {
        private List<Pagina> _pagini;

        // Constructors

        public Carte(List<Pagina> pagini)
        {
            _pagini = pagini;
        }

        // Accessors

        public List<Pagina> Pagini
        {
            get { return _pagini; }
            set
            {
                _pagini = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "CARTE :\n";

            foreach (Pagina pagina in _pagini)
            {
                desc += $"{pagina}";
            }

            return desc;
        }

        public override bool Equals(object? obj)
        {
            Carte check = obj as Carte;
            for (int i = 0; i < _pagini.Count(); i++)
            {
                if (!_pagini[i].Equals(check._pagini[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override void AdaugaText(string text)
        {
            foreach (Pagina pagina in _pagini)
            {
                pagina.AdaugaText(text);
            }
        }

        public override void Display()
        {
            Console.WriteLine(this + "\n");
        }

        public override Carte Duplicate()
        {
            List<Pagina> pagini = new List<Pagina>();
            foreach (Pagina pagina in _pagini)
            {
                pagini.Add(pagina.Duplicate());
            }
            return new Carte(pagini);
        }
    }
}
