using Dapper.Contrib.Extensions;
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
    public class CartaRepository : ICartaRepository
    {
        private readonly IDbConnection _db;

        public CartaRepository(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<Carta> Add(Carta entity)
        {
            try
            {
                var rs = await _db.InsertAsync(entity);
                entity.CartaId = rs;
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
