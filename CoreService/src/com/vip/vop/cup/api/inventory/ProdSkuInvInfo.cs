using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.inventory{
	
	
	
	
	
	public class ProdSkuInvInfo {
		
		///<summary>
		/// 商品SkuId
		///</summary>
		
		private string prod_sku_id_;
		
		///<summary>
		/// 商品库存数量
		///</summary>
		
		private int? inventory_info_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		public int? GetInventory_info(){
			return this.inventory_info_;
		}
		
		public void SetInventory_info(int? value){
			this.inventory_info_ = value;
		}
		
	}
	
}