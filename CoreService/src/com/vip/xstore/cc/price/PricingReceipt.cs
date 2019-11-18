using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceipt {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 定价单号
		///</summary>
		
		private string pricingNo_;
		
		///<summary>
		/// 定价单创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetPricingNo(){
			return this.pricingNo_;
		}
		
		public void SetPricingNo(string value){
			this.pricingNo_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		
	}
	
}