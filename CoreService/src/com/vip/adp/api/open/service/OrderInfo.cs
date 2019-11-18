using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class OrderInfo {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 订单状态:0-不合格，1-待定，2-已完结
		///</summary>
		
		private short? status_;
		
		///<summary>
		/// 新老客：0-待定，1-新客，2-老客
		///</summary>
		
		private short? newCustomer_;
		
		///<summary>
		/// 渠道标识
		///</summary>
		
		private string channelTag_;
		
		///<summary>
		/// 下单时间 时间戳 单位毫秒
		///</summary>
		
		private long? orderTime_;
		
		///<summary>
		/// 签收时间 时间戳 单位毫秒
		///</summary>
		
		private long? signTime_;
		
		///<summary>
		/// 结算时间 时间戳 单位毫秒
		///</summary>
		
		private long? settledTime_;
		
		///<summary>
		/// 商品明细
		///</summary>
		
		private List<com.vip.adp.api.open.service.OrderDetailInfo> detailList_;
		
		///<summary>
		/// 订单上次更新时间 时间戳 单位毫秒
		///</summary>
		
		private long? lastUpdateTime_;
		
		///<summary>
		/// 订单结算状态 0-未结算,1-已结算
		///</summary>
		
		private short? settled_;
		
		///<summary>
		/// 是否自推自买 0-否，1-是
		///</summary>
		
		private int? selfBuy_;
		
		///<summary>
		/// 订单子状态：流转状态-支持状态：（已下单、已付款、已签收、待结算、已结算、已失效）
		///</summary>
		
		private string orderSubStatusName_;
		
		///<summary>
		/// 商品总佣金:单位元
		///</summary>
		
		private string commission_;
		
		///<summary>
		/// 售后订单佣金变动：仅在订单完结之后发生售后行为时返回
		///</summary>
		
		private string afterSaleChangeCommission_;
		
		///<summary>
		/// 售后订单总商品数量变动：仅在订单完结之后发生售后行为时返回
		///</summary>
		
		private int? afterSaleChangeGoodsCount_;
		
		///<summary>
		/// 入账时间，时间戳，单位毫秒
		///</summary>
		
		private long? commissionEnterTime_;
		
		///<summary>
		/// 订单来源
		///</summary>
		
		private string orderSource_;
		
		///<summary>
		/// 推广PID
		///</summary>
		
		private string pid_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public short? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(short? value){
			this.status_ = value;
		}
		public short? GetNewCustomer(){
			return this.newCustomer_;
		}
		
		public void SetNewCustomer(short? value){
			this.newCustomer_ = value;
		}
		public string GetChannelTag(){
			return this.channelTag_;
		}
		
		public void SetChannelTag(string value){
			this.channelTag_ = value;
		}
		public long? GetOrderTime(){
			return this.orderTime_;
		}
		
		public void SetOrderTime(long? value){
			this.orderTime_ = value;
		}
		public long? GetSignTime(){
			return this.signTime_;
		}
		
		public void SetSignTime(long? value){
			this.signTime_ = value;
		}
		public long? GetSettledTime(){
			return this.settledTime_;
		}
		
		public void SetSettledTime(long? value){
			this.settledTime_ = value;
		}
		public List<com.vip.adp.api.open.service.OrderDetailInfo> GetDetailList(){
			return this.detailList_;
		}
		
		public void SetDetailList(List<com.vip.adp.api.open.service.OrderDetailInfo> value){
			this.detailList_ = value;
		}
		public long? GetLastUpdateTime(){
			return this.lastUpdateTime_;
		}
		
		public void SetLastUpdateTime(long? value){
			this.lastUpdateTime_ = value;
		}
		public short? GetSettled(){
			return this.settled_;
		}
		
		public void SetSettled(short? value){
			this.settled_ = value;
		}
		public int? GetSelfBuy(){
			return this.selfBuy_;
		}
		
		public void SetSelfBuy(int? value){
			this.selfBuy_ = value;
		}
		public string GetOrderSubStatusName(){
			return this.orderSubStatusName_;
		}
		
		public void SetOrderSubStatusName(string value){
			this.orderSubStatusName_ = value;
		}
		public string GetCommission(){
			return this.commission_;
		}
		
		public void SetCommission(string value){
			this.commission_ = value;
		}
		public string GetAfterSaleChangeCommission(){
			return this.afterSaleChangeCommission_;
		}
		
		public void SetAfterSaleChangeCommission(string value){
			this.afterSaleChangeCommission_ = value;
		}
		public int? GetAfterSaleChangeGoodsCount(){
			return this.afterSaleChangeGoodsCount_;
		}
		
		public void SetAfterSaleChangeGoodsCount(int? value){
			this.afterSaleChangeGoodsCount_ = value;
		}
		public long? GetCommissionEnterTime(){
			return this.commissionEnterTime_;
		}
		
		public void SetCommissionEnterTime(long? value){
			this.commissionEnterTime_ = value;
		}
		public string GetOrderSource(){
			return this.orderSource_;
		}
		
		public void SetOrderSource(string value){
			this.orderSource_ = value;
		}
		public string GetPid(){
			return this.pid_;
		}
		
		public void SetPid(string value){
			this.pid_ = value;
		}
		
	}
	
}