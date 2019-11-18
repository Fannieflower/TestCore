using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseInventoryLogQueryCriteria {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数据源, 0:调整单, 1: 订单发货, 2:ERP同步
		///</summary>
		
		private int? source_;
		
		///<summary>
		/// 开始时间
		///</summary>
		
		private System.DateTime? startDate_;
		
		///<summary>
		/// 结束时间
		///</summary>
		
		private System.DateTime? endDate_;
		
		///<summary>
		/// skuId
		///</summary>
		
		private long? skuId_;
		
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public long? GetWarehouseId(){
			return this.warehouseId_;
		}
		
		public void SetWarehouseId(long? value){
			this.warehouseId_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetSource(){
			return this.source_;
		}
		
		public void SetSource(int? value){
			this.source_ = value;
		}
		public System.DateTime? GetStartDate(){
			return this.startDate_;
		}
		
		public void SetStartDate(System.DateTime? value){
			this.startDate_ = value;
		}
		public System.DateTime? GetEndDate(){
			return this.endDate_;
		}
		
		public void SetEndDate(System.DateTime? value){
			this.endDate_ = value;
		}
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		
	}
	
}