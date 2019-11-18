using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class CancelledSkus {
		
		///<summary>
		/// 商品sku id
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 商品个数
		///</summary>
		
		private int? amount_;
		
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
		
	}
	
}