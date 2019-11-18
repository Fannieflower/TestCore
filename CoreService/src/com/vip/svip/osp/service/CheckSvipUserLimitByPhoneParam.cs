using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class CheckSvipUserLimitByPhoneParam {
		
		///<summary>
		/// 手机号码
		///</summary>
		
		private string phone_;
		
		///<summary>
		/// 用户ip
		///</summary>
		
		private string userIp_;
		
		///<summary>
		/// 调用方
		///</summary>
		
		private string operator_;
		
		public string GetPhone(){
			return this.phone_;
		}
		
		public void SetPhone(string value){
			this.phone_ = value;
		}
		public string GetUserIp(){
			return this.userIp_;
		}
		
		public void SetUserIp(string value){
			this.userIp_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}