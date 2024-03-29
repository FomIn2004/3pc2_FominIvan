﻿using System;
using System.Drawing;
using System.Xml.Linq;

namespace PZ_5
{
    class Animal : ICloneable, IComparable<Animal>
    {
        string _type;
        int _age;
        Owner _owner;

        public string Type {
            get { return _type; }
            set { _type = value; }
        }
        public int Age {
            get { return _age; }
            set { _age = value; }
        }
        public Owner Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public Animal(string type, int age, Owner owner)
        {
            _type = type;
            _age = age;
            _owner = owner;
        }


        public override string ToString() 
        {
            return $"данному животному({_type}) {_age} лет, хозяин - {_owner.Name}";
        }

        public object Clone()  
        {
            return new Animal(_type, _age, new Owner(_owner.Name));
        }

        public int CompareTo(Animal? animal)
        {
            if (animal is null)
                throw new ArgumentException("Неправильный параметр");
            return Age.CompareTo(animal.Age);
        }
    }

    internal class Owner
    {
        string _name;

        public Owner(string name)
        {
            _name = name;
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var owner1 = new Owner("Иванов");
            var owner2 = new Owner("Сидоров");
            var animal = new Animal("Собака", 8, owner1);
            var clone = (Animal)animal.Clone();
            clone.Owner = owner2;

            Console.WriteLine(animal.ToString());
            Console.WriteLine(clone.ToString());

            Console.WriteLine(animal.CompareTo(clone));
        }
    }
}