using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class StoreProdItemPrice {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private string marketPrice_;
		
		///<summary>
		/// 销售价
		///</summary>
		
		private string salePrice_;
		
		///<summary>
		/// 建议零售价（定价或者调价的价格）
		///</summary>
		
		private string retailPrice_;
		
		///<summary>
		/// 销售价的价签，0=白标，1=黄标，2=红标
		///</summary>
		
		private byte? priceTag_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
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
		public byte? GetPriceTag(){
			return this.priceTag_;
		}
		
		public void SetPriceTag(byte? value){
			this.priceTag_ = value;
		}
		
	}
	
}