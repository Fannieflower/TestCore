using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class QueryPricingReceiptItemResp {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 价格变更单明细列表
		///</summary>
		
		private List<vipapis.xstore.cc.price.api.PricingReceiptItem> pricing_receipt_items_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.price.api.PricingReceiptItem> GetPricing_receipt_items(){
			return this.pricing_receipt_items_;
		}
		
		public void SetPricing_receipt_items(List<vipapis.xstore.cc.price.api.PricingReceiptItem> value){
			this.pricing_receipt_items_ = value;
		}
		
	}
	
}