using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class ConfirmPoWarehouseReceiptReq {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 入库批次号
		///</summary>
		
		private string warehouse_receipt_no_;
		
		///<summary>
		/// 外部的入库单号
		///</summary>
		
		private string outer_no_;
		
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public string GetWarehouse_receipt_no(){
			return this.warehouse_receipt_no_;
		}
		
		public void SetWarehouse_receipt_no(string value){
			this.warehouse_receipt_no_ = value;
		}
		public string GetOuter_no(){
			return this.outer_no_;
		}
		
		public void SetOuter_no(string value){
			this.outer_no_ = value;
		}
		
	}
	
}