using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class ExternalInvoiceHandleStateReqModelExt {
		
		///<summary>
		/// 入参集合
		///</summary>
		
		private List<com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel> queryModelList_;
		
		///<summary>
		/// 集合长度限制
		///</summary>
		
		private int? limit_;
		
		public List<com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel> GetQueryModelList(){
			return this.queryModelList_;
		}
		
		public void SetQueryModelList(List<com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel> value){
			this.queryModelList_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}