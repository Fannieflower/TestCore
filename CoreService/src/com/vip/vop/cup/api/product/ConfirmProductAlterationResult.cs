using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ConfirmProductAlterationResult {
		
		///<summary>
		/// 错误码
		///</summary>
		
		private int? errorCode_;
		
		///<summary>
		/// 执行结果：true代表成功，false代表失败。为true时，code=200；为false时code代表错误码，message代表失败原因
		///</summary>
		
		private bool? result_;
		
		///<summary>
		/// result为false时message代表失败原因
		///</summary>
		
		private string message_;
		
		public int? GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(int? value){
			this.errorCode_ = value;
		}
		public bool? GetResult(){
			return this.result_;
		}
		
		public void SetResult(bool? value){
			this.result_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}