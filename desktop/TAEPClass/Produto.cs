using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Produto
    {

        public int Id { get; set; }
        public string Rotulo { get; set; } 
        public string Descricao { get; set; }   
        public double ValorUnit {  get; set; }  
        public string CodBarras { get; set; }   
        public string NomeImagem { get; set; }
        public bool Destaque {  get; set; }
        public DateTime DataCad {  get; set; }
        public bool Ativo { get; set; }
        public Categoria CategoriaId { get; set; }
        public Produto () { }

        public Produto(int id, string rotulo, string descricao, double valorUnit, string codBarras, string nomeImagem, bool destaque, DateTime dataCad, bool ativo, Categoria categoriaId)
        {
            Id = id;
            Rotulo = rotulo;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            NomeImagem = nomeImagem;
            Destaque = destaque;
            DataCad = dataCad;
            Ativo = ativo;
            CategoriaId = categoriaId;
        }

        public Produto(string rotulo, string descricao, double valorUnit, string codBarras, string nomeImagem, bool destaque, DateTime dataCad, bool ativo, Categoria categoriaId)
        {
            Rotulo = rotulo;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            NomeImagem = nomeImagem;
            Destaque = destaque;
            DataCad = dataCad;
            CategoriaId = categoriaId;
        }

        public Produto(int id, string rotulo, string descricao, double valorUnit, string codBarras, string nomeImagem, bool destaque, Categoria categoriaId)
        {
            Id = id;
            Rotulo = rotulo;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            NomeImagem = nomeImagem;
            Destaque = destaque;
            CategoriaId = categoriaId;
        }

        public Produto(string rotulo, string descricao, double valorUnit, string codBarras, string nomeImagem, bool destaque, Categoria categoriaId)
        {
            Rotulo = rotulo;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            NomeImagem = nomeImagem;
            Destaque = destaque;
            CategoriaId = categoriaId;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("sprotulo",Rotulo);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spnome_imagem", NomeImagem);
            cmd.Parameters.AddWithValue("spdestaque", Destaque);
            cmd.Parameters.AddWithValue("spcategorias_id", CategoriaId.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("sprotulo", Rotulo);
            cmd.Parameters.AddWithValue("spdescricao ", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spnome_imagem", NomeImagem);
            cmd.Parameters.AddWithValue("spdestaque", Destaque);
            cmd.Parameters.AddWithValue("spcategorias_id", CategoriaId.Id);
            try
            {
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public bool Deletar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static List<Produto> ObterLista(string descricao = null)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from produtos order by rotulo";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where rotulo like '%{descricao}%' order by rotulo";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(
                    new(
                        dr.GetInt32(0)
                        , dr.GetString(1)
                        , dr.GetString(2)
                        , dr.GetDouble(3)
                        , dr.GetString(4)
                        , dr.GetString(5)
                        , dr.GetBoolean(6)
                        , Categoria.ObterPorId((7))

                ));
            }

            return produto;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                         dr.GetInt32(0)
                        ,dr.GetString(1)
                        ,dr.GetString(2)
                        ,dr.GetDouble(3)
                        ,dr.GetString(4)
                        ,dr.GetString(5)
                        ,dr.GetBoolean(6)
                        ,dr.GetDateTime(7)
                        ,dr.GetBoolean(8)
                        ,Categoria.ObterPorId(dr.GetInt32((9)))
                );
            }
            return produto;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad);
        }
    }
}
