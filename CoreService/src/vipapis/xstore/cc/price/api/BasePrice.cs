using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class BasePrice {
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 建议零售价
		///</summary>
		
		private string suggestion_retail_price_;
		
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