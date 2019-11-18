using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class BatchDecryptReq {
		
		///<summary>
		/// 解密请求内容
		///</summary>
		
		private List<string> contents_;
		
		public List<string> GetContents(){
			return this.contents_;
		}
		
		public void SetContents(List<string> value){
			this.contents_ = value;
		}
		
	}
	
}