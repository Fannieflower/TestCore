using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.omni.logistics{
	
	
	
	
	
	public class MaxSpeedRouteInfo {
		
		///<summary>
		/// 顺丰订单ID
		///</summary>
		
		private string sfOrderId_;
		
		///<summary>
		/// 商家订单ID-对应唯品会OrderSn
		///</summary>
		
		private string shopOrderId_;
		
		///<summary>
		/// 回调url前缀
		///</summary>
		
		private string urlIndex_;
		
		///<summary>
		/// 配送员姓名
		///</summary>
		
		private string operatorName_;
		
		///<summary>
		/// 配送员电话
		///</summary>
		
		private string operatorPhone_;
		
		///<summary>
		/// 配送员位置经度
		///</summary>
		
		private string riderLng_;
		
		///<summary>
		/// 配送员位置纬度
		///</summary>
		
		private string riderLat_;
		
		///<summary>
		/// 订单状态-10-配送员确认;12:配送员到店;15:配送员配送中
		///</summary>
		
		private int? orderStatus_;
		
		///<summary>
		/// 状态描述
		///</summary>
		
		private string statusDesc_;
		
		///<summary>
		/// 推送时间，时间戳
		///</summary>
		
		private int? pushTime_;
		
		///<summary>
		/// 加密签名
		///</summary>
		
		private string sign_;
		
		public string GetSfOrderId(){
			return this.sfOrderId_;
		}
		
		public void SetSfOrderId(string value){
			this.sfOrderId_ = value;
		}
		public string GetShopOrderId(){
			return this.shopOrderId_;
		}
		
		public void SetShopOrderId(string value){
			this.shopOrderId_ = value;
		}
		public string GetUrlIndex(){
			return this.urlIndex_;
		}
		
		public void SetUrlIndex(string value){
			this.urlIndex_ = value;
		}
		public string GetOperatorName(){
			return this.operatorName_;
		}
		
		public void SetOperatorName(string value){
			this.operatorName_ = value;
		}
		public string GetOperatorPhone(){
			return this.operatorPhone_;
		}
		
		public void SetOperatorPhone(string value){
			this.operatorPhone_ = value;
		}
		public string GetRiderLng(){
			return this.riderLng_;
		}
		
		public void SetRiderLng(string value){
			this.riderLng_ = value;
		}
		public string GetRiderLat(){
			return this.riderLat_;
		}
		
		public void SetRiderLat(string value){
			this.riderLat_ = value;
		}
		public int? GetOrderStatus(){
			return this.orderStatus_;
		}
		
		public void SetOrderStatus(int? value){
			this.orderStatus_ = value;
		}
		public string GetStatusDesc(){
			return this.statusDesc_;
		}
		
		public void SetStatusDesc(string value){
			this.statusDesc_ = value;
		}
		public int? GetPushTime(){
			return this.pushTime_;
		}
		
		public void SetPushTime(int? value){
			this.pushTime_ = value;
		}
		public string GetSign(){
			return this.sign_;
		}
		
		public void SetSign(string value){
			this.sign_ = value;
		}
		
	}
	
}