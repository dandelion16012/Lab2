using System;
using System.Diagnostics;

class Plane :Vihicle
{
    int number_of_passenger;
    string home_port;
    public Plane(int prise, int speed, int year_of_manufacture, int number_of_passenger, string home_port) : base(prise, speed, year_of_manufacture)
    {
        this.number_of_passenger= number_of_passenger;
        this.home_port= home_port;

    }
    public override void getinfo()
    {
        base.getinfo();
        Console.WriteLine($"number of passenger\t {number_of_passenger}\thome port\t{home_port}");
    }
  }

class Car : Vihicle
{
    string name;
    public Car(int prise, int speed, int year_of_manufacture, string name): base (prise, speed, year_of_manufacture)
    {
        this.name = name;
    }
    public override void getinfo()
    {
        base.getinfo();
        Console.WriteLine($"name\t {name}");
    }
}

class Ship : Vihicle
{
    int height;
    int number_of_passengers;

    public Ship(int price, int speed, int year_of_manufacture,int hight, int number_of_passenger) : base(price, speed, year_of_manufacture)
    {
        this.height=hight;
        this.number_of_passengers=number_of_passenger;
    }
    public override void getinfo()
    {
        base.getinfo();
        Console.WriteLine($"height\t {height}\tnumber of passenger\t{number_of_passengers}");
    }
}
class Vihicle
{
    int price;
    int speed;
    int year_of_manufacture;
    public Vihicle(int price, int speed, int year_of_manufacture)
    {
        this.price = price;
        this.speed = speed;
        this.year_of_manufacture = year_of_manufacture;
    }
    public virtual void getinfo()
    {
        Console.WriteLine($"prise\t {price}\tspeed\t{speed}\tyear_of_manufacture\t{year_of_manufacture}");
    }
}







namespace part2
{
    class program
    {
        static void Main(string[] args)
        {
            Car a = new Car(2000, 70, 1954, "Mystang");
            a.getinfo();
            Plane b = new Plane(4500,90, 2014, 234, "AQua");
            b.getinfo();
            Ship c = new Ship(7800, 45, 1999, 35, 567);
            c.getinfo();


        }
    }
}