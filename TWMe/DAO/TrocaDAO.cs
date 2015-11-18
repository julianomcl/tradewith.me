using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using TWMe.Models;

namespace TWMe.DAO
{
    public class TrocaDAO
    {
        public List<Troca> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_TROCA, ID_USUARIO_SOLICITANTE, ID_USUARIO_DETENTOR, DATA_INCLUSAO, DATA_SITUACAO,"
                                                            +"SITUACAO, POSICAO_SOLICITANTE, POSICAO_DETENTOR FROM TROCA", conn))
                {

                    List<Troca> lista = new List<Troca>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Troca t = new Troca();
                        t.Id_Troca = Convert.ToInt32(reader["ID_TROCA"]);
                        t.Id_Usuario_Solicitante = Convert.ToInt32(reader["ID_USUARIO_SOLICITANTE"]);
                        t.Id_Usuario_Detentor = Convert.ToInt32(reader["ID_USUARIO_DETENTOR"]);
                        t.Data_Inclusao = Convert.ToDateTime(reader["DATA_INCLUSAO"]);
                        t.Data_Situacao = Convert.ToDateTime(reader["DATA_SITUACAO"]);
                        t.Situacao = Convert.ToInt32(reader["SITUACAO"]);
                        t.Posicao_Solicitante = Convert.ToInt32(reader["POSICAO_SOLICITANTE"]);
                        t.Posicao_Detentor = Convert.ToInt32(reader["POSICAO_DETENTOR"]);
                        lista.Add(t);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Troca u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("TROCA_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros                    
                    cmd.Parameters.Add("p_ID_TROCA", u.Id_Troca);
                    cmd.Parameters.Add("p_ID_USUARIO_SOLICITANTE", u.Id_Usuario_Solicitante);
                    cmd.Parameters.Add("p_ID_USUARIO_DETENTOR", u.Id_Usuario_Detentor);
                    cmd.Parameters.Add("p_DATA_INCLUSAO", u.Data_Inclusao);
                    cmd.Parameters.Add("p_DATA_SITUACAO", u.Data_Situacao);
                    cmd.Parameters.Add("p_SITUACAO", u.Situacao);
                    cmd.Parameters.Add("p_POSICAO_SOLICITANTE", u.Posicao_Solicitante);
                    cmd.Parameters.Add("p_POSICAO_DETENTOR", u.Posicao_Detentor);

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
        public void Upd(Troca u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("TROCA_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_TROCA", u.Id_Troca);
                    cmd.Parameters.Add("p_ID_USUARIO_SOLICITANTE", u.Id_Usuario_Solicitante);
                    cmd.Parameters.Add("p_ID_USUARIO_DETENTOR", u.Id_Usuario_Detentor);
                    cmd.Parameters.Add("p_DATA_INCLUSAO", u.Data_Inclusao);
                    cmd.Parameters.Add("p_DATA_SITUACAO", u.Data_Situacao);
                    cmd.Parameters.Add("p_SITUACAO", u.Situacao);
                    cmd.Parameters.Add("p_POSICAO_SOLICITANTE", u.Posicao_Solicitante);
                    cmd.Parameters.Add("p_POSICAO_DETENTOR", u.Posicao_Detentor);

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
        public void Del(Troca u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("TROCA_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_TROCA", u.Id_Troca);

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
