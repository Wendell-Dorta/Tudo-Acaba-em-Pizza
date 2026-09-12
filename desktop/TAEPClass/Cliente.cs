using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Cliente
    {
        

        public int Id { get; set; }   
        public Usuario Usuario { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public List<Endereco> Enderecos{ get; set;}
        public List<Telefone> Telefones { get; set; }

        public Cliente() { }
        public Cliente(int id, Usuario usuario, string cpf, DateTime dataNasc, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Id = id;
            Usuario = usuario;
            Cpf = cpf;
            DataNasc = dataNasc;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, string cpf, DateTime dataNasc, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, string cpf, DateTime dataNasc)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        } 

        public Cliente(int id, Usuario usuario, string cpf, DateTime dataNasc)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public Cliente(string cpf, DateTime dataNasc)
        {
            DataNasc = dataNasc; 
            Cpf = cpf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nasc", DataNasc);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }
        public static Cliente ObterPorId(int id)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM clientes WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new Cliente
                        {
                            Id = dr.GetInt32(0),
                            Usuario = Usuario.ObterPorId(dr.GetInt32(1)),
                            Cpf = dr.GetString(2),
                            DataNasc = dr.GetDateTime(3),
                        };
                    }
                }
            }
            return null; // Retorna null se o cliente não for encontrado
        }


        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from vw_clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(1),
                    dr.GetString(2),
                    dr.GetDateTime(3),
                    Endereco.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))),
                    Telefone.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))
                    )
                ));
            }
            return clientes;
        }
    }
}
