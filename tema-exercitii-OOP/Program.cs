using System.Runtime.CompilerServices;
using tema_exercitii_OOP;

internal class Program
{ 
    private static void Main(string[] args)
    {
        TestMethods test = new TestMethods();
        bool running = true;
        while (running)
        {
            Console.WriteLine("1 - Test Geometric Structure");
            Console.WriteLine("2 - Test Room with Furniture");
            Console.WriteLine("3 - Test Carte");

            string k = Console.ReadLine().ToString();

            switch (k)
            {
                case "1":
                    test.TestGeometricStructure();
                    break;
                case "2":
                    test.TestRoomFurniture();
                    break;
                case "3":
                    test.TestCarte();
                    break;
                default:
                    running = false;
                    break;
            }
        }
    }
}