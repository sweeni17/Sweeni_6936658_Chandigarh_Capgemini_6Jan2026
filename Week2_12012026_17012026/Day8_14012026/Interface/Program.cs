namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C3 obj1 = new C3();
            Interface1 obj2 = (Interface1)obj1;
            Inter2 obj3 = (Inter2)obj1;
            obj2.f1();
            obj3.f1();
            
        }
    }
}
