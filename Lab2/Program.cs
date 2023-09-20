using System;
public class ClassRoom 
{
    Pupil[] pupils;
    public ClassRoom (params Pupil[] pu)
    {
       for (int i = 0; i < pu.Length; i++)
        {
            pupils[i] = pu[i];
        }

    }
}

class EclselentPupil : Pupil
{
    public override void Study() 
    {
        Console.WriteLine("учится отлично");
    }
    public override void Read() {
        Console.WriteLine("читает отлично");

    }
    public override void Write() 
    {
        Console.WriteLine("пишет отлично");
    }
    public override void Relax() 
    {
        Console.WriteLine("отдыхает отлично");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("учится хорошо");
    }
    public override void Read()
    {
        Console.WriteLine("читает хорошо");

    }
    public override void Write()
    {
        Console.WriteLine("пишет хорошо");
    }
    public override void Relax()
    {
        Console.WriteLine("отдыхает хорошо");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("учится плохо");
    }
    public override void Read()
    {
        Console.WriteLine("читает плохо");

    }
    public override void Write()
    {
        Console.WriteLine("пишет плохо");
    }
    public override void Relax()
    {
        Console.WriteLine("отдыхает плохо");
    }
}
public abstract class Pupil
{
    public abstract void Study();
    public abstract void Read();
    public abstract void Write();
    public abstract void Relax();


}




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil a = new ExcelentPupil();
            GoodPupil b = new GoodPupil();
            BadPupil c = new BadPupil();

            ClassRoom class1 = new ClassRoom(a, b, c, c);
            ClassRoom class2 = new ClassRoom(a, b);
            Console.Read();
        }
    }


