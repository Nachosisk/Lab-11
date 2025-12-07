using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {

        class Animal
        {
            public string food;
            public string location;

            public Animal() //конструктор
            {
                food = "еда";
                location = "местонахождение";
            }

            public virtual void makeNoise() //методы род класса
            {
                Console.WriteLine("Вы издали звук");
            }
            public virtual void eat()
            {
                Console.WriteLine("Вы покормили животное");
            }
            public static void sleep()
            {
                Console.WriteLine("Животное спит");
            }
        }
        class Horse : Animal //дочерние классы
        {
            public string speedkmh;
            public string health;
            public Horse()
            {
                health = "very nice";
                speedkmh = "20";
                food = "морковь";
                location = "загон";
            }
            public override void makeNoise()
            {
                Console.WriteLine("Вы издали звук 'игого' ");
            }
            public override void eat()
            {
                Console.WriteLine("Вы покормили лошадь");
            }

        }
        class Dog : Animal
        {
            public string poroda;
            public string name;
            public Dog()
            {
                poroda = "чихуа-хуа";
                name = "vano";
                food = "кость";
                location = "будка";
            }
            public override void makeNoise()
            {
                Console.WriteLine("Вы издали звук 'гав' ");
            }
            public override void eat()
            {
                Console.WriteLine("Вы покормили собаку");
            }
        }
        class Cat : Animal
        {
            public string favouritefood;
            public string height;
            public Cat()
            {
                favouritefood = "рыба";
                height = "0.8";
                food = "рыба";
                location = "дом";
            }
            public override void makeNoise()
            {
                Console.WriteLine("Вы издали звук 'мяу'");
            }
            public override void eat()
            {
                Console.WriteLine("Вы покормили котика");
            }
        }
        class Veterinar //класс ветеринара выводит еду и локацию объекта класса Animal
        {
            public static void treatAnimal(Animal animal)
            {
                Console.WriteLine($"Еда: {animal.food}");
                Console.WriteLine($"Местонахождение: {animal.location}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите животное из представленного списка: кошка, собака, лошадь, для вывода его еды и местонахождения");
            string a = Console.ReadLine();

            Dog dog = new Dog();
            Cat cat = new Cat();
            Horse horse = new Horse();
            if ( a == "кошка")
            {
                Veterinar.treatAnimal(cat);
            }
            else if (a == "собака")
            {
                Veterinar.treatAnimal(dog);
            }
            else if (a == "лошадь")
            {
                Veterinar.treatAnimal(horse);
            }
        }
    }
