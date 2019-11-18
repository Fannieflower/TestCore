using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class GetReturnAddressRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrierCode_;
		
		///<summary>
		/// 运单号列表
		///</summary>
		
		private List<string> transportNos_;
		
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
		public List<string> GetTransportNos(){
			return this.transportNos_;
		}
		
		public void SetTransportNos(List<string> value){
			this.transportNos_ = value;
		}
		
	}
	
}