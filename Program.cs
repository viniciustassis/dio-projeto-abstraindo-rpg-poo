using System;
using POO.src.Entities;

namespace POO;

public class Program {
    public static void Main(string[] args) {
        Knight arus = new Knight("Arus", 2, "Knight");
        //Hero oponent = new Hero("Maleficus", 99, "Devil");
        Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

        Console.WriteLine(arus);
        //Console.WriteLine(oponent);
        Console.WriteLine(wizard.Attack(5));
        Console.WriteLine(wizard.Attack(7));
    }
}