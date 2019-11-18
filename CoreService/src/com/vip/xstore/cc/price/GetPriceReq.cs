using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class GetPriceReq {
		
		///<summary>
		/// 请求上下文
		///</summary>
		
		private com.vip.xstore.cc.price.ReqContext reqContext_;
		
		///<summary>
		/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
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
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		
	}
	
}