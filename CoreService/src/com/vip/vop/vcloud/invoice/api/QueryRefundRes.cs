using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	
	
	public class QueryRefundRes {
		
		///<summary>
		/// 列表
		///</summary>
		
		private List<com.vip.vop.vcloud.invoice.api.Refund> refunds_;
		
		///<summary>
		/// 分页
		///</summary>
		
		private com.vip.vop.vcloud.common.api.Pagination pagination_;
		
		public List<com.vip.vop.vcloud.invoice.api.Refund> GetRefunds(){
			return this.refunds_;
		}
		
		public void SetRefunds(List<com.vip.vop.vcloud.invoice.api.Refund> value){
			this.refunds_ = value;
		}
		public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
			this.pagination_ = value;
		}
		
	}
	
}