using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class PidInfo {
		
		///<summary>
		/// 推广位ID
		///</summary>
		
		private string pid_;
		
		///<summary>
		/// 推广位名称
		///</summary>
		
		private string pidName_;
		
		///<summary>
		/// 该推广位创建的时间
		///</summary>
		
		private long? createTime_;
		
		public string GetPid(){
			return this.pid_;
		}
		
		public void SetPid(string value){
			this.pid_ = value;
		}
		public string GetPidName(){
			return this.pidName_;
		}
		
		public void SetPidName(string value){
			this.pidName_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		
	}
	
}