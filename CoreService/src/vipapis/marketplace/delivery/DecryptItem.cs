using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class DecryptItem {
		
		///<summary>
		/// 加密内容
		///</summary>
		
		private string encrypt_code_;
		
		///<summary>
		/// 解密内容
		///</summary>
		
		private string decrypt_code_;
		
		///<summary>
		/// 解密结果：1、解密成功 0、解密失败
		///</summary>
		
		private int? state_;
		
		public string GetEncrypt_code(){
			return this.encrypt_code_;
		}
		
		public void SetEncrypt_code(string value){
			this.encrypt_code_ = value;
		}
		public string GetDecrypt_code(){
			return this.decrypt_code_;
		}
		
		public void SetDecrypt_code(string value){
			this.decrypt_code_ = value;
		}
		public int? GetState(){
			return this.state_;
		}
		
		public void SetState(int? value){
			this.state_ = value;
		}
		
	}
	
}