//using static System.Console;
////Create math proxy
//IMath p = new MathProxy();
//// Do the math
//WriteLine("4 + 2 = " + p.Add(4, 2));
//WriteLine("4 - 2 = " + p.Sub(4, 2));
//WriteLine("4 * 2 = " + p.Mul(4, 2));
//try
//{
//    WriteLine("4 / 0 = " + p.Div(4, 0));
//}
//catch (Exception ex)
//{ WriteLine(ex.Message); }
//// Wait for user
//ReadKey();


//public interface IMath
//{
//    double Add(double x, double y);
//    double Sub(double x, double y);
//    double Mul(double x, double y);
//    double Div(double x, double y);
//}

////RealSubject - реальный объект

//class Math : IMath
//{
//    public Math()
//    {
//        Console.WriteLine("Create object Math. Wait...");
//        Thread.Sleep(1000);
//    }
//    public double Add(double x, double y)
//    {
//        return x + y;
//    }
//    public double Sub(double x, double y)
//    {
//        return x - y;
//    }
//    public double Mul(double x, double y)
//    {
//        return x * y;
//    }
//    public double Div(double x, double y)
//    {
//        return x / y;
//    }
//}

////Proxy - заместитель
//class MathProxy : IMath
//{
//    Math math;
//    public MathProxy()
//    {
//        math = null;
//    }
//    // Быстрая операция - не требует реального субъекта
//    public double Add(double x, double y)
//    {
//        return x + y;
//    }
//    public double Sub(double x, double y)
//    {
//        return x - y;
//    }
//    //Медленная операция - требует создания реального субъекта
//    public double Mul(double x, double y)
//    {
//        if (math == null)
//            math = new Math();
//        return math.Mul(x, y);
//    }
//    public double Div(double x, double y)
//    {
//        if (y == 0) throw (new Exception("Деление на ноль"));
//        if (math == null)
//            math = new Math();
//        return math.Div(x, y);
//    }
//}
