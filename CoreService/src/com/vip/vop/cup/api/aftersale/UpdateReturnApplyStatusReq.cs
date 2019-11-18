using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class UpdateReturnApplyStatusReq {
		
		///<summary>
		/// 外部退款申请单号，最大长度50 
		///</summary>
		
		private string apply_id_;
		
		///<summary>
		/// 外部订单号，最大长度50
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员ID，最大长度32
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 场景码
		///</summary>
		
		private string scenario_code_;
		
		///<summary>
		/// 外部服务单状态环节
		///</summary>
		
		private int? return_status_;
		
		///<summary>
		/// 外部服务单更改时间，格式：yyyy-MM-dd HH:mm:ss，最大长度20
		///</summary>
		
		private string update_time_;
		
		///<summary>
		/// 备注，最大长度200
		///</summary>
		
		private string remark_;
		
		public string GetApply_id(){
			return this.apply_id_;
		}
		
		public void SetApply_id(string value){
			this.apply_id_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetUser_code(){
			return this.user_code_;
		}
		
		public void SetUser_code(string value){
			this.user_code_ = value;
		}
		public string GetScenario_code(){
			return this.scenario_code_;
		}
		
		public void SetScenario_code(string value){
			this.scenario_code_ = value;
		}
		public int? GetReturn_status(){
			return this.return_status_;
		}
		
		public void SetReturn_status(int? value){
			this.return_status_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}