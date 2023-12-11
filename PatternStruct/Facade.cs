using static System.Console;



VisualStudioFacade ide = new VisualStudioFacade();

Programmer programmer = new Programmer();
programmer.CreateApplication(ide);
programmer.Work();

ReadKey();


class TextEditor
{
    public void CreateCode()
    {
        Console.WriteLine("Написание кода");
    }
    public void Save()
    {
        Console.WriteLine("Сохранение кода");
    }
}
class Compiller
{
    public void Compile()
    {
        Console.WriteLine("Компиляция приложения");
    }
}
class CLR
{
    public void Execute()
    {
        Console.WriteLine("Выполнение приложения");
    }
    public void Finish()
    {
        Console.WriteLine("Завершение работы приложения");
    }
}

class VisualStudioFacade
{
    TextEditor textEditor = new TextEditor();
    Compiller compiller = new Compiller();
    CLR clr = new CLR();
    public VisualStudioFacade()
    {

    }
    public void Start()
    {
        textEditor.CreateCode();
        textEditor.Save();
        compiller.Compile();
        clr.Execute();
    }
    public void Stop()
    {
        clr.Finish();
    }
}



class Programmer
{
    VisualStudioFacade? _facade;
    public void CreateApplication(VisualStudioFacade facade)
    {
        _facade = facade;
    }

    public void Work()
    {
        if (_facade != null)
        {
            _facade.Start();
            _facade.Stop();
        }

    }
}