
/* == SECOND ANSWER ==
 *
 * Immutable animal
 * Second variant
 *
 * We can use struct, create new object,
 * and change current object to new object
 * when one of object properties is changing.
 */

using System;

namespace TaskOne
{
    struct Person
    {
        private static int _countOfPersons;

        public int Id { get; private set; }

        private string _name;

        public string Name
        {
            get => _name;
            set => this = new Person(value, _height);
        }

        private int _height;

        public int Height
        {
            get => _height;
            set => this = new Person(_name, value);
        }

        public Person(string name)
        {
            Id = ++_countOfPersons;
            _name = name;
            _height = 0;
        }

        public Person(string name, int height) : this(name) =>
            _height = height;

        public void Print() => Console.WriteLine(this);

        public override string ToString() =>
            base.ToString() + $": Id: = {Id}, Name: {_name}, Height: {_height}";
    }
}