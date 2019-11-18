using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class GoodsInfo {
		
		///<summary>
		/// pos系统的商品sku id
		///</summary>
		
		private string prod_sku_id_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 商品件数
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 商品价格
		///</summary>
		
		private string price_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public string GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(string value){
			this.price_ = value;
		}
		
	}
	
}