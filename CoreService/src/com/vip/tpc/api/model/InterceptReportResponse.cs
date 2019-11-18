using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class InterceptReportResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 拦截结果响应明细
		///</summary>
		
		private List<com.vip.tpc.api.model.InterceptResponse> interceptResponses_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.InterceptResponse> GetInterceptResponses(){
			return this.interceptResponses_;
		}
		
		public void SetInterceptResponses(List<com.vip.tpc.api.model.InterceptResponse> value){
			this.interceptResponses_ = value;
		}
		
	}
	
}