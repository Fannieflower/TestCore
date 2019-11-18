using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	
	
	public class ProdValidateRespDTO {
		
		///<summary>
		/// 渠道编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 货品来源,2-买断模式中的SI；3-买断模式的VI
		///</summary>
		
		private int? businessType_;
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel> prodPoolSkus_;
		
		///<summary>
		/// 错误商品列表
		///</summary>
		
		private List<com.vip.xstore.cc.product.pool.service.ErrorSkuModel> errSkus_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public int? GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(int? value){
			this.businessType_ = value;
		}
		public List<com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel> GetProdPoolSkus(){
			return this.prodPoolSkus_;
		}
		
		public void SetProdPoolSkus(List<com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel> value){
			this.prodPoolSkus_ = value;
		}
		public List<com.vip.xstore.cc.product.pool.service.ErrorSkuModel> GetErrSkus(){
			return this.errSkus_;
		}
		
		public void SetErrSkus(List<com.vip.xstore.cc.product.pool.service.ErrorSkuModel> value){
			this.errSkus_ = value;
		}
		
	}
	
}