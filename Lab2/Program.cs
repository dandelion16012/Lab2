using System;
using System.Drawing;

public class ClassRoom 
{
    Pupil[]pupils;
    public ClassRoom (params Pupil[] pu)
    {
        this.pupils = new Pupil[pu.Length];
        for (int i = 0; i < pu.Length; i++)
        {
            pupils[i] = pu[i];
        }

    }
    public void printStudy()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
        }

    }
    public void printRead()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Read();
        }

    }
    public  void printWrite()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Write();
        }
    }
    public void printRelax()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Relax();
        }
    }
}

class ExcelentPupil : Pupil
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
            Pupil  [] ar1= {a, b,c};
            Pupil[] ar2 = {a, b};

            ClassRoom class1 = new ClassRoom(ar1);
            ClassRoom class2 = new ClassRoom(ar2);
            class1.printRead();
            class1.printRelax();
            class1.printStudy();
            class1.printWrite();
            class2.printRead();
            class2.printRelax();
            class2.printStudy();
            class2.printWrite();
            Console.Read();
        }
    }
}
