using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	
	
	public class LbsAcceptLogisticsTrackRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.lbs.track.waybill.service.common.LbsRequestHeader header_;
		
		///<summary>
		/// 推送轨迹明细列表
		///</summary>
		
		private List<com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack> trackDataList_;
		
		public com.vip.lbs.track.waybill.service.common.LbsRequestHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.lbs.track.waybill.service.common.LbsRequestHeader value){
			this.header_ = value;
		}
		public List<com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack> GetTrackDataList(){
			return this.trackDataList_;
		}
		
		public void SetTrackDataList(List<com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack> value){
			this.trackDataList_ = value;
		}
		
	}
	
}