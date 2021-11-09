using Dal;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class UsuariosBll
    {
        private static readonly IDaoUsuario dao = FabricaDaos.ObtenerDaoUsuario(Tipos.Entity);
        public static Usuario Verificar(Usuario usuario)
        {
            Usuario aVerificar = dao.ObtenerPorEmail(usuario.Email);

            if (aVerificar != null && usuario.Password == aVerificar.Password)
            {
                return aVerificar;
            }

            return null;
        }
    }
}
