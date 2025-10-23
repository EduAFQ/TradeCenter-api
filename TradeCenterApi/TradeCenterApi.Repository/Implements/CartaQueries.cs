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
    public class CartaQueries : ICartaQueries
    {
        private readonly IDbConnection _db;

        public CartaQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<IEnumerable<Carta>> GetAll()
        {
            try
            {
                var rs = await _db.QueryAsync<Carta>("SELECT * FROM Carta");
                return rs;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
