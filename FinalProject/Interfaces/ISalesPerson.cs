using FinalProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public interface ISalesPerson
    {
        String Name { get; }
        String Title { get; }
        SalesCollection SalesCollection { get; }
        void AddSale();

    }
}
