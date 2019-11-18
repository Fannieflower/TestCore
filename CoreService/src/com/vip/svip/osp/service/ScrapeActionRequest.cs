using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class ScrapeActionRequest {
		
		///<summary>
		/// 业务编码
		///</summary>
		
		private string bizCode_;
		
		///<summary>
		/// 加密手机号
		///</summary>
		
		private string encryptPhone_;
		
		///<summary>
		/// 应用名称
		///</summary>
		
		private string appName_;
		
		public string GetBizCode(){
			return this.bizCode_;
		}
		
		public void SetBizCode(string value){
			this.bizCode_ = value;
		}
		public string GetEncryptPhone(){
			return this.encryptPhone_;
		}
		
		public void SetEncryptPhone(string value){
			this.encryptPhone_ = value;
		}
		public string GetAppName(){
			return this.appName_;
		}
		
		public void SetAppName(string value){
			this.appName_ = value;
		}
		
	}
	
}