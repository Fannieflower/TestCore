using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class UpdateTransferringWopReceivedQuantityResult {
		
		///<summary>
		/// 返回状态码；成功：200
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string message_;
		
		///<summary>
		/// 更新结果
		///</summary>
		
		private Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo> results_;
		
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
		public Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo> GetResults(){
			return this.results_;
		}
		
		public void SetResults(Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo> value){
			this.results_ = value;
		}
		
	}
	
}