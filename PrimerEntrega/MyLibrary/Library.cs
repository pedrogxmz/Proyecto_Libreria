using System;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace MyLibrary
{
    class Library
    {
        private List<Editorial> editorials;
        private List<Book> books;
        private List<User> users;
        private List<Borrow> borrows;

        public Library()
        {
            editorials = EasyFile<Editorial>.LoadDataFromFile("editorials.txt",
                    tokens => new Editorial(Convert.ToInt32(tokens[0]), tokens[1]));
            books = EasyFile<Book>.LoadDataFromFile("books.txt",
                    tokens => new Book(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), tokens[2], tokens[3], Convert.ToInt32(tokens[4]), Convert.ToInt32(tokens[5]), Convert.ToInt32(tokens[6])));
            users = EasyFile<User>.LoadDataFromFile("users.txt",
                    tokens => new User(Convert.ToInt32(tokens[0]), tokens[1], tokens[2]));
            borrows = EasyFile<Borrow>.LoadDataFromFile("borrows.txt",
                    tokens => new Borrow(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1])));
        }
        public List<User> UsuariosPorNombre()
        {
            List<User> usuarios = new List<User>(this.users);
            usuarios.Sort((u1, u2) => u1.FirstName.CompareTo(u2.FirstName));
            return usuarios;
        }
        public List<User> UsuariosPorAPellido()
        {
            List<User> usuarios = new List<User>(this.users);
            usuarios.Sort((u1, u2) => u1.LastName.CompareTo(u2.LastName));
            return usuarios;
        }
        public List<User> UsuariosPorId()
        {
            List<User> usuarios = new List<User>(this.users);
            usuarios.Sort((u1, u2) => u1.Id.CompareTo(u2.Id));
            return usuarios;
        }
        public bool ValidarId(int id) => users.Exists(u => u.Id == id);
        public void Agregar(int id, string nombre, string apellido)
        {
            users.Add(new User(id, nombre, apellido));
            EasyFile<User>.SaveDataToFile("users.txt",
                                            new[] { "Id", "FirstName", "LastName" },
                                            users);
        }
        public bool ValidarPrestamosPorUsuario(int usuarioId) => borrows.Exists(b => b.UserId == usuarioId);
        public List<LibrosPendientes> LibrosEnPrestamosPorUsuario(int usuarioId)
        {
            var pendientes = new List<LibrosPendientes>();

            borrows.FindAll(a => a.UserId == usuarioId).ForEach(a =>
                    pendientes.Add(new LibrosPendientes(
                        books.Find(b => b.Id == a.BookId))));
            return pendientes;
        }
        public void UsuarioEliminado(int usuarioId)
        {
            users.RemoveAll(u => u.Id == usuarioId);
            EasyFile<User>.SaveDataToFile("users.txt",
                                            new[] { "Id", "FirstName", "LastName" },
                                            users);
        }
        public bool ValidarIdLibro(int id) => books.Exists(u => u.Id == id);

        public bool ValidarPrestamosLibros(int LibroId) => borrows.Exists(b => b.BookId == LibroId);

        public void AgregarLibro(int id, int copias, string titulo, string autor, int editorialid, int edicion, int año)
        {
            books.Add(new Book(id, copias, titulo, autor, editorialid, edicion, año));
            EasyFile<Book>.SaveDataToFile("books.txt",
                                            new[] { "Id", "Copies", "Title", "Author", "EditorialId", "Edition", "Year" },
                                            books);
        }
        public List<Book> InfoLibros(int LibroId)
        {
            List<Book> libros = new List<Book>();
            return libros = books.FindAll(b => b.Id == LibroId);
        }
        public int AgregarCopias(int CopiasActuales, int CopiasNuevas)
        {
            int NewCopies = CopiasActuales + CopiasNuevas;
            return NewCopies;
        }
        public int EliminarCopias(int CopiasActuales, int CopiasNuevas)
        {
            int NewCopies = CopiasActuales - CopiasNuevas;
            return NewCopies;
        }
        public void ActualizarCopias(int Libroid, int NewCopies)
        {
            string titulo = books.Find(b => b.Id == Libroid).Title;
            string autor = books.Find(b => b.Id == Libroid).Author;
            int editorialid = books.Find(b => b.Id == Libroid).EditorialId;
            int edicion = books.Find(b => b.Id == Libroid).Edition;
            int año = books.Find(b => b.Id == Libroid).Year;
            books.Remove(books.Find(b => b.Id == Libroid));
            books.Add(new Book(Libroid, NewCopies, titulo, autor, editorialid, edicion, año));
            EasyFile<Book>.SaveDataToFile("books.txt",
                                          new[] { "Id", "Copies", "Title", "Author", "EditorialId", "Edition", "Year" },
                                          books);
        }
        public void BajaDeLibro(int LibroId)
        {
            books.RemoveAll(u => u.Id == LibroId);
            EasyFile<Book>.SaveDataToFile("books.txt",
                                            new[] { "Id", "Copies", "Title", "Author", "EditorialId", "Edition", "Year" },
                                            books);
        }
        public List<User> UsuariosConPrestamo() => new List<User>(this.users);
        public List<PrestamosPendientes> ObtenerPrestamosPendientes(int userid)
        {
            var pendings = new List<PrestamosPendientes>(userid);
            borrows.FindAll(b=> b.UserId == userid).ForEach(b =>
            pendings.Add(new PrestamosPendientes(
                users.Find(u => u.Id == b.UserId),
                books.Find(l => l.Id == b.BookId)
                )));
            return pendings;
        }
        public bool Disponibilidad(int book_id)
        {
            var mylist = new List<Borrow>();
            int copias = 0;
            bool bandera = false;

            mylist = borrows.FindAll(b => b.BookId == book_id);
            copias = books.Find(p => p.Id == book_id).Copies;
            if (mylist.ToArray().Length < copias == true)
            {
                bandera = true;
            }

            return bandera;
        }
        public void AgregarPrestamo(int UserId, int BookId)
        {
            borrows.Add(new Borrow(UserId, BookId));
            EasyFile<Borrow>.SaveDataToFile("borrows.txt",
                new[] { "UserId", "BookId" },
                borrows);
        }
        public List<PrestamosPendientes> PrestamosPorLibro( int bookid)
        {
            var pendientes = new List<PrestamosPendientes>();
            borrows.FindAll(b => b.BookId == bookid).ForEach(b =>
             pendientes.Add(new PrestamosPendientes(
                 users.Find(u => u.Id == b.UserId),
                 books.Find(l => l.Id == b.BookId)
                 )));
            return pendientes;
        }
        public string ImprimirLibro(int bookId)
        {
            string libro = books.Find(b => b.Id == bookId).Title;
            return libro;
        }
        public int ObtenerContador(int bookId)
        {
            var pendientes = new List<PrestamosPendientes>();
            borrows.FindAll(b => b.BookId == bookId).ForEach(b =>
             pendientes.Add(new PrestamosPendientes(
                 users.Find(u => u.Id == b.UserId),
                 books.Find(l => l.Id == b.BookId)
                 )));
            int contador = pendientes.FindAll(b => b.Book.Id == bookId).Count;
            return contador;
        }
        public void DevolverPrestamo(int UserId, int BookId)
        {
            borrows.RemoveAll(b => b.BookId == BookId && b.UserId == UserId);
            EasyFile<Borrow>.SaveDataToFile("borrows.txt",
                new[] { "UserId", "BookId" },
                borrows);
        }
    }
}
