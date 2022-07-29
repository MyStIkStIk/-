using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_компании
{
    public class Post
    {
        Employee sotrudnik;
        string nazvanieDoljnosti;
        decimal zarplata;
        public decimal Zarplata
        {
            get { return zarplata; }
        }
        public Post(string imya, string familia, string nazvanieDoljnosti, decimal zarplata)
        {
            this.sotrudnik = new Employee(familia, imya);
            this.nazvanieDoljnosti = nazvanieDoljnosti;
            this.zarplata = zarplata;
        }
        public void ReturnInfo()
        {
            sotrudnik.ReturnInfo();
            Console.WriteLine(nazvanieDoljnosti);
            Console.WriteLine(zarplata);
        }
    }
}
