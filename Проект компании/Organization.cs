using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_компании
{
    public class Organization
    {
        Post[] doljnosti;
        string nameOrganization;
        decimal budjet;
        public Organization(string nameOrganization, decimal budjet)
        {
            this.nameOrganization = nameOrganization;
            this.budjet = budjet;
        }
        public void VuplataZarplat()
        {

        }
        public int RabotaMesac(string project)
        {
            return 0;
        }

    }
}
