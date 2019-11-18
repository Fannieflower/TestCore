using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class ReturnApplyGood {
		
		///<summary>
		/// prodSkuId，最大长度：32
		///</summary>
		
		private string prod_sku_id_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		
	}
	
}