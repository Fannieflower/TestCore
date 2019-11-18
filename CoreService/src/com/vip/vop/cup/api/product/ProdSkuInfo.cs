using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ProdSkuInfo {
		
		///<summary>
		/// 商品SkuId
		///</summary>
		
		private string prod_sku_id_;
		
		///<summary>
		/// Spu上下架状态(true:上架，false:下架)
		///</summary>
		
		private bool? sku_state_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		public bool? GetSku_state(){
			return this.sku_state_;
		}
		
		public void SetSku_state(bool? value){
			this.sku_state_ = value;
		}
		
	}
	
}