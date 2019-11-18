using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class SubOrder {
		
		///<summary>
		/// 订单ID
		///</summary>
		
		private long? orderId_;
		
		///<summary>
		/// 子订单ID
		///</summary>
		
		private long? subOrderId_;
		
		///<summary>
		/// 合作伙伴
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 渠道Id
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 剩余未装箱数
		///</summary>
		
		private int? leavingUnboxQuantity_;
		
		///<summary>
		/// 未装箱数
		///</summary>
		
		private int? unboxQuantity_;
		
		public long? GetOrderId(){
			return this.orderId_;
		}
		
		public void SetOrderId(long? value){
			this.orderId_ = value;
		}
		public long? GetSubOrderId(){
			return this.subOrderId_;
		}
		
		public void SetSubOrderId(long? value){
			this.subOrderId_ = value;
		}
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
		public int? GetLeavingUnboxQuantity(){
			return this.leavingUnboxQuantity_;
		}
		
		public void SetLeavingUnboxQuantity(int? value){
			this.leavingUnboxQuantity_ = value;
		}
		public int? GetUnboxQuantity(){
			return this.unboxQuantity_;
		}
		
		public void SetUnboxQuantity(int? value){
			this.unboxQuantity_ = value;
		}
		
	}
	
}