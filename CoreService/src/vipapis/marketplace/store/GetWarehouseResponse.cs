using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.store{
	
	
	
	
	
	public class GetWarehouseResponse {
		
		///<summary>
		/// 仓库信息列表
		///</summary>
		
		private List<vipapis.marketplace.store.Warehouse> warehouse_;
		
		public List<vipapis.marketplace.store.Warehouse> GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(List<vipapis.marketplace.store.Warehouse> value){
			this.warehouse_ = value;
		}
		
	}
	
}