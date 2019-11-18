using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class CarrierTakingAwayGoodsResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 响应列表
		///</summary>
		
		private List<com.vip.tpc.api.model.ReturnCollectResult> returnCollectResult_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.ReturnCollectResult> GetReturnCollectResult(){
			return this.returnCollectResult_;
		}
		
		public void SetReturnCollectResult(List<com.vip.tpc.api.model.ReturnCollectResult> value){
			this.returnCollectResult_ = value;
		}
		
	}
	
}