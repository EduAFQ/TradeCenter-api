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
    public class ColeccionUsuarioQueries : IColeccionUsuarioQueries
    {
        private readonly IDbConnection _db;

        public ColeccionUsuarioQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<IEnumerable<DetallIntercambio>> GetColeccionByUsuarioId(int UsuarioId)
        {
            try
            {
                string sql = $"SELECT C.* FROM ColeccionUsuario C " +
                    $"INNER JOIN Carta G " +
                    $"ON C.CartaId = G.ColeccionUsuarioId " +
                    $"WHERE G.UsuarioId={UsuarioId}";
                return await _db.QueryAsync<DetallIntercambio>(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
