using System;

class ExpertDocumentWorker: ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument() {
        Console.WriteLine("Редактирование документа  доступно в версии Pro");
    }
    public virtual void SaveDocument() {
        Console.WriteLine("Сохранение документа  доступно в версии Pro");
    }
}

namespace part3
{
    class program
    {
        private const string PRO_LICENSE = "123";
        private const string EXP_LICENSE = "345";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter license key:");
            var license = Console.ReadLine();
            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: 
                    worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: 
                    worker = new ExpertDocumentWorker(); break;
                default: 
                    worker = new DocumentWorker(); break;
            }
            while (true)
            {
                Console.WriteLine("Enter Command (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }

    }
}