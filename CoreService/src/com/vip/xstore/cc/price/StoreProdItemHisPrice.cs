using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class StoreProdItemHisPrice {
		
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
		/// 建议零售价、定价或者调价的价格
		///</summary>
		
		private string retailPrice_;
		
		///<summary>
		/// 建议零售价生效时间
		///</summary>
		
		private System.DateTime? retailPriceEffectiveTime_;
		
		///<summary>
		/// 市场价，对应gpdc市场价
		///</summary>
		
		private string marketPrice_;
		
		///<summary>
		/// 销售价
		///</summary>
		
		private string salePrice_;
		
		///<summary>
		/// 销售价生效时间
		///</summary>
		
		private System.DateTime? salePriceEffectiveTime_;
		
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
		public string GetRetailPrice(){
			return this.retailPrice_;
		}
		
		public void SetRetailPrice(string value){
			this.retailPrice_ = value;
		}
		public System.DateTime? GetRetailPriceEffectiveTime(){
			return this.retailPriceEffectiveTime_;
		}
		
		public void SetRetailPriceEffectiveTime(System.DateTime? value){
			this.retailPriceEffectiveTime_ = value;
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
		public System.DateTime? GetSalePriceEffectiveTime(){
			return this.salePriceEffectiveTime_;
		}
		
		public void SetSalePriceEffectiveTime(System.DateTime? value){
			this.salePriceEffectiveTime_ = value;
		}
		
	}
	
}