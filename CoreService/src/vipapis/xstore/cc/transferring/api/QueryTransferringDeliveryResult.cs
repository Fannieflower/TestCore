using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class QueryTransferringDeliveryResult {
		
		///<summary>
		/// 调拨单出库记录
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList> transferring_orders_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList> GetTransferring_orders(){
			return this.transferring_orders_;
		}
		
		public void SetTransferring_orders(List<vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList> value){
			this.transferring_orders_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}