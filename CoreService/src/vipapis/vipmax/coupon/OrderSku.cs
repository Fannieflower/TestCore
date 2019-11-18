using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class OrderSku {
		
		///<summary>
		/// 商品sku id
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 商品个数
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 唯品价
		///</summary>
		
		private double? vip_price_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public double? GetVip_price(){
			return this.vip_price_;
		}
		
		public void SetVip_price(double? value){
			this.vip_price_ = value;
		}
		
	}
	
}