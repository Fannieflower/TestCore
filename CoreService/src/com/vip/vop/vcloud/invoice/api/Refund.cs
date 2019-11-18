using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	
	
	public class Refund {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 渠道id
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 事务流水id
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 原订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 退款时间
		///</summary>
		
		private System.DateTime? refundTime_;
		
		///<summary>
		/// 退款总金额
		///</summary>
		
		private double? totalAmount_;
		
		///<summary>
		/// 退款sku列表
		///</summary>
		
		private List<com.vip.vop.vcloud.invoice.api.RefundDetail> details_;
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 处理状态
		///</summary>
		
		private byte? dealType_;
		
		///<summary>
		/// 退款总优惠金额
		///</summary>
		
		private double? discountAmount_;
		
		///<summary>
		/// 退款人信息
		///</summary>
		
		private com.vip.vop.vcloud.invoice.api.RefundShippingAddress shippingAddress_;
		
		///<summary>
		/// 小计
		///</summary>
		
		private double? subTotal_;
		
		///<summary>
		/// 支付方式
		///</summary>
		
		private string paymentMethod_;
		
		///<summary>
		/// 优惠描述
		///</summary>
		
		private string discountDescription_;
		
		///<summary>
		/// 退款类型
		///</summary>
		
		private string invoiceType_;
		
		///<summary>
		/// 退款状态 pending-处理中 audited-已审核 complete-已完成
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 客退单号
		///</summary>
		
		private string returnNo_;
		
		///<summary>
		/// 客款申请单号
		///</summary>
		
		private string returnApplicationId_;
		
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public System.DateTime? GetRefundTime(){
			return this.refundTime_;
		}
		
		public void SetRefundTime(System.DateTime? value){
			this.refundTime_ = value;
		}
		public double? GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(double? value){
			this.totalAmount_ = value;
		}
		public List<com.vip.vop.vcloud.invoice.api.RefundDetail> GetDetails(){
			return this.details_;
		}
		
		public void SetDetails(List<com.vip.vop.vcloud.invoice.api.RefundDetail> value){
			this.details_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public byte? GetDealType(){
			return this.dealType_;
		}
		
		public void SetDealType(byte? value){
			this.dealType_ = value;
		}
		public double? GetDiscountAmount(){
			return this.discountAmount_;
		}
		
		public void SetDiscountAmount(double? value){
			this.discountAmount_ = value;
		}
		public com.vip.vop.vcloud.invoice.api.RefundShippingAddress GetShippingAddress(){
			return this.shippingAddress_;
		}
		
		public void SetShippingAddress(com.vip.vop.vcloud.invoice.api.RefundShippingAddress value){
			this.shippingAddress_ = value;
		}
		public double? GetSubTotal(){
			return this.subTotal_;
		}
		
		public void SetSubTotal(double? value){
			this.subTotal_ = value;
		}
		public string GetPaymentMethod(){
			return this.paymentMethod_;
		}
		
		public void SetPaymentMethod(string value){
			this.paymentMethod_ = value;
		}
		public string GetDiscountDescription(){
			return this.discountDescription_;
		}
		
		public void SetDiscountDescription(string value){
			this.discountDescription_ = value;
		}
		public string GetInvoiceType(){
			return this.invoiceType_;
		}
		
		public void SetInvoiceType(string value){
			this.invoiceType_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetReturnNo(){
			return this.returnNo_;
		}
		
		public void SetReturnNo(string value){
			this.returnNo_ = value;
		}
		public string GetReturnApplicationId(){
			return this.returnApplicationId_;
		}
		
		public void SetReturnApplicationId(string value){
			this.returnApplicationId_ = value;
		}
		
	}
	
}