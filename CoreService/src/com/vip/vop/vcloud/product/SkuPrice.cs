using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class SkuPrice {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private string partnerId_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private double? marketPrice_;
		
		///<summary>
		/// 折扣价
		///</summary>
		
		private double? foorPrice_;
		
		///<summary>
		/// 零售价
		///</summary>
		
		private double? retailPrice_;
		
		///<summary>
		/// 折扣开始时间
		///</summary>
		
		private System.DateTime? specialFrom_;
		
		///<summary>
		/// 折扣结束时间
		///</summary>
		
		private System.DateTime? specialTo_;
		
		public string GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(string value){
			this.partnerId_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public double? GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(double? value){
			this.marketPrice_ = value;
		}
		public double? GetFoorPrice(){
			return this.foorPrice_;
		}
		
		public void SetFoorPrice(double? value){
			this.foorPrice_ = value;
		}
		public double? GetRetailPrice(){
			return this.retailPrice_;
		}
		
		public void SetRetailPrice(double? value){
			this.retailPrice_ = value;
		}
		public System.DateTime? GetSpecialFrom(){
			return this.specialFrom_;
		}
		
		public void SetSpecialFrom(System.DateTime? value){
			this.specialFrom_ = value;
		}
		public System.DateTime? GetSpecialTo(){
			return this.specialTo_;
		}
		
		public void SetSpecialTo(System.DateTime? value){
			this.specialTo_ = value;
		}
		
	}
	
}