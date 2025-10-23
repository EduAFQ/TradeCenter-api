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
    public class ResenaRepository : IResenaRepository
    {
        private readonly IDbConnection _db;

        public ResenaRepository(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<Resena> Add(Resena entity)
        {
            try
            {
                var rs = await _db.InsertAsync(entity);
                entity.ResenaId = rs;
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
