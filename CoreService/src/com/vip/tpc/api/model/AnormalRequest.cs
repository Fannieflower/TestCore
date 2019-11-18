using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AnormalRequest {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 唯品会订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 问题件编码
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 问题描述
		///</summary>
		
		private string content_;
		
		///<summary>
		/// 问题件产生时间
		///</summary>
		
		private long? time_;
		
		///<summary>
		/// 上报城市
		///</summary>
		
		private string reportCity_;
		
		///<summary>
		/// 上报城市
		///</summary>
		
		private string reportOrgName_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		public long? GetTime(){
			return this.time_;
		}
		
		public void SetTime(long? value){
			this.time_ = value;
		}
		public string GetReportCity(){
			return this.reportCity_;
		}
		
		public void SetReportCity(string value){
			this.reportCity_ = value;
		}
		public string GetReportOrgName(){
			return this.reportOrgName_;
		}
		
		public void SetReportOrgName(string value){
			this.reportOrgName_ = value;
		}
		
	}
	
}