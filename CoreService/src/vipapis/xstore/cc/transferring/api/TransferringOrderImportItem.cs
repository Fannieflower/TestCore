using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderImportItem {
		
		///<summary>
		/// 调拨单Item Id
		///</summary>
		
		private long? item_id_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 计划调拨数量
		///</summary>
		
		private int? planned_item_quantity_;
		
		///<summary>
		/// 实际冻结数量
		///</summary>
		
		private int? frozen_item_quantity_;
		
		public long? GetItem_id(){
			return this.item_id_;
		}
		
		public void SetItem_id(long? value){
			this.item_id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetPlanned_item_quantity(){
			return this.planned_item_quantity_;
		}
		
		public void SetPlanned_item_quantity(int? value){
			this.planned_item_quantity_ = value;
		}
		public int? GetFrozen_item_quantity(){
			return this.frozen_item_quantity_;
		}
		
		public void SetFrozen_item_quantity(int? value){
			this.frozen_item_quantity_ = value;
		}
		
	}
	
}