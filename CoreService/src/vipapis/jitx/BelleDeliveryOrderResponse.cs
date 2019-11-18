using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class BelleDeliveryOrderResponse {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 寻仓订单列表
		///</summary>
		
		private List<vipapis.jitx.BelleDeliveryOrder> orders_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.BelleDeliveryOrder> GetOrders(){
			return this.orders_;
		}
		
		public void SetOrders(List<vipapis.jitx.BelleDeliveryOrder> value){
			this.orders_ = value;
		}
		
	}
	
}