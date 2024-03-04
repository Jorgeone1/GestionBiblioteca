create database biblioteca;
use biblioteca;
CREATE TABLE libros (
    id INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(100),
    autor VARCHAR(100),
    genero VARCHAR(50),
    anio_publicacion INT,
    editorial VARCHAR(100),
    isbn VARCHAR(20)
);

INSERT INTO libros (titulo, autor, genero, anio_publicacion, editorial, isbn)
VALUES
('Cien años de soledad', 'Gabriel García Márquez', 'Realismo mágico', 1967, 'Editorial Sudamericana', '978-84-663-1712-9'),
('1984', 'George Orwell', 'Distopía', 1949, 'Secker & Warburg', '978-0451524935'),
('El señor de los anillos', 'J.R.R. Tolkien', 'Fantasía', 1954, 'Allen & Unwin', '978-0261103252'),
('Orgullo y prejuicio', 'Jane Austen', 'Romance', 1813, 'T. Egerton, Whitehall', '978-1613820925'),
('Harry Potter y la piedra filosofal', 'J.K. Rowling', 'Fantasía', 1997, 'Bloomsbury Publishing', '978-0747532699'),
('Moby Dick', 'Herman Melville', 'Aventura', 1851, 'Richard Bentley', '978-1979623860'),
('La sombra del viento', 'Carlos Ruiz Zafón', 'Misterio', 2001, 'Planeta', '978-8408036809'),
('El nombre del viento', 'Patrick Rothfuss', 'Fantasía', 2007, 'DAW Books', '978-8416031026'),
('Las Crónicas de Narnia', 'C.S. Lewis', 'Fantasía', 1950, 'Geoffrey Bles', '978-0007117307'),
('Crónica del pájaro que da cuerda al mundo', 'Haruki Murakami', 'Realismo mágico', 1995, 'Shinchosha', '978-0099540879');

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dni VARCHAR(20),
    contrasena_hash VARCHAR(64), 
    salt VARCHAR(32),
    email VARCHAR(100),
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    fecha_nacimiento DATE
);

INSERT INTO usuarios (dni, contrasena_hash, salt, email, nombre, apellido, fecha_nacimiento)
VALUES
('12345678A', SHA2(CONCAT('password1', UUID()), 256), UUID(), 'usuario1@example.com', 'Juan', 'Martínez', '1990-05-15'),
('98765432B', SHA2(CONCAT('password2', UUID()), 256), UUID(), 'usuario2@example.com', 'María', 'González', '1985-09-20'),
('56789012C', SHA2(CONCAT('password3', UUID()), 256), UUID(), 'usuario3@example.com', 'Luis', 'Rodríguez', '1993-11-25'),
('34567890D', SHA2(CONCAT('password4', UUID()), 256), UUID(), 'usuario4@example.com', 'Ana', 'Fernández', '1988-03-10'),
('90123456E', SHA2(CONCAT('password5', UUID()), 256), UUID(), 'usuario5@example.com', 'Elena', 'López', '1977-07-05');
