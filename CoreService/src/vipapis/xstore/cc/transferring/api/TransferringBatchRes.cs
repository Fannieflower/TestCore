using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringBatchRes {
		
		///<summary>
		/// 响应码,200:成功,其他失败
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 错误信息
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