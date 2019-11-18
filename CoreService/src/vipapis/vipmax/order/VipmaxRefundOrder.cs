using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class VipmaxRefundOrder {
		
		///<summary>
		/// 退货单商家订单号
		///</summary>
		
		private string refund_order_sn_;
		
		///<summary>
		/// 退货时间
		///</summary>
		
		private System.DateTime? refund_time_;
		
		///<summary>
		/// 退货单明细
		///</summary>
		
		private List<vipapis.vipmax.order.VipmaxRefundOrderDetail> refund_order_detail_;
		
		public string GetRefund_order_sn(){
			return this.refund_order_sn_;
		}
		
		public void SetRefund_order_sn(string value){
			this.refund_order_sn_ = value;
		}
		public System.DateTime? GetRefund_time(){
			return this.refund_time_;
		}
		
		public void SetRefund_time(System.DateTime? value){
			this.refund_time_ = value;
		}
		public List<vipapis.vipmax.order.VipmaxRefundOrderDetail> GetRefund_order_detail(){
			return this.refund_order_detail_;
		}
		
		public void SetRefund_order_detail(List<vipapis.vipmax.order.VipmaxRefundOrderDetail> value){
			this.refund_order_detail_ = value;
		}
		
	}
	
}