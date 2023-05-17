using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    enum Genre
    {
        triller,
        comedia,
        fiting,
        detective
    }
    internal class Piesa : IDisposable
    {
        //поля класса
        public Genre genre { get; set; }
        public StringBuilder name { get; set; }
        public StringBuilder fullName { get; set; }
        public StringBuilder time { get; set; }
        //конструктор
        public Piesa()
        {
            genre = Genre.comedia;
            name = new StringBuilder("Pikaso life");
            fullName = new StringBuilder("Niki Posteranos");
            time = new StringBuilder("1982");

            Console.WriteLine("generate class");
        }
        //деструктор
        public void Dispose()
        {
            genre = default;
            name.Clear();
            fullName.Clear();
            time.Clear();
            Console.WriteLine("destroed class");
        }
        //вивід
        public void show()
        {
            Console.WriteLine(name + " it's a " + fullName + "show");
            Console.WriteLine("genre is " + genre + " data duration - " + time);
            Console.WriteLine();
        }
    }
}
