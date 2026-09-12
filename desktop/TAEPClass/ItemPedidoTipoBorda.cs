using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public class ItemPedidoTipoBorda
    {
       

        public int Id { get; set; }


        public int PedidoId { get; set; }

        public int TipoBordaId { get; set; }

        public ItemPedidoTipoBorda(int id, int pedidoId,int tipoBordaId)
        {
            Id = id;
            PedidoId = pedidoId;
            TipoBordaId = tipoBordaId;
            
        }

        public ItemPedidoTipoBorda(int pedidoId, int tipoBordaId)
        {
            PedidoId = pedidoId;
            TipoBordaId = tipoBordaId;
            
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_tipoborda_insert";
            cmd.Parameters.AddWithValue("sppedido_id", PedidoId);
            cmd.Parameters.AddWithValue("sptipoborda_id", TipoBordaId);
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
