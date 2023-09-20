using System;

class Plane :Vihicle
{

}

class Car : Vihicle
{

}

class Ship : Vihicle
{
    int height;
    int number_of_passengers;
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
}







namespace part2
{
    class program
    {
        static void Main(string[] args)
        {

        }
    }
}