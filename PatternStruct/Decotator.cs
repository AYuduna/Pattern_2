//using static System.Console;
////есть пиццерия, которая готовит различные типы пицц с различными добавками. 
////Есть итальянская, болгарская пиццы. К ним могут добавляться помидоры, сыр и т.д. 
////И в зависимости от типа пицц и комбинаций добавок пицца может иметь разную стоимость. 

//Pizza pizza1 = new ItalianPizza();
//pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
//WriteLine("Название: {0}", pizza1.Name);
//WriteLine("Цена: {0}", pizza1.GetCost());

//Pizza pizza2 = new ItalianPizza();
//pizza2 = new CheesePizza(pizza2);// итальянская пицца с сыром
//WriteLine("Название: {0}", pizza2.Name);
//WriteLine("Цена: {0}", pizza2.GetCost());

//Pizza pizza3 = new BulgerianPizza();
//pizza3 = new TomatoPizza(pizza3);
//pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
//WriteLine("Название: {0}", pizza3.Name);
//WriteLine("Цена: {0}", pizza3.GetCost());

//ReadKey();

//abstract class Pizza
//{
//    public Pizza(string name)
//    {
//        this.Name = name;
//    }
//    public string Name { get; protected set; }
//    public abstract int GetCost();
//}

//class ItalianPizza : Pizza
//{
//    public ItalianPizza() : base("Итальянская пицца")
//    { }
//    public override int GetCost()
//    {
//        return 10;
//    }
//}
//class BulgerianPizza : Pizza
//{
//    public BulgerianPizza()
//        : base("Болгарская пицца")
//    { }
//    public override int GetCost()
//    {
//        return 8;
//    }
//}

//abstract class PizzaDecorator : Pizza
//{
//    protected Pizza pizza;
//    public PizzaDecorator(string name, Pizza pizza) : base(name)
//    {
//        this.pizza = pizza;
//    }
//}

//class TomatoPizza : PizzaDecorator
//{
//    public TomatoPizza(Pizza p)
//        : base(p.Name + ", с томатами", p)
//    { }

//    public override int GetCost()
//    {
//        return pizza.GetCost() + 3;
//    }
//}

//class CheesePizza : PizzaDecorator
//{
//    public CheesePizza(Pizza p)
//        : base(p.Name + ", с сыром", p)
//    { }

//    public override int GetCost()
//    {
//        return pizza.GetCost() + 5;
//    }
//}
