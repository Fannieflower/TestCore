using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OfficialMember {
		
		///<summary>
		/// 会员ID
		///</summary>
		
		private string memberId_;
		
		///<summary>
		/// 会员账号
		///</summary>
		
		private string account_;
		
		///<summary>
		/// 会员等级
		///</summary>
		
		private string customerGroup_;
		
		public string GetMemberId(){
			return this.memberId_;
		}
		
		public void SetMemberId(string value){
			this.memberId_ = value;
		}
		public string GetAccount(){
			return this.account_;
		}
		
		public void SetAccount(string value){
			this.account_ = value;
		}
		public string GetCustomerGroup(){
			return this.customerGroup_;
		}
		
		public void SetCustomerGroup(string value){
			this.customerGroup_ = value;
		}
		
	}
	
}