using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringDeliveryItem {
		
		///<summary>
		/// 中台新条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 调拨出库数量
		///</summary>
		
		private int? delivery_quantity_;
		
		///<summary>
		/// 箱号
		///</summary>
		
		private string container_no_;
		
		///<summary>
		/// 事务ID
		///</summary>
		
		private string tx_id_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetDelivery_quantity(){
			return this.delivery_quantity_;
		}
		
		public void SetDelivery_quantity(int? value){
			this.delivery_quantity_ = value;
		}
		public string GetContainer_no(){
			return this.container_no_;
		}
		
		public void SetContainer_no(string value){
			this.container_no_ = value;
		}
		public string GetTx_id(){
			return this.tx_id_;
		}
		
		public void SetTx_id(string value){
			this.tx_id_ = value;
		}
		
	}
	
}