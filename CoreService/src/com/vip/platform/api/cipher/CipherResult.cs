using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class CipherResult {
		
		///<summary>
		/// 加密或者解密的数据
		///</summary>
		
		private string content_;
		
		///<summary>
		/// 是否处理成功
		///</summary>
		
		private bool? success_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string message_;
		
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		public bool? GetSuccess(){
			return this.success_;
		}
		
		public void SetSuccess(bool? value){
			this.success_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}