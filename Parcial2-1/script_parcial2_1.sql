IF DB_ID('db_parcial2_1') IS NULL
    CREATE DATABASE db_parcial2_1;
GO

USE db_parcial2_1;
GO

IF OBJECT_ID('dbo.dnotas', 'U') IS NOT NULL DROP TABLE dbo.dnotas;
IF OBJECT_ID('dbo.notas', 'U') IS NOT NULL DROP TABLE dbo.notas;
IF OBJECT_ID('dbo.periodos', 'U') IS NOT NULL DROP TABLE dbo.periodos;
IF OBJECT_ID('dbo.materias', 'U') IS NOT NULL DROP TABLE dbo.materias;
IF OBJECT_ID('dbo.alumnos', 'U') IS NOT NULL DROP TABLE dbo.alumnos;
IF OBJECT_ID('dbo.usuarios_usis018804', 'U') IS NOT NULL DROP TABLE dbo.usuarios_usis018804;
GO

CREATE TABLE dbo.usuarios_usis018804
(
    idUsuario  INT IDENTITY(1,1) NOT NULL,
    usuario    VARCHAR(35) NOT NULL,
    clave      VARCHAR(35) NOT NULL,
    nombre     VARCHAR(65) NOT NULL,
    direccion  VARCHAR(85) NULL,
    telefono   VARCHAR(9)  NULL,
    CONSTRAINT PK_usuarios_usis018804 PRIMARY KEY (idUsuario),
    CONSTRAINT UQ_usuarios_usis018804_usuario UNIQUE (usuario)
);
GO

CREATE TABLE dbo.alumnos
(
    idAlumno   INT IDENTITY(1,1) NOT NULL,
    codigo     VARCHAR(10) NOT NULL,
    nombre     VARCHAR(65) NOT NULL,
    direccion  VARCHAR(85) NULL,
    telefono   VARCHAR(9)  NULL,
    CONSTRAINT PK_alumnos PRIMARY KEY (idAlumno),
    CONSTRAINT UQ_alumnos_codigo UNIQUE (codigo)
);

CREATE TABLE dbo.materias
(
    idMateria  INT IDENTITY(1,1) NOT NULL,
    codigo     INT NOT NULL,
    nombre     VARCHAR(65) NOT NULL,
    uv         INT NOT NULL,
    CONSTRAINT PK_materias PRIMARY KEY (idMateria),
    CONSTRAINT UQ_materias_codigo UNIQUE (codigo)
);

CREATE TABLE dbo.periodos
(
    idPeriodo  INT IDENTITY(1,1) NOT NULL,
    periodo    VARCHAR(30) NOT NULL,
    fecha      DATE NOT NULL,
    CONSTRAINT PK_periodos PRIMARY KEY (idPeriodo)
);

CREATE TABLE dbo.notas
(
    idNota     INT IDENTITY(1,1) NOT NULL,
    idAlumno   INT NOT NULL,
    idPeriodo  INT NOT NULL,
    fecha      DATE NOT NULL,
    CONSTRAINT PK_notas PRIMARY KEY (idNota),
    CONSTRAINT FK_notas_alumnos  FOREIGN KEY (idAlumno)  REFERENCES dbo.alumnos (idAlumno) ON DELETE CASCADE,
    CONSTRAINT FK_notas_periodos FOREIGN KEY (idPeriodo) REFERENCES dbo.periodos (idPeriodo)
);

CREATE TABLE dbo.dnotas
(
    idDetalle  INT IDENTITY(1,1) NOT NULL,
    idNota     INT NOT NULL,
    idMateria  INT NOT NULL,
    lab1       DECIMAL(4,2) NOT NULL DEFAULT 0,
    lab2       DECIMAL(4,2) NOT NULL DEFAULT 0,
    parcial    DECIMAL(4,2) NOT NULL DEFAULT 0,
    CONSTRAINT PK_dnotas PRIMARY KEY (idDetalle),
    CONSTRAINT FK_dnotas_notas    FOREIGN KEY (idNota)    REFERENCES dbo.notas (idNota) ON DELETE CASCADE,
    CONSTRAINT FK_dnotas_materias FOREIGN KEY (idMateria) REFERENCES dbo.materias (idMateria) ON DELETE CASCADE
);
GO

INSERT INTO dbo.usuarios_usis018804 (usuario, clave, nombre, direccion, telefono) VALUES
('admin01',   'Admin2026', 'Administrador del Sistema', 'Barrio El Calvario, Usulután',   '2662-0101'),
('mlopez22',  'Lopez2026', 'María Fernanda López',      'Colonia Las Palmeras, Usulután', '7012-3456'),
('cmartinez', 'Carlos123', 'Carlos Ernesto Martínez',   'Santiago de María, Usulután',    '7845-1122'),
('USTR081726', 'MejiaUGB2026*', 'José Mejía', NULL, NULL);

INSERT INTO dbo.alumnos (codigo, nombre, direccion, telefono) VALUES
('AL2026001', 'José Manuel Rivas',        'Barrio La Merced, Usulután',  '7123-4501'),
('AL2026002', 'Daniela Beatriz Cruz',     'Colonia El Molino, Usulután', '7234-5612'),
('AL2026003', 'Kevin Alexander Portillo', 'Santa María, Usulután',       '7345-6723'),
('AL2026004', 'Gabriela Abigail Mejía',   'Ozatlán, Usulután',           '7456-7834'),
('AL2026005', 'Luis Fernando Argueta',    'Jiquilisco, Usulután',        '7567-8945');

INSERT INTO dbo.materias (codigo, nombre, uv) VALUES
(101, 'Programación Computacional I', 4),
(102, 'Matemática I',                 4),
(103, 'Lógica Computacional',         3),
(104, 'Inglés Técnico I',             3);

INSERT INTO dbo.periodos (periodo, fecha) VALUES
('Ciclo I-2026',  '2026-01-19'),
('Ciclo II-2026', '2026-07-13');

INSERT INTO dbo.notas (idAlumno, idPeriodo, fecha)
SELECT a.idAlumno, p.idPeriodo, p.fecha
FROM dbo.alumnos a CROSS JOIN dbo.periodos p;

INSERT INTO dbo.dnotas (idNota, idMateria, lab1, lab2, parcial)
SELECT n.idNota, m.idMateria,
       5 + ((n.idNota * 3 + m.idMateria * 7)  % 50) / 10.0,
       5 + ((n.idNota * 7 + m.idMateria * 3)  % 50) / 10.0,
       5 + ((n.idNota * 11 + m.idMateria * 5) % 50) / 10.0
FROM dbo.notas n CROSS JOIN dbo.materias m;
GO

SELECT 'usuarios' AS tabla, COUNT(*) AS filas FROM dbo.usuarios_usis018804
UNION ALL SELECT 'alumnos',  COUNT(*) FROM dbo.alumnos
UNION ALL SELECT 'materias', COUNT(*) FROM dbo.materias
UNION ALL SELECT 'periodos', COUNT(*) FROM dbo.periodos
UNION ALL SELECT 'notas',    COUNT(*) FROM dbo.notas
UNION ALL SELECT 'dnotas',   COUNT(*) FROM dbo.dnotas;
GO
