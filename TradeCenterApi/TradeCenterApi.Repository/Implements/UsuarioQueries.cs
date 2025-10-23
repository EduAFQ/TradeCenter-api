using System.Data;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Repository.Implements
{
    public class UsuarioQueries : IUsuarioQueries
    {
        private readonly IDbConnection _db;

        public UsuarioQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            try
            {
                var rs = await _db.QueryAsync<Usuario>("SELECT * FROM Usuario");
                return rs;
            }
            catch (Exception)
            {

                throw;
            }
        }


        Task<IEnumerable<Usuario>> IUsuarioQueries.GetUsuarioById(int UsuarioId)
        {
            try
            {
                var sql = "SELECT * FROM Usuario WHERE Id = @Id";
                var usuario = await _db.QueryAsync<Usuario>(sql, new { Id = id });
                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
