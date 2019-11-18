using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class ExternalInvoiceHandleState {
		
		///<summary>
		/// 0为未处理，1为已处理
		///</summary>
		
		private string state_;
		
		///<summary>
		/// 发票代码
		///</summary>
		
		private string fpdm_;
		
		///<summary>
		/// 发票号码
		///</summary>
		
		private string fphm_;
		
		///<summary>
		/// 订单号码
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 响应状态
		///</summary>
		
		private com.vip.fcs.vei.service.BaseRetMsg retMsg_;
		
		///<summary>
		/// 店铺来源
		///</summary>
		
		private string storeSource_;
		
		///<summary>
		/// 店铺id
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 用户id
		///</summary>
		
		private string userId_;
		
		///<summary>
		/// 0位默认值。1为销售，正常订单。2为取消，取消订单。3为拒收，拒收订单。4为退货
		///</summary>
		
		private string type_;
		
		///<summary>
		/// 售后申请单单号
		///</summary>
		
		private string orderReturnNo_;
		
		///<summary>
		/// 电子发票PDF下载url
		///</summary>
		
		private string pdfUrl_;
		
		///<summary>
		/// 卖方纳税人识别号--供应商的
		///</summary>
		
		private string taxRegisterNo_;
		
		///<summary>
		/// 序列号
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 发票金额
		///</summary>
		
		private string invoiceAmount_;
		
		///<summary>
		/// 发票请求流水号
		///</summary>
		
		private string invoiceSeqNo_;
		
		public string GetState(){
			return this.state_;
		}
		
		public void SetState(string value){
			this.state_ = value;
		}
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
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public com.vip.fcs.vei.service.BaseRetMsg GetRetMsg(){
			return this.retMsg_;
		}
		
		public void SetRetMsg(com.vip.fcs.vei.service.BaseRetMsg value){
			this.retMsg_ = value;
		}
		public string GetStoreSource(){
			return this.storeSource_;
		}
		
		public void SetStoreSource(string value){
			this.storeSource_ = value;
		}
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public string GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(string value){
			this.userId_ = value;
		}
		public string GetType(){
			return this.type_;
		}
		
		public void SetType(string value){
			this.type_ = value;
		}
		public string GetOrderReturnNo(){
			return this.orderReturnNo_;
		}
		
		public void SetOrderReturnNo(string value){
			this.orderReturnNo_ = value;
		}
		public string GetPdfUrl(){
			return this.pdfUrl_;
		}
		
		public void SetPdfUrl(string value){
			this.pdfUrl_ = value;
		}
		public string GetTaxRegisterNo(){
			return this.taxRegisterNo_;
		}
		
		public void SetTaxRegisterNo(string value){
			this.taxRegisterNo_ = value;
		}
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public string GetInvoiceAmount(){
			return this.invoiceAmount_;
		}
		
		public void SetInvoiceAmount(string value){
			this.invoiceAmount_ = value;
		}
		public string GetInvoiceSeqNo(){
			return this.invoiceSeqNo_;
		}
		
		public void SetInvoiceSeqNo(string value){
			this.invoiceSeqNo_ = value;
		}
		
	}
	
}