using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class VendorCaptchaActiveModel {
		
		///<summary>
		/// 是否支持确认函验证码
		///</summary>
		
		private bool? captchaActive_;
		
		///<summary>
		/// 供应商联系邮箱
		///</summary>
		
		private string vendorContactEmail_;
		
		///<summary>
		/// 供应商联系电话
		///</summary>
		
		private string vendorContactMobile_;
		
		public bool? GetCaptchaActive(){
			return this.captchaActive_;
		}
		
		public void SetCaptchaActive(bool? value){
			this.captchaActive_ = value;
		}
		public string GetVendorContactEmail(){
			return this.vendorContactEmail_;
		}
		
		public void SetVendorContactEmail(string value){
			this.vendorContactEmail_ = value;
		}
		public string GetVendorContactMobile(){
			return this.vendorContactMobile_;
		}
		
		public void SetVendorContactMobile(string value){
			this.vendorContactMobile_ = value;
		}
		
	}
	
}