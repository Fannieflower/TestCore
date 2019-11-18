using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class ResultCode {
		
		///<summary>
		/// 响应码，200=成功
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 响应信息
		///</summary>
		
		private string message_;
		
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}