using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Repository.Implements
{
    public class TcgQueries : ITcgQueries
    {
        private readonly IDbConnection _db;

        public TcgQueries(IDbConnection db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task<IEnumerable<Tcg>> GetAll()
        {
            try
            {
                var rs = await _db.QueryAsync<Tcg>("SELECT * FROM Estudiantes");
                return rs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Tcg>> GetTcgById(int TcgId)
        {
            try
            {
                string sql = $"SELECT FROM Tcg WHERE TcgId={TcgId}";
                return await _db.QueryAsync<Tcg>(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
