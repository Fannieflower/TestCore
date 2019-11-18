using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class GetCaptchaParam {
		
		///<summary>
		/// 验证码方式（1：邮箱，2：短信）
		///</summary>
		
		private byte? captchaType_;
		
		///<summary>
		/// 确认函ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 用户IP
		///</summary>
		
		private string ip_;
		
		///<summary>
		/// 用户CID
		///</summary>
		
		private string cid_;
		
		public byte? GetCaptchaType(){
			return this.captchaType_;
		}
		
		public void SetCaptchaType(byte? value){
			this.captchaType_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetIp(){
			return this.ip_;
		}
		
		public void SetIp(string value){
			this.ip_ = value;
		}
		public string GetCid(){
			return this.cid_;
		}
		
		public void SetCid(string value){
			this.cid_ = value;
		}
		
	}
	
}