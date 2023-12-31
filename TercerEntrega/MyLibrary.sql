--------------------CREACIÓN DE TABLAS Y BASE DE DATOS-------------------------------
drop table if exists borrows;
drop table if exists books;
drop table if exists editorials;
drop table if exists users;

create table users
(
    id INTEGER primary key,
    first_name TEXT not null,
    last_name TEXT not null
);

create table books
(
    id           INTEGER primary key,
    copies       INTEGER not null,
    title        TEXT    not null,
    author       TEXT    not null,
    editorial_id INTEGER not null
        references editorials (id),
    edition      INTEGER not null,
    year         INTEGER not null
);

create table borrows
(
    user_id INTEGER not null
        references users (id),
    book_id INTEGER not null
        references books (id),
    unique (user_id,book_id)
);

create table editorials
(
    id INTEGER primary key,
    editorial   TEXT not null unique
);
--------- CARGADO DE ARCHIVOS A LAS TABLAS----------------------------------
INSERT INTO users (id, first_name, last_name) VALUES (656219, 'Erika', 'Valdes');
INSERT INTO users (id, first_name, last_name) VALUES (843281, 'Guillermo', 'Farias');
INSERT INTO users (id, first_name, last_name) VALUES (696870, 'Miguel', 'Zapata');
INSERT INTO users (id, first_name, last_name) VALUES (921055, 'Ruben', 'Mendoza');
INSERT INTO users (id, first_name, last_name) VALUES (802580, 'Perla', 'Villanueva');
INSERT INTO users (id, first_name, last_name) VALUES (519508, 'Yanuario', 'Rivera');
INSERT INTO users (id, first_name, last_name) VALUES (904872, 'Salomon', 'Aleman');

INSERT INTO editorials (id, editorial) VALUES (0, 'Pearson');
INSERT INTO editorials (id, editorial) VALUES (1, 'McGrawHill');
INSERT INTO editorials (id, editorial) VALUES (2, 'Alfaomega');
INSERT INTO editorials (id, editorial) VALUES (3, 'Dextra');
INSERT INTO editorials (id, editorial) VALUES (4, 'Paraninfo');
INSERT INTO editorials (id, editorial) VALUES (5, 'Patria');

INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (1507952, 1, 'Dispositivos y circuitos electronicos', 'Donald Neamen', 1, 4, 2012);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (1509482, 2, 'Fundamentos de circuitos electricos', 'Charles K. Alexander', 1, 5,2013);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (2609674, 2, 'Principios de circuitos electricos', 'Thomas L. Floyd', 0, 8, 2007);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3226605, 2, 'Ingenieria de control moderna', 'Katsuhiko Ogata', 0, 5, 2010);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3233255, 4, 'Electronica de potencia', 'Muhammad Rashid', 0, 4, 2015);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3243957, 4, 'Electronica: teoria de circuitos', 'Robert Boylestad', 0, 11, 2018);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4383904, 5, 'Ecuaciones diferenciales', 'Ana Elizabeth Garcia', 5, 1, 2011);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4386141, 3, 'Calculo integral', 'Gustavo Guerrero Torres', 5, 1, 2013);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4386325, 3, 'Dinamica', 'Roberto Hernandez', 5, 1, 2013);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4391383, 1, 'Quimica', 'Gregory R. Choppin', 5, 1, 1981);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6223628, 4, 'Circuitos electricos', 'Richard C. Dorf', 2, 9, 2015);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6226889, 4, 'Maquinas electricas: tecnicas modernas de control', 'Pedro Ponce Cruz', 2, 2, 2017);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6277124, 1, 'Problemas de mecanismos', 'E. Bautista Paz', 3, 1, 2014);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7071907, 5, 'Robotica: control de robots manipuladores', 'Fernando Reyes Cortes', 2, 1, 2011);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7076032, 2, 'Mecatronica: sistemas de control electronico', 'W. Bolton', 2, 5, 2013);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7325639, 1, 'Problemas resueltos de control digital', 'Jose Gomez Campomanes', 4, 1, 2012);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (8334419, 2, 'Analisis de mecanismos planos', 'Enrique Sanmiguel Rojas', 4, 1, 2014);

INSERT INTO borrows (user_id, book_id) VALUES (843281, 3226605);
INSERT INTO borrows (user_id, book_id) VALUES (802580, 3233255);
INSERT INTO borrows (user_id, book_id) VALUES (904872, 3243957);
INSERT INTO borrows (user_id, book_id) VALUES (802580, 4383904);
INSERT INTO borrows (user_id, book_id) VALUES (843281, 6223628);
INSERT INTO borrows (user_id, book_id) VALUES (656219, 6277124);
INSERT INTO borrows (user_id, book_id) VALUES (843281, 7325639);
INSERT INTO borrows (user_id, book_id) VALUES (656219, 8334419);

-------------------------MENU USUARIOS----------------------------------

--MOSTRAR USUARIOS--

    --USUARIOS ORDENADOS POR NOMBRE--
    SELECT * FROM users
    ORDER BY first_name;

    --USUARIOS ORDENADOS POR APELLIDO--
    SELECT * FROM users
    ORDER BY last_name;

    --USUARIOS ORDENADOS POR ID--
    SELECT * FROM users
    ORDER BY id;

--AGREGAR USUARIO AL SISTEMA--
    INSERT INTO users (id, first_name, last_name) VALUES (123456,'NombrePrueba','ApellidoPrueba');

--ELIMINAR USUARIO--
    DELETE FROM users WHERE id =  904872; --id = int id;

        SELECT title FROM books
        INNER JOIN borrows b on books.id = b.book_id
        WHERE b.user_id = 904872
        ORDER BY title;
--------------------------------MENU PRESTAMOS-----------------------------

--PENDIENTES--

SELECT users.first_name || ',' || users.last_name AS full_name, books.title
FROM borrows
INNER JOIN books ON borrows.book_id = books.id
INNER JOIN users ON borrows.user_id = users.id
ORDER BY full_name;

--SOLICITAR--

    --Lista de usuarios ordenados por apellidos
SELECT id, first_name || ' ' || last_name AS full_name
FROM users
ORDER BY last_name;

    --LIsta de libros disponibles en la biblioteca
SELECT id, title
FROM books
ORDER BY title;


    --Copias en prestamo del libro seleccionado

SELECT id, title, count(id) AS num_copias_prestadas
FROM books
INNER JOIN borrows b on books.id = b.book_id
WHERE book_id = 6223628 --Numero variable
GROUP BY title, id;

    --Numero de copias del libro seleccionado
SELECT copies, title FROM books WHERE id = 6223628;

    --Crear préstamo
INSERT INTO borrows  (user_id, book_id) VALUES (1234, 5678); --Los valores son variables acorde a los elementos seleccionados anteriormente


--DEVOLVER--
    --- libros en préstamo
SELECT DISTINCT book_id, title AS libros_en_prestamo
FROM borrows
INNER JOIN books ON books.id= borrows.book_id
ORDER BY book_id;

    -- usuarios con el libro seleccionado anteriormente
SELECT first_name || ' ' || users.last_name AS full_name
FROM borrows
INNER JOIN users ON users.id = borrows.user_id
WHERE book_id = 6223628 -- Elemento variable según combobox
ORDER BY full_name;

    --Eliminar préstamo del usuario seleccionado
DELETE FROM borrows WHERE user_id= 1234 AND book_id = 5678;-- Los numeros son elementos variables según opciones anteriores


--------------------------------INVENTARIO----------------------------------

--Alta de libros --
    INSERT INTO books (id, copies, title, author, editorial_id, edition, year)
    VALUES (1234567, 0, 'Título', 'Autor', '-', '--', '----');

--Arribo de libros --
    UPDATE books SET copies = copies + 2 WHERE id = 1509482;
        SELECT id, copies, title||' - '||author AS info_libro FROM books
        WHERE id = 1509482;

--Eliminar libros --
    UPDATE books SET copies = copies - 2 WHERE id = 1509482;
        SELECT id, copies, title||' - '||author AS info_libro FROM books
        WHERE id = 1509482;

--Baja de libros --
    DELETE FROM books WHERE id = 8334419;

        SELECT users.first_name|| '-' || users.last_name AS En_prestamo_a,users.id FROM users
        INNER JOIN borrows b on users.id = b.user_id
        WHERE book_id = 8334419;

