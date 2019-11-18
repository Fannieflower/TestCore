using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PoWarehouseReceiptQty {
		
		///<summary>
		/// 事务号(明细行的唯一标识)
		///</summary>
		
		private string txid_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 收货数量
		///</summary>
		
		private int? receive_quantity_;
		
		public string GetTxid(){
			return this.txid_;
		}
		
		public void SetTxid(string value){
			this.txid_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetReceive_quantity(){
			return this.receive_quantity_;
		}
		
		public void SetReceive_quantity(int? value){
			this.receive_quantity_ = value;
		}
		
	}
	
}