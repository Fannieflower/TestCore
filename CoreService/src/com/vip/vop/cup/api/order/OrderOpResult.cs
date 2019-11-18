using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderOpResult {
		
		///<summary>
		/// 处理结果信息
		///</summary>
		
		private com.vip.vop.cup.api.order.Result result_;
		
		///<summary>
		/// 处理成功的外部订单号列表
		///</summary>
		
		private List<string> succ_order_sn_list_;
		
		///<summary>
		/// 处理失败的外部订单号列表以及失败描述
		///</summary>
		
		private List<com.vip.vop.cup.api.order.FailMsg> failed_order_sn_list_;
		
		public com.vip.vop.cup.api.order.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.order.Result value){
			this.result_ = value;
		}
		public List<string> GetSucc_order_sn_list(){
			return this.succ_order_sn_list_;
		}
		
		public void SetSucc_order_sn_list(List<string> value){
			this.succ_order_sn_list_ = value;
		}
		public List<com.vip.vop.cup.api.order.FailMsg> GetFailed_order_sn_list(){
			return this.failed_order_sn_list_;
		}
		
		public void SetFailed_order_sn_list(List<com.vip.vop.cup.api.order.FailMsg> value){
			this.failed_order_sn_list_ = value;
		}
		
	}
	
}