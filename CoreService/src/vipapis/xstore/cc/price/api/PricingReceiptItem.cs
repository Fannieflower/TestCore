using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class PricingReceiptItem {
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 建议零售价
		///</summary>
		
		private string suggestion_retail_price_;
		
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetSuggestion_retail_price(){
			return this.suggestion_retail_price_;
		}
		
		public void SetSuggestion_retail_price(string value){
			this.suggestion_retail_price_ = value;
		}
		
	}
	
}