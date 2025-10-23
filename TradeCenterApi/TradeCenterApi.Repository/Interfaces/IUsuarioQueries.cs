using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCenterApi.Models;

namespace TradeCenterApi.Repository.Interfaces
{
    public interface IUsuarioQueries
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<IEnumerable<Usuario> GetUsuarioById(int UsuarioId);
    }
}
