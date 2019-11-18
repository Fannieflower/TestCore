using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class ReturnApply {
		
		///<summary>
		/// 外部退款申请单号，最大长度：50
		///</summary>
		
		private string apply_id_;
		
		///<summary>
		/// 外部订单号，最大长度：50
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员ID，最大长度：32
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 申请时间，最大长度：19,格式：yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string add_time_;
		
		///<summary>
		/// 原因ID：35（当期只支持一种）
		///</summary>
		
		private int? reason_id_;
		
		///<summary>
		/// 退回原因描述，最大长度：100
		///</summary>
		
		private string reason_;
		
		///<summary>
		/// 订单用户备注，最大长度：255
		///</summary>
		
		private string user_remark_;
		
		///<summary>
		/// 商家备注，最大长度：255
		///</summary>
		
		private string admin_remark_;
		
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
		public string GetAdd_time(){
			return this.add_time_;
		}
		
		public void SetAdd_time(string value){
			this.add_time_ = value;
		}
		public int? GetReason_id(){
			return this.reason_id_;
		}
		
		public void SetReason_id(int? value){
			this.reason_id_ = value;
		}
		public string GetReason(){
			return this.reason_;
		}
		
		public void SetReason(string value){
			this.reason_ = value;
		}
		public string GetUser_remark(){
			return this.user_remark_;
		}
		
		public void SetUser_remark(string value){
			this.user_remark_ = value;
		}
		public string GetAdmin_remark(){
			return this.admin_remark_;
		}
		
		public void SetAdmin_remark(string value){
			this.admin_remark_ = value;
		}
		
	}
	
}