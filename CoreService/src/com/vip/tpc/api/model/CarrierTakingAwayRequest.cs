using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class CarrierTakingAwayRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 揽收请求列表
		///</summary>
		
		private string carrierCode_;
		
		///<summary>
		/// 揽收请求列表
		///</summary>
		
		private List<com.vip.tpc.api.model.TakingAwayRequest> takingAwayRequests_;
		
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
		public List<com.vip.tpc.api.model.TakingAwayRequest> GetTakingAwayRequests(){
			return this.takingAwayRequests_;
		}
		
		public void SetTakingAwayRequests(List<com.vip.tpc.api.model.TakingAwayRequest> value){
			this.takingAwayRequests_ = value;
		}
		
	}
	
}