using FinalProject.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
    public class SalesCollection : IEnumerable
    {
        private List<Double> _sales = new List<Double>();
        private List<SalesPerson> _salesPeople = new List<SalesPerson>();

        public void AddSale(Double amount)
        {
            _sales.Add(amount);
        }

        public SalesPerson AddSalesPerson(String name, String title)
        {
            SalesPerson person = new SalesPerson(name, title, this);
            _salesPeople.Add(person);
            return person;
        }

        public IEnumerator GetEnumerator()
        {
            return new SalesIterator(this);
        }

        public int Count => _sales.Count;
        public List<SalesPerson> SalesPeople => this._salesPeople;
        public List<Double> Sales => this._sales;

        public int this[int index] => (int)_sales[index];
      
    }
}
