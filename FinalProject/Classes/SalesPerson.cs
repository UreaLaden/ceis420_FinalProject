using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
    public class SalesPerson
    {
        private String _name;
        private String _title;
        private SalesCollection _salesCollection;
        public String Name => this._name;
        public String Title => this._title;
        public SalesCollection SalesCollection => this._salesCollection;

        public SalesPerson(String name, String title, SalesCollection collection)
        {
            _name = name;
            _title = title;
            _salesCollection = collection;
        }

        public void AddSale(Double amount)
        {
            _salesCollection.AddSale(amount);
        }

        public IEnumerator<Double> SalesIterator => _salesCollection.Sales.GetEnumerator();
    }
}
