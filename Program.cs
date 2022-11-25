using System.Runtime.CompilerServices;

namespace Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sandwich();
        }

        public static void Sandwich()
        {
            
            Console.Write("How many people are we making PB&J sandwiches for? ");
            int Peeps = int.Parse(Console.ReadLine());


            double slicesPerLoaf = 28;
            double totalSlicesNeeded = Peeps * 2;
            double totalBreadNeeded = totalSlicesNeeded / slicesPerLoaf;
            double breadRound = Math.Ceiling(totalBreadNeeded);


            double tbsPerJar = 32;
            double totalTBSneeded = Peeps * 2;
            double totalPBneeded = totalTBSneeded / tbsPerJar;
            double PbutterRound = Math.Ceiling(totalPBneeded);



            double teaspoonPerJar = 48;
            double totalTeaSpoonNeeded = Peeps * 4;
            double totalJellyneeded = totalTeaSpoonNeeded / teaspoonPerJar;
            double jellyRound = Math.Ceiling(totalJellyneeded);





            Console.Write("You need: \n\n" + totalSlicesNeeded + " slices of bread\n" + totalTBSneeded + " tablespoons of peanut butter\n" + totalTeaSpoonNeeded + " teaspoons of jelly \n\nwhich is... \n\n" + breadRound + " loaves of bread\n" + PbutterRound + " jars of peanut butter\n" + jellyRound + " jars of jelly\n");
            Console.WriteLine("\nWould you like to restart? Enter yes or y to continue, or enter any other key to exit");
            var restartprompt = Console.ReadLine();
            if (restartprompt.Equals ("yes"))
            {
                Sandwich();
            } else if (restartprompt.Equals ("y")) { 
                Sandwich();
            }else {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}