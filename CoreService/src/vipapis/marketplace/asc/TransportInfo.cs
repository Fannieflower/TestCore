using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class TransportInfo {
		
		///<summary>
		/// 商品退货运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 承运商快递公司
		///</summary>
		
		private string carrier_;
		
		///<summary>
		/// 承运商快递公司编码
		///</summary>
		
		private string carriers_code_;
		
		///<summary>
		/// 退货包裹发货时间
		///</summary>
		
		private string delivery_time_;
		
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetCarrier(){
			return this.carrier_;
		}
		
		public void SetCarrier(string value){
			this.carrier_ = value;
		}
		public string GetCarriers_code(){
			return this.carriers_code_;
		}
		
		public void SetCarriers_code(string value){
			this.carriers_code_ = value;
		}
		public string GetDelivery_time(){
			return this.delivery_time_;
		}
		
		public void SetDelivery_time(string value){
			this.delivery_time_ = value;
		}
		
	}
	
}