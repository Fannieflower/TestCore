using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class CarrierTakingAwayGoodsRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrierCode_;
		
		///<summary>
		/// 请求列表
		///</summary>
		
		private List<com.vip.tpc.api.model.TakingAwayGoodsRequest> takingAwayGoodsRequests_;
		
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
		public List<com.vip.tpc.api.model.TakingAwayGoodsRequest> GetTakingAwayGoodsRequests(){
			return this.takingAwayGoodsRequests_;
		}
		
		public void SetTakingAwayGoodsRequests(List<com.vip.tpc.api.model.TakingAwayGoodsRequest> value){
			this.takingAwayGoodsRequests_ = value;
		}
		
	}
	
}