using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class OxoReturnOrderResponse {
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? has_next_;
		
		///<summary>
		/// 退货订单列表
		///</summary>
		
		private List<vipapis.order.OxoReturnOrder> oxo_return_orders_;
		
		public bool? GetHas_next(){
			return this.has_next_;
		}
		
		public void SetHas_next(bool? value){
			this.has_next_ = value;
		}
		public List<vipapis.order.OxoReturnOrder> GetOxo_return_orders(){
			return this.oxo_return_orders_;
		}
		
		public void SetOxo_return_orders(List<vipapis.order.OxoReturnOrder> value){
			this.oxo_return_orders_ = value;
		}
		
	}
	
}