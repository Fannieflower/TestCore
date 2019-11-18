using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class GetCancelInfoResponse {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 取消申请单号
		///</summary>
		
		private string apply_sn_;
		
		///<summary>
		/// 用户选择的取消原因
		///</summary>
		
		private string reason_choice_remark_;
		
		///<summary>
		/// 用户输入的取消原因
		///</summary>
		
		private string reason_remark_;
		
		///<summary>
		/// 取消申请单发起操作角色
		///</summary>
		
		private string operator_role_name_;
		
		///<summary>
		/// 取消申请单审核状态：1- 待审核，2-审核通过，3- 审核不通过，4-关闭
		///</summary>
		
		private int? audit_status_;
		
		///<summary>
		/// 取消申请单审核意见
		///</summary>
		
		private string audit_opinion_;
		
		///<summary>
		/// 订单状态. 10:订单已审核, 22:订单已发货, 25:已签收, 70:已拒收, 97:订单已取消
		///</summary>
		
		private string order_status_;
		
		///<summary>
		/// 是否系统自动审核，返回是或否
		/// @sampleValue is_system 是
		///</summary>
		
		private string is_system_;
		
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
		public string GetReason_choice_remark(){
			return this.reason_choice_remark_;
		}
		
		public void SetReason_choice_remark(string value){
			this.reason_choice_remark_ = value;
		}
		public string GetReason_remark(){
			return this.reason_remark_;
		}
		
		public void SetReason_remark(string value){
			this.reason_remark_ = value;
		}
		public string GetOperator_role_name(){
			return this.operator_role_name_;
		}
		
		public void SetOperator_role_name(string value){
			this.operator_role_name_ = value;
		}
		public int? GetAudit_status(){
			return this.audit_status_;
		}
		
		public void SetAudit_status(int? value){
			this.audit_status_ = value;
		}
		public string GetAudit_opinion(){
			return this.audit_opinion_;
		}
		
		public void SetAudit_opinion(string value){
			this.audit_opinion_ = value;
		}
		public string GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(string value){
			this.order_status_ = value;
		}
		public string GetIs_system(){
			return this.is_system_;
		}
		
		public void SetIs_system(string value){
			this.is_system_ = value;
		}
		
	}
	
}