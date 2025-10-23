using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Repository.Implements
{
    public class DetalleIntercambioQueries : IDetalleIntercambioQueries
    {
        private readonly IDbConnection _db;

        public DetalleIntercambioQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<IEnumerable<DetalleIntercambio>> GetDetalleByIntercambioId(int IntercambioId)
        {
            try
            {
                string sql = $"SELECT * FROM DetalleIntercambio WHERE IntercambioId={IntercambioId}";
                return await _db.QueryAsync<DetalleIntercambio>(sql);
            }
            catch (Exception)
            {

                throw;
            }
            ;
        }
    }
}
