using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class StatPoCommonReq {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 分组信息
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.service.StatPoGroupType?> groupTypes_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数
		///</summary>
		
		private int? pageSize_;
		
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public List<com.vip.xstore.cc.bulkbuying.service.StatPoGroupType?> GetGroupTypes(){
			return this.groupTypes_;
		}
		
		public void SetGroupTypes(List<com.vip.xstore.cc.bulkbuying.service.StatPoGroupType?> value){
			this.groupTypes_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}