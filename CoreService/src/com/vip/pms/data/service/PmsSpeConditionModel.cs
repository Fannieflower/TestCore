using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsSpeConditionModel {
		
		///<summary>
		/// 用户标签列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsSpeConfigModel> customerTagList_;
		
		///<summary>
		/// 用户等级列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsSpeConfigModel> customerSrcList_;
		
		///<summary>
		/// 分流配置
		///</summary>
		
		private List<com.vip.pms.data.service.PmsCustomerPageConfigModel> customerPageConfigList_;
		
		///<summary>
		/// 受众配置
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> audienceConfigList_;
		
		public List<com.vip.pms.data.service.PmsSpeConfigModel> GetCustomerTagList(){
			return this.customerTagList_;
		}
		
		public void SetCustomerTagList(List<com.vip.pms.data.service.PmsSpeConfigModel> value){
			this.customerTagList_ = value;
		}
		public List<com.vip.pms.data.service.PmsSpeConfigModel> GetCustomerSrcList(){
			return this.customerSrcList_;
		}
		
		public void SetCustomerSrcList(List<com.vip.pms.data.service.PmsSpeConfigModel> value){
			this.customerSrcList_ = value;
		}
		public List<com.vip.pms.data.service.PmsCustomerPageConfigModel> GetCustomerPageConfigList(){
			return this.customerPageConfigList_;
		}
		
		public void SetCustomerPageConfigList(List<com.vip.pms.data.service.PmsCustomerPageConfigModel> value){
			this.customerPageConfigList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetAudienceConfigList(){
			return this.audienceConfigList_;
		}
		
		public void SetAudienceConfigList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.audienceConfigList_ = value;
		}
		
	}
	
}