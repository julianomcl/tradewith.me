CREATE OR REPLACE Usuario_Delete(	pid_usuario INTEGER) AS
BEGIN

DELETE FROM usuario
WHERE id_usuario = pid_usuario

END Usuario_Insert;