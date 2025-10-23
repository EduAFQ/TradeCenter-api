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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDbConnection _db;

        public UsuarioRepository(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<Usuario> Add(Usuario entity)
        {
            try
            {
                var rs = await _db.InsertAsync(entity);
                entity.UsuarioId = rs;
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                string sql = $"DELETE FROM Inscripciones WHERE Id={id}";
                await _db.ExecuteAsync(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
