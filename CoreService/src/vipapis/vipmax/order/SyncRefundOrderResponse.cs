using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class SyncRefundOrderResponse {
		
		///<summary>
		/// 退货单商家订单号
		///</summary>
		
		private string refund_order_sn_;
		
		///<summary>
		/// 产生退货的原商家订单号
		///</summary>
		
		private string origin_out_order_sn_;
		
		public string GetRefund_order_sn(){
			return this.refund_order_sn_;
		}
		
		public void SetRefund_order_sn(string value){
			this.refund_order_sn_ = value;
		}
		public string GetOrigin_out_order_sn(){
			return this.origin_out_order_sn_;
		}
		
		public void SetOrigin_out_order_sn(string value){
			this.origin_out_order_sn_ = value;
		}
		
	}
	
}