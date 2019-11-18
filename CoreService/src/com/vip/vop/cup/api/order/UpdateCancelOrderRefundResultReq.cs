using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class UpdateCancelOrderRefundResultReq {
		
		///<summary>
		/// 外部订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员ID
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 外部服务单状态，最大长度：10。3200： "取消订单退款待处理"
		///</summary>
		
		private int? order_status_;
		
		///<summary>
		/// 外部服务单更改时间,格式：yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string update_time_;
		
		///<summary>
		/// 额外数据 JSON
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
		public int? GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(int? value){
			this.order_status_ = value;
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