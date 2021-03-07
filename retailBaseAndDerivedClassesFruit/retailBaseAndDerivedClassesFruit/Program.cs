using System;

namespace retailBaseAndDerivedClassesFruit
{
    class Program
    {// usefull for building algortihms
        static void Main(string[] args)
        {
            Apple apple = new Apple("Macintosh", .5); // this is an objectnamed Apple
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", apple.Kind, apple.GetCost(), Environment.NewLine);
            Orange orange = new Orange("Valencia", .75);// this is an object named Orange
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", orange.Kind, orange.GetCost(),Environment.NewLine);
            Banana banana = new Banana("Banana bunch", .75);// this is an object named Banana
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", banana.Kind, banana.GetCost(), Environment.NewLine);
        }
    }
    class Fruit // base class
    {//data is taken from here and placed to a derived class 
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
    }
    class Apple : Fruit  // derived class
    {
        public Apple(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
    class Orange : Fruit // derived class
    {
        public Orange(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
    class Banana : Fruit
    {
        public Banana(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
}
