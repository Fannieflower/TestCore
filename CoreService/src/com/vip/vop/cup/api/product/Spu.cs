using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class Spu {
		
		///<summary>
		/// prodSpuId
		///</summary>
		
		private string prod_spu_id_;
		
		///<summary>
		/// Spu上下架状态(true:上架，false:下架)
		///</summary>
		
		private bool? spu_status_;
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ProdSkuInfo> prod_sku_list_;
		
		public string GetProd_spu_id(){
			return this.prod_spu_id_;
		}
		
		public void SetProd_spu_id(string value){
			this.prod_spu_id_ = value;
		}
		public bool? GetSpu_status(){
			return this.spu_status_;
		}
		
		public void SetSpu_status(bool? value){
			this.spu_status_ = value;
		}
		public List<com.vip.vop.cup.api.product.ProdSkuInfo> GetProd_sku_list(){
			return this.prod_sku_list_;
		}
		
		public void SetProd_sku_list(List<com.vip.vop.cup.api.product.ProdSkuInfo> value){
			this.prod_sku_list_ = value;
		}
		
	}
	
}