
/* == FIRST ANSWER ==
 * 
 * Immutable animal
 * First variant
 *
 * Name is setting when the object is creating. 
 * After creation the object cannot be changed.
 * It is the immutable object.
 * When user is creating new object using operation: Animal animal = "AnimalName"
 * a new object of Animal is creating
 */

using System;

namespace TaskOne
{
    class Animal
    {
        private static int _countOfAnimals;

        public int Id { get; private set; } = ++_countOfAnimals;

        public string Name { init; get; }

        public Animal(string name) => Name = name;

        public void Print() => Console.WriteLine(this);

        public override string ToString() => 
            base.ToString() + $": Id: = {Id}, Name: {Name}";

        public static implicit operator Animal(string name) => new(name);
    }
}
