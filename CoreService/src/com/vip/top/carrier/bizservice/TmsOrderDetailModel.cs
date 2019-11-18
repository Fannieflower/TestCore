using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TmsOrderDetailModel {
		
		///<summary>
		/// 原始订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 所在仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 发货仓库编码
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		/// 收件人姓名
		///</summary>
		
		private string receiverName_;
		
		///<summary>
		/// 收件人手机号码
		///</summary>
		
		private string receiverPhone_;
		
		///<summary>
		/// 收件人电话
		///</summary>
		
		private string receiverMobile_;
		
		///<summary>
		/// 收件人省
		///</summary>
		
		private string receiverProvince_;
		
		///<summary>
		/// 收件人城市
		///</summary>
		
		private string receiverCity_;
		
		///<summary>
		/// 收件人区
		///</summary>
		
		private string receiverCounty_;
		
		///<summary>
		/// 收件人街道
		///</summary>
		
		private string receiverTown_;
		
		///<summary>
		/// 收件人地址
		///</summary>
		
		private string receiverAddress_;
		
		///<summary>
		/// 收件人邮政编码
		///</summary>
		
		private string receiverPostCode_;
		
		///<summary>
		/// 是否JITX订单
		///</summary>
		
		private int? isJitx_;
		
		///<summary>
		/// 包裹序号
		///</summary>
		
		private string boxSeq_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public string GetReceiverName(){
			return this.receiverName_;
		}
		
		public void SetReceiverName(string value){
			this.receiverName_ = value;
		}
		public string GetReceiverPhone(){
			return this.receiverPhone_;
		}
		
		public void SetReceiverPhone(string value){
			this.receiverPhone_ = value;
		}
		public string GetReceiverMobile(){
			return this.receiverMobile_;
		}
		
		public void SetReceiverMobile(string value){
			this.receiverMobile_ = value;
		}
		public string GetReceiverProvince(){
			return this.receiverProvince_;
		}
		
		public void SetReceiverProvince(string value){
			this.receiverProvince_ = value;
		}
		public string GetReceiverCity(){
			return this.receiverCity_;
		}
		
		public void SetReceiverCity(string value){
			this.receiverCity_ = value;
		}
		public string GetReceiverCounty(){
			return this.receiverCounty_;
		}
		
		public void SetReceiverCounty(string value){
			this.receiverCounty_ = value;
		}
		public string GetReceiverTown(){
			return this.receiverTown_;
		}
		
		public void SetReceiverTown(string value){
			this.receiverTown_ = value;
		}
		public string GetReceiverAddress(){
			return this.receiverAddress_;
		}
		
		public void SetReceiverAddress(string value){
			this.receiverAddress_ = value;
		}
		public string GetReceiverPostCode(){
			return this.receiverPostCode_;
		}
		
		public void SetReceiverPostCode(string value){
			this.receiverPostCode_ = value;
		}
		public int? GetIsJitx(){
			return this.isJitx_;
		}
		
		public void SetIsJitx(int? value){
			this.isJitx_ = value;
		}
		public string GetBoxSeq(){
			return this.boxSeq_;
		}
		
		public void SetBoxSeq(string value){
			this.boxSeq_ = value;
		}
		
	}
	
}