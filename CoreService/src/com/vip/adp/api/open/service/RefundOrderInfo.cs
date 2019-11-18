using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class RefundOrderInfo {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 申请时间:时间戳，单位毫秒
		///</summary>
		
		private long? applyTime_;
		
		///<summary>
		/// 维权类型：0-退货，1-换货
		///</summary>
		
		private int? refundType_;
		
		///<summary>
		/// 订单计佣金额:单位元
		///</summary>
		
		private string commissionTotalCost_;
		
		///<summary>
		/// 订单佣金：单位元
		///</summary>
		
		private string commission_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? goodsCount_;
		
		///<summary>
		/// 维权返还佣金的入账流水号
		///</summary>
		
		private string commissionEnterTxn_;
		
		///<summary>
		/// 维权返还佣金的入账时间: 时间戳，单位毫秒
		///</summary>
		
		private long? commissionEnterTime_;
		
		///<summary>
		/// 维权返回佣金的结算时间：时间戳，单位毫秒
		///</summary>
		
		private long? commissionSettledTime_;
		
		///<summary>
		/// 维权订单明细
		///</summary>
		
		private List<com.vip.adp.api.open.service.RefundOrderDetail> refundOrderDetails_;
		
		///<summary>
		/// 订单归属人id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 订单时间:时间戳，单位毫秒
		///</summary>
		
		private long? orderTime_;
		
		///<summary>
		/// 订单入账时间：发起维权之前入账时间，时间戳，单位毫秒
		///</summary>
		
		private long? originCommEnterTime_;
		
		///<summary>
		/// 订单入账流水：发起维权之前入账流水号
		///</summary>
		
		private string originCommEnterTxn_;
		
		///<summary>
		/// 售后订单结算状态：0-未结算，1-已结算
		///</summary>
		
		private int? settled_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public long? GetApplyTime(){
			return this.applyTime_;
		}
		
		public void SetApplyTime(long? value){
			this.applyTime_ = value;
		}
		public int? GetRefundType(){
			return this.refundType_;
		}
		
		public void SetRefundType(int? value){
			this.refundType_ = value;
		}
		public string GetCommissionTotalCost(){
			return this.commissionTotalCost_;
		}
		
		public void SetCommissionTotalCost(string value){
			this.commissionTotalCost_ = value;
		}
		public string GetCommission(){
			return this.commission_;
		}
		
		public void SetCommission(string value){
			this.commission_ = value;
		}
		public int? GetGoodsCount(){
			return this.goodsCount_;
		}
		
		public void SetGoodsCount(int? value){
			this.goodsCount_ = value;
		}
		public string GetCommissionEnterTxn(){
			return this.commissionEnterTxn_;
		}
		
		public void SetCommissionEnterTxn(string value){
			this.commissionEnterTxn_ = value;
		}
		public long? GetCommissionEnterTime(){
			return this.commissionEnterTime_;
		}
		
		public void SetCommissionEnterTime(long? value){
			this.commissionEnterTime_ = value;
		}
		public long? GetCommissionSettledTime(){
			return this.commissionSettledTime_;
		}
		
		public void SetCommissionSettledTime(long? value){
			this.commissionSettledTime_ = value;
		}
		public List<com.vip.adp.api.open.service.RefundOrderDetail> GetRefundOrderDetails(){
			return this.refundOrderDetails_;
		}
		
		public void SetRefundOrderDetails(List<com.vip.adp.api.open.service.RefundOrderDetail> value){
			this.refundOrderDetails_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public long? GetOrderTime(){
			return this.orderTime_;
		}
		
		public void SetOrderTime(long? value){
			this.orderTime_ = value;
		}
		public long? GetOriginCommEnterTime(){
			return this.originCommEnterTime_;
		}
		
		public void SetOriginCommEnterTime(long? value){
			this.originCommEnterTime_ = value;
		}
		public string GetOriginCommEnterTxn(){
			return this.originCommEnterTxn_;
		}
		
		public void SetOriginCommEnterTxn(string value){
			this.originCommEnterTxn_ = value;
		}
		public int? GetSettled(){
			return this.settled_;
		}
		
		public void SetSettled(int? value){
			this.settled_ = value;
		}
		
	}
	
}