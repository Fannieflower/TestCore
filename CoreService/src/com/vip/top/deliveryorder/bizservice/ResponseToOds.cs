using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class ResponseToOds {
		
		///<summary>
		/// 原来订单下发的message_id(即ODS订单ID：order_id)
		///</summary>
		
		private string messageId_;
		
		///<summary>
		/// 处理结果编码：100成功，-1拒绝
		///</summary>
		
		private string result_;
		
		///<summary>
		/// 处理结果描述：处理成功或处理失败
		///</summary>
		
		private string dealMsg_;
		
		public string GetMessageId(){
			return this.messageId_;
		}
		
		public void SetMessageId(string value){
			this.messageId_ = value;
		}
		public string GetResult(){
			return this.result_;
		}
		
		public void SetResult(string value){
			this.result_ = value;
		}
		public string GetDealMsg(){
			return this.dealMsg_;
		}
		
		public void SetDealMsg(string value){
			this.dealMsg_ = value;
		}
		
	}
	
}