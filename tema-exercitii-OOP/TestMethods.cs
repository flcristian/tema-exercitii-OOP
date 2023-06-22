using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema_exercitii_OOP.Room_Furniture;
using tema_exercitii_OOP.Geometric_Structure;
using tema_exercitii_OOP.Exercitiu_Carte;

namespace tema_exercitii_OOP
{
    public class TestMethods
    {
        public void TestGeometricStructure()
        {
            Line width = new Line(4, "red");
            Line height = new Line(4, "blue");
            Parallelogram parallelogram = new Parallelogram(width, height, "green");
            Rectangle rectangle = new Rectangle(3, "red", 3, "blue", "green");
            Parallelepiped parallelepiped = new Parallelepiped(parallelogram, rectangle, "white");

            Line radius = new Line(3, "black");
            Sphere sphere = new Sphere(radius, "black");

            List<GeometricObject> geometricObjects = new List<GeometricObject> { parallelepiped, sphere };
            GeometricStructure structure = new GeometricStructure(geometricObjects, "black");

            structure.Display();
        }

        public void TestRoomFurniture()
        {
            Material wood = new Material("wood", "flat grain", "blackwood");
            Material marble = new Material("marble", "seamless", "beige");
            Leg leg = new Leg(50, wood);
            Chair chair = new Chair(leg, wood);
            Table table = new Table(leg, marble, "oval");

            List<Furniture> furniture = new List<Furniture> { chair, table };
            Room room = new Room(furniture, wood);
            room.Display();
        }

        public void TestCarte()
        {
            Propozitie propozitie = new Propozitie("ma cheama ruben meister");
            List<Propozitie> propozitii = new List<Propozitie> { propozitie, propozitie.Duplicate(), propozitie.Duplicate().Duplicate() };
            Paragraf paragraf = new Paragraf(propozitii);
            List<Paragraf> paragrafe = new List<Paragraf> { paragraf, paragraf.Duplicate(), paragraf.Duplicate().Duplicate() };
            Pagina pagina = new Pagina(paragrafe);
            List<Pagina> pagini = new List<Pagina> { pagina, pagina.Duplicate(), pagina.Duplicate().Duplicate() };
            Carte carte = new Carte(pagini);
            carte.Display();
        }
    }
}
