using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	
	
	public class OutTpsResponse {
		
		///<summary>
		/// 结果代码
		///</summary>
		
		private int? resultCode_;
		
		///<summary>
		/// 结果描述
		///</summary>
		
		private string resultMessage_;
		
		///<summary>
		/// 返回成功交易流水号
		///</summary>
		
		private string transactionId_;
		
		public int? GetResultCode(){
			return this.resultCode_;
		}
		
		public void SetResultCode(int? value){
			this.resultCode_ = value;
		}
		public string GetResultMessage(){
			return this.resultMessage_;
		}
		
		public void SetResultMessage(string value){
			this.resultMessage_ = value;
		}
		public string GetTransactionId(){
			return this.transactionId_;
		}
		
		public void SetTransactionId(string value){
			this.transactionId_ = value;
		}
		
	}
	
}