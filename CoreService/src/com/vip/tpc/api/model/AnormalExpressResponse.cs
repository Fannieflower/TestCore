using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AnormalExpressResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 问题件上报响应明细
		///</summary>
		
		private List<com.vip.tpc.api.model.AnormalResponse> anormalResponse_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.AnormalResponse> GetAnormalResponse(){
			return this.anormalResponse_;
		}
		
		public void SetAnormalResponse(List<com.vip.tpc.api.model.AnormalResponse> value){
			this.anormalResponse_ = value;
		}
		
	}
	
}