using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class WayBillResponse {
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.vop.vcloud.common.api.Pagination pagination_;
		
		///<summary>
		/// 运单信息列表
		///</summary>
		
		private List<com.vip.vop.vcloud.order.WayBill> wayBills_;
		
		public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
			this.pagination_ = value;
		}
		public List<com.vip.vop.vcloud.order.WayBill> GetWayBills(){
			return this.wayBills_;
		}
		
		public void SetWayBills(List<com.vip.vop.vcloud.order.WayBill> value){
			this.wayBills_ = value;
		}
		
	}
	
}