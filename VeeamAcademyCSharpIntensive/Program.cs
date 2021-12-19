
// Create your own immutable type.
// When a field of the your type is changed
// a new object of the class have been created.
// You can use String class as an example.
//
// Animal is the first implementation
// Person is the second implementation

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAnimal();
            TestPerson();
        }

        private static void TestAnimal()
        {
            var animal = new Animal("Eagle");
            animal.Print();

            animal = "Mouse";
            animal.Print();

            animal = "Lion";
            animal.Print();

            animal = "Zebra";
            animal.Print();
        }

        private static void TestPerson()
        {
            var person = new Person("Bob");
            person.Print();

            person.Name = "Frank";
            person.Print();

            person.Height = 100;
            person.Print();
        }
    }
}
