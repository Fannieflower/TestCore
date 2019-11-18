using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class QueryStoreSalePriceChangeResp {
		
		///<summary>
		/// 总数量
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 商品价格变动列表
		///</summary>
		
		private List<vipapis.xstore.cc.price.api.ProdItemSalePrice> prod_sale_price_change_items_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.price.api.ProdItemSalePrice> GetProd_sale_price_change_items(){
			return this.prod_sale_price_change_items_;
		}
		
		public void SetProd_sale_price_change_items(List<vipapis.xstore.cc.price.api.ProdItemSalePrice> value){
			this.prod_sale_price_change_items_ = value;
		}
		
	}
	
}