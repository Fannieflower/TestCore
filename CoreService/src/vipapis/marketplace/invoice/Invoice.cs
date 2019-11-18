using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.invoice{
	
	
	
	
	
	public class Invoice {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 订单状态
		///</summary>
		
		private string order_status_;
		
		///<summary>
		/// 下单时间
		///</summary>
		
		private string order_time_;
		
		///<summary>
		/// 发票状态：0-未开具，1-开具中，2-已开具，9-开具失败
		///</summary>
		
		private string invoice_status_;
		
		///<summary>
		/// 发票类型：1 纸质发票 2电子发票
		///</summary>
		
		private string invoice_type_;
		
		///<summary>
		/// 发票抬头
		///</summary>
		
		private string invoice_title_;
		
		///<summary>
		/// 纳税人识别号
		///</summary>
		
		private string tax_payer_no_;
		
		///<summary>
		/// 发票金额
		///</summary>
		
		private string ex_pay_money_;
		
		///<summary>
		/// 发票运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 电子发票URL
		///</summary>
		
		private string invoice_url_;
		
		///<summary>
		/// 发票代码
		///</summary>
		
		private string invoice_code_;
		
		///<summary>
		/// 发票号码
		///</summary>
		
		private string invoice_num_;
		
		///<summary>
		/// 承运商
		///</summary>
		
		private string carrier_;
		
		///<summary>
		/// 是否红冲发票
		///</summary>
		
		private string red_punching_invoice_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(string value){
			this.order_status_ = value;
		}
		public string GetOrder_time(){
			return this.order_time_;
		}
		
		public void SetOrder_time(string value){
			this.order_time_ = value;
		}
		public string GetInvoice_status(){
			return this.invoice_status_;
		}
		
		public void SetInvoice_status(string value){
			this.invoice_status_ = value;
		}
		public string GetInvoice_type(){
			return this.invoice_type_;
		}
		
		public void SetInvoice_type(string value){
			this.invoice_type_ = value;
		}
		public string GetInvoice_title(){
			return this.invoice_title_;
		}
		
		public void SetInvoice_title(string value){
			this.invoice_title_ = value;
		}
		public string GetTax_payer_no(){
			return this.tax_payer_no_;
		}
		
		public void SetTax_payer_no(string value){
			this.tax_payer_no_ = value;
		}
		public string GetEx_pay_money(){
			return this.ex_pay_money_;
		}
		
		public void SetEx_pay_money(string value){
			this.ex_pay_money_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetInvoice_url(){
			return this.invoice_url_;
		}
		
		public void SetInvoice_url(string value){
			this.invoice_url_ = value;
		}
		public string GetInvoice_code(){
			return this.invoice_code_;
		}
		
		public void SetInvoice_code(string value){
			this.invoice_code_ = value;
		}
		public string GetInvoice_num(){
			return this.invoice_num_;
		}
		
		public void SetInvoice_num(string value){
			this.invoice_num_ = value;
		}
		public string GetCarrier(){
			return this.carrier_;
		}
		
		public void SetCarrier(string value){
			this.carrier_ = value;
		}
		public string GetRed_punching_invoice(){
			return this.red_punching_invoice_;
		}
		
		public void SetRed_punching_invoice(string value){
			this.red_punching_invoice_ = value;
		}
		
	}
	
}