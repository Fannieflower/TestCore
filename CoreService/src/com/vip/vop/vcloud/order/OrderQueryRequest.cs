using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderQueryRequest {
		
		///<summary>
		/// 合作伙伴ID
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 渠道ID
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 门店ID
		///</summary>
		
		private List<long?> warehouses_;
		
		///<summary>
		/// 收件人
		///</summary>
		
		private string recipients_;
		
		///<summary>
		/// 手机号
		///</summary>
		
		private string mobileNo_;
		
		///<summary>
		/// 物流单号
		///</summary>
		
		private string expressNo_;
		
		///<summary>
		/// 下单开始时间
		///</summary>
		
		private long? startTime_;
		
		///<summary>
		/// 下单结束时间
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 订单状态：0、待处理 1、待发货 3、历史订单 4、异常订单
		///</summary>
		
		private int? orderType_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页数量
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 是否包含订单明细
		///</summary>
		
		private bool? includeOrderDetail_;
		
		///<summary>
		/// 订单类型 0-普通 1-预售
		///</summary>
		
		private int? orderSaleType_;
		
		///<summary>
		/// 确认发货时间(开始)
		///</summary>
		
		private long? startDeliveryTime_;
		
		///<summary>
		/// 确认发货时间(结束)
		///</summary>
		
		private long? endDeliveryTime_;
		
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
		public List<long?> GetWarehouses(){
			return this.warehouses_;
		}
		
		public void SetWarehouses(List<long?> value){
			this.warehouses_ = value;
		}
		public string GetRecipients(){
			return this.recipients_;
		}
		
		public void SetRecipients(string value){
			this.recipients_ = value;
		}
		public string GetMobileNo(){
			return this.mobileNo_;
		}
		
		public void SetMobileNo(string value){
			this.mobileNo_ = value;
		}
		public string GetExpressNo(){
			return this.expressNo_;
		}
		
		public void SetExpressNo(string value){
			this.expressNo_ = value;
		}
		public long? GetStartTime(){
			return this.startTime_;
		}
		
		public void SetStartTime(long? value){
			this.startTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		public int? GetOrderType(){
			return this.orderType_;
		}
		
		public void SetOrderType(int? value){
			this.orderType_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public bool? GetIncludeOrderDetail(){
			return this.includeOrderDetail_;
		}
		
		public void SetIncludeOrderDetail(bool? value){
			this.includeOrderDetail_ = value;
		}
		public int? GetOrderSaleType(){
			return this.orderSaleType_;
		}
		
		public void SetOrderSaleType(int? value){
			this.orderSaleType_ = value;
		}
		public long? GetStartDeliveryTime(){
			return this.startDeliveryTime_;
		}
		
		public void SetStartDeliveryTime(long? value){
			this.startDeliveryTime_ = value;
		}
		public long? GetEndDeliveryTime(){
			return this.endDeliveryTime_;
		}
		
		public void SetEndDeliveryTime(long? value){
			this.endDeliveryTime_ = value;
		}
		
	}
	
}