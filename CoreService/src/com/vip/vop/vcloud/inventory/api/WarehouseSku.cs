using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseSku {
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// sku id
		///</summary>
		
		private long? skuId_;
		
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
		
	}
	
}