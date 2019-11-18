using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	
	
	public class ProdQueryReqDTO {
		
		///<summary>
		/// 渠道编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 货品来源,2-买断模式中的SI；3-买断模式的VI
		///</summary>
		
		private int? businessType_;
		
		///<summary>
		/// 查询v_sku_id列表
		///</summary>
		
		private List<com.vip.xstore.cc.product.pool.service.QueryItem> queryItems_;
		
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
		public List<com.vip.xstore.cc.product.pool.service.QueryItem> GetQueryItems(){
			return this.queryItems_;
		}
		
		public void SetQueryItems(List<com.vip.xstore.cc.product.pool.service.QueryItem> value){
			this.queryItems_ = value;
		}
		
	}
	
}