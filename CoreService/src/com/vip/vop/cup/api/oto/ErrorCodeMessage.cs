using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.oto{
	
	
	
	
	
	public class ErrorCodeMessage {
		
		///<summary>
		/// 错误码
		///</summary>
		
		private string error_code_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string message_;
		
		public string GetError_code(){
			return this.error_code_;
		}
		
		public void SetError_code(string value){
			this.error_code_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}