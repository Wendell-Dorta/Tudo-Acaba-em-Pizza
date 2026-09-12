using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class TamanhoPizza
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public TamanhoPizza() { }
        public TamanhoPizza(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public TamanhoPizza(int id, string descricao, string sigla, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Sigla = sigla;
            Ativo = ativo;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tamanhopizza_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tamanhopizza_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tamanhopizza_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<TamanhoPizza> ObterLista()
        {
            List<TamanhoPizza> tamanhoPizza = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tamanhos_pizza";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tamanhoPizza.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return tamanhoPizza;
        }
        public static TamanhoPizza ObterPorId(int id)
        {
            TamanhoPizza tamanhoPizza = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tamanhos_pizza where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tamanhoPizza.Id = dr.GetInt32(0);
                tamanhoPizza.Descricao = dr.GetString(1);
                tamanhoPizza.Sigla = dr.GetString(2);
                tamanhoPizza.Ativo = dr.GetBoolean(3);
            }
            return tamanhoPizza;
        }
    }
}
