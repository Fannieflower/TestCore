using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class GetOrderTransportInfoResult {
		
		///<summary>
		/// 处理结果
		///</summary>
		
		private com.vip.vop.cup.api.order.Result result_;
		
		///<summary>
		/// 订单物流轨迹信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.order.OrderTransportInfo> order_transport_info_list_;
		
		public com.vip.vop.cup.api.order.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.order.Result value){
			this.result_ = value;
		}
		public List<com.vip.vop.cup.api.order.OrderTransportInfo> GetOrder_transport_info_list(){
			return this.order_transport_info_list_;
		}
		
		public void SetOrder_transport_info_list(List<com.vip.vop.cup.api.order.OrderTransportInfo> value){
			this.order_transport_info_list_ = value;
		}
		
	}
	
}