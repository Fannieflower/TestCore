using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class QueryPurchaseOrderResp {
		
		///<summary>
		/// 总记录数
		/// @sampleValue total 100
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 采购单列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrder> purchase_orders_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrder> GetPurchase_orders(){
			return this.purchase_orders_;
		}
		
		public void SetPurchase_orders(List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrder> value){
			this.purchase_orders_ = value;
		}
		
	}
	
}