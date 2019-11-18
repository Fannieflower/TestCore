using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AnormalExpressRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrierCode_;
		
		///<summary>
		/// 问题件上报请求明细
		///</summary>
		
		private List<com.vip.tpc.api.model.AnormalRequest> anormalRequest_;
		
		public com.vip.tpc.api.model.common.TpcRequestHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcRequestHeader value){
			this.header_ = value;
		}
		public string GetCarrierCode(){
			return this.carrierCode_;
		}
		
		public void SetCarrierCode(string value){
			this.carrierCode_ = value;
		}
		public List<com.vip.tpc.api.model.AnormalRequest> GetAnormalRequest(){
			return this.anormalRequest_;
		}
		
		public void SetAnormalRequest(List<com.vip.tpc.api.model.AnormalRequest> value){
			this.anormalRequest_ = value;
		}
		
	}
	
}