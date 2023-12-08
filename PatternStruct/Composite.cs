//using static System.Console;



//component filesystem = new directory("файловая система");
//// определяем новый диск
//component diskc = new directory("диск с");
//// новые файлы
//component pngfile = new file("12345.png");
//component docxfile = new file("document.docx");
//// добавляем файлы на диск с
//diskc.add(pngfile);
//diskc.add(docxfile);
//// добавляем диск с в файловую систему
//filesystem.add(diskc);
//// выводим все данные
//filesystem.print();
//Console.WriteLine();
//// удаляем с диска с файл
//diskc.remove(pngfile);
//// создаем новую папку
//component docsfolder = new directory("мои документы");
//// добавляем в нее файлы
//component txtfile = new file("readme.txt");
//component csfile = new file("program.cs");
//docsfolder.add(txtfile);
//docsfolder.add(csfile);
//diskc.add(docsfolder);

//filesystem.print();

//Console.ReadKey();


//abstract class component
//{
//    protected string name;

//    public component(string name)
//    {
//        this.name = name;
//    }

//    public virtual void add(component component) { }

//    public virtual void remove(component component) { }

//    public virtual void print()
//    {
//        Console.WriteLine(name);
//    }
//}
//class directory : component //composition
//{
//    private List<component> components = new List<component>();

//    public directory(string name)
//        : base(name)
//    {
//    }

//    public override void add(component component)
//    {
//        components.Add(component);
//    }

//    public override void remove(component component)
//    {
//        components.Remove(component);
//    }

//    public override void print()
//    {
//        Console.WriteLine("узел " + name);
//        Console.WriteLine("подузлы:");
//        for (int i = 0; i < components.Count; i++)
//        {
//            components[i].print();
//        }
//    }
//}

//class file : component //leaf
//{
//    public file(string name)
//            : base(name)
//    { }
//}