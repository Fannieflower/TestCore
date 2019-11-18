using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.store{
	
	
	
	
	
	public class WarehouseStoreRequest {
		
		///<summary>
		/// 供应商ID
		/// @sampleValue vendor_id 550
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 仓库编码
		/// @sampleValue warehouse_code 
		///</summary>
		
		private List<string> warehouse_code_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<string> GetWarehouse_code(){
			return this.warehouse_code_;
		}
		
		public void SetWarehouse_code(List<string> value){
			this.warehouse_code_ = value;
		}
		
	}
	
}