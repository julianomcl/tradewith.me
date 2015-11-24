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
    public class PlataformaDAO
    {
        public List<Plataforma> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_PLATAFORMA, NOME FROM PLATAFORMA", conn))
                {

                    List<Plataforma> lista = new List<Plataforma>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Plataforma p = new Plataforma();
                        p.Id_Plataforma = Convert.ToInt32(reader["ID_PLATAFORMA"]);
                        p.Nome = Convert.ToString(reader["NOME"]);
                        lista.Add(p);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Plataforma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PLATAFORMA_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_PLATAFORMA", u.Id_Plataforma);
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
        public void Upd(Plataforma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PLATAFORMA_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_PLATAFORMA", u.Id_Plataforma);
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
        public void Del(Plataforma u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PLATAFORMA_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_PLATAFORMA", u.Id_Plataforma);


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
