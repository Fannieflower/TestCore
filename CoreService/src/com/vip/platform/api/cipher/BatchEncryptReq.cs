using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class BatchEncryptReq {
		
		///<summary>
		/// 密钥分类标识
		///</summary>
		
		private string keyCategory_;
		
		///<summary>
		/// 加密请求内容
		///</summary>
		
		private List<string> contents_;
		
		public string GetKeyCategory(){
			return this.keyCategory_;
		}
		
		public void SetKeyCategory(string value){
			this.keyCategory_ = value;
		}
		public List<string> GetContents(){
			return this.contents_;
		}
		
		public void SetContents(List<string> value){
			this.contents_ = value;
		}
		
	}
	
}