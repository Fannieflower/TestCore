using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class QueryPricingReceiptResp {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 变价单列表
		///</summary>
		
		private List<vipapis.xstore.cc.price.api.PricingReceipt> pricing_receipts_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.price.api.PricingReceipt> GetPricing_receipts(){
			return this.pricing_receipts_;
		}
		
		public void SetPricing_receipts(List<vipapis.xstore.cc.price.api.PricingReceipt> value){
			this.pricing_receipts_ = value;
		}
		
	}
	
}