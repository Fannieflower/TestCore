using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class MpInvoiceIssueResultRequestModel {
		
		///<summary>
		/// 开票流水号。
		///</summary>
		
		private string serialNo_;
		
		///<summary>
		/// 第三方开票平台标记
		///</summary>
		
		private string trusteeshipPlatform_;
		
		///<summary>
		/// 结果类型。1为成功，2为驳回，3为异常
		///</summary>
		
		private string resultType_;
		
		///<summary>
		/// 开票结果，resultType=1时必填。
		///</summary>
		
		private com.vip.fcs.vei.service.MpInvoiceIssueResultModel mpInvoiceIssueResultModel_;
		
		///<summary>
		/// 驳回或异常消息，resultType=2或resultType=3时必填。
		///</summary>
		
		private com.vip.fcs.vei.service.InvoiceIssueResultMessage invoiceIssueResultMessage_;
		
		public string GetSerialNo(){
			return this.serialNo_;
		}
		
		public void SetSerialNo(string value){
			this.serialNo_ = value;
		}
		public string GetTrusteeshipPlatform(){
			return this.trusteeshipPlatform_;
		}
		
		public void SetTrusteeshipPlatform(string value){
			this.trusteeshipPlatform_ = value;
		}
		public string GetResultType(){
			return this.resultType_;
		}
		
		public void SetResultType(string value){
			this.resultType_ = value;
		}
		public com.vip.fcs.vei.service.MpInvoiceIssueResultModel GetMpInvoiceIssueResultModel(){
			return this.mpInvoiceIssueResultModel_;
		}
		
		public void SetMpInvoiceIssueResultModel(com.vip.fcs.vei.service.MpInvoiceIssueResultModel value){
			this.mpInvoiceIssueResultModel_ = value;
		}
		public com.vip.fcs.vei.service.InvoiceIssueResultMessage GetInvoiceIssueResultMessage(){
			return this.invoiceIssueResultMessage_;
		}
		
		public void SetInvoiceIssueResultMessage(com.vip.fcs.vei.service.InvoiceIssueResultMessage value){
			this.invoiceIssueResultMessage_ = value;
		}
		
	}
	
}