using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class QueryTransferringDeliveryItemResult {
		
		///<summary>
		/// 调拨出库明细
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringDeliveryItem> transferring_delivery_items_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<vipapis.xstore.cc.transferring.api.TransferringDeliveryItem> GetTransferring_delivery_items(){
			return this.transferring_delivery_items_;
		}
		
		public void SetTransferring_delivery_items(List<vipapis.xstore.cc.transferring.api.TransferringDeliveryItem> value){
			this.transferring_delivery_items_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}