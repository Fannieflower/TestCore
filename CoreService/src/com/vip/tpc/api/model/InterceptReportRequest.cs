using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class InterceptReportRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商编码,承运商填固定值，由唯品提供编码
		///</summary>
		
		private string carrierCode_;
		
		///<summary>
		/// 拦截结果请求明细
		///</summary>
		
		private List<com.vip.tpc.api.model.InterceptResult> interceptResults_;
		
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
		public List<com.vip.tpc.api.model.InterceptResult> GetInterceptResults(){
			return this.interceptResults_;
		}
		
		public void SetInterceptResults(List<com.vip.tpc.api.model.InterceptResult> value){
			this.interceptResults_ = value;
		}
		
	}
	
}