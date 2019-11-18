using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class GetTrusteeshipInfoResponseModel {
		
		///<summary>
		/// 签约信息
		///</summary>
		
		private com.vip.fcs.vei.service.TrusteeshipInfoModel trusteeshipInfoModel_;
		
		///<summary>
		/// 结果消息
		///</summary>
		
		private com.vip.fcs.vei.service.BaseRetMsg restulMesg_;
		
		public com.vip.fcs.vei.service.TrusteeshipInfoModel GetTrusteeshipInfoModel(){
			return this.trusteeshipInfoModel_;
		}
		
		public void SetTrusteeshipInfoModel(com.vip.fcs.vei.service.TrusteeshipInfoModel value){
			this.trusteeshipInfoModel_ = value;
		}
		public com.vip.fcs.vei.service.BaseRetMsg GetRestulMesg(){
			return this.restulMesg_;
		}
		
		public void SetRestulMesg(com.vip.fcs.vei.service.BaseRetMsg value){
			this.restulMesg_ = value;
		}
		
	}
	
}