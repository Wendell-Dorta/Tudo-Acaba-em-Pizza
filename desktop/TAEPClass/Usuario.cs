using TAEPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BCryptNet = BCrypt.Net.BCrypt;

namespace TAEPClass
{
    public  class Usuario
    {

        /// <summary>
        /// Identificador único do usuário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do usuário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Endereço de e-mail do usuário.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário (criptografada).
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Data de cadastro do usuário.
        /// </summary>
        public DateTime DataCad { get; set; }

        /// <summary>
        /// Indica se o usuário está ativo ou não.
        /// </summary>
        public bool Ativo { get; set; }

        /// <summary>
        /// Nível de acesso do usuário.
        /// </summary>
        public Nivel Nivel { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Usuario() { }

        /// <summary>
        /// Construtor com parâmetros.
        /// </summary>
        /// <param name="id">Identificador único do usuário.</param>
        /// <param name="nome">Nome do usuário.</param>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <param name="dataCad">Data de cadastro do usuário.</param>
        /// <param name="ativo">Indica se o usuário está ativo ou não.</param>
        /// <param name="nivelId">Nível de acesso do usuário.</param>
        public Usuario(int id, string nome, string email, string senha, DateTime dataCad, bool ativo, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCad = dataCad;
            Ativo = ativo;
            Nivel = nivelId;
        }

        /// <summary>
        /// Construtor com parâmetros (sem ID).
        /// </summary>
        /// <param name="nome">Nome do usuário.</param>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <param name="nivelId">Nível de acesso do usuário.</param>
        public Usuario(string nome, string email, string senha, Nivel nivelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
        }

        /// <summary>
        /// Construtor com parâmetros (sem ID).
        /// </summary>
        /// /// <param name="id">Id do usuário.</param>
        /// <param name="nome">Nome do usuário.</param>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <param name="nivelId">Nível de acesso do usuário.</param>
        public Usuario(int id, string nome, string email, string senha, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
        }

        /// <summary>
        /// Construtor com parâmetros (sem ID).
        /// </summary>
        /// /// <param name="id">Id do usuário.</param>
        /// <param name="nome">Nome do usuário.</param>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="nivelId">Nível de acesso do usuário.</param>
        public Usuario(int id, string nome, string email, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nivel = nivelId;
        }

        /// <summary>
        /// Construtor com parâmetros (sem ID e Nível).
        /// </summary>
        /// <param name="nome">Nome do usuário.</param>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        /// <summary>
        /// Obtém um usuário pelo seu ID.
        /// </summary>
        /// <param name="id">Identificador único do usuário.</param>
        /// <returns>Usuário encontrado ou null se não encontrado.</returns>
        public static Usuario ObterPorId(int id)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM usuarios WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = dr.GetInt32(0),
                            Nome = dr.GetString(1),
                            Email = dr.GetString(2),
                            Senha = dr.GetString(3),
                            DataCad = dr.GetDateTime(4),
                            Ativo = dr.GetBoolean(5),
                            Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(6)))
                        };

                        return usuario;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Obtém uma lista de usuários (opcionalmente filtrada por nome).
        /// </summary>
        /// <param name="nome">Nome do usuário (opcional).</param>
        /// <returns>Lista de usuários.</returns>
        public static List<Usuario> ObterLista(string nome = null)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                if (nome == null)
                {
                    cmd.CommandText = "SELECT * FROM usuarios ORDER BY nome";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM usuarios WHERE nome LIKE '%{nome}%' ORDER BY nome";
                }

                using (var dr = cmd.ExecuteReader())
                {
                    var lista = new List<Usuario>();
                    while (dr.Read())
                    {
                        lista.Add(new Usuario
                        {
                            Id = dr.GetInt32(0),
                            Nome = dr.GetString(1),
                            Email = dr.GetString(2),
                            Senha = dr.GetString(3),
                            DataCad = dr.GetDateTime(4),
                            Ativo = dr.GetBoolean(5),
                            Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(6)))
                        });
                    }
                    return lista;
                }
            }
        }

        /// <summary>
        /// Insere um novo usuário.
        /// </summary>
        public void Inserir()
        {
            string senhaCriptografada = CriptografarSenha(Senha);
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spemail", Email);
                cmd.Parameters.AddWithValue("spsenha", senhaCriptografada);
                cmd.Parameters.AddWithValue("spniveis_id", Nivel.Id);
                var resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    Id = Convert.ToInt32(resultado);
                }
            }
        }

        /// <summary>
        /// Edita um usuário existente.
        /// </summary>
        /// <param name="id">Identificador único do usuário.</param>
        /// <param name="senhaConfirmar">Senha de confirmação.</param>
        /// <returns>True se a edição foi bem-sucedida, false caso contrário.</returns>
        public bool Editar(int id, string senhaConfirmar,string senha)
        {
            bool resultado = false;
            if (senhaConfirmar == senha)
            {
                using (var cmd = Banco.Abrir())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "sp_usuario_update";
                    cmd.Parameters.AddWithValue("spid", id);
                    cmd.Parameters.AddWithValue("spnome", Nome);
                    cmd.Parameters.AddWithValue("spemail", Email);
                    cmd.Parameters.AddWithValue("spsenha", Senha);
                    cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return resultado;
        }

        /// <summary>
        /// Ativa ou desativa um usuário.
        /// </summary>
        /// <param name="id">Identificador único do usuário.</param>
        /// <param name="ativo">Indica se o usuário deve ser ativado ou desativado.</param>
        public void AtivarOuDesativar(int id, bool ativo) 
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_set_ativo";
                cmd.Parameters.AddWithValue("spid", id);
                cmd.Parameters.AddWithValue("spativo", ativo);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Efetua login de um usuário.
        /// </summary>
        /// <param name="email">Endereço de e-mail do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <returns>Usuário logado ou null se as credenciais forem inválidas.</returns>
        public static Usuario EfetuarLogin(string email, string senha)
        {
            int nivelId = 0;
            //recuperando id do nivel cliente
            using (var cmdNivel = Banco.Abrir())
            { 
                string comandoNivel = "SELECT id FROM niveis WHERE descricao = 'cliente'";
                cmdNivel.CommandType = CommandType.Text;
                cmdNivel.CommandText = comandoNivel;
                nivelId = Convert.ToInt32(cmdNivel.ExecuteScalar());
            }
            // recuperando usuario
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM usuarios WHERE email = @email AND ativo = 1 AND nivel_id != @nivelId";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nivelId", nivelId);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = dr.GetInt32(0),
                            Nome = dr.GetString(1),
                            Email = dr.GetString(2),
                            Senha = dr.GetString(3),
                            DataCad = dr.GetDateTime(4),
                            Ativo = dr.GetBoolean(5),
                            Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(6)))
                        };

                        if (VerificarSenha(senha, usuario.Senha))
                        {
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Criptografa uma senha.
        /// </summary>
        /// <param name="senha">Senha a ser criptografada.</param>
        /// <returns>Senha criptografada.</returns>
        public string CriptografarSenha(string senha)
        {
            string salt = BCryptNet.GenerateSalt(10);
            string CripSenha = BCryptNet.HashPassword(senha,salt);
            return CripSenha;
        }

        /// <summary>
        /// Verifica se uma senha coincide com uma senha criptografada.
        /// </summary>
        /// <param name="senha">Senha a ser verificada.</param>
        /// <param name="hashPass">Senha criptografada.</param>
        /// <returns>True se as senhas coincidem, false caso contrário.</returns>
        private static bool VerificarSenha(string senha,string hashPass)
        {
            return BCryptNet.Verify(senha, hashPass);
        }

        /// <summary>
        /// Retorna um código de hash para o objeto.
        /// </summary>
        /// <returns>Código de hash.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad, Nivel.Sigla, Email);
        }
    }
}