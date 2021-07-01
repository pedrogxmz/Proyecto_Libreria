using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;

namespace MyLibrary
{
    public class Library
    {
        private SQLiteConn conn;

        public Library() 
        {
            conn = new SQLiteConn("MyLibrary.db", true);
        }

        public List<Users> UsuariosPorNombre()
        {
            return conn.UsuariosPorNombre();
        }
        public List<Users> UsuariosPorApellido()
        {
            return conn.UsuariosPorApellido();
        }
        public List<Users> UsuariosPorId()
        {
            return conn.UsuariosPorId();
        }
        public void AgregarUsuario(int id, string firstname, string lastname) 
            => conn.AgregarUsuario(id, firstname , lastname);

        public bool ValidarId(int id)
            => conn.ValidarId(id);

        public void EliminarUsuario(int id)
            => conn.EliminarUsuario(id);

        public bool ValidarPrestamos(int id)
            => conn.ValidarPrestamos(id);
   
        public List<PrestamosPendientes> PrestamosPendientes(int id)
        {
            return conn.PrestamosPendientes(id);
        }

        public List<UsuariosConPrestamo> GetUsersWithBorrows()
        {
            return conn.GetUsersWithBorrows();
        }

        public List<PrestamosPendientes> GetBorrowedBooks()
        {
            return conn.GetBorrowedBooks();
        }
        public void Close() 
        {
            conn.Close();
        }
    }
}
