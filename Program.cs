using System;

namespace Person_Data_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            List<Person> objListOfPersonsInCity = new List<Person>();
            Repository objRep = new Repository();
            objRep.AddRecords(objListOfPersonsInCity);
            objRep.Retrieving_TopTwoRecords_ForAgeLessThanSixty(objListOfPersonsInCity);
            objRep.Retrieving_Records_ForAgeBetween13to18(objListOfPersonsInCity);
            objRep.AverageAge(objListOfPersonsInCity);
            objRep.SpecificName_PresentOrNot(objListOfPersonsInCity, "John");
        }
    }
}