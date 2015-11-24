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
    public class JogoDAO
    {
        public List<Jogo> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_JOGO, NOME FROM JOGO", conn))
                {

                    List<Jogo> lista = new List<Jogo>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Jogo j = new Jogo();
        
                        j.Id_Rotulo = Convert.ToInt32(reader["ID_ROTULO"]);
                        j.Marca = Convert.ToString(reader["MARCA"]);
                        j.Recursos = Convert.ToString(reader["RECURSOS"]);
                        j.Faixa_Etaria = Convert.ToString(reader["FAIXA_ETARIA"]);
                        j.Id_Plataforma = Convert.ToInt32(reader["ID_PLATAFORMA"]);
                        j.Id_Genero = Convert.ToInt32(reader["ID_GENERO"]);
                        lista.Add(j);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Jogo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("JOGO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_MARCA", u.Marca);
                    cmd.Parameters.Add("p_RECURSOS", u.Recursos);
                    cmd.Parameters.Add("p_FAIXA_ETARIA", u.Faixa_Etaria);
                    cmd.Parameters.Add("p_ID_PLATAFORMA", u.Id_Plataforma);
                    cmd.Parameters.Add("p_ID_GENERO", u.Id_Genero);

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
        public void Upd(Jogo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("JOGO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_MARCA", u.Marca);
                    cmd.Parameters.Add("p_RECURSOS", u.Recursos);
                    cmd.Parameters.Add("p_FAIXA_ETARIA", u.Faixa_Etaria);
                    cmd.Parameters.Add("p_ID_PLATAFORMA", u.Id_Plataforma);
                    cmd.Parameters.Add("p_ID_GENERO", u.Id_Genero);

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
        public void Del(Jogo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("JOGO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_JOGO", u.Id_Rotulo);
                    
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
