using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class InventoryUpdateRequest {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string trans_id_;
		
		///<summary>
		/// 合作伙伴ID
		///</summary>
		
		private long? partner_id_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_code_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 可用库存
		///</summary>
		
		private int? quantity_;
		
		public string GetTrans_id(){
			return this.trans_id_;
		}
		
		public void SetTrans_id(string value){
			this.trans_id_ = value;
		}
		public long? GetPartner_id(){
			return this.partner_id_;
		}
		
		public void SetPartner_id(long? value){
			this.partner_id_ = value;
		}
		public string GetWarehouse_code(){
			return this.warehouse_code_;
		}
		
		public void SetWarehouse_code(string value){
			this.warehouse_code_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		
	}
	
}