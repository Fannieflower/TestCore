using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleInfoModelResponse {
		
		///<summary>
		/// 商品销售情况列表
		///</summary>
		
		private List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> roductSaleInfoModel_;
		
		///<summary>
		/// 总记录条数
		///</summary>
		
		private int? total_;
		
		public List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> GetRoductSaleInfoModel(){
			return this.roductSaleInfoModel_;
		}
		
		public void SetRoductSaleInfoModel(List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value){
			this.roductSaleInfoModel_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}