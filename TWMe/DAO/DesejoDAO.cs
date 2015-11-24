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
    public class DesejoDAO
    {
        public List<Desejo> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_USUARIO, ID_ROTULO, ID_FABRICANTE, ID_CATEGORIA, ID_DESEJO FROM DESEJO", conn))
                {

                    List<Desejo> lista = new List<Desejo>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Desejo d = new Desejo();
                        d.Id_Desejo = Convert.ToInt32(reader["ID_DESEJO"]);
                        d.Id_Usuario = Convert.ToInt32(reader["ID_USUARIO"]);
                        d.Id_Rotulo = Convert.ToInt32(reader["ID_ROTULO"]);            
                        d.Id_Fabricante = Convert.ToInt32(reader["ID_FABRICANTE"]);
                        lista.Add(d);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Desejo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("DESEJO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_DESEJO", u.Id_Desejo);
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_ID_FABRICANTE", u.Id_Fabricante);

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
        public void Upd(Desejo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("DESEJO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_DESEJO", u.Id_Desejo);
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_ID_FABRICANTE", u.Id_Fabricante);

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
        public void Del(Desejo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("DESEJO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_DESEJO", u.Id_Desejo);

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
