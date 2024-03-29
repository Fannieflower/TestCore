using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.inventory{
	
	
	
	
	
	public class IncreaseStoreSkuStock {
		
		///<summary>
		/// 店铺id
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 商品sku编号
		///</summary>
		
		private string productSkuId_;
		
		///<summary>
		/// 库存数量，全量更新时不能为负数
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 批次号，同一个供应商id需保证batch_no不重复，batch_no长度不超过40
		///</summary>
		
		private string batchNo_;
		
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public string GetProductSkuId(){
			return this.productSkuId_;
		}
		
		public void SetProductSkuId(string value){
			this.productSkuId_ = value;
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
		public string GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(string value){
			this.batchNo_ = value;
		}
		
	}
	
}