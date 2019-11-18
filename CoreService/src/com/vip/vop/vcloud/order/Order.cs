using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class Order {
		
		///<summary>
		/// 渠道ID
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 订单下单时间
		///</summary>
		
		private long? orderTime_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 收货人
		///</summary>
		
		private string recipients_;
		
		///<summary>
		/// 手机号
		///</summary>
		
		private string mobileNo_;
		
		///<summary>
		/// 门店Id
		///</summary>
		
		private long? storeId_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 快递公司
		///</summary>
		
		private string expressCompany_;
		
		///<summary>
		/// 快递单号
		///</summary>
		
		private string expressNo_;
		
		///<summary>
		/// 确认发货时间
		///</summary>
		
		private long? deliveryTime_;
		
		///<summary>
		/// 订单类型
		///</summary>
		
		private int? orderSaleType_;
		
		///<summary>
		/// 预售时间
		///</summary>
		
		private long? preOrderReleaseDate_;
		
		///<summary>
		/// 门店备注
		///</summary>
		
		private string remark_;
		
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public long? GetOrderTime(){
			return this.orderTime_;
		}
		
		public void SetOrderTime(long? value){
			this.orderTime_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
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
		public long? GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(long? value){
			this.storeId_ = value;
		}
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		public string GetExpressCompany(){
			return this.expressCompany_;
		}
		
		public void SetExpressCompany(string value){
			this.expressCompany_ = value;
		}
		public string GetExpressNo(){
			return this.expressNo_;
		}
		
		public void SetExpressNo(string value){
			this.expressNo_ = value;
		}
		public long? GetDeliveryTime(){
			return this.deliveryTime_;
		}
		
		public void SetDeliveryTime(long? value){
			this.deliveryTime_ = value;
		}
		public int? GetOrderSaleType(){
			return this.orderSaleType_;
		}
		
		public void SetOrderSaleType(int? value){
			this.orderSaleType_ = value;
		}
		public long? GetPreOrderReleaseDate(){
			return this.preOrderReleaseDate_;
		}
		
		public void SetPreOrderReleaseDate(long? value){
			this.preOrderReleaseDate_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}