using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class InvoiceIssueResultMessage {
		
		///<summary>
		/// 错误代码
		///</summary>
		
		private string errorCode_;
		
		///<summary>
		/// 错误消息
		///</summary>
		
		private string errorMessage_;
		
		public string GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(string value){
			this.errorCode_ = value;
		}
		public string GetErrorMessage(){
			return this.errorMessage_;
		}
		
		public void SetErrorMessage(string value){
			this.errorMessage_ = value;
		}
		
	}
	
}