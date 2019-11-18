using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderStatusInfo {
		
		///<summary>
		/// 外部订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员号
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 状态类型。1010000:'订单审核'，1080000:'拆分订单'，1010001:'取消订单'，1010002:'出仓'，1010003:'订单签收'，1010008:'订单完成'
		///</summary>
		
		private string scenario_code_;
		
		///<summary>
		/// 外部服务单状态环节。1001:'审核通过'，1002:'审核不通过'，2000:'已发货'，2100:'签收'，2200:'拒收'，3001:'取消订单审核通过'，3002:'取消订单审核不通过'，3003:'取消订单,物流拦截中'
		///</summary>
		
		private int? order_status_;
		
		///<summary>
		/// 业务更改时间
		///</summary>
		
		private string biz_update_time_;
		
		///<summary>
		/// 记录更新时间
		///</summary>
		
		private string update_time_;
		
		///<summary>
		/// 额外数据，JSON格式
		///</summary>
		
		private string extra_data_;
		
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
		public int? GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(int? value){
			this.order_status_ = value;
		}
		public string GetBiz_update_time(){
			return this.biz_update_time_;
		}
		
		public void SetBiz_update_time(string value){
			this.biz_update_time_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		public string GetExtra_data(){
			return this.extra_data_;
		}
		
		public void SetExtra_data(string value){
			this.extra_data_ = value;
		}
		
	}
	
}