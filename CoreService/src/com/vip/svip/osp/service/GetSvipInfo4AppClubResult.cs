using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetSvipInfo4AppClubResult {
		
		///<summary>
		/// 是否限购
		///</summary>
		
		private bool? limit_;
		
		///<summary>
		/// 限购编码
		///</summary>
		
		private int? limitCode_;
		
		///<summary>
		/// 限购信息
		///</summary>
		
		private string limitMsg_;
		
		///<summary>
		/// 用户状态 
		///</summary>
		
		private int? userStatus_;
		
		///<summary>
		/// 到期时间 
		///</summary>
		
		private long? expireTime_;
		
		public bool? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(bool? value){
			this.limit_ = value;
		}
		public int? GetLimitCode(){
			return this.limitCode_;
		}
		
		public void SetLimitCode(int? value){
			this.limitCode_ = value;
		}
		public string GetLimitMsg(){
			return this.limitMsg_;
		}
		
		public void SetLimitMsg(string value){
			this.limitMsg_ = value;
		}
		public int? GetUserStatus(){
			return this.userStatus_;
		}
		
		public void SetUserStatus(int? value){
			this.userStatus_ = value;
		}
		public long? GetExpireTime(){
			return this.expireTime_;
		}
		
		public void SetExpireTime(long? value){
			this.expireTime_ = value;
		}
		
	}
	
}