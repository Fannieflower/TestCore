using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringReceivedItem {
		
		///<summary>
		/// 中台新条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 调拨入库数量
		///</summary>
		
		private int? received_quantity_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetReceived_quantity(){
			return this.received_quantity_;
		}
		
		public void SetReceived_quantity(int? value){
			this.received_quantity_ = value;
		}
		
	}
	
}