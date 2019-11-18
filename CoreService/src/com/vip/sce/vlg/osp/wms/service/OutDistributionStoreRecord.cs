using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	
	
	public class OutDistributionStoreRecord {
		
		///<summary>
		/// 交易流水号
		///</summary>
		
		private string transactionId_;
		
		///<summary>
		/// 原单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 单据类型
		///</summary>
		
		private string billtype_;
		
		///<summary>
		/// 运输方式
		///</summary>
		
		private string transportMode_;
		
		///<summary>
		/// 运输工具
		///</summary>
		
		private string transportTool_;
		
		///<summary>
		/// 承运单位
		///</summary>
		
		private string carrierUnit_;
		
		///<summary>
		/// 承运方式
		///</summary>
		
		private string carrierMode_;
		
		///<summary>
		/// 物流单号
		///</summary>
		
		private string logisticsNo_;
		
		///<summary>
		/// 车牌号
		///</summary>
		
		private string plateNumber_;
		
		///<summary>
		/// 运输员
		///</summary>
		
		private string transporter_;
		
		///<summary>
		/// 启运时间  yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string departureTime_;
		
		///<summary>
		/// 温度
		///</summary>
		
		private double? temperature_;
		
		///<summary>
		/// 湿度
		///</summary>
		
		private double? humidity_;
		
		public string GetTransactionId(){
			return this.transactionId_;
		}
		
		public void SetTransactionId(string value){
			this.transactionId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetBilltype(){
			return this.billtype_;
		}
		
		public void SetBilltype(string value){
			this.billtype_ = value;
		}
		public string GetTransportMode(){
			return this.transportMode_;
		}
		
		public void SetTransportMode(string value){
			this.transportMode_ = value;
		}
		public string GetTransportTool(){
			return this.transportTool_;
		}
		
		public void SetTransportTool(string value){
			this.transportTool_ = value;
		}
		public string GetCarrierUnit(){
			return this.carrierUnit_;
		}
		
		public void SetCarrierUnit(string value){
			this.carrierUnit_ = value;
		}
		public string GetCarrierMode(){
			return this.carrierMode_;
		}
		
		public void SetCarrierMode(string value){
			this.carrierMode_ = value;
		}
		public string GetLogisticsNo(){
			return this.logisticsNo_;
		}
		
		public void SetLogisticsNo(string value){
			this.logisticsNo_ = value;
		}
		public string GetPlateNumber(){
			return this.plateNumber_;
		}
		
		public void SetPlateNumber(string value){
			this.plateNumber_ = value;
		}
		public string GetTransporter(){
			return this.transporter_;
		}
		
		public void SetTransporter(string value){
			this.transporter_ = value;
		}
		public string GetDepartureTime(){
			return this.departureTime_;
		}
		
		public void SetDepartureTime(string value){
			this.departureTime_ = value;
		}
		public double? GetTemperature(){
			return this.temperature_;
		}
		
		public void SetTemperature(double? value){
			this.temperature_ = value;
		}
		public double? GetHumidity(){
			return this.humidity_;
		}
		
		public void SetHumidity(double? value){
			this.humidity_ = value;
		}
		
	}
	
}