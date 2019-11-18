using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	
	
	public class ProdValidateReqDTO {
		
		///<summary>
		/// 采购主体
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 货品来源,2-买断模式中的SI；3-买断模式的VI
		///</summary>
		
		private int? businessType_;
		
		///<summary>
		/// 校验商品列表
		///</summary>
		
		private List<com.vip.xstore.cc.product.pool.service.VerificationItem> verificationItems_;
		
		///<summary>
		/// 是否集团采买：0-否，1-是
		///</summary>
		
		private byte? isQuota_;
		
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
		public List<com.vip.xstore.cc.product.pool.service.VerificationItem> GetVerificationItems(){
			return this.verificationItems_;
		}
		
		public void SetVerificationItems(List<com.vip.xstore.cc.product.pool.service.VerificationItem> value){
			this.verificationItems_ = value;
		}
		public byte? GetIsQuota(){
			return this.isQuota_;
		}
		
		public void SetIsQuota(byte? value){
			this.isQuota_ = value;
		}
		
	}
	
}