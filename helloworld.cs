Console.WriteLine("Hello, World!");

SuperClass superClass1 = new SuperClass(104);
SubClass subClass1 = new SubClass(105, 'A');
superClass1.Method();
subClass1.Method();

list<SuperClass> list = new list<SuperClass>();
list.Add(superClass1);
list.Add(subClass1);

foreach(SuperClass item in list)
{
    item.Method();
}

public class SuperClass
{
    private int attributo;

    public int Attributo { get => attributo; set => attributo = value; }

    public SuperClass(int attributo)
    {
        this.attributo = attributo;
    }

    public virtual void Method()
    {
        Console.WriteLine($"Method of SuperClass called. Attributo {attributo}");
    }

}

public class SubClass : SuperClass
{
    private char attributoLocale;

    public SubClass(int attributo, char attributoLocale) : base(attributo) // Sfrutta il costruttore della superclasse per inizializzare l'attributo
    {
        this.attributoLocale = attributoLocale;
    }

    public override void Method()
    {
        Console.WriteLine($"SubMethod of SubClass called. AttributoLocale {attributoLocale}");
    }
}

