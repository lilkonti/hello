namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var Store = new Store()) 
            {
                Store.show();
            }
            using (var piesa = new Piesa())
            {
                piesa.show();
            }
        }
    }
}