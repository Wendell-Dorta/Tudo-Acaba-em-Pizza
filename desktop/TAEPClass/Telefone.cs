using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Telefone
    {
       

        public int Id {  get; set; }
        public string Ddi { get; set; }
        public string Ddd { get; set; } 
        public string Numero { get; set; }
        public bool Ativo { get; set; } 
        public int ClienteId { get; set; }
        public TipoTelefone TipoTelefone { get; set; }

        public Telefone() { }
        public Telefone(int id) 
        {
            Id = id;
        }
        public Telefone(int id, string ddi, string ddd, string numero, bool ativo, int clienteId, TipoTelefone tipoTelefone)
        {
            Id = id;
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoTelefone = tipoTelefone;
        }
        public Telefone( string ddi, string ddd, string numero, int clienteId, TipoTelefone tipoTelefone)
        {
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            ClienteId = clienteId;
            TipoTelefone = tipoTelefone;
        }

        public Telefone(string ddd, string ddi, string numero, bool ativo, int clienteId, TipoTelefone tipoTelefone)
        {
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoTelefone = tipoTelefone;
        }

        

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_insert";
            cmd.Parameters.AddWithValue("spddi", Ddi);
            cmd.Parameters.AddWithValue("spddd", Ddd);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefone.Id);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spddi", Ddi);
            cmd.Parameters.AddWithValue("spddd", Ddd);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefone.Id);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Deletar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone = new(
                    dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4),
                        dr.GetInt32(6),
                     TipoTelefone.ObterPorId(dr.GetInt32(5))

                    );
            }
            return telefone;
        }
        public static List<Telefone> ObterListaPorCliente(int clienteid)
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where cliente_id = {clienteid}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4),
                      dr.GetInt32(6),
                     TipoTelefone.ObterPorId(dr.GetInt32(5))
                        )
                    );
            }
            return telefone;
        }
    }
}
