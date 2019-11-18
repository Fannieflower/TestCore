using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ActivityRequestModel {
		
		///<summary>
		/// pmsActCore
		///</summary>
		
		private com.vip.pms.data.service.PmsActCoreModel actCoreModel_;
		
		///<summary>
		/// pmsActCondition
		///</summary>
		
		private com.vip.pms.data.service.PmsActConditionModel actConditionModel_;
		
		///<summary>
		/// 频道列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActSiteModel> actSiteList_;
		
		public com.vip.pms.data.service.PmsActCoreModel GetActCoreModel(){
			return this.actCoreModel_;
		}
		
		public void SetActCoreModel(com.vip.pms.data.service.PmsActCoreModel value){
			this.actCoreModel_ = value;
		}
		public com.vip.pms.data.service.PmsActConditionModel GetActConditionModel(){
			return this.actConditionModel_;
		}
		
		public void SetActConditionModel(com.vip.pms.data.service.PmsActConditionModel value){
			this.actConditionModel_ = value;
		}
		public List<com.vip.pms.data.service.PmsActSiteModel> GetActSiteList(){
			return this.actSiteList_;
		}
		
		public void SetActSiteList(List<com.vip.pms.data.service.PmsActSiteModel> value){
			this.actSiteList_ = value;
		}
		
	}
	
}