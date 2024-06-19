using FinalProject.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public class SalesIterator : IEnumerator
    {
        private SalesCollection _salesCollection;
        private int _index = -1;

        public SalesIterator(SalesCollection Sales) {
            this._salesCollection = Sales;
        }

        public double Current {
            get {
                if (this._index < 0 || _index > _salesCollection.Count) {
                    throw new InvalidOperationException();
                }
                return _salesCollection[_index];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _salesCollection.Count;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
