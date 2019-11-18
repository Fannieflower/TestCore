using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class GetReturnAddressResponse {
		
		///<summary>
		/// 返回头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 运单对应的退回地址MAP
		///</summary>
		
		private Dictionary<string, com.vip.tpc.api.model.ReturnInfo> returnAddressMap_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public Dictionary<string, com.vip.tpc.api.model.ReturnInfo> GetReturnAddressMap(){
			return this.returnAddressMap_;
		}
		
		public void SetReturnAddressMap(Dictionary<string, com.vip.tpc.api.model.ReturnInfo> value){
			this.returnAddressMap_ = value;
		}
		
	}
	
}