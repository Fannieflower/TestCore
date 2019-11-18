using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringBatchSubmitRes {
		
		///<summary>
		/// 响应码,200:成功,其他失败
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string message_;
		
		///<summary>
		/// 调拨单号
		///</summary>
		
		private string transferring_no_;
		
		///<summary>
		/// 调拨单明细
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringOrderImportItem> items_;
		
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
		public string GetTransferring_no(){
			return this.transferring_no_;
		}
		
		public void SetTransferring_no(string value){
			this.transferring_no_ = value;
		}
		public List<vipapis.xstore.cc.transferring.api.TransferringOrderImportItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<vipapis.xstore.cc.transferring.api.TransferringOrderImportItem> value){
			this.items_ = value;
		}
		
	}
	
}