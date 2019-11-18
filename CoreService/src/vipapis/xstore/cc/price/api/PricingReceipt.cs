using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class PricingReceipt {
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 价格变更单号
		///</summary>
		
		private string pricing_no_;
		
		///<summary>
		/// 价格变更单创建时间
		///</summary>
		
		private System.DateTime? create_time_;
		
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public string GetPricing_no(){
			return this.pricing_no_;
		}
		
		public void SetPricing_no(string value){
			this.pricing_no_ = value;
		}
		public System.DateTime? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(System.DateTime? value){
			this.create_time_ = value;
		}
		
	}
	
}