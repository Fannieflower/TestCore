using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class StoreProdItemSalePrice {
		
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
		/// 价签，0=白标，1=黄标，2=红标
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
		public string GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(string value){
			this.salePrice_ = value;
		}
		public byte? GetPriceTag(){
			return this.priceTag_;
		}
		
		public void SetPriceTag(byte? value){
			this.priceTag_ = value;
		}
		
	}
	
}