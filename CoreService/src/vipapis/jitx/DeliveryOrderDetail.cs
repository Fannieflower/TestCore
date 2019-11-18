using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class DeliveryOrderDetail {
		
		///<summary>
		/// 商品品牌
		///</summary>
		
		private string brand_name_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string product_name_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 商品尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string po_no_;
		
		///<summary>
		/// 常态合作编码
		///</summary>
		
		private string cooperation_no_;
		
		///<summary>
		/// 单价
		///</summary>
		
		private string price_;
		
		public string GetBrand_name(){
			return this.brand_name_;
		}
		
		public void SetBrand_name(string value){
			this.brand_name_ = value;
		}
		public string GetProduct_name(){
			return this.product_name_;
		}
		
		public void SetProduct_name(string value){
			this.product_name_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public string GetPo_no(){
			return this.po_no_;
		}
		
		public void SetPo_no(string value){
			this.po_no_ = value;
		}
		public string GetCooperation_no(){
			return this.cooperation_no_;
		}
		
		public void SetCooperation_no(string value){
			this.cooperation_no_ = value;
		}
		public string GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(string value){
			this.price_ = value;
		}
		
	}
	
}