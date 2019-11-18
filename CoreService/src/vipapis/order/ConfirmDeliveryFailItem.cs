using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class ConfirmDeliveryFailItem {
		
		///<summary>
		/// 状态码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 消息
		///</summary>
		
		private string message_;
		
		///<summary>
		/// 请求对象
		///</summary>
		
		private vipapis.order.ConfirmDelivery item_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		public vipapis.order.ConfirmDelivery GetItem(){
			return this.item_;
		}
		
		public void SetItem(vipapis.order.ConfirmDelivery value){
			this.item_ = value;
		}
		
	}
	
}