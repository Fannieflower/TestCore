using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.user{
	
	
	
	
	
	public class GetUserInfoRequest {
		
		///<summary>
		/// 手机号码
		///</summary>
		
		private string mobile_;
		
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		
	}
	
}