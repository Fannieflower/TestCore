using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AcceptCarLoadDetailRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商装车清单入参实例
		///</summary>
		
		private com.vip.tpc.api.model.LoadOrderRequest loadOrderRequest_;
		
		public com.vip.tpc.api.model.common.TpcRequestHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcRequestHeader value){
			this.header_ = value;
		}
		public com.vip.tpc.api.model.LoadOrderRequest GetLoadOrderRequest(){
			return this.loadOrderRequest_;
		}
		
		public void SetLoadOrderRequest(com.vip.tpc.api.model.LoadOrderRequest value){
			this.loadOrderRequest_ = value;
		}
		
	}
	
}