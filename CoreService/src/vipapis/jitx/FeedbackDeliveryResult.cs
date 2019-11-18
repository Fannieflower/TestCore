using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class FeedbackDeliveryResult {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 寻仓结果;成功：SUCCESS; 失败:FAIL
		///</summary>
		
		private string feedback_status_;
		
		///<summary>
		/// 仓库编码，如果是feedback_state = SUCCESS，则从avaliable_warehouses内选择其中一个写值如果是feedback_state = FAIL，则该值应为空
		///</summary>
		
		private string warehouse_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetFeedback_status(){
			return this.feedback_status_;
		}
		
		public void SetFeedback_status(string value){
			this.feedback_status_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		
	}
	
}