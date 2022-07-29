using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_компании
{
    public class Organization
    {
        public Post[] doljnosti;
        string nameOrganization;
        decimal budjet;
        public Organization(string nameOrganization, decimal budjet)
        {
            this.nameOrganization = nameOrganization;
            this.budjet = budjet;
        }
        void VuplataZarplat()
        {
            for (int i = 0; i < doljnosti.Length; i++)
            {
                budjet -= (doljnosti[i].Zarplata * 1.185M);
            }
        }
        public void RabotaMesac(string project)
        {
            if (project == "new app")
            {
                VuplataZarplat();
                budjet += 50000;
                Console.WriteLine(budjet);
            }
            else if (project == "new PO")
            {
                VuplataZarplat();
                budjet -= 10000;
                Console.WriteLine(budjet);
            }
            else if (project == "correct PO")
            {
                VuplataZarplat();
                budjet -= 5000;
                Console.WriteLine(budjet);
            }
            else
            {
                VuplataZarplat();
                Console.WriteLine($"Некорректная задача, весь месяц пинали..., остаток бюджета {budjet}");
            }
        }

    }
}
