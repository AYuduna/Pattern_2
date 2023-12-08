//using static System.Console;
/////* Существует множество программистов, но одни являются фрилансерами, 
//// кто-то работает в компании инженером,
//// кто-то совмещает работу в компании и фриланс. 
//// Таким образом, вырисовывается иерархия различных классов программистов. 
////  Но эти программисты могут работать с различными языками и технологиями.
////  И в зависимости от выбранного языка деятельность программиста будет отличаться.*/


//// создаем нового программиста, он работает с с++
//Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
//freelancer.DoWork();
//freelancer.GetMoney();
//ReadKey();
//// пришел новый заказ, но теперь нужен c#
//freelancer.Language = new CSharpLanguage();
//freelancer.DoWork();
//freelancer.GetMoney();
//ReadKey();
//Programmer freelancer1 = new CorporateProgrammer(new CPPLanguage());
//freelancer1.DoWork();
//freelancer1.GetMoney();
//ReadKey();


//interface ILanguage
//{
//    void Build();
//    void Execute();
//}

//class CPPLanguage : ILanguage
//{
//    public void Build()
//    {
//        WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");
//    }

//    public void Execute()
//    {
//        WriteLine("Запускаем исполняемый файл программы");
//    }
//}

//class CSharpLanguage : ILanguage
//{
//    public void Build()
//    {
//        WriteLine("С помощью компилятора Roslyn компилируем исходный код в файл exe");
//    }

//    public void Execute()
//    {
//        WriteLine("JIT компилирует программу  в бинарный код");
//        WriteLine("CLR выполняет скомпилированный бинарный код");
//    }
//}

//abstract class Programmer
//{
//    protected ILanguage language;
//    public ILanguage Language
//    {
//        set { language = value; }
//    }
//    public Programmer(ILanguage lang)
//    {
//        language = lang;
//    }
//    public virtual void DoWork()
//    {
//        language.Build();
//        language.Execute();
//    }
//    public abstract void GetMoney();
//}

//class FreelanceProgrammer : Programmer
//{
//    public FreelanceProgrammer(ILanguage lang) : base(lang)
//    {
//    }
//    public override void GetMoney()
//    {
//        WriteLine("Получаем оплату за выполненный заказ");
//    }
//}
//class CorporateProgrammer : Programmer
//{
//    public CorporateProgrammer(ILanguage lang)
//        : base(lang)
//    {
//    }
//    public override void GetMoney()
//    {
//        WriteLine("Получаем в конце месяца зарплату");
//    }
//}