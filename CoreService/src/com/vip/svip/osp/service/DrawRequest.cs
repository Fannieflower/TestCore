using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class DrawRequest {
		
		///<summary>
		/// 业务编码
		///</summary>
		
		private string bizCode_;
		
		///<summary>
		/// 加密手机号
		///</summary>
		
		private string encryptPhone_;
		
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
		
	}
	
}