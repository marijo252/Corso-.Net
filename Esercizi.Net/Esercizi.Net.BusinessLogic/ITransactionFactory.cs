using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Net.BusinessLogic
{
    public interface ITransactionFactory : IFactory<ITransazione> //ITransactionFactory implementa una interfaccia IFactory con "tipo" Itransazione
    {
    }
}
