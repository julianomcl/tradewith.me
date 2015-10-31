CREATE OR REPLACE Usuario_Insert(	pid_usuario INTEGER,
	pnome IN VARCHAR(60),
	psenha IN CHAR(6),
	pdata_nascimento IN DATE,
	pemail IN VARCHAR(60),
	pfoto IN VARCHAR2(250),
	pfacebook IN VARCHAR2(250)) AS
BEGIN

INSERT INTO usuario(id_usuario, nome, senha, data_nascimento, email, foto, facebook)
VALUES(pid_usuario, pnome, psenha, pdata_nascimento, pemail, pfoto, pfacebook)

END Usuario_Insert;