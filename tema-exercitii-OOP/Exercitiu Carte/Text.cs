using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_exercitii_OOP.Exercitiu_Carte
{
    public class Text
    {
        public virtual void AdaugaText(string text)
        {
            Console.WriteLine("Add text base function.");
        }

        public virtual void Display()
        {
            Console.WriteLine("Display base function.");
        }

        public virtual Text Duplicate()
        {
            Console.WriteLine("Duplicate base function.");
            return null;
        }
    }
}
