using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseSkuInventoryUpdateReq {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// sku id
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 库存数量
		///</summary>
		
		private int? quantity_;
		
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public long? GetWarehouseId(){
			return this.warehouseId_;
		}
		
		public void SetWarehouseId(long? value){
			this.warehouseId_ = value;
		}
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		
	}
	
}