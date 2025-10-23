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
    public class IntercambioRepository : IIntercambioRepository
    {
        private readonly IDbConnection _db;

        public IntercambioRepository(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<Intercambio> Add(Intercambio entity)
        {
            try
            {
                var rs = await _db.InsertAsync(entity);
                entity.IntercambioId = rs;
                return entity;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public async Task<Intercambio> Update(Intercambio entity)
        {
            try
            {
                var actualizado = await _db.UpdateAsync(entity);

                if (!actualizado)
                    throw new Exception("No se pudo actualizar el intercambio.");

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el intercambio: {ex.Message}", ex);
            }
        }
    }
}
