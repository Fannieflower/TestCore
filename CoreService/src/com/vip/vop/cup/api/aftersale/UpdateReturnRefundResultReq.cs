using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class UpdateReturnRefundResultReq {
		
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
		/// 退款金额，最大长度50
		///</summary>
		
		private string refund_money_;
		
		///<summary>
		/// 货款退款金额 = 退款金额 - 所退商品商家优惠金额，最大长度50
		///</summary>
		
		private string seller_refund_money_;
		
		///<summary>
		/// 退款完成时间，最大长度20
		///</summary>
		
		private string refund_time_;
		
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
		public string GetRefund_money(){
			return this.refund_money_;
		}
		
		public void SetRefund_money(string value){
			this.refund_money_ = value;
		}
		public string GetSeller_refund_money(){
			return this.seller_refund_money_;
		}
		
		public void SetSeller_refund_money(string value){
			this.seller_refund_money_ = value;
		}
		public string GetRefund_time(){
			return this.refund_time_;
		}
		
		public void SetRefund_time(string value){
			this.refund_time_ = value;
		}
		
	}
	
}