using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderApiConfirmQuery {
		
		///<summary>
		/// 单据编号
		///</summary>
		
		private string transferring_order_no_;
		
		///<summary>
		/// 调拨单状态 created/cancelled
		///</summary>
		
		private string status_;
		
		public string GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(string value){
			this.transferring_order_no_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		
	}
	
}