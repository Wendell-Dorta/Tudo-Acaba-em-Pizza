using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;
using System.Data;

namespace TAEPClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public Status StatusId {  get; set; }
        public string StatusDesc { get; set; }  
        public ClasseDesconto ClasseDesconto {  get; set; }
        public ItemPedido ItemPedido { get; set; }
        public ItemPedidoAdicional PedidoAdicional { get; set; }
        public ItemPedidoTipoBorda PedidoTipoBorda { get; set; }
        List<ItemPedido> Itens { get; set; }

        public Pedido() { }

        public Pedido(int id, DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDesconto, List<ItemPedido> itens)
        {
            Id = id;
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDesconto = classeDesconto;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDesconto)
        {
            Id = id;
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDesconto = classeDesconto;

        }

        public Pedido(DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDesconto)
        {
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDesconto = classeDesconto;
        }

        public Pedido(Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDesconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDesconto = classeDesconto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spdata_pedido", DataPedido);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spclasse_desconto_id", ClasseDesconto.Id);
            cmd.Parameters.AddWithValue("spstatus_id", StatusId.Id);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new(dr.GetInt32(0)
                    ,dr.GetDateTime(1)
                    , Usuario.ObterPorId(dr.GetInt32(2))
                    , Cliente.ObterPorId(dr.GetInt32(3))
                    ,Status.ObterPorId(dr.GetInt32(5))
                    , ClasseDesconto.ObterPorId(dr.GetInt32(4))
                     , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    );
            }

            return pedido;
        }
        public Pedido ObterPorClienteId(int ClienteId)
        {
            Pedido pedido = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {ClienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new(dr.GetInt32(0)
                    , dr.GetDateTime(1)
                    , Usuario.ObterPorId(dr.GetInt32(2))
                    , Cliente.ObterPorId(dr.GetInt32(3))
                    , Status.ObterPorId(dr.GetInt32(4))
                    , ClasseDesconto.ObterPorId(dr.GetInt32(5))
                    , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    
                    );
            }
            return pedido;
        }

        public static List<Pedido> ObterLista(Status statusid = null)
        {
            List<Pedido> pedido = new();
            var cmd = Banco.Abrir();
            if (statusid == null)
            {
                cmd.CommandText = "select * from pedidos";
            }
            else
            {
                cmd.CommandText = $"select * from pedidos where status = {statusid}";
            }

            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido.Add(new(dr.GetInt32(0)
                    , dr.GetDateTime(1)
                    , Usuario.ObterPorId(dr.GetInt32(2))
                    , Cliente.ObterPorId(dr.GetInt32(3))
                    , Status.ObterPorId(dr.GetInt32(4))
                    , ClasseDesconto.ObterPorId(dr.GetInt32(5))
                    , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))

                    ));


            }
            return pedido;
        }

        public bool Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spstatus_id", StatusId.Id);
            cmd.Parameters.AddWithValue("spclasse_desconto_id", ClasseDesconto.Id);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
          
            return true;
        }
        public bool Alterar(Status statusid)

        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update pedidos set status = {statusid} where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public static double CalcularPedido(int id)
        {
            return 0.0;
        }

    
        
    }
}
