using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.inventory{
	
	
	
	
	
	public class InventoryFlowResult {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transactionId_;
		
		///<summary>
		/// 返回编码 0-成功
		/// @sampleValue code 0
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 错误原因
		/// @sampleValue message 成功
		///</summary>
		
		private string message_;
		
		public string GetTransactionId(){
			return this.transactionId_;
		}
		
		public void SetTransactionId(string value){
			this.transactionId_ = value;
		}
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