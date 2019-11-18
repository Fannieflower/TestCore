using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.inventory{
	
	
	
	
	
	public class ProdSkuInv {
		
		///<summary>
		/// 商品SkuId
		///</summary>
		
		private string prod_sku_id_;
		
		///<summary>
		/// 预占sku数量
		///</summary>
		
		private int? amount_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		
	}
	
}