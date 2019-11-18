using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class VipLinkCheckReq {
		
		///<summary>
		/// 请求源
		///</summary>
		
		private string source_;
		
		///<summary>
		/// 检查的内容(长度不超过10000)
		///</summary>
		
		private string content_;
		
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		
	}
	
}