using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class RejectApplyRefundRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 操作人信息
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 确认退款备注
		///</summary>
		
		private string opinion_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public string GetOpinion(){
			return this.opinion_;
		}
		
		public void SetOpinion(string value){
			this.opinion_ = value;
		}
		
	}
	
}