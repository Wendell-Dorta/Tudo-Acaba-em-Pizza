using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public Categoria() { }
        public Categoria(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
        public Categoria(int id, string sigla, string descricao, bool ativo)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
            Ativo = ativo;
        }

        public Categoria(int id, string sigla, string descricao)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
            
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Desativar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static List<Categoria> ObterLista(string descricao = null)
        {
            List<Categoria> lista = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from categorias order by descricao";
            }
            else
            {
                cmd.CommandText = $"select * from categorias where descricao like '%{descricao}%' order by descricao";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria cat = new Categoria();
                cat.Id = dr.GetInt32(0);
                cat.Sigla = dr.GetString(1);
                cat.Descricao = dr.GetString(2);

                lista.Add(cat);
            }

            return lista;
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Id = dr.GetInt32(0);
                categoria.Sigla = dr.GetString(1);
                categoria.Descricao = dr.GetString(2);
                categoria.Ativo = dr.GetBoolean(3);
            }
            return categoria;
        }
    }
}
