using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class GetCancelInfoRequest {
		
		///<summary>
		/// 订单号（订单号和取消申请单号，至少必填其一！）
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 取消申请单号（订单号和取消申请单号，至少必填其一！）
		///</summary>
		
		private string apply_sn_;
		
		///<summary>
		/// 取消申请单审核状态：1- 待审核，2-审核通过，3- 审核不通过，4-关闭
		/// @sampleValue audit_status 1
		///</summary>
		
		private int? audit_status_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
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
		
	}
	
}