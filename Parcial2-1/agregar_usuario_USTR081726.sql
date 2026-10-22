USE db_parcial2_1;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.usuarios_usis018804 WHERE usuario = 'USTR081726')
    INSERT INTO dbo.usuarios_usis018804 (usuario, clave, nombre, direccion, telefono)
    VALUES ('USTR081726', 'MejiaUGB2026*', 'José Mejía', NULL, NULL);
GO
