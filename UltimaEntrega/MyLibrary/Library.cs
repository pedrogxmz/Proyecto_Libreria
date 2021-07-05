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
        public List<Usuarios> UsersById()
        {
            return conn.UsersById();
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

        public List<UsuariosConPrestamo> GetBorrowsByBook(int id)
        {
            return conn.GetBorrowsByBook(id);
        }

        public List<Books> GetAllBooks()
        {
            return conn.GetAllBooks();
        }

        public void ReturnBook(int user_id, int book_id)
        {
            conn.ReturnBook( user_id, book_id);
        }
        public bool ValidarBookId(int id)
            => conn.ValidarBookId(id);
        public bool ValidarCopias(int id, int copias)
            => conn.ValidarCopias(id, copias);
        public void EliminarCopias(int id, int copias)
            => conn.EliminarCopias(id, copias);
        public bool ValidarPrestamosPorBookId(int id)
            => conn.ValidarPrestamosPorBookId(id);
        public void BajaDeLibro(int id)
            => conn.BajaDeLibro(id);
        public void AltaDeLibro(int id, int copies, string title, string author, int editorial_id, int edition, int year)
            => conn.AltaDeLibro(id, copies, title, author, editorial_id, edition, year);
        public bool ValidarEditorialId(int editorial_id)
            => conn.ValidarEditorialId(editorial_id);
        public void AgregarCopias(int id, int copias)
            => conn.AgregarCopias(id, copias);
        public bool ValidarDisponibilidad (int id)
        {
            return conn.ValidarDisponibilidad(id);
        }

        public void PrestarLibro(int user_id, int book_id)
        {
             conn.PrestarLibro(user_id, book_id);
        }

        public bool ValidarPrestamo (int user_id, int book_id)
        {
            return conn.ValidarPrestamo(user_id, book_id);
        }
        public void Close() 
        {
            conn.Close();
        }
    }
}
