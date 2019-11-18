using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.common.process.template{
	
	
	
	
	
	public class CreateProcessTemplateResp {
		
		///<summary>
		/// 结果代码，0=失败，1=成功
		///</summary>
		
		private int? resultCode_;
		
		///<summary>
		/// 提示信息
		///</summary>
		
		private string message_;
		
		public int? GetResultCode(){
			return this.resultCode_;
		}
		
		public void SetResultCode(int? value){
			this.resultCode_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}