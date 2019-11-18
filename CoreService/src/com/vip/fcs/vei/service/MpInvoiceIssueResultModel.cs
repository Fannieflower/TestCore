using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class MpInvoiceIssueResultModel {
		
		///<summary>
		/// 发票代码,长度12
		///</summary>
		
		private string invoiceCode_;
		
		///<summary>
		/// 发票号码，长度8
		///</summary>
		
		private string invoiceNo_;
		
		///<summary>
		/// 开票日期。格式：yyyyMMddHHmmss
		///</summary>
		
		private string invoiceDate_;
		
		///<summary>
		/// PDF下载地址，长度200
		///</summary>
		
		private string pdfUrl_;
		
		///<summary>
		/// 税控码,对应发票的密码区,长度112
		///</summary>
		
		private string taxControlCode_;
		
		///<summary>
		/// 校验码，长度22.
		///</summary>
		
		private string invoiceCheckCode_;
		
		///<summary>
		/// 二维码，打印在发票页面上的二维码
		///</summary>
		
		private string invoiceQrCode_;
		
		public string GetInvoiceCode(){
			return this.invoiceCode_;
		}
		
		public void SetInvoiceCode(string value){
			this.invoiceCode_ = value;
		}
		public string GetInvoiceNo(){
			return this.invoiceNo_;
		}
		
		public void SetInvoiceNo(string value){
			this.invoiceNo_ = value;
		}
		public string GetInvoiceDate(){
			return this.invoiceDate_;
		}
		
		public void SetInvoiceDate(string value){
			this.invoiceDate_ = value;
		}
		public string GetPdfUrl(){
			return this.pdfUrl_;
		}
		
		public void SetPdfUrl(string value){
			this.pdfUrl_ = value;
		}
		public string GetTaxControlCode(){
			return this.taxControlCode_;
		}
		
		public void SetTaxControlCode(string value){
			this.taxControlCode_ = value;
		}
		public string GetInvoiceCheckCode(){
			return this.invoiceCheckCode_;
		}
		
		public void SetInvoiceCheckCode(string value){
			this.invoiceCheckCode_ = value;
		}
		public string GetInvoiceQrCode(){
			return this.invoiceQrCode_;
		}
		
		public void SetInvoiceQrCode(string value){
			this.invoiceQrCode_ = value;
		}
		
	}
	
}