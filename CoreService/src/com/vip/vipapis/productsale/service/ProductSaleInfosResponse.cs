using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleInfosResponse {
		
		///<summary>
		/// 商品销售情况列表
		///</summary>
		
		private List<com.vip.vipapis.productsale.service.ProductSaleInfo> productSaleInfos_;
		
		///<summary>
		/// 总记录条数
		///</summary>
		
		private int? total_;
		
		public List<com.vip.vipapis.productsale.service.ProductSaleInfo> GetProductSaleInfos(){
			return this.productSaleInfos_;
		}
		
		public void SetProductSaleInfos(List<com.vip.vipapis.productsale.service.ProductSaleInfo> value){
			this.productSaleInfos_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}