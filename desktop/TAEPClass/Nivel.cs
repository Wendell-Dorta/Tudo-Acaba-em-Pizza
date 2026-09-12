using MySql.Data.MySqlClient;
using TAEPClass;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public Nivel() { }
        public Nivel(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
        public Nivel(int id, string sigla, string descricao, bool ativo)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
            Ativo = ativo;
        }
        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_insert";
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2),dr.GetBoolean(3)));
            }
            return niveis;
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Sigla = dr.GetString(1);
                nivel.Descricao = dr.GetString(2);
                nivel.Ativo = dr.GetBoolean(3);
            }
            return nivel;
        }
        public static Nivel ObterPorDescricao(string descricao) {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where UPPER(descricao)  = UPPER('{descricao}')";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Sigla = dr.GetString(1);
                nivel.Descricao = dr.GetString(2);
                nivel.Ativo = dr.GetBoolean(3);
            }
            return nivel;
        }

    }
}