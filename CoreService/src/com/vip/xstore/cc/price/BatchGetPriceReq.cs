using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class BatchGetPriceReq {
		
		///<summary>
		/// 请求上下文
		///</summary>
		
		private com.vip.xstore.cc.price.ReqContext reqContext_;
		
		///<summary>
		/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码列表，最大100
		///</summary>
		
		private List<string> barcodes_;
		
		public com.vip.xstore.cc.price.ReqContext GetReqContext(){
			return this.reqContext_;
		}
		
		public void SetReqContext(com.vip.xstore.cc.price.ReqContext value){
			this.reqContext_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public List<string> GetBarcodes(){
			return this.barcodes_;
		}
		
		public void SetBarcodes(List<string> value){
			this.barcodes_ = value;
		}
		
	}
	
}