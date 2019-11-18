using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class VipmaxOrderDetail {
		
		///<summary>
		/// 商品SKU
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 商品单价
		///</summary>
		
		private double? price_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string title_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public double? GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(double? value){
			this.price_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		
	}
	
}