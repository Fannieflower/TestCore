using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class CreateKeyReq {
		
		///<summary>
		/// 密钥分类标识
		///</summary>
		
		private string keyCategory_;
		
		///<summary>
		/// 密钥分类名称
		///</summary>
		
		private string keyName_;
		
		public string GetKeyCategory(){
			return this.keyCategory_;
		}
		
		public void SetKeyCategory(string value){
			this.keyCategory_ = value;
		}
		public string GetKeyName(){
			return this.keyName_;
		}
		
		public void SetKeyName(string value){
			this.keyName_ = value;
		}
		
	}
	
}