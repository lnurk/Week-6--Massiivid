using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees- või perekonnanime

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sine perekonnanimes on {lastName.Length} sümbolit.");

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            if(lastNameLength > firstNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }
            else if (firstNameLength == lastNameLength)
            {
                Console.WriteLine("Sinu ees- ja perekonnanimi on sama pikad.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
