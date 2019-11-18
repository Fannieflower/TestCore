using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	
	
	public class LbsAcceptLogisticsTrackResponse {
		
		///<summary>
		/// 响应头信息
		///</summary>
		
		private com.vip.lbs.track.waybill.service.common.LbsResponseHeader header_;
		
		public com.vip.lbs.track.waybill.service.common.LbsResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.lbs.track.waybill.service.common.LbsResponseHeader value){
			this.header_ = value;
		}
		
	}
	
}