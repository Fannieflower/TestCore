using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class CarrierTakingAwayResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 响应列表
		///</summary>
		
		private List<com.vip.tpc.api.model.TakingAwayResponse> takingAwayResponses_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.TakingAwayResponse> GetTakingAwayResponses(){
			return this.takingAwayResponses_;
		}
		
		public void SetTakingAwayResponses(List<com.vip.tpc.api.model.TakingAwayResponse> value){
			this.takingAwayResponses_ = value;
		}
		
	}
	
}