using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseInventoryLogQueryResult {
		
		///<summary>
		/// 日志列表
		///</summary>
		
		private List<com.vip.vop.vcloud.inventory.api.WarehouseInventoryLog> list_;
		
		///<summary>
		/// 分页结构体
		///</summary>
		
		private com.vip.vop.vcloud.common.api.Pagination pagination_;
		
		public List<com.vip.vop.vcloud.inventory.api.WarehouseInventoryLog> GetList(){
			return this.list_;
		}
		
		public void SetList(List<com.vip.vop.vcloud.inventory.api.WarehouseInventoryLog> value){
			this.list_ = value;
		}
		public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
			this.pagination_ = value;
		}
		
	}
	
}