using System;
using System.Collections.Generic;
using System.Data;

namespace TAEPClass
{
    /// <summary>
    /// Representa um endereço no sistema.
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// Identificador único do endereço.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Código de Endereçamento Postal (CEP).
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Logradouro do endereço (rua, avenida, etc.).
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do endereço.
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Complemento do endereço (apartamento, bloco, etc.).
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro do endereço.
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade do endereço.
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Unidade Federativa (Estado) do endereço.
        /// </summary>
        public string Uf { get; set; }

        /// <summary>
        /// Indica se o endereço está ativo ou não.
        /// </summary>
        public bool Ativo { get; set; }

        /// <summary>
        /// Identificador do cliente associado ao endereço.
        /// </summary>
        public int ClienteId { get; set; }

        /// <summary>
        /// Tipo de endereço (residencial, comercial, etc.).
        /// </summary>
        public TipoEndereco TipoEnderecos { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Endereco() { }

        /// <summary>
        /// Construtor com identificador.
        /// </summary>
        /// <param name="id">Identificador único do endereço.</param>
        public Endereco(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Construtor com todos os parâmetros.
        /// </summary>
        /// <param name="id">Identificador único do endereço.</param>
        /// <param name="cep">Código de Endereçamento Postal (CEP).</param>
        /// <param name="logradouro">Logradouro do endereço.</param>
        /// <param name="numero">Número do endereço.</param>
        /// <param name="complemento">Complemento do endereço.</param>
        /// <param name="bairro">Bairro do endereço.</param>
        /// <param name="cidade">Cidade do endereço.</param>
        /// <param name="uf">Unidade Federativa (Estado) do endereço.</param>
        /// <param name="ativo">Indica se o endereço está ativo.</param>
        /// <param name="clienteId">Identificador do cliente associado.</param>
        /// <param name="tipoEnderecos">Tipo de endereço.</param>
        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, bool ativo, int clienteId, TipoEndereco tipoEnderecos)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }

        /// <summary>
        /// Construtor com parâmetros, sem o identificador.
        /// </summary>
        /// <param name="cep">Código de Endereçamento Postal (CEP).</param>
        /// <param name="logradouro">Logradouro do endereço.</param>
        /// <param name="numero">Número do endereço.</param>
        /// <param name="complemento">Complemento do endereço.</param>
        /// <param name="bairro">Bairro do endereço.</param>
        /// <param name="cidade">Cidade do endereço.</param>
        /// <param name="uf">Unidade Federativa (Estado) do endereço.</param>
        /// <param name="ativo">Indica se o endereço está ativo.</param>
        /// <param name="clienteId">Identificador do cliente associado.</param>
        /// <param name="tipoEnderecos">Tipo de endereço.</param>
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, bool ativo, int clienteId, TipoEndereco tipoEnderecos)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }

        /// <summary>
        /// Construtor com parâmetros, sem o identificador e o complemento.
        /// </summary>
        /// <param name="cep">Código de Endereçamento Postal (CEP).</param>
        /// <param name="logradouro">Logradouro do endereço.</param>
        /// <param name="numero">Número do endereço.</param>
        /// <param name="bairro">Bairro do endereço.</param>
        /// <param name="cidade">Cidade do endereço.</param>
        /// <param name="uf">Unidade Federativa (Estado) do endereço.</param>
        /// <param name="clienteId">Identificador do cliente associado.</param>
        /// <param name="tipoEnderecos">Tipo de endereço.</param>
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, int clienteId, TipoEndereco tipoEnderecos)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }

        /// <summary>
        /// Insere um novo endereço no banco de dados.
        /// </summary>
        public void Inserir()
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_enderecos_insert";
                cmd.Parameters.AddWithValue("spcep", Cep);
                cmd.Parameters.AddWithValue("splogradouro", Logradouro);
                cmd.Parameters.AddWithValue("spnumero", Numero);
                cmd.Parameters.AddWithValue("spcomplemento", Complemento);
                cmd.Parameters.AddWithValue("spbairro", Bairro);
                cmd.Parameters.AddWithValue("spcidade", Cidade);
                cmd.Parameters.AddWithValue("spuf", Uf);
                cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
                cmd.Parameters.AddWithValue("sptipo_endereco_id", TipoEnderecos.Id);

                var resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    Id = Convert.ToInt32(resultado);
                }
            }
        }

        /// <summary>
        /// Edita um endereço existente.
        /// </summary>
        /// <param name="id">Identificador único do endereço a ser editado.</param>
        /// <returns>True se a edição foi bem-sucedida, false caso contrário.</returns>
        public bool Editar(int id)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_enderecos_update";
                cmd.Parameters.AddWithValue("spid", id);
                cmd.Parameters.AddWithValue("spcep", Cep);
                cmd.Parameters.AddWithValue("splogradouro", Logradouro);
                cmd.Parameters.AddWithValue("spnumero", Numero);
                cmd.Parameters.AddWithValue("spcomplemento", Complemento);
                cmd.Parameters.AddWithValue("spbairro", Bairro);
                cmd.Parameters.AddWithValue("spcidade", Cidade);
                cmd.Parameters.AddWithValue("spuf", Uf);
                cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
                cmd.Parameters.AddWithValue("sptipo_endereco_id", TipoEnderecos.Id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Deleta um endereço do banco de dados.
        /// </summary>
        /// <param name="id">Identificador único do endereço a ser deletado.</param>
        /// <param name="ativo">Indica se o endereço deve ser mantido ativo ou não.</param>
        /// <returns>True se a deleção foi bem-sucedida, false caso contrário.</returns>
        public bool Deletar(int id, bool ativo)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_enderecos_delete";
                cmd.Parameters.AddWithValue("spid", id);
                cmd.Parameters.AddWithValue("spativo", ativo);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Obtém um endereço pelo seu ID.
        /// </summary>
        /// <param name="id">Identificador único do endereço.</param>
        /// <returns>O endereço encontrado ou null se não encontrado.</returns>
        public static Endereco ObterPorId(int id)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM enderecos WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new Endereco
                        {
                            Id = dr.GetInt32(0),
                            Cep = dr.GetString(1),
                            Logradouro = dr.GetString(2),
                            Numero = dr.GetString(3),
                            Complemento = dr.GetString(4),
                            Bairro = dr.GetString(5),
                            Cidade = dr.GetString(6),
                            Uf = dr.GetString(7),
                            Ativo = dr.GetBoolean(8),
                            ClienteId = dr.GetInt32(9),
                            TipoEnderecos = TipoEndereco.ObterPorId(dr.GetInt32(10))
                        };
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Obtém uma lista de endereços associados a um cliente.
        /// </summary>
        /// <param name="clienteId">Identificador único do cliente.</param>
        /// <returns>Lista de endereços associados ao cliente.</returns>
        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            var enderecos = new List<Endereco>();

            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM enderecos WHERE cliente_id = @clienteId";
                cmd.Parameters.AddWithValue("@clienteId", clienteId);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        enderecos.Add(new Endereco
                        {
                            Id = dr.GetInt32(0),
                            Cep = dr.GetString(1),
                            Logradouro = dr.GetString(2),
                            Numero = dr.GetString(3),
                            Complemento = dr.GetString(4),
                            Bairro = dr.GetString(5),
                            Cidade = dr.GetString(6),
                            Uf = dr.GetString(7),
                            Ativo = dr.GetBoolean(8),
                            ClienteId = dr.GetInt32(9),
                            TipoEnderecos = TipoEndereco.ObterPorId(dr.GetInt32(10))
                        });
                    }
                }
            }

            return enderecos;
        }
    }
}