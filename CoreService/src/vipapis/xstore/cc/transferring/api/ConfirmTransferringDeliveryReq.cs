using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class ConfirmTransferringDeliveryReq {
		
		///<summary>
		/// 中台调拨单号
		///</summary>
		
		private List<string> transferring_order_no_;
		
		public List<string> GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(List<string> value){
			this.transferring_order_no_ = value;
		}
		
	}
	
}