using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class StoreProdItemHisSalePrice {
		
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
		/// 销售价
		///</summary>
		
		private string salePrice_;
		
		///<summary>
		/// 生效时间
		///</summary>
		
		private System.DateTime? effectiveTime_;
		
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
		public string GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(string value){
			this.salePrice_ = value;
		}
		public System.DateTime? GetEffectiveTime(){
			return this.effectiveTime_;
		}
		
		public void SetEffectiveTime(System.DateTime? value){
			this.effectiveTime_ = value;
		}
		
	}
	
}