using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Order
	{
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string Reciver { get; set; }
		public string Phones { get; set; }
		public string Address { get; set; }
		public int ShipFee { get; set; }
		public string? Description { get; set; }
		public string? ModifyNote { get; set; }
		public DateTime? ModifyDate { get; set; }
		public DateTime? AcceptDate { get; set;}
		public DateTime? DeliveryDate { get; set; }
		public DateTime? ReciveDate { get; set; }
		public DateTime? PaymentDate { get; set; }
		public DateTime CreatedDate { get; set; }
		public Guid Id_User { get; set; }
		public Guid Id_Status { get; set; }
		public virtual User User { get; set; }
		public virtual StatusOrder StatusOrder { get; set; }
		public virtual List<OrderDetail> OrderDetails { get; set; }
		public virtual List<ReturnOrder> ReturnOrders { get; set; }
		public virtual List<PaymentOrder> PaymentOrders { get; set; }
	}
}
