// Create a class called Person with properties Name and Age.
// Then, create an instance of the Person class and populate it with values.
// Display the name and age of the created object on the screen.
// Change the value of the Age property and display the updated data on the screen.
//

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("name", 20);

            Console.WriteLine(person.ToString());

            person.setAge(30);

            Console.WriteLine(person.ToString());
        }
    }
}