using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerratorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
               new Person("John", "Smith"),
               new Person("Jim", "Johnson"),
               new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.FirstName + " " + p.SecondName);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 人（基础）
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Person(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
    }
    /// <summary>
    /// 人类
    /// </summary>
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] array)
        {
            _people = new Person[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                _people[i] = array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new PersonEnum(_people);
        }
    }

    public class PersonEnum : IEnumerator
    {
        private Person[] _people;
        public int position = -1;//初始值
        public PersonEnum(Person[] list)
        {
            _people = list;
        }
        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
