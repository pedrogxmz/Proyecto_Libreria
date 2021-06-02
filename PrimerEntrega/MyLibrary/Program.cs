using System;
using System.Collections.Generic;
using static System.Console;

namespace MyLibrary
{
    class Program
    {
        static Library library;
        static void Main(string[] args)
        {
            library = new Library();
            int op = -1;
            do
            {
                Clear();
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("                                        LIBRERIA                                            ");
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("\n\t1)Usuarios");
                WriteLine("\n\t2)Prestamos");
                WriteLine("\n\t3)Inventario");
                WriteLine("\n\t0)Salir");
                WriteLine("\n\tElige una opción: ");
                op = Convert.ToInt32(ReadLine());
                switch (op)
                {
                    case 1:
                        SubMenuUsuarios();
                        break;
                    case 2:
                        SubMenuPrestamos();
                        break;
                    case 3:
                        SubMenuInventario();
                        break;
                    case 0:
                        WriteLine("\n\t¡Hasta la proxima!");
                        break;
                    default:
                        WriteLine("\n\t¡Opción no valida!");
                        ReadKey(true);
                        break;
                }
            } while (op != 0);
        }
        static void SubMenuUsuarios()
        {
            int op = -1;
            do
            {
                Clear();
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("                                        USUARIOS                                            ");
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("\n\t1)Mostrar");
                WriteLine("\n\t2)Agregar");
                WriteLine("\n\t3)Eliminar");
                WriteLine("\n\t0)Volver");
                WriteLine("\n\tElige una opción: ");
                op = Convert.ToInt32(ReadLine());
                switch (op)
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        AgregarUsuarios();
                        break;
                    case 3:
                        EliminarUsuarios();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("¡Opción no valida!");
                        ReadKey(true);
                        break;
                }
            } while (op != 0);
        }
        static void MostrarUsuarios()
        {
            int op = -1;
            do
            {
                Clear();
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("                                MOSTRAR USUARIOS                                            ");
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("\n\t1)Ordenados por nombre");
                WriteLine("\n\t2)Ordenados por apellido");
                WriteLine("\n\t3)Ordenar por Id");
                WriteLine("\n\t0)Volver");
                WriteLine("\n\tElige una opción: ");
                op = Convert.ToInt32(ReadLine());
                switch (op)
                {
                    case 1:
                        OrdenadosPorNombre();
                        break;
                    case 2:
                        OrdenadosPorApellido();
                        break;
                    case 3:
                        OrdenadosPorId();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("¡Opción no valida!");
                        ReadKey(true);
                        break;
                }
            } while (op != 0);
        }
        static void OrdenadosPorNombre()
        {
            Clear();
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                  USUARIOS ORDENADOS POR NOMBRE                          ");
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();
            library.UsuariosPorNombre().ForEach(u =>
            {
                WriteLine($"{u.Id} - {u.FirstName} {u.LastName}");
            });
            WriteLine();
            ReadKey(true);
        }
        static void OrdenadosPorApellido()
        {
            Clear();
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                  USUARIOS ORDENADOS POR APELLIDO                        ");
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();
            library.UsuariosPorAPellido().ForEach(u =>
            {
                WriteLine($"{u.Id} - {u.FirstName} {u.LastName}");
            });
            WriteLine();
            ReadKey(true);
        }
        static void OrdenadosPorId()
        {
            Clear();
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                  USUARIOS ORDENADOS POR ID                              ");
            WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();
            library.UsuariosPorId().ForEach(u =>
            {
                WriteLine($"{u.Id} - {u.FirstName} {u.LastName}");
            });
            WriteLine();
            ReadKey(true);
        }
        static void AgregarUsuarios()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                           AGREGAR USUARIOS                                       ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();
            int id;
            do
            {
                Random num = new Random();
                id = num.Next(99999, 1000000);
            } while (library.ValidarId(id));

            WriteLine("\nIngrese el primer nombre del usuario: ");
            string nombre = ReadLine();
            WriteLine("\nIngrese el primer apellido del usuario: ");
            string apellido = ReadLine();
            library.Agregar(id, nombre, apellido);
            WriteLine($"\nEl usuario {nombre} {apellido} ha sido añadido y se le ha asignado {id} como ID.");
            ReadKey(true);
        }
        static void EliminarUsuarios()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                           ELIMINAR USUARIOS                                      ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("\nIngrese el ID del usuario que desea eliminar: ");
            int usuarioId = Convert.ToInt32(ReadLine());
            if (library.ValidarId(usuarioId))
            {
                if (library.ValidarPrestamosPorUsuario(usuarioId))
                {
                    WriteLine($"\nEl usuario con ID {usuarioId} tiene los siguientes libros en prestamo: ");
                    WriteLine();
                    var titulos = library.LibrosEnPrestamosPorUsuario(usuarioId);
                    for (int i = 0; i < titulos.Count; i++)
                    {
                        WriteLine($"{titulos[i].Book.Id} - {titulos[i].Book.Title}");
                    }
                    ReadKey(true);
                }
                else
                {
                    library.UsuarioEliminado(usuarioId);
                    WriteLine("El usuario ha sido eliminado.");
                    ReadKey(true);
                }
            }
            else
            {
                WriteLine($"\n\t¡El usuario con ID: {usuarioId} no está registrado.!");
                ReadKey(true);
            }
        }
        static void SubMenuInventario()
        {
            int op = -1;
            do
            {
                Clear();
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("                                  SUBMENU INVENTARIO                                        ");
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("\n\t1)Alta de Libros");
                WriteLine("\n\t2)Arribo de libros al inventario");
                WriteLine("\n\t3)Eliminar libros del inventario");
                WriteLine("\n\t4)Baja de libros");
                WriteLine("\n\t0)Volver");
                WriteLine("\n\tElige una opción: ");
                op = Convert.ToInt32(ReadLine());
                switch (op)
                {
                    case 1:
                        AltaDeLibros();
                        break;
                    case 2:
                        ArriboDeLibros();
                        break;
                    case 3:
                        EliminarLibros();
                        break;
                    case 4:
                        BajaDeLibros();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("¡Opción no valida!");
                        ReadKey(true);
                        break;
                }

            } while (op != 0);
        }
        static void AltaDeLibros()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                            ALTA DE LIBROS                                        ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();
            int id;
            do
            {
                Random num = new Random();
                id = num.Next(1000000, 9999999);
            } while (library.ValidarIdLibro(id));

            WriteLine("\nIngrese el nombre del libro: ");
            string titulo = ReadLine();
            int copias = 0;
            WriteLine("\nIngrese el nombre del autor: ");
            string autor = ReadLine();
            WriteLine("\nIngrese el número de editorial: ");
            string numeditorialid = ReadLine();
            int editorialid = Convert.ToInt32(numeditorialid);
            WriteLine("\nIngrese el número de edición: ");
            string numedicion = ReadLine();
            int edicion = Convert.ToInt32(numedicion);
            WriteLine("\nIngrese el año: ");
            string anopublicacion = ReadLine();
            int ano = Convert.ToInt32(anopublicacion);

            library.AgregarLibro(id, copias, titulo, autor, editorialid, edicion, ano);
            WriteLine($"\nEl libro {titulo} del autor {autor} ha sido añadido y se le ha asignado {id} como ID.");
            ReadKey(true);
        }
        static void ArriboDeLibros()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                           ARRIBO DE LIBROS                                       ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();

            Write("Clave del libro: ");
            int LibroId = Convert.ToInt32(ReadLine());

            if (library.ValidarIdLibro(LibroId))
            {
                List<Book> libro = library.InfoLibros(LibroId);
                foreach (var item in libro)
                {
                    WriteLine($"\n{item.Title}");
                    WriteLine();
                    WriteLine("\n¿Desea agregar nuevas unidades? [s/n]: ");
                    if (ReadLine().Trim().ToUpper()[0] == 'S')
                    {
                        WriteLine("\nInserte el numero de copias que desea agregar: ");
                        int CopiasNuevas = Convert.ToInt32(ReadLine());
                        int CopiasActuales = item.Copies;
                        int NewCopies = library.AgregarCopias(CopiasActuales, CopiasNuevas);
                        library.ActualizarCopias(LibroId, NewCopies);
                        WriteLine("\n¡El arribo se ha realizado con exito!");
                        WriteLine($"Ahora hay {NewCopies} unidades del libro.");
                        ReadKey(true);
                    }
                    else
                    {
                        WriteLine("\n¡La actualización del arribo ha sido cancelada");
                    }
                }
            }
            else
            {
                WriteLine("\n¡La clave del libro es incorrecta!");
            }
            WriteLine();
            ReadKey(true);
        }
        static void EliminarLibros()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                           ELIMINAR LIBROS                                        ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();

            Write("Clave del libro: ");
            int LibroId = Convert.ToInt32(ReadLine());

            if (library.ValidarIdLibro(LibroId))
            {
                List<Book> libro = library.InfoLibros(LibroId);
                foreach (var item in libro)
                {
                    WriteLine($"\n{item.Title}");
                    WriteLine();
                    WriteLine("\n¿Desea eliminar unidades del libro? [s/n]: ");
                    if (ReadLine().Trim().ToUpper()[0] == 'S')
                    {
                        if (!library.ValidarPrestamosLibros(LibroId))
                        {
                            WriteLine("\nInserte el numero de copias que desea eliminar: ");
                            int CopiasNuevas = Convert.ToInt32(ReadLine());
                            int CopiasActuales = item.Copies;
                            var NewCopies = library.EliminarCopias(CopiasActuales, CopiasNuevas);
                            library.ActualizarCopias(LibroId, NewCopies);
                            WriteLine("\n¡La operación se ha realizado con exito!");
                            WriteLine($"Ahora hay {NewCopies} unidades del libro.");
                            ReadKey(true);
                        }
                        else
                        {
                            WriteLine("\n¡El libro no se puede dar de baja porque se encuentra en prestamo!");
                        }
                    }
                    else
                    {
                        WriteLine("\n¡La operación ha sido cancelada");
                    }
                }
            }
            else
            {
                WriteLine("\n¡La clave del libro es incorrecta!");
            }
            WriteLine();
            ReadKey(true);
        }
        static void BajaDeLibros()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                           BAJA DE LIBROS                                         ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine();

            Write("Clave del libro: ");
            int LibroId = Convert.ToInt32(ReadLine());

            if (library.ValidarIdLibro(LibroId))
            {
                List<Book> libro = library.InfoLibros(LibroId);
                foreach (var item in libro)
                {
                    WriteLine($"\n{item.Title}");
                    WriteLine();
                    WriteLine("\n¿Desea dar de baja el libro del inventario? [s/n]: ");
                    if (ReadLine().Trim().ToUpper()[0] == 'S')
                    {
                        if (!library.ValidarPrestamosLibros(LibroId))
                        {
                            library.BajaDeLibro(LibroId);
                            WriteLine("\n¡BAJA EXITOSA!");
                        }
                        else
                        {
                            WriteLine("\n¡El libro no se puede dar de baja porque se encuentra en prestamo!");
                        }
                    }
                    else
                    {
                        WriteLine("\n¡BAJA CANCELADA!");
                    }
                }
            }
            else
            {
                WriteLine("\n¡La clave del libro es incorrecta!");
            }
            WriteLine();
            ReadKey(true);
        }
        static void SubMenuPrestamos()
        {
            int op = -1;
            do
            {
                Clear();
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("                                        PRESTAMOS                                           ");
                WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                WriteLine("\n\t1)Pendientes");
                WriteLine("\n\t2)Solicitar");
                WriteLine("\n\t3)Devolver");
                WriteLine("\n\t0)Volver");
                WriteLine("\n\tElige una opción: ");

                op = Convert.ToInt32(ReadLine());
                switch (op)
                {
                    case 1:
                        PrestamosPendientes();
                        break;
                    case 2:
                        SolicitarPrestamos();
                        break;
                    case 3:
                        DevolverPrestamos();
                        break;
                    case 0:
                        break;
                    default:
                        WriteLine("¡Opción no valida!");
                        ReadKey(true);
                        break;
                }

            } while (op != 0);
        }
        static void PrestamosPendientes()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                        PRÉSTAMOS PENDIENTES                                      ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            var usuarios = library.UsuariosConPrestamo();
            for (int i = 0; i<usuarios.Count; i++)
            {
                WriteLine($" {usuarios[i].Id} {usuarios[i].FirstName} {usuarios[i].LastName}");
                WriteLine();
                library.ObtenerPrestamosPendientes(usuarios[i].Id)
                    .ForEach(b =>WriteLine($"+ {b.Book.Title}"));
                WriteLine();
                WriteLine();
            }
            ReadKey(true);
        }
        static void SolicitarPrestamos()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                        SOLICITAR PRÉSTAMO                                        ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            WriteLine("Clave de usuario: ");
            int UserId = Convert.ToInt32(ReadLine());
            if (library.ValidarId(UserId))
            {
                WriteLine("Ingrese el id del libro a prestar: ");
                int bookId = Convert.ToInt32(ReadLine());
                if (library.ValidarIdLibro(bookId) == true)
                {
                    if (library.Disponibilidad(bookId) == true)
                    {
                        library.AgregarPrestamo(UserId, bookId);
                        WriteLine("El prestamo se ha añadido con éxito");
                    }
                    else
                    {
                        WriteLine("El libro solicitado no está disponible para préstamo");
                    }
                }
                else
                {
                    WriteLine("El libro ingresado no existe");
                }
            }
            else
            {
                WriteLine("El usuario no existe");
            }
            WriteLine();
            ReadKey();
        }
        static void DevolverPrestamos()
        {
            Clear();
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("                                       DEVOLVER PRÉSTAMO                                          ");
            WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            WriteLine("Ingrese el id del libro a devolver: ");
            int bookId = Convert.ToInt32(ReadLine());
            if (library.ValidarPrestamosLibros(bookId))
            {
                List<PrestamosPendientes> pendientes = library.PrestamosPorLibro(bookId);
                string libro = library.ImprimirLibro(bookId);
                WriteLine($"{ libro}");
                int contador = library.ObtenerContador(bookId);
                for (int i = 0; i < contador; i++)
                {
                    WriteLine($"{i} {pendientes[i].User.FirstName} {pendientes[i].User.LastName}");
                }
                WriteLine("Ingrese el numero de usuario que devolverá el libro: ");
                int opcion = Convert.ToInt32(ReadLine());
                library.DevolverPrestamo(pendientes[opcion].User.Id, bookId);
                WriteLine("El libro ha sido devuelto con éxito");
                WriteLine();
                ReadKey(true);
            }
            else
            {
                WriteLine("El libro ingresado no existe o no tiene préstamos realizados");
                ReadKey(true);
            }
        }
    }
}