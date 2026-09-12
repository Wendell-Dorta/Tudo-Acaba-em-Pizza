using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public TipoEndereco() { }
        public TipoEndereco(string sigla, string descricao)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public TipoEndereco(int id, string sigla, string descricao, bool ativo)
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
            cmd.CommandText = "sp_tipoendereco_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoendereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Desativar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoendereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static List<TipoEndereco> ObterLista()
        {
            List<TipoEndereco> tipoEndereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos_endereco order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEndereco.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return tipoEndereco;
        }
        public static TipoEndereco ObterPorId(int id)
        {
            TipoEndereco tipoEndereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipos_endereco where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEndereco.Id = dr.GetInt32(0);
                tipoEndereco.Sigla = dr.GetString(1);
                tipoEndereco.Descricao = dr.GetString(2);
                tipoEndereco.Ativo = dr.GetBoolean(3);
            }
            return tipoEndereco;
        }
    }
}
