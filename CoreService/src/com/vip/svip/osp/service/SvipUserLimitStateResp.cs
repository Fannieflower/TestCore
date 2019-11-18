using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipUserLimitStateResp {
		
		///<summary>
		/// 开通限制
		///</summary>
		
		private com.vip.svip.osp.service.BaseResult formal_;
		
		///<summary>
		/// 试用限制
		///</summary>
		
		private com.vip.svip.osp.service.BaseResult trial_;
		
		///<summary>
		/// 用户等级
		///</summary>
		
		private string userLv_;
		
		///<summary>
		/// 用户状态
		///</summary>
		
		private int? userStatus_;
		
		///<summary>
		/// 剩余天数
		///</summary>
		
		private int? remainingDays_;
		
		public com.vip.svip.osp.service.BaseResult GetFormal(){
			return this.formal_;
		}
		
		public void SetFormal(com.vip.svip.osp.service.BaseResult value){
			this.formal_ = value;
		}
		public com.vip.svip.osp.service.BaseResult GetTrial(){
			return this.trial_;
		}
		
		public void SetTrial(com.vip.svip.osp.service.BaseResult value){
			this.trial_ = value;
		}
		public string GetUserLv(){
			return this.userLv_;
		}
		
		public void SetUserLv(string value){
			this.userLv_ = value;
		}
		public int? GetUserStatus(){
			return this.userStatus_;
		}
		
		public void SetUserStatus(int? value){
			this.userStatus_ = value;
		}
		public int? GetRemainingDays(){
			return this.remainingDays_;
		}
		
		public void SetRemainingDays(int? value){
			this.remainingDays_ = value;
		}
		
	}
	
}