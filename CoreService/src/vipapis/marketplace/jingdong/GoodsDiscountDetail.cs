using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.jingdong{
	
	
	
	
	
	public class GoodsDiscountDetail {
		
		///<summary>
		/// 唯品会sku编码
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 单件商品优惠金额，精度六位小数
		///</summary>
		
		private string unit_discount_money_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public string GetUnit_discount_money(){
			return this.unit_discount_money_;
		}
		
		public void SetUnit_discount_money(string value){
			this.unit_discount_money_ = value;
		}
		
	}
	
}