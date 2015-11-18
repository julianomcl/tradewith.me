using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using TWMe.Models;

namespace TWMe.DAO
{
    public class ProdutoDAO
    {
        public List<Produto> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_PRODUTO, ID_USUARIO, ID_ROTULO, DESCRICAO, DATA_INCLUSAO, SITUACAO, DATA_SITUACAO,"
                                                            +"FL_ROUPA, DEFAULT_IMAGEM FROM PRODUTO", conn))
                {

                    List<Produto> lista = new List<Produto>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Produto p = new Produto();
                        p.Id_Produto = Convert.ToInt32(reader["ID_PRODUTO"]);
                        p.Id_Usuario = Convert.ToInt32(reader["ID_USUARIO"]);
                        p.Id_Rotulo = Convert.ToInt32(reader["ID_ROTULO"]);
                        p.Descricao = Convert.ToString(reader["DESCRICAO"]);
                        p.Data_Inclusao = Convert.ToDateTime(reader["DATA_INCLUSAO"]);
                        p.Situacao = Convert.ToInt32(reader["SITUACAO"]);
                        p.Data_Situacao = Convert.ToDateTime(reader["DATA_SITUACAO"]);
                        p.Fl_Roupa = Convert.ToChar(reader["FL_ROUPA"]);
                        p.Imagem = Convert.ToString(reader["IMAGEM"]);
                        lista.Add(p);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Produto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PRODUTO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros                    
                    cmd.Parameters.Add("p_ID_PRODUTO", u.Id_Produto);
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_DESCRICAO", u.Descricao);
                    cmd.Parameters.Add("p_DATA_INCLUSAO", u.Data_Inclusao);
                    cmd.Parameters.Add("p_SITUACAO", u.Situacao);
                    cmd.Parameters.Add("p_DATA_SITUACAO", u.Data_Situacao);
                    cmd.Parameters.Add("p_FL_ROUPA", u.Fl_Roupa);
                    cmd.Parameters.Add("p_IMAGEM", u.Imagem);

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
        public void Upd(Produto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PRODUTO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_PRODUTO", u.Id_Produto);
                    cmd.Parameters.Add("p_ID_USUARIO", u.Id_Usuario);
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_DESCRICAO", u.Descricao);
                    cmd.Parameters.Add("p_DATA_INCLUSAO", u.Data_Inclusao);
                    cmd.Parameters.Add("p_SITUACAO", u.Situacao);
                    cmd.Parameters.Add("p_DATA_SITUACAO", u.Data_Situacao);
                    cmd.Parameters.Add("p_FL_ROUPA", u.Fl_Roupa);
                    cmd.Parameters.Add("p_IMAGEM", u.Imagem); 

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
        public void Del(Produto u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("PRODUTO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_PRODUTO", u.Id_Produto);

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
