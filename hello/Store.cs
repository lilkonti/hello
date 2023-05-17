using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hello
{
    enum Type
    {
        Product,
        Clouth,
        Boots,
        Gospodar
    }
    internal class Store : IDisposable
    {
        //поля класса
        public Type type { get; set; }
        public StringBuilder adress { get; set; }
        public StringBuilder name { get; set; }
        //конструктор
        public Store()
        {
            type = Type.Product;
            name = new StringBuilder("Anastasia");
            adress = new StringBuilder("Kovalivska 37");
        }
        //деструктор
        public void Dispose()
        {
            type = default;
            name.Clear();
            adress.Clear();
            Console.WriteLine("destroed class");
        }
        //вивід
        public void show()
        {
            Console.WriteLine(name + " it's a shop in " + adress);
            Console.WriteLine("type of shop " + type);
            Console.WriteLine();
        }
    }
}
