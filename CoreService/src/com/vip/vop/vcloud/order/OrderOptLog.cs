using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderOptLog {
		
		///<summary>
		/// 状态
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string account_;
		
		///<summary>
		/// 操作时间
		///</summary>
		
		private long? optTime_;
		
		///<summary>
		/// 操作
		///</summary>
		
		private string operate_;
		
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetAccount(){
			return this.account_;
		}
		
		public void SetAccount(string value){
			this.account_ = value;
		}
		public long? GetOptTime(){
			return this.optTime_;
		}
		
		public void SetOptTime(long? value){
			this.optTime_ = value;
		}
		public string GetOperate(){
			return this.operate_;
		}
		
		public void SetOperate(string value){
			this.operate_ = value;
		}
		
	}
	
}