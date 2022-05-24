using System;

internal class Program
{
    static void Main(string[] args)
    {
        string firstName = "Брежнев";
        string lastName = "Антон";
        string temporary;
        temporary = firstName;
        firstName = lastName;
        lastName = temporary;

        Console.WriteLine(firstName + " " + lastName);
    }
}























