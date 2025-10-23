using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCenterApi.Models;

namespace TradeCenterApi.Repository.Interfaces
{
    public interface IDetalleIntercambioQueries
    {
        Task<IEnumerable<DetalleIntercambio>> GetDetalleByIntercambioId(int IntercambioId);
    }
}
