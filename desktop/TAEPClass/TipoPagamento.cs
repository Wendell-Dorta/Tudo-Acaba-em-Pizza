using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class TipoPagamento
    {
        public int Id { get; set; }
        public string  Sigla { get; set; }
        public string Descricão { get; set; }

        public TipoPagamento() { }

        public TipoPagamento(int id, string sigla, string descricao)
        {
            Id = id;
            Sigla = sigla;
            Descricão = descricao;
        }

        public TipoPagamento(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricão = descricao;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipopagamento_insert";
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.Parameters.AddWithValue("spdescricao", Descricão);
            cmd.ExecuteNonQuery();

        }

        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoendereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue(" spsigla",Sigla);
            cmd.Parameters.AddWithValue(" spdescricao", Descricão);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }

        public static List<TipoPagamento> ObterLista()
        {
            List<TipoPagamento> tipoPagamento = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos_pagamento";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoPagamento.Add(new(dr.GetInt32(0), dr.GetString(1),dr.GetString(2)));
            }
            return tipoPagamento;
        }

        public static TipoPagamento ObterPorId(int id)
        {
            TipoPagamento tipoPagamento = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipos_pagamento where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoPagamento.Id = dr.GetInt32(0);
                tipoPagamento.Sigla = dr.GetString(1);
                tipoPagamento.Descricão = dr.GetString(2);
               
            }
            return tipoPagamento;
        }
    }
}
