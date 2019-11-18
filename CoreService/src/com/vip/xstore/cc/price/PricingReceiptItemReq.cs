using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceiptItemReq {
		
		///<summary>
		/// 请求上下文
		///</summary>
		
		private com.vip.xstore.cc.price.ReqContext reqContext_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 定价单号
		///</summary>
		
		private string pricingNo_;
		
		public com.vip.xstore.cc.price.ReqContext GetReqContext(){
			return this.reqContext_;
		}
		
		public void SetReqContext(com.vip.xstore.cc.price.ReqContext value){
			this.reqContext_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public string GetPricingNo(){
			return this.pricingNo_;
		}
		
		public void SetPricingNo(string value){
			this.pricingNo_ = value;
		}
		
	}
	
}