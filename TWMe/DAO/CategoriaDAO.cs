using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using TWMe.Models;

namespace TWMe.DAO
{
    public class CategoriaDAO
    {
        public List<Categoria> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT C.ID_CATEGORIA, C.NOME, C.ID_CATEGORIA_MAE, CMAE.NOME FROM CATEGORIA C" 
                                                            +"JOIN CATEGORIA CMAE ON C.ID_CATEGORIA = CMAE.ID_CATEGORIA", conn))
                {

                    List<Categoria> lista = new List<Categoria>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria c = new Categoria();
                        c.Id_Categoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
                        c.Nome = Convert.ToString(reader["NOME"]);
                        c.Id_Categoria_Mae = Convert.ToInt32(reader["ID_CATEGORIA_MAE"]);
                        //c.NomeMae = Convert.ToString(reader["NOME"]); ?
                        lista.Add(c);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Categoria u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("CATEGORIA_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_CATEGORIA", u.Id_Categoria);
                    cmd.Parameters.Add("p_ID_CATEGORIA_MAE", u.Id_Categoria_Mae);
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
        public void Upd(Categoria u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("CATEGORIA_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_CATEGORIA", u.Id_Categoria);
                    cmd.Parameters.Add("p_ID_CATEGORIA_MAE", u.Id_Categoria_Mae);
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
        public void Del(Categoria u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("CATEGORIA_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_CATEGORIA", u.Id_Categoria);

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
