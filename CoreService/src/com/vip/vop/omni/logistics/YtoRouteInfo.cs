using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.omni.logistics{
	
	
	
	
	
	public class YtoRouteInfo {
		
		///<summary>
		/// 固定YTO
		///</summary>
		
		private string logisticProviderId_;
		
		///<summary>
		/// 唯品会在圆通的客户编码
		///</summary>
		
		private string clientId_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string mailNo_;
		
		///<summary>
		/// 物流号
		///</summary>
		
		private string txLogisticId_;
		
		///<summary>
		/// 通知类型STATUS：物流状态
		///</summary>
		
		private string infoType_;
		
		///<summary>
		/// 操作，固定为：ACCEPT-接单;UNACCEPT-不接单;GOT-已收件;NOT_SEND-揽收失败;ARRIVAL-已收入;DEPARTURE-已发出;PACKAGE-已打包;UNPACK-已拆包;SENT_SCAN-派件;SIGNED-签收成功;FAILED-签收失败
		///</summary>
		
		private string infoContent_;
		
		///<summary>
		/// 备注或失败原因（值为中文原因或备注）
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 揽收重量
		///</summary>
		
		private double? weight_;
		
		///<summary>
		/// 签收人
		///</summary>
		
		private string signedName_;
		
		///<summary>
		/// 该状态操作人员，签收、派送、揽件
		///</summary>
		
		private string deliveryName_;
		
		///<summary>
		/// 事件发生时间
		///</summary>
		
		private System.DateTime? acceptTime_;
		
		///<summary>
		/// 联系方式（包括手机，电话等）
		///</summary>
		
		private string contactInfo_;
		
		public string GetLogisticProviderId(){
			return this.logisticProviderId_;
		}
		
		public void SetLogisticProviderId(string value){
			this.logisticProviderId_ = value;
		}
		public string GetClientId(){
			return this.clientId_;
		}
		
		public void SetClientId(string value){
			this.clientId_ = value;
		}
		public string GetMailNo(){
			return this.mailNo_;
		}
		
		public void SetMailNo(string value){
			this.mailNo_ = value;
		}
		public string GetTxLogisticId(){
			return this.txLogisticId_;
		}
		
		public void SetTxLogisticId(string value){
			this.txLogisticId_ = value;
		}
		public string GetInfoType(){
			return this.infoType_;
		}
		
		public void SetInfoType(string value){
			this.infoType_ = value;
		}
		public string GetInfoContent(){
			return this.infoContent_;
		}
		
		public void SetInfoContent(string value){
			this.infoContent_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public double? GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(double? value){
			this.weight_ = value;
		}
		public string GetSignedName(){
			return this.signedName_;
		}
		
		public void SetSignedName(string value){
			this.signedName_ = value;
		}
		public string GetDeliveryName(){
			return this.deliveryName_;
		}
		
		public void SetDeliveryName(string value){
			this.deliveryName_ = value;
		}
		public System.DateTime? GetAcceptTime(){
			return this.acceptTime_;
		}
		
		public void SetAcceptTime(System.DateTime? value){
			this.acceptTime_ = value;
		}
		public string GetContactInfo(){
			return this.contactInfo_;
		}
		
		public void SetContactInfo(string value){
			this.contactInfo_ = value;
		}
		
	}
	
}