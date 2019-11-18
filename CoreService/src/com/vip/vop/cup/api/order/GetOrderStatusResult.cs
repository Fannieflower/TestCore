using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class GetOrderStatusResult {
		
		///<summary>
		/// 处理结果
		///</summary>
		
		private com.vip.vop.cup.api.order.Result result_;
		
		///<summary>
		/// 订单状态信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.order.OrderStatusInfo> order_status_info_list_;
		
		public com.vip.vop.cup.api.order.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.order.Result value){
			this.result_ = value;
		}
		public List<com.vip.vop.cup.api.order.OrderStatusInfo> GetOrder_status_info_list(){
			return this.order_status_info_list_;
		}
		
		public void SetOrder_status_info_list(List<com.vip.vop.cup.api.order.OrderStatusInfo> value){
			this.order_status_info_list_ = value;
		}
		
	}
	
}