using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using TWMe.Models;

namespace TWMe.DAO
{
    public class RotuloDAO
    {
        public List<Rotulo> Get()
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("SELECT ID_ROTULO, ID_FABRICANTE, ID_CATEGORIA, NOME, FL_TIPO_ROTULO FROM ROTULO", conn))
                {

                    List<Rotulo> lista = new List<Rotulo>();
                    cmd.CommandType = CommandType.Text;

                    //Executando o select
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Rotulo r = new Rotulo();
                        r.Id_Rotulo = Convert.ToInt32(reader["ID_ROTULO"]);
                        r.Id_Fabricante = Convert.ToInt32(reader["ID_FABRICANTE"]);
                        r.Id_Categoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
                        r.Nome = Convert.ToString(reader["NOME"]);
                        r.Fl_Tipo_Rotulo = Convert.ToChar(reader["FL_TIPO_ROTULO"]);
                        lista.Add(r);
                    }
                    return lista;
                }
            }
        }
        public void Ins(Rotulo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ROTULO_tapi.ins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_ID_FABRICANTE", u.Id_Fabricante);
                    cmd.Parameters.Add("p_ID_CATEGORIA", u.Id_Categoria);
                    cmd.Parameters.Add("p_NOME", u.Nome);
                    cmd.Parameters.Add("p_FL_TIPO_ROTULO", u.Fl_Tipo_Rotulo);

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
        public void Upd(Rotulo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ROTULO_tapi.upd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);
                    cmd.Parameters.Add("p_ID_FABRICANTE", u.Id_Fabricante);
                    cmd.Parameters.Add("p_ID_CATEGORIA", u.Id_Categoria);
                    cmd.Parameters.Add("p_NOME", u.Nome);
                    cmd.Parameters.Add("p_FL_TIPO_ROTULO", u.Fl_Tipo_Rotulo);

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
        public void Del(Rotulo u)
        {
            using (OracleConnection conn = BaseDAO.GetConnection())
            {
                //Define o comando
                using (OracleCommand cmd = new OracleCommand("ROTULO_tapi.del", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Define parametros
                    cmd.Parameters.Add("p_ID_ROTULO", u.Id_Rotulo);

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
