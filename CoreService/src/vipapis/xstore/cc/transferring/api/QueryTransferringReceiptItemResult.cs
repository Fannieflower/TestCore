using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class QueryTransferringReceiptItemResult {
		
		///<summary>
		/// 调拨入库明细
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringReceivedItem> transferring_received_items_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<vipapis.xstore.cc.transferring.api.TransferringReceivedItem> GetTransferring_received_items(){
			return this.transferring_received_items_;
		}
		
		public void SetTransferring_received_items(List<vipapis.xstore.cc.transferring.api.TransferringReceivedItem> value){
			this.transferring_received_items_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}