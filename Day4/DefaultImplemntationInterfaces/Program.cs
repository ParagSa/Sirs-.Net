﻿namespace DefaultImplemntationInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Insert();
            //o.Select();

            Console.WriteLine();
            (o as IDbFunctions).Insert();
            (o as IDbFunctions).Select();

        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("default implementation code");
        }
    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("class1 display");
        }
        public void Delete()
        {
            Console.WriteLine("class1 Idbfunctions delete");
        }
        public void Insert()
        {
            Console.WriteLine("class1 Idbfunctions insert");
        }
        public void Update()
        {
            Console.WriteLine("class1 Idbfunctions update");
        }
        //public void Select()
        //{
        //    Console.WriteLine("public class1 Idbfunctions select");
        //}
        void IDbFunctions.Select()
        {
            Console.WriteLine("explicit class1 Idbfunctions select");
        }


    }
}