using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class StatPoCommonResp {
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.cc.bulkbuying.model.PaginationModel pagination_;
		
		public com.vip.xstore.cc.bulkbuying.model.PaginationModel GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.xstore.cc.bulkbuying.model.PaginationModel value){
			this.pagination_ = value;
		}
		
	}
	
}