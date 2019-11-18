using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class SalesWarehouse {
		
		///<summary>
		/// 专场No
		///</summary>
		
		private long? salesNo_;
		
		///<summary>
		/// 仓库名称（中文）
		///</summary>
		
		private string warehouseCN_;
		
		public long? GetSalesNo(){
			return this.salesNo_;
		}
		
		public void SetSalesNo(long? value){
			this.salesNo_ = value;
		}
		public string GetWarehouseCN(){
			return this.warehouseCN_;
		}
		
		public void SetWarehouseCN(string value){
			this.warehouseCN_ = value;
		}
		
	}
	
}