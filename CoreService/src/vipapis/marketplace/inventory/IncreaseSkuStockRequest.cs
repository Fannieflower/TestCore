using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.inventory{
	
	
	
	
	
	public class IncreaseSkuStockRequest {
		
		///<summary>
		/// 商品skuID，对应prodSkuId
		/// @sampleValue sku_id SKU-B02C540000009F
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 商品库存数量
		/// @sampleValue quantity 20
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 批次号，同一个供应商id需保证batch_no不重复，batch_no长度不超过40
		///</summary>
		
		private string batch_no_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetBatch_no(){
			return this.batch_no_;
		}
		
		public void SetBatch_no(string value){
			this.batch_no_ = value;
		}
		
	}
	
}