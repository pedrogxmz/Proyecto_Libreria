--CODIGO PARA CREAR LAS TABLAS--

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
    editorial_id INTEGER not null,
    edition      INTEGER not null,
    year         INTEGER not null
);

--CODIGO PARA AGREGAR VALORES A LAS TABLAS--

INSERT INTO users (id, first_name, last_name) VALUES (656219, 'Erika', 'Valdes');
INSERT INTO users (id, first_name, last_name) VALUES (843281, 'Guillermo', 'Farias');
INSERT INTO users (id, first_name, last_name) VALUES (696870, 'Miguel', 'Zapata');
INSERT INTO users (id, first_name, last_name) VALUES (921055, 'Ruben', 'Mendoza');
INSERT INTO users (id, first_name, last_name) VALUES (802580, 'Perla', 'Villanueva');
INSERT INTO users (id, first_name, last_name) VALUES (519508, 'Yanuario', 'Rivera');
INSERT INTO users (id, first_name, last_name) VALUES (904872, 'Salomon', 'Aleman');

INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (1507952, 1, 'Dispositivos y circuitos electronicos', 'Donald Neamen', 1, 2012, 4);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (1509482, 2, 'Fundamentos de circuitos electricos', 'Charles K. Alexander', 1, 2013, 5);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (2609674, 2, 'Principios de circuitos electricos', 'Thomas L. Floyd', 0, 2007, 8);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (2727464, 5, 'Programacion en C++', 'Edson Estrada', 1234, 2019, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3226605, 2, 'Ingenieria de control moderna', 'Katsuhiko Ogata', 0, 2010, 5);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3233255, 4, 'Electronica de potencia', 'Muhammad Rashid', 0, 2015, 4);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (3243957, 4, 'Electronica: teoria de circuitos', 'Robert Boylestad', 0, 2018, 11);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4383904, 5, 'Ecuaciones diferenciales', 'Ana Elizabeth Garcia', 5, 2011, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4386141, 3, 'Calculo integral', 'Gustavo Guerrero Torres', 5, 2013, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4386325, 3, 'Dinamica', 'Roberto Hernandez', 5, 2013, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (4391383, 1, 'Quimica', 'Gregory R. Choppin', 5, 1981, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6223628, 4, 'Circuitos electricos', 'Richard C. Dorf', 2, 2015, 9);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6226889, 4, 'Maquinas electricas: tecnicas modernas de control', 'Pedro Ponce Cruz', 2, 2017, 2);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (6277124, 1, 'Problemas de mecanismos', 'E. Bautista Paz', 3, 2014, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7071907, 5, 'Robotica: control de robots manipuladores', 'Fernando Reyes Cortes', 2, 2011, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7076032, 2, 'Mecatronica: sistemas de control electronico', 'W. Bolton', 2, 2013, 5);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (7325639, 1, 'Problemas resueltos de control digital', 'Jose Gomez Campomanes', 4, 2012, 1);
INSERT INTO books (id, copies, title, author, editorial_id, edition, year) VALUES (8334419, 2, 'Analisis de mecanismos planos', 'Enrique Sanmiguel Rojas', 4, 2014, 1);