using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderBasicInfo {
		
		///<summary>
		/// 外部母单号
		///</summary>
		
		private string parent_order_sn_;
		
		///<summary>
		/// 外部订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 外部会员号
		///</summary>
		
		private string user_code_;
		
		///<summary>
		/// 下单时间
		///</summary>
		
		private string add_time_;
		
		///<summary>
		/// 支付时间
		///</summary>
		
		private string pay_time_;
		
		///<summary>
		/// 支付金额
		///</summary>
		
		private string money_;
		
		///<summary>
		/// 支付人姓名
		///</summary>
		
		private string payer_;
		
		///<summary>
		/// 货款金额，订单总金额-商家优惠金额，没有商家优惠时，填订单金额
		///</summary>
		
		private string seller_money_;
		
		///<summary>
		/// 运费，若无运费填 0
		///</summary>
		
		private string carriage_;
		
		///<summary>
		/// 送货类型 1-快递,3-上门自提
		///</summary>
		
		private int? transport_way_;
		
		///<summary>
		/// 配送特殊要求
		///</summary>
		
		private string transport_special_req_;
		
		///<summary>
		/// 送货方式 1-不限,2-双休日,3-工作日
		///</summary>
		
		private int? transport_day_;
		
		///<summary>
		/// 配送时间 1-全天 2-白天 3-夜间
		///</summary>
		
		private int? transport_time_;
		
		///<summary>
		/// 买家备注
		///</summary>
		
		private string user_remark_;
		
		///<summary>
		/// 卖家备注
		///</summary>
		
		private string seller_remark_;
		
		///<summary>
		/// 外部订单状态更新时间
		///</summary>
		
		private string update_time_;
		
		public string GetParent_order_sn(){
			return this.parent_order_sn_;
		}
		
		public void SetParent_order_sn(string value){
			this.parent_order_sn_ = value;
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
		public string GetPay_time(){
			return this.pay_time_;
		}
		
		public void SetPay_time(string value){
			this.pay_time_ = value;
		}
		public string GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(string value){
			this.money_ = value;
		}
		public string GetPayer(){
			return this.payer_;
		}
		
		public void SetPayer(string value){
			this.payer_ = value;
		}
		public string GetSeller_money(){
			return this.seller_money_;
		}
		
		public void SetSeller_money(string value){
			this.seller_money_ = value;
		}
		public string GetCarriage(){
			return this.carriage_;
		}
		
		public void SetCarriage(string value){
			this.carriage_ = value;
		}
		public int? GetTransport_way(){
			return this.transport_way_;
		}
		
		public void SetTransport_way(int? value){
			this.transport_way_ = value;
		}
		public string GetTransport_special_req(){
			return this.transport_special_req_;
		}
		
		public void SetTransport_special_req(string value){
			this.transport_special_req_ = value;
		}
		public int? GetTransport_day(){
			return this.transport_day_;
		}
		
		public void SetTransport_day(int? value){
			this.transport_day_ = value;
		}
		public int? GetTransport_time(){
			return this.transport_time_;
		}
		
		public void SetTransport_time(int? value){
			this.transport_time_ = value;
		}
		public string GetUser_remark(){
			return this.user_remark_;
		}
		
		public void SetUser_remark(string value){
			this.user_remark_ = value;
		}
		public string GetSeller_remark(){
			return this.seller_remark_;
		}
		
		public void SetSeller_remark(string value){
			this.seller_remark_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		
	}
	
}