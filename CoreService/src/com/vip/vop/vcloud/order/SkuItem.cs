using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class SkuItem {
		
		///<summary>
		/// SKUID
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string productName_;
		
		///<summary>
		/// 颜色
		///</summary>
		
		private string color_;
		
		///<summary>
		/// 尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 颜色码
		///</summary>
		
		private string colorCode_;
		
		///<summary>
		/// spu
		///</summary>
		
		private string spu_;
		
		///<summary>
		/// barcode
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// categoryName
		///</summary>
		
		private string categoryName_;
		
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		public string GetProductName(){
			return this.productName_;
		}
		
		public void SetProductName(string value){
			this.productName_ = value;
		}
		public string GetColor(){
			return this.color_;
		}
		
		public void SetColor(string value){
			this.color_ = value;
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
		public string GetColorCode(){
			return this.colorCode_;
		}
		
		public void SetColorCode(string value){
			this.colorCode_ = value;
		}
		public string GetSpu(){
			return this.spu_;
		}
		
		public void SetSpu(string value){
			this.spu_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetCategoryName(){
			return this.categoryName_;
		}
		
		public void SetCategoryName(string value){
			this.categoryName_ = value;
		}
		
	}
	
}