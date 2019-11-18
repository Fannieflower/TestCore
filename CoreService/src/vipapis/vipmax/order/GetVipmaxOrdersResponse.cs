using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class GetVipmaxOrdersResponse {
		
		///<summary>
		/// 是否有下页
		///</summary>
		
		private bool? has_next_;
		
		///<summary>
		/// 订单列表
		///</summary>
		
		private List<vipapis.vipmax.order.VipmaxOrder> vipmax_orders_;
		
		public bool? GetHas_next(){
			return this.has_next_;
		}
		
		public void SetHas_next(bool? value){
			this.has_next_ = value;
		}
		public List<vipapis.vipmax.order.VipmaxOrder> GetVipmax_orders(){
			return this.vipmax_orders_;
		}
		
		public void SetVipmax_orders(List<vipapis.vipmax.order.VipmaxOrder> value){
			this.vipmax_orders_ = value;
		}
		
	}
	
}