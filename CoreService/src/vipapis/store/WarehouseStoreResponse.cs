using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.store{
	
	
	
	
	
	public class WarehouseStoreResponse {
		
		///<summary>
		/// 分区仓库门店信息
		/// @sampleValue warehouse_store 
		///</summary>
		
		private Dictionary<string, List<vipapis.store.StoreInfo>> warehouse_store_;
		
		public Dictionary<string, List<vipapis.store.StoreInfo>> GetWarehouse_store(){
			return this.warehouse_store_;
		}
		
		public void SetWarehouse_store(Dictionary<string, List<vipapis.store.StoreInfo>> value){
			this.warehouse_store_ = value;
		}
		
	}
	
}