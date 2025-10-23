using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCenterApi.Models;

namespace TradeCenterApi.Repository.Interfaces
{
    public interface IResenaQueries
    {
        Task<IEnumerable<Resena>> GetResenasByUsuarioId(int UsuarioId);
    }
}
