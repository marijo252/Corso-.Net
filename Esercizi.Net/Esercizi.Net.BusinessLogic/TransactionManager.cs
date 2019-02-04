using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Net.BusinessLogic
{
    public class TransactionManager
    {
        //

        public ITransactionFactory Factory{ get;}

        public List<ITransazione> Transazioni { get; } // quando chiamo il get leggo il oggetto cioè ho l'accesso al oggeto (la lista)

        public TransactionManager(ITransactionFactory factory) //costruttore perche ha lo stesso nome della classe
        {
            Factory = factory;
            Transazioni = new List<ITransazione>();
        }

        public ITransazione CreateTransaction() 
        //questo e un metodo che non prende nulla in input, restituisce un itransaction. 
        //la implementazione consiste nel chiamare il metodo create della property factory di tipo itransactionfactory
        {
            return Factory.Create();
        }
        public void SaveTransaction (ITransazione transazione)
        {
            Transazioni.Add(transazione);
        }
        public ITransazione DeleteTransaction(int index)
        {
            return null;
        }

        public IEnumerable<ITransazione> GetTransactions()
        {
            return null;
        }
    }
}
