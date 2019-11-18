using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class SpecialRequestModel {
		
		///<summary>
		/// 专享价核心参数
		///</summary>
		
		private com.vip.pms.data.service.PmsSpecialCoreModel specialCoreModel_;
		
		///<summary>
		/// pmsSpeCondition
		///</summary>
		
		private com.vip.pms.data.service.PmsSpeConditionModel speConditionModel_;
		
		public com.vip.pms.data.service.PmsSpecialCoreModel GetSpecialCoreModel(){
			return this.specialCoreModel_;
		}
		
		public void SetSpecialCoreModel(com.vip.pms.data.service.PmsSpecialCoreModel value){
			this.specialCoreModel_ = value;
		}
		public com.vip.pms.data.service.PmsSpeConditionModel GetSpeConditionModel(){
			return this.speConditionModel_;
		}
		
		public void SetSpeConditionModel(com.vip.pms.data.service.PmsSpeConditionModel value){
			this.speConditionModel_ = value;
		}
		
	}
	
}