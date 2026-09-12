using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace TAEPClass
{
    public class ItemPedidoAdicional
    {

        public int Id { get; set; } 

        public int AdicionalId { get; set; }

        public int ItemPedidoId { get; set; }

        public ItemPedidoAdicional(int id, int adicionalId, int itemPedidoId)
        {
            Id = id;
            AdicionalId = adicionalId;
            ItemPedidoId = itemPedidoId;
        }

        public ItemPedidoAdicional(int adicionalId, int itemPedidoId)
        {
            AdicionalId = adicionalId;
            ItemPedidoId = itemPedidoId;
        }

       
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_adicionais_insert";
            cmd.Parameters.AddWithValue("spadicional_id", AdicionalId);
            cmd.Parameters.AddWithValue("spitem_pedido_id", ItemPedidoId);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }

        public static void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_adicionais_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }

        

    }
}
