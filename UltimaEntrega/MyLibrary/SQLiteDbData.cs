using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class Users
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }


        public Users(int id, string firstname, string lastname)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;

        }
    }
    public class PrestamosPendientes
    {
        public int Book_Id { get; }
        public string Title { get; }

        public PrestamosPendientes(int id, string title)
        {
            this.Book_Id = id;
            this.Title = title;
        }
    }

    public class UsuariosConPrestamo
    {
        public int User_Id { get; }
        public string Full_Name { get; }

        public UsuariosConPrestamo(int user_Id, string full_Name)
        {
            User_Id = user_Id;
            Full_Name = full_Name;
        }
    }

    public class Book
    {
        public int Id { get; }
        public int Copies { get; }
        public string Title { get; }
        public string Author { get; }
        public int EditorialId { get; }
        public int Edition { get; }
        public int Year { get; }

        public Book(int id, int copies, string title, string author, int editorialId, int edition, int year)
        {
            Id = id;
            Copies = copies;
            Title = title;
            Author = author;
            EditorialId = editorialId;
            Edition = edition;
            Year = year;
        }
    }
    public class BookCopies
    {
        public int Copies { get; }

        public BookCopies(int copies)
        {
            Copies = copies;
        }
    }
    public class BorrowsCopies
    {
        public int Copies { get; }

        public BorrowsCopies(int copies)
        {
            Copies = copies;
        }
    }




    public partial class SQLiteConn
    {
        public List<Users> UsuariosPorNombre()
        {
            List<Users> usuarios = new List<Users>();

            string sql = "SELECT id, first_name, last_name FROM users"
                        + " ORDER BY first_name";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Users(rs.GetInt32("id"),
                                           rs.GetString("first_name"),
                                           rs.GetString("last_name")));
                }
            }
            return usuarios;
        }
        public List<Users> UsuariosPorApellido()
        {
            List<Users> usuarios = new List<Users>();

            string sql = "SELECT id, first_name, last_name FROM users"
                       + " ORDER BY last_name";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Users(rs.GetInt32("id"),
                                           rs.GetString("first_name"),
                                           rs.GetString("last_name")));
                }
            }
            return usuarios;
        }
        public List<Users> UsuariosPorId()
        {
            List<Users> usuarios = new List<Users>();

            string sql = "SELECT id, first_name, last_name FROM users"
                      + " ORDER BY id";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Users(rs.GetInt32("id"),
                                           rs.GetString("first_name"),
                                           rs.GetString("last_name")));
                }
            }
            return usuarios;
        }
        public bool ValidarId(int id)
        {
            string sql = $"SELECT * FROM users WHERE id = {id}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return rs.NextRecord();
            }
        }
        public void AgregarUsuario(int id, string firstname, string lastname)
        {
            string sql = "INSERT INTO users (id, first_name, last_name)"
                        + $" VALUES ('{id}', '{firstname}', '{lastname}')";
            ExecuteNonQuery(sql);
        }
        public bool ValidarPrestamos(int id)
        {
            string sql = $"SELECT * FROM borrows WHERE user_id = {id}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return rs.NextRecord();
            }
        }
        public void EliminarUsuario(int id)
        {
            string sql = $"DELETE FROM users WHERE id = {id}";
            ExecuteNonQuery(sql);
        }
        public List<PrestamosPendientes> PrestamosPendientes(int id)
        {
            List<PrestamosPendientes> prestamos = new List<PrestamosPendientes>();
            string sql = "SELECT book_id, title FROM books"
                        + " INNER JOIN borrows b on books.id = b.book_id"
                        + $" WHERE b.user_id = {id}"
                        + " ORDER BY title";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    prestamos.Add(new PrestamosPendientes(rs.GetInt32("book_id"),
                                                          rs.GetString("title")));
                }
            }
            return prestamos;
        }
        public List<UsuariosConPrestamo> GetUsersWithBorrows()
        {
            List<UsuariosConPrestamo> users = new List<UsuariosConPrestamo>();
            string sql = "  SELECT DISTINCT  user_id AS user_id, first_name || ' ' || last_name AS full_name FROM  borrows"
                            + " INNER JOIN users u on borrows.user_id = u.id"
                            + " ORDER BY user_id; ";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    users.Add(new UsuariosConPrestamo(rs.GetInt32("user_id"),
                                         rs.GetString("full_name")));
                }
            }

            return users;
        }

        public List<PrestamosPendientes> GetBorrowedBooks()
        {
            List<PrestamosPendientes> prestamos = new List<PrestamosPendientes>();
            string sql = "SELECT DISTINCT book_id, title FROM books"
                        + " INNER JOIN borrows b on books.id = b.book_id"
                        + " ORDER BY title";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    prestamos.Add(new PrestamosPendientes(rs.GetInt32("book_id"),
                                                          rs.GetString("title")));
                }
            }
            return prestamos;
        }
        public void AltaDeLibro(int id, int copies, string title, string author, int editorial_id, int edition, int year)
        {
            string sql = "INSERT INTO books (id, copies, title, author, editorial_id, edition, year)"
                    + $" VALUES ('{id}','{0}','{title}','{author}','{editorial_id }','{edition}','{year}')";
            ExecuteNonQuery(sql);
        }
        public bool ValidarBookId(int id)
        {
            string sql = $"SELECT * FROM books WHERE id = {id}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return rs.NextRecord();
            }
        }
        public bool ValidarEditorialId(int editorial_id)
        {
            string sql = $"SELECT * FROM books WHERE editorial_id = {editorial_id}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return rs.NextRecord();
            }
        }
        public bool ValidarCopias(int id, int Copias)
        {
            var CopiasEnInventario = new List<BookCopies>();
            var CopiasEnPrestamo = new List<BorrowsCopies>();

            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT copies FROM books WHERE id = {id}"))
            {
                while (rs.NextRecord())
                {
                    CopiasEnInventario.Add(new BookCopies(rs.GetInt32("copies")));
                }
            }
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT user_id FROM borrows WHERE book_id = {id}"))
            {
                while (rs.NextRecord())
                {
                    CopiasEnPrestamo.Add(new BorrowsCopies(rs.GetInt32("user_id")));
                }
            }
            int copiasdisponibles = CopiasEnInventario[0].Copies - CopiasEnPrestamo.Count;
            if (copiasdisponibles == Copias || copiasdisponibles > Copias)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void EliminarCopias(int id, int copias)
        {
            var CopiasEnInventario = new List<BookCopies>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT copies FROM books WHERE id = {id}"))
            {
                while (rs.NextRecord())
                {
                    CopiasEnInventario.Add(new BookCopies(rs.GetInt32("copies")));
                }
            }
            int NuevasCopias = CopiasEnInventario[0].Copies - copias;

            string sql = $"UPDATE books SET copies = {NuevasCopias} WHERE id = {id}";
            ExecuteNonQuery(sql);
        }
        public bool ValidarPrestamosPorBookId(int id)
        {
            string sql = $"SELECT * FROM borrows WHERE book_id = {id}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return rs.NextRecord();
            }
        } 
        public void BajaDeLibro(int id)
        {
            string sql = $"DELETE FROM books WHERE id = {id}";
            ExecuteNonQuery(sql);
        }
    }
}
