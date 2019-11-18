using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class AuditCancelApplyRequest {
		
		///<summary>
		/// 取消申请单号
		///</summary>
		
		private string apply_sn_;
		
		///<summary>
		/// 审核结果：2 - 审核通过，3 - 审核不通过
		/// @sampleValue audit_status 2
		///</summary>
		
		private int? audit_status_;
		
		///<summary>
		/// 审核意见，长度5-255个字符，审核不通过时必填。
		///</summary>
		
		private string opinion_;
		
		public string GetApply_sn(){
			return this.apply_sn_;
		}
		
		public void SetApply_sn(string value){
			this.apply_sn_ = value;
		}
		public int? GetAudit_status(){
			return this.audit_status_;
		}
		
		public void SetAudit_status(int? value){
			this.audit_status_ = value;
		}
		public string GetOpinion(){
			return this.opinion_;
		}
		
		public void SetOpinion(string value){
			this.opinion_ = value;
		}
		
	}
	
}