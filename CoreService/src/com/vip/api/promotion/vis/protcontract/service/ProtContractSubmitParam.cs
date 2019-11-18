using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractSubmitParam {
		
		///<summary>
		/// 确认函ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 验证码参数，验证码模式确认函提交时必填
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParam checkCaptchaParam_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParam GetCheckCaptchaParam(){
			return this.checkCaptchaParam_;
		}
		
		public void SetCheckCaptchaParam(com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParam value){
			this.checkCaptchaParam_ = value;
		}
		
	}
	
}