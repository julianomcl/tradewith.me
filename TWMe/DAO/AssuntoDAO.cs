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
    public class AssuntoDAO
    {
        public List<Assunto> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_ASSUNTO, NOME FROM ASSUNTO", conn))
                {

                    List<Assunto> lista = new List<Assunto>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Assunto a = new Assunto();
                        a.Id_Assunto = Convert.ToInt32(reader["ID_ASSUNTO"]);
                        a.Nome = Convert.ToString(reader["NOME"]);
                        lista.Add(a);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Assunto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ASSUNTO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ASSUNTO", u.Id_Assunto);
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
        public void Upd(Assunto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ASSUNTO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ASSUNTO", u.Id_Assunto);
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
        public void Del(Assunto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ASSUNTO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ASSUNTO", u.Id_Assunto);


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
