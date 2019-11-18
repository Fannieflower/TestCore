using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.invoice{
	
	
	
	
	
	public class ConfirmInvoiceRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 发票类型：1 纸质发票 2电子发票
		///</summary>
		
		private string invoice_type_;
		
		///<summary>
		/// 发票抬头，最大长度100
		///</summary>
		
		private string invoice_title_;
		
		///<summary>
		/// 发票号码，电子发票必填，最大长度30
		///</summary>
		
		private string invoice_num_;
		
		///<summary>
		/// 发票代码，电子发票必填，最大长度30
		///</summary>
		
		private string invoice_code_;
		
		///<summary>
		/// 发票下载链接，电子发票必填，最大长度700
		///</summary>
		
		private string invoice_url_;
		
		///<summary>
		/// 是否红冲发票：1 是 ， 2 否。 默认否
		///</summary>
		
		private string red_punching_invoice_;
		
		///<summary>
		/// 承运商，纸质发票非空
		///</summary>
		
		private string carrier_;
		
		///<summary>
		/// 发票运单号，纸质发票非空，最大长度100
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 原发票号码，红冲发票不能为空 ，最大长度30，电子发票非空
		///</summary>
		
		private string blue_invoice_num_;
		
		///<summary>
		/// 原发票代码，红冲发票不能为空 ， 最大长度30，电子发票非空
		///</summary>
		
		private string blue_invoice_code_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operator_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
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
		public string GetInvoice_num(){
			return this.invoice_num_;
		}
		
		public void SetInvoice_num(string value){
			this.invoice_num_ = value;
		}
		public string GetInvoice_code(){
			return this.invoice_code_;
		}
		
		public void SetInvoice_code(string value){
			this.invoice_code_ = value;
		}
		public string GetInvoice_url(){
			return this.invoice_url_;
		}
		
		public void SetInvoice_url(string value){
			this.invoice_url_ = value;
		}
		public string GetRed_punching_invoice(){
			return this.red_punching_invoice_;
		}
		
		public void SetRed_punching_invoice(string value){
			this.red_punching_invoice_ = value;
		}
		public string GetCarrier(){
			return this.carrier_;
		}
		
		public void SetCarrier(string value){
			this.carrier_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetBlue_invoice_num(){
			return this.blue_invoice_num_;
		}
		
		public void SetBlue_invoice_num(string value){
			this.blue_invoice_num_ = value;
		}
		public string GetBlue_invoice_code(){
			return this.blue_invoice_code_;
		}
		
		public void SetBlue_invoice_code(string value){
			this.blue_invoice_code_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}