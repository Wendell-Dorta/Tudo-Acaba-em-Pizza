using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Status
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public Status() { }
        public Status(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public Status(int id, string descricao, string sigla, bool ativo)
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
            cmd.CommandText = "sp_status_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_status_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_status_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<Status> ObterLista()
        {
            List<Status> status = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from status";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                status.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return status;
        }
        public static Status ObterPorId(int id)
        {
            Status status = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from status where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                status.Id = dr.GetInt32(0);
                status.Descricao = dr.GetString(1);
                status.Sigla = dr.GetString(2);
                status.Ativo = dr.GetBoolean(3);
            }
            return status;
        }
        

    }
}
