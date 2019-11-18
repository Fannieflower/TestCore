using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service.common{
	
	
	
	
	
	public class CodeResult {
		
		///<summary>
		/// 结果码，默认SUCCESS
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 结果消息
		///</summary>
		
		private string message_;
		
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
		
	}
	
}