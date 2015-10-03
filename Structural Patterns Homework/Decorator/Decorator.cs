using System;

public abstract class BakeryComponent
{
    public abstract string GetName();
    public abstract double GetPrice();
}

class CakeBase : BakeryComponent
{
    private string m_Name = "Cake Base";
    private double m_Price = 200.0;

    public override string GetName()
    {
        return m_Name;
    }

    public override double GetPrice()
    {
        return m_Price;
    }
}

class PastryBase : BakeryComponent
{
  
    private string m_Name = "Pastry Base";
    private double m_Price = 20.0;

    public override string GetName()
    {
        return m_Name;
    }

    public override double GetPrice()
    {
        return m_Price;
    }
}


/* Now we have our base object ready. Now we will look into how the other required things can be added to it dynamically. 
 * Lets start by looking at the Decorator class.
*/

public abstract class Decorator : BakeryComponent
{
    BakeryComponent m_BaseComponent = null;

    protected string m_Name = "Undefined Decorator";
    protected double m_Price = 0.0;

    protected Decorator(BakeryComponent baseComponent)
    {
        m_BaseComponent = baseComponent;
    }

    #region BakeryComponent Members

    string BakeryComponent.GetName()
    {
        return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
    }

    double BakeryComponent.GetPrice()
    {
        return m_Price + m_BaseComponent.GetPrice();
    }
    #endregion
}

/*
 * There are two things to notice here. First that this class implements the BakeryComponent interface. 
 * The reason for that is a Cake with a Component will also be a cake and thus all the operations possible on a cake 
 * should also be possible on a Decorated cake. The second interesting thing to note is that it also hold the BakeryComponent object inside. 
 * The reason for that is that we need the logical is-a relationship between a cake and a decorating item but since actually 
 * that is not the case we hold a BakeryComponent object inside to be able to mimic that is-a relationship.

In short what we have done is that instead of having a static is-a relationship using inheritance, 
 * we have a dynamic is-a relationship by using composition.

Let us now see how the ConcreteDecorators can be implemented.
*/

class ArtificialScentDecorator : Decorator
{
    public ArtificialScentDecorator(BakeryComponent baseComponent)
        : base(baseComponent)
    {
        this.m_Name = "Artificial Scent";
        this.m_Price = 3.0;
    }
}

class CherryDecorator : Decorator
{
    public CherryDecorator(BakeryComponent baseComponent)
        : base(baseComponent)
    {
        this.m_Name = "Cherry";
        this.m_Price = 2.0;
    }
}

class CreamDecorator : Decorator
{
    public CreamDecorator(BakeryComponent baseComponent)
        : base(baseComponent)
    {
        this.m_Name = "Cream";
        this.m_Price = 1.0;
    }
}


/*
 * Now in these classes we have simply set the decorator specific values of the items and not customized any behavior. 
 * But if we want we can even customize the behavior or add more state variables in the ConcereteDecorator objects. 
 * To illustrate this point lets say whenever the customer choose to add the Namecard on his cake he is eligible to get 
 * a discount card for the next purchase and we need to show this message in the receipt. Lets see how the ConcreteDecorator 
 * will add its own state and behavior in that case.
 */

class NameCardDecorator : Decorator
{
    private int m_DiscountRate = 5;

    public NameCardDecorator(BakeryComponent baseComponent)
        : base(baseComponent)
    {
        this.m_Name = "Name Card";
        this.m_Price = 4.0;
    }

    public override string GetName()
    {
        return base.GetName() +
            string.Format("\n(Please Collect your discount card for {0}%)",
            m_DiscountRate);
    }
}

/* Now our client application can create combination of these ConcreteComponents with any Decorator. */

static void Main(string[] args)
{
    // Let us create a Simple Cake Base first
    CakeBase cBase = new CakeBase();
    PrintProductDetails(cBase);

    // Lets add cream to the cake
    CreamDecorator creamCake = new CreamDecorator(cBase);
    PrintProductDetails(creamCake);
    
    // Let now add a Cherry on it
    CherryDecorator cherryCake = new CherryDecorator(creamCake);
    PrintProductDetails(cherryCake);

    // Lets now add Scent to it
    ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
    PrintProductDetails(scentedCake);

    // Finally add a Name card on the cake
    NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
    PrintProductDetails(nameCardOnCake);
    
    // Lets now create a simple Pastry
    PastryBase pastry = new PastryBase();
    PrintProductDetails(pastry);

    // Lets just add cream and cherry only on the pastry 
    CreamDecorator creamPastry = new CreamDecorator(pastry);
    CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
    PrintProductDetails(cherryPastry);
}


