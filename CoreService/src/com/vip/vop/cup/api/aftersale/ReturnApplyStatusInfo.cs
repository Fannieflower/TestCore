using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class ReturnApplyStatusInfo {
		
		///<summary>
		/// 外部售后申请单号，最大长度50
		///</summary>
		
		private string apply_id_;
		
		///<summary>
		/// 外部订单号，最大长度50
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员号，最大长度32
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 状态类型：审核/收货 等等，最大长度10
		///</summary>
		
		private string scenario_code_;
		
		///<summary>
		/// 外部服务单状态环节，最大长度10
		///</summary>
		
		private int? return_status_;
		
		///<summary>
		/// 额外数据，JSON格式
		///</summary>
		
		private string extra_data_;
		
		///<summary>
		/// 数据入接口表的时间，最大长度20
		///</summary>
		
		private string update_time_;
		
		///<summary>
		/// 业务处理时间，最大长度20
		///</summary>
		
		private string biz_update_time_;
		
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
		public string GetExtra_data(){
			return this.extra_data_;
		}
		
		public void SetExtra_data(string value){
			this.extra_data_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		public string GetBiz_update_time(){
			return this.biz_update_time_;
		}
		
		public void SetBiz_update_time(string value){
			this.biz_update_time_ = value;
		}
		
	}
	
}