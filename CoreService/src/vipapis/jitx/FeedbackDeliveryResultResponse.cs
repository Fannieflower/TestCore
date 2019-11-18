using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class FeedbackDeliveryResultResponse {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 结果代码：SUCCESS代表成功，FAIL代表失败
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 提示信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 当前状态
		///</summary>
		
		private string status_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		
	}
	
}