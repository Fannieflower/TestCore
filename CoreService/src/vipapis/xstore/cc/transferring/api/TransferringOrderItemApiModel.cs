using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderItemApiModel {
		
		///<summary>
		/// 中台调拨单号
		///</summary>
		
		private string transferring_order_no_;
		
		///<summary>
		/// 中台条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// PO编号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 下达调拨数量
		///</summary>
		
		private int? transferring_quantity_;
		
		public string GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(string value){
			this.transferring_order_no_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public int? GetTransferring_quantity(){
			return this.transferring_quantity_;
		}
		
		public void SetTransferring_quantity(int? value){
			this.transferring_quantity_ = value;
		}
		
	}
	
}