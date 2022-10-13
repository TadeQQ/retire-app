using System;

class Program

{
    static void Main(string[] args)
    {   
        Console.WriteLine("Podaj swoje Nazwisko, Wiek oraz Płeć (wpisz: Mężczyzna lub Kobieta): ");
        Console.WriteLine("Nazwisko: ");
        string LastName = Console.ReadLine();
        
        Console.WriteLine("Wiek: ");
        int currAge = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Płeć: ");
        string gender = Console.ReadLine();

        int maleRetireAge = 65;
        int femaleRetireAge = 60;

        Console.WriteLine($"Witaj, {LastName}!");
        
        if (currAge < 0) {
        Console.WriteLine("Wiek nie może być ujemny!");
     } 
        else if (gender == "Kobieta" && currAge < femaleRetireAge)
     { Console.WriteLine($"Masz {currAge} lat i utożsamiasz się jako {gender}, więc brakuje Ci {currAge - femaleRetireAge} do emerytury!");
     } 
        else if (gender == "Mężczyzna" && currAge < maleRetireAge)
     { Console.WriteLine($"Masz {currAge} lat i utożsamiasz się jako {gender}, więc brakuje Ci {currAge - maleRetireAge} do emerytury!");
     } 
        else {Console.WriteLine("Jesteś emerytem!");
         }
    }
}