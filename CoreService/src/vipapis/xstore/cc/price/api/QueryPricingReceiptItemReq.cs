using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class QueryPricingReceiptItemReq {
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数，最大为100
		///</summary>
		
		private int? page_size_;
		
		///<summary>
		/// 价格变更单号
		///</summary>
		
		private string pricing_no_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPage_size(){
			return this.page_size_;
		}
		
		public void SetPage_size(int? value){
			this.page_size_ = value;
		}
		public string GetPricing_no(){
			return this.pricing_no_;
		}
		
		public void SetPricing_no(string value){
			this.pricing_no_ = value;
		}
		
	}
	
}