using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AcceptCarLoadDetailResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 承运商装车清单响应对象
		///</summary>
		
		private List<com.vip.tpc.api.model.LoadOrderResponse> loadOrderResponse_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.LoadOrderResponse> GetLoadOrderResponse(){
			return this.loadOrderResponse_;
		}
		
		public void SetLoadOrderResponse(List<com.vip.tpc.api.model.LoadOrderResponse> value){
			this.loadOrderResponse_ = value;
		}
		
	}
	
}