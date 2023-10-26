// Tom Ellner NET23
namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri minCirkel = new Cirkel(); // Create a new Cirkel object and store it in a Geometri reference.
            Console.Write("Min cikels area: "); // Display a message indicating the shape being processed.
            Console.WriteLine(minCirkel.Area()); // Calculate and print the area of the circle.
            Console.WriteLine(); // Add a newline for separation. Repeat for all shapes.

            Geometri minKvadrat = new Kvadrat();
            Console.Write("Min kvadrats area: "); 
            Console.WriteLine(minKvadrat.Area()); 
            Console.WriteLine(); 

            Geometri minRektangel = new Rektangel(); 
            Console.Write("Min rektangels area: "); 
            Console.WriteLine(minRektangel.Area()); 
            Console.WriteLine();

            Geometri mittParalellogram = new Paralellogram();
            Console.Write("Mitt paralellograms area: ");
            Console.WriteLine(mittParalellogram.Area()); 
            Console.WriteLine();

            Geometri minEllips = new Ellips(); 
            Console.Write("Min ellips area: "); 
            Console.WriteLine(minEllips.Area()); 
            Console.WriteLine();
        }
    }
}