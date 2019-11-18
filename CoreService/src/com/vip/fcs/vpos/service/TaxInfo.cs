using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class TaxInfo {
		
		///<summary>
		/// 平台编码
		///</summary>
		
		private string platformCode_;
		
		///<summary>
		/// 返回结果详情
		///</summary>
		
		private string message_;
		
		///<summary>
		/// 通知类型 1.蓝票或者2.红票
		///</summary>
		
		private string notifyType_;
		
		///<summary>
		/// 通知时间 格式 2017-09-09 10:20:12
		///</summary>
		
		private string notifyTime_;
		
		///<summary>
		/// 商户交易流水号(由商户维护唯一性)
		///</summary>
		
		private string orderId_;
		
		///<summary>
		/// 发票号码 开票失败时值为空
		///</summary>
		
		private string ticketSn_;
		
		///<summary>
		/// 发票代码 开票失败时值为空
		///</summary>
		
		private string ticketCode_;
		
		///<summary>
		/// 开票时间
		///</summary>
		
		private string ticketDate_;
		
		///<summary>
		/// 发票状态（1开票中,2开票成功 -2开票失败）
		///</summary>
		
		private int? ticketStatus_;
		
		///<summary>
		/// 发票含税总价 开票失败时值为空
		///</summary>
		
		private string amountHasTax_;
		
		///<summary>
		/// 发票去税总价 开票失败时值为空
		///</summary>
		
		private string amountNoTax_;
		
		///<summary>
		/// 发票税额 开票失败时值为空
		///</summary>
		
		private string ticketTaxAmount_;
		
		///<summary>
		/// 发票校验码 开票失败时值为空
		///</summary>
		
		private string checkCode_;
		
		///<summary>
		/// 发票url地址 开票失败时值为空
		///</summary>
		
		private string pdfUrl_;
		
		public string GetPlatformCode(){
			return this.platformCode_;
		}
		
		public void SetPlatformCode(string value){
			this.platformCode_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		public string GetNotifyType(){
			return this.notifyType_;
		}
		
		public void SetNotifyType(string value){
			this.notifyType_ = value;
		}
		public string GetNotifyTime(){
			return this.notifyTime_;
		}
		
		public void SetNotifyTime(string value){
			this.notifyTime_ = value;
		}
		public string GetOrderId(){
			return this.orderId_;
		}
		
		public void SetOrderId(string value){
			this.orderId_ = value;
		}
		public string GetTicketSn(){
			return this.ticketSn_;
		}
		
		public void SetTicketSn(string value){
			this.ticketSn_ = value;
		}
		public string GetTicketCode(){
			return this.ticketCode_;
		}
		
		public void SetTicketCode(string value){
			this.ticketCode_ = value;
		}
		public string GetTicketDate(){
			return this.ticketDate_;
		}
		
		public void SetTicketDate(string value){
			this.ticketDate_ = value;
		}
		public int? GetTicketStatus(){
			return this.ticketStatus_;
		}
		
		public void SetTicketStatus(int? value){
			this.ticketStatus_ = value;
		}
		public string GetAmountHasTax(){
			return this.amountHasTax_;
		}
		
		public void SetAmountHasTax(string value){
			this.amountHasTax_ = value;
		}
		public string GetAmountNoTax(){
			return this.amountNoTax_;
		}
		
		public void SetAmountNoTax(string value){
			this.amountNoTax_ = value;
		}
		public string GetTicketTaxAmount(){
			return this.ticketTaxAmount_;
		}
		
		public void SetTicketTaxAmount(string value){
			this.ticketTaxAmount_ = value;
		}
		public string GetCheckCode(){
			return this.checkCode_;
		}
		
		public void SetCheckCode(string value){
			this.checkCode_ = value;
		}
		public string GetPdfUrl(){
			return this.pdfUrl_;
		}
		
		public void SetPdfUrl(string value){
			this.pdfUrl_ = value;
		}
		
	}
	
}