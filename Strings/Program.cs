using System;

namespace CSharpfundamentals;
{
    class Program
    {
    static void Main(string[] args)
    {
       //You cannot change strings - the methods to change a string returns a new string
       
       // Varbatim string
       // string path = @"c:\projects\project1\folder1"
       //Else
       // string path = "c:\\projects\\project1\\folder1"

       int number;
       
       var firstName = "Mosh";
       //string class - importeras
       String lastName = "Hamedani";
       //string keyword
       string myName = "Sara";
       
       //Concatination
       var fullName = firstName + " " + lastName;

       var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

       var names = new string[3] {"John", "Jack", "Gill"};
       var formattedNames = string.Join(",", names);
       Console.WriteLine(formattedNames);
    }
    }
}
