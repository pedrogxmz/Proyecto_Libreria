
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