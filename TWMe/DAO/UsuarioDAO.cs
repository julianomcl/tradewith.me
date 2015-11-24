using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using TWMe.Models;

namespace TWMe.DAO
{
    public class UsuarioDAO
    {
        public List<Usuario> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_USUARIO, NOME, SENHA, DATA_NASCIMENTO, EMAIL, FOTO, FACEBOOK FROM USUARIO", conn))
                {

                    List<Usuario> lista = new List<Usuario>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario u = new Usuario();
                        u.Id_Usuario = Convert.ToInt32(reader["ID_USUARIO"]);
                        u.Nome = Convert.ToString(reader["NOME"]);
                        u.Senha = Convert.ToString(reader["SENHA"]);
                        u.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                        u.Email = Convert.ToString(reader["EMAIL"]);
                        u.Foto = Convert.ToString(reader["FOTO"]);
                        u.Facebook = Convert.ToString(reader["FACEBOOK"]);
                        lista.Add(u);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Usuario u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("USUARIO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros          
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_NOME", u.Nome);
                    cmd.Parameters.Add("p_SENHA", u.Senha);
                    cmd.Parameters.Add("p_DATA_NASCIMENTO", u.DataNascimento);
                    cmd.Parameters.Add("p_EMAIL", u.Email);
                    cmd.Parameters.Add("p_FOTO", u.Foto);
                    cmd.Parameters.Add("p_FACEBOOK", u.Facebook);

                    //Executa
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        throw new Exception("Ocorreu o erro(BD): " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) { conn.Close(); }
                    }
                }
            }
        }
        public void Upd(Usuario u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("INSERT INTO USUARIO VALUES (p_ID_USUARIO, p_NOME, p_SENHA, p_DATA_NASCIMENTO, p_EMAIL, p_FOTO, p_FACEBOOK)", conn))
                //using (OracleCommand cmd = new OracleCommand("USUARIO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_NOME", u.Nome);
                    cmd.Parameters.Add("p_SENHA", u.Senha);
                    cmd.Parameters.Add("p_DATA_NASCIMENTO", u.DataNascimento);
                    cmd.Parameters.Add("p_EMAIL", u.Email);
                    cmd.Parameters.Add("p_FOTO", u.Foto);
                    cmd.Parameters.Add("p_FACEBOOK", u.Facebook);
                    
                    //Executa
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        throw new Exception("Ocorreu o erro(BD): " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) { conn.Close(); }
                    }
                }
            }
        }
        public void Del(Usuario u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("USUARIO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);

                    //Executa
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        throw new Exception("Ocorreu o erro(BD): " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) { conn.Close(); }
                    }
                }
            }
        }
    }
    
}
