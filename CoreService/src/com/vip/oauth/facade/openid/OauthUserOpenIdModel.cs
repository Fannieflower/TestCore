using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.oauth.facade.openid{
	
	
	
	
	
	public class OauthUserOpenIdModel {
		
		///<summary>
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 用户OpenId
		///</summary>
		
		private string openId_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetOpenId(){
			return this.openId_;
		}
		
		public void SetOpenId(string value){
			this.openId_ = value;
		}
		
	}
	
}