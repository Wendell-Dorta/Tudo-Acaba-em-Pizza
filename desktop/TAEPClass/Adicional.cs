using System;
using TAEPClass;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public class Adicional
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public Adicional() { }
        public Adicional(double preco, string descricao)
        {
            Preco = preco;
            Descricao = descricao;
        }
        public Adicional(int id, double preco, string descricao)
        {
            Id = id;
            Preco = preco;
            Descricao = descricao;
          
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_adicional_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_adicional_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_adicional_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<Adicional> ObterLista()
        {
            List<Adicional> adicional = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from adicionais";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adicional.Add(new(dr.GetInt32(0), dr.GetDouble(1), dr.GetString(2)));
            }
            return adicional;
        }
        public static Adicional ObterPorId(int id)
        {
            Adicional adicional = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from adicionais where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adicional.Id = dr.GetInt32(0);
                adicional.Preco = dr.GetDouble(1);
                adicional.Descricao = dr.GetString(2);
            }
            return adicional;
        }
    }
}
