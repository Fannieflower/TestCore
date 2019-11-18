using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.entity{
	
	
	
	
	
	public class GetExplainedBarcodesResponse {
		
		///<summary>
		/// 【统一字段】响应头
		///</summary>
		
		private com.vip.lbs.lpc.service.common.LbsResponseHeader header_;
		
		///<summary>
		/// 解析结果map
		///</summary>
		
		private Dictionary<string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail> explainedResultMap_;
		
		public com.vip.lbs.lpc.service.common.LbsResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.lbs.lpc.service.common.LbsResponseHeader value){
			this.header_ = value;
		}
		public Dictionary<string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail> GetExplainedResultMap(){
			return this.explainedResultMap_;
		}
		
		public void SetExplainedResultMap(Dictionary<string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail> value){
			this.explainedResultMap_ = value;
		}
		
	}
	
}