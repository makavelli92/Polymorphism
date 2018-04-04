using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа ограничено в бесплатно версии");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа недоступно");
        }
    }
    class  ProDocumentWorker : DocumentWorker 
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован в версии Pro");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в версии Pro (ограничено)");
        }
    }
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован в версии Expert");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в версии Expert (расширено)");
        }
    }
    class Program
    {
        static DocumentWorker EnterKey(string key)
        {
            switch (key)
            {
                case "1a2b":
                    return new ProDocumentWorker();
                case "12ab":
                    return new ExpertDocumentWorker();
            }
            return new DocumentWorker();
                
        }
        static void Main(string[] args)
        {
            DocumentWorker my;
            my = EnterKey("kjhg");
            my.EditDocument();

            Console.ReadLine();
        }
    }
}
