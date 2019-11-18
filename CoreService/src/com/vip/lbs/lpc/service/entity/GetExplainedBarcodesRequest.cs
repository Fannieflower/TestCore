using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.entity{
	
	
	
	
	
	public class GetExplainedBarcodesRequest {
		
		///<summary>
		/// 【统一字段】请求头
		///</summary>
		
		private com.vip.lbs.lpc.service.common.LbsRequestHeader header_;
		
		///<summary>
		/// 请求入参，大小不超过50，支持配置
		///</summary>
		
		private List<com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel> explainedBarcodesModelList_;
		
		public com.vip.lbs.lpc.service.common.LbsRequestHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.lbs.lpc.service.common.LbsRequestHeader value){
			this.header_ = value;
		}
		public List<com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel> GetExplainedBarcodesModelList(){
			return this.explainedBarcodesModelList_;
		}
		
		public void SetExplainedBarcodesModelList(List<com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel> value){
			this.explainedBarcodesModelList_ = value;
		}
		
	}
	
}