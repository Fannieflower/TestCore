using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class QueryPurchaseOrderItemResp {
		
		///<summary>
		/// 采购单明细列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem> items_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem> value){
			this.items_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}