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
    public class ResenaQueries : IResenaQueries
    {
        private readonly IDbConnection _db;

        public ResenaQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<IEnumerable<Resena>> GetResenasByUsuarioId(int UsuarioId)
        {
            try
            {
                var rs = await _db.QueryAsync<Resena>($"SELECT * FROM Resena WHERE UsuarioId={UsuarioId}");
                return rs;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
