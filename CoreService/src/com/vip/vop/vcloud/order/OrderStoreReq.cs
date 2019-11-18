using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderStoreReq {
		
		///<summary>
		/// 渠道ID
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 合作伙伴ID
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 操作人账号
		///</summary>
		
		private string account_;
		
		///<summary>
		/// 操作说明
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 指定的门店ID
		///</summary>
		
		private long? appointToStoreId_;
		
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
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
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		public string GetAccount(){
			return this.account_;
		}
		
		public void SetAccount(string value){
			this.account_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public long? GetAppointToStoreId(){
			return this.appointToStoreId_;
		}
		
		public void SetAppointToStoreId(long? value){
			this.appointToStoreId_ = value;
		}
		
	}
	
}