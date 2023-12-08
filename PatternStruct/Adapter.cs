using static System.Console;

/* Есть путешественник, который путешествует на машине. 
   Но в какой-то момент ему приходится передвигаться по пескам пустыни, где он не может ехать на машине. 
   Зато он может использовать для передвижения верблюда. 
   Однако в классе путешественника использование класса верблюда не предусмотрено, поэтому нам надо использовать адаптер  */

//путешественник
Driver driver = new Driver();
//машина
Transport auto = new Transport();
//отправляемся в путешествие
driver.Travel(auto);
//встретились пески, надо использовать верблюда
Camel camel = new Camel();
//используем адаптер
TransportAdapterToCamel camelTransport = new TransportAdapterToCamel(camel);
//продолжаем путь по пескам пустыни
driver.Travel(camelTransport);

ReadKey();




class Driver // (Client)
{
    public void Travel(Transport transport)
    {
        transport.Drive();
    }
}
//класс машины
class Transport
{
    public virtual void Drive()
    {
        WriteLine("Машина едет по дороге");
    }
}

//класс верблюда (adaptee)
class Camel
{
    public void Move()
    {
        WriteLine("Верблюд идет по пескам пустыни");
    }
}
//Адаптер от  Transport к Camel (adapter)
class TransportAdapterToCamel : Transport
{
    Camel camel;
    public TransportAdapterToCamel(Camel c)
    {
        camel = c;
    }

    public override void Drive()
    {
        camel.Move();
    }
}

