using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class CancelUser {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 登录名
		///</summary>
		
		private string account_;
		
		///<summary>
		/// oa 账号
		///</summary>
		
		private string oa_;
		
		///<summary>
		/// 唯品卡金额
		///</summary>
		
		private string vipCardAmount_;
		
		///<summary>
		/// 原因列表
		///</summary>
		
		private List<com.vip.svip.osp.service.CancelReason> reasonList_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetAccount(){
			return this.account_;
		}
		
		public void SetAccount(string value){
			this.account_ = value;
		}
		public string GetOa(){
			return this.oa_;
		}
		
		public void SetOa(string value){
			this.oa_ = value;
		}
		public string GetVipCardAmount(){
			return this.vipCardAmount_;
		}
		
		public void SetVipCardAmount(string value){
			this.vipCardAmount_ = value;
		}
		public List<com.vip.svip.osp.service.CancelReason> GetReasonList(){
			return this.reasonList_;
		}
		
		public void SetReasonList(List<com.vip.svip.osp.service.CancelReason> value){
			this.reasonList_ = value;
		}
		
	}
	
}