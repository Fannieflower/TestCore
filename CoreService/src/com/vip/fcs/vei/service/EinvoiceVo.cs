using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class EinvoiceVo {
		
		///<summary>
		/// 发票代码
		///</summary>
		
		private string fpdm_;
		
		///<summary>
		/// 发票号码
		///</summary>
		
		private string fphm_;
		
		///<summary>
		/// pdf下载url
		///</summary>
		
		private string pdfUrl_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 卖方纳税人识别号
		///</summary>
		
		private string taxRegisterNo_;
		
		///<summary>
		/// 数据类型
		///</summary>
		
		private byte? dataType_;
		
		///<summary>
		/// 原发票代码
		///</summary>
		
		private string originFpdm_;
		
		///<summary>
		/// 原发票号码
		///</summary>
		
		private string originFphm_;
		
		///<summary>
		/// 发票唯一流水号
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 发票抬头，长度100
		///</summary>
		
		private string title_;
		
		///<summary>
		/// 纳税人识别号或统一社会信用代码，长度100
		///</summary>
		
		private string buyerTaxRegisterNo_;
		
		///<summary>
		/// 开票人手机号码，长度48
		///</summary>
		
		private string mobileNumber_;
		
		///<summary>
		/// 开票人电子邮箱，长度100
		///</summary>
		
		private string emailAddress_;
		
		///<summary>
		/// 买家纳税人地址，长度50
		///</summary>
		
		private string invoiceAddress_;
		
		///<summary>
		/// 买家纳税人开户银行，长度50
		///</summary>
		
		private string invoiceBank_;
		
		///<summary>
		/// 买家纳税人地址，长度27
		///</summary>
		
		private string invoiceBankAccount_;
		
		///<summary>
		/// 买家纳税人电话，长度50
		///</summary>
		
		private string invoicePhone_;
		
		///<summary>
		/// 类型，5为补开，6为重开
		///</summary>
		
		private string type_;
		
		///<summary>
		/// 开票内容。1为商品明细，2为商品类别。默认1商品明细。
		///</summary>
		
		private int? invoiceContentType_;
		
		public string GetFpdm(){
			return this.fpdm_;
		}
		
		public void SetFpdm(string value){
			this.fpdm_ = value;
		}
		public string GetFphm(){
			return this.fphm_;
		}
		
		public void SetFphm(string value){
			this.fphm_ = value;
		}
		public string GetPdfUrl(){
			return this.pdfUrl_;
		}
		
		public void SetPdfUrl(string value){
			this.pdfUrl_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetTaxRegisterNo(){
			return this.taxRegisterNo_;
		}
		
		public void SetTaxRegisterNo(string value){
			this.taxRegisterNo_ = value;
		}
		public byte? GetDataType(){
			return this.dataType_;
		}
		
		public void SetDataType(byte? value){
			this.dataType_ = value;
		}
		public string GetOriginFpdm(){
			return this.originFpdm_;
		}
		
		public void SetOriginFpdm(string value){
			this.originFpdm_ = value;
		}
		public string GetOriginFphm(){
			return this.originFphm_;
		}
		
		public void SetOriginFphm(string value){
			this.originFphm_ = value;
		}
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		public string GetBuyerTaxRegisterNo(){
			return this.buyerTaxRegisterNo_;
		}
		
		public void SetBuyerTaxRegisterNo(string value){
			this.buyerTaxRegisterNo_ = value;
		}
		public string GetMobileNumber(){
			return this.mobileNumber_;
		}
		
		public void SetMobileNumber(string value){
			this.mobileNumber_ = value;
		}
		public string GetEmailAddress(){
			return this.emailAddress_;
		}
		
		public void SetEmailAddress(string value){
			this.emailAddress_ = value;
		}
		public string GetInvoiceAddress(){
			return this.invoiceAddress_;
		}
		
		public void SetInvoiceAddress(string value){
			this.invoiceAddress_ = value;
		}
		public string GetInvoiceBank(){
			return this.invoiceBank_;
		}
		
		public void SetInvoiceBank(string value){
			this.invoiceBank_ = value;
		}
		public string GetInvoiceBankAccount(){
			return this.invoiceBankAccount_;
		}
		
		public void SetInvoiceBankAccount(string value){
			this.invoiceBankAccount_ = value;
		}
		public string GetInvoicePhone(){
			return this.invoicePhone_;
		}
		
		public void SetInvoicePhone(string value){
			this.invoicePhone_ = value;
		}
		public string GetType(){
			return this.type_;
		}
		
		public void SetType(string value){
			this.type_ = value;
		}
		public int? GetInvoiceContentType(){
			return this.invoiceContentType_;
		}
		
		public void SetInvoiceContentType(int? value){
			this.invoiceContentType_ = value;
		}
		
	}
	
}