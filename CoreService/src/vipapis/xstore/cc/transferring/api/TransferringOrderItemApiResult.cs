using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderItemApiResult {
		
		///<summary>
		/// 中台调拨单
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel> transferring_order_items_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel> GetTransferring_order_items(){
			return this.transferring_order_items_;
		}
		
		public void SetTransferring_order_items(List<vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel> value){
			this.transferring_order_items_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}