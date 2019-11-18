using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class ProdItemPrice {
		
		///<summary>
		/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 市场价，单位元
		///</summary>
		
		private string marketPrice_;
		
		///<summary>
		/// 销售价，单位元
		///</summary>
		
		private string salePrice_;
		
		///<summary>
		/// 建议零售价，单位元
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
		public string GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(string value){
			this.salePrice_ = value;
		}
		public string GetRetailPrice(){
			return this.retailPrice_;
		}
		
		public void SetRetailPrice(string value){
			this.retailPrice_ = value;
		}
		
	}
	
}