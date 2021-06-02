--CODIGO PARA CREAR LAS TABLAS--

create table users
(
    id INTEGER primary key,
    first_name TEXT not null,
    last_name TEXT not null
);


--CODIGO PARA AGREGAR VALORES A LAS TABLAS--

INSERT INTO users (id, first_name, last_name) VALUES (656219, 'Erika', 'Valdes');
INSERT INTO users (id, first_name, last_name) VALUES (843281, 'Guillermo', 'Farias');
INSERT INTO users (id, first_name, last_name) VALUES (696870, 'Miguel', 'Zapata');
INSERT INTO users (id, first_name, last_name) VALUES (921055, 'Ruben', 'Mendoza');
INSERT INTO users (id, first_name, last_name) VALUES (802580, 'Perla', 'Villanueva');
INSERT INTO users (id, first_name, last_name) VALUES (519508, 'Yanuario', 'Rivera');
INSERT INTO users (id, first_name, last_name) VALUES (904872, 'Salomon', 'Aleman');