using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Oracle.DataAccess.Client;


using TWMe.Models;

namespace TWMe.DAO
{
    public class IdiomaDAO
    {
        public List<Idioma> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_IDIOMA, NOME FROM IDIOMA", conn))
                {

                    List<Idioma> lista = new List<Idioma>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Idioma i = new Idioma();
                        i.Id_Idioma = Convert.ToInt32(reader["ID_IDIOMA"]);
                        i.Nome = Convert.ToString(reader["NOME"]);
                        lista.Add(i);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Idioma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("IDIOMA_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_IDIOMA", u.Id_Idioma);
                    cmd.Parameters.Add("p_NOME", u.Nome);

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
        public void Upd(Idioma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("IDIOMA_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_IDIOMA", u.Id_Idioma);
                    cmd.Parameters.Add("p_NOME", u.Nome);

                    //Executa
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
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
        public void Del(Idioma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("IDIOMA_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_IDIOMA", u.Id_Idioma);


                    //Executa
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
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
