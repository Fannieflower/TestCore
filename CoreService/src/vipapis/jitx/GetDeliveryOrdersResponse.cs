using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetDeliveryOrdersResponse {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 寻仓订单列表
		///</summary>
		
		private List<vipapis.jitx.DeliveryOrder> delivery_orders_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.DeliveryOrder> GetDelivery_orders(){
			return this.delivery_orders_;
		}
		
		public void SetDelivery_orders(List<vipapis.jitx.DeliveryOrder> value){
			this.delivery_orders_ = value;
		}
		
	}
	
}