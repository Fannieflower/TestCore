using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class BatchCipherResp {
		
		///<summary>
		/// 加密结果，key为加密前的内容，value为加密后的内容
		///</summary>
		
		private Dictionary<string, com.vip.platform.api.cipher.CipherResult> resultMap_;
		
		public Dictionary<string, com.vip.platform.api.cipher.CipherResult> GetResultMap(){
			return this.resultMap_;
		}
		
		public void SetResultMap(Dictionary<string, com.vip.platform.api.cipher.CipherResult> value){
			this.resultMap_ = value;
		}
		
	}
	
}