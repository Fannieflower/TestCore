using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class ProdItemRetailPrice {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private string marketPrice_;
		
		///<summary>
		/// 零售价（定价或者调价的价格）
		///</summary>
		
		private string retailPrice_;
		
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
		public string GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(string value){
			this.marketPrice_ = value;
		}
		public string GetRetailPrice(){
			return this.retailPrice_;
		}
		
		public void SetRetailPrice(string value){
			this.retailPrice_ = value;
		}
		
	}
	
}