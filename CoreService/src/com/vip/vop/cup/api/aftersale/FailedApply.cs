using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class FailedApply {
		
		///<summary>
		/// 申请单ID
		///</summary>
		
		private string apply_id_;
		
		///<summary>
		/// 失败原因描述
		///</summary>
		
		private string remark_;
		
		public string GetApply_id(){
			return this.apply_id_;
		}
		
		public void SetApply_id(string value){
			this.apply_id_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}