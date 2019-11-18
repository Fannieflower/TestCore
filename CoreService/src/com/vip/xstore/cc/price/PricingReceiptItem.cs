using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceiptItem {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 建议零售价
		///</summary>
		
		private string suggestionRetailPrice_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetSuggestionRetailPrice(){
			return this.suggestionRetailPrice_;
		}
		
		public void SetSuggestionRetailPrice(string value){
			this.suggestionRetailPrice_ = value;
		}
		
	}
	
}