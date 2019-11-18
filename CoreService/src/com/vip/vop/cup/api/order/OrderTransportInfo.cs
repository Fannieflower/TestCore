using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderTransportInfo {
		
		///<summary>
		/// 外部订单号，最大长度50
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 中文描述，最大长度4
		///</summary>
		
		private string transport_type_;
		
		///<summary>
		/// 物流运输详情，最大长度255
		///</summary>
		
		private string transport_detail_;
		
		///<summary>
		/// 物流运输NUMBER，最大长度32
		///</summary>
		
		private string transport_number_;
		
		///<summary>
		/// 承运商code，最大长度20
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 承运商名称，最大长度128
		///</summary>
		
		private string carrier_name_;
		
		///<summary>
		/// 业务处理时间，最大长度50
		///</summary>
		
		private string add_time_;
		
		///<summary>
		/// 更新时间，最大长度50
		///</summary>
		
		private string update_time_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetTransport_type(){
			return this.transport_type_;
		}
		
		public void SetTransport_type(string value){
			this.transport_type_ = value;
		}
		public string GetTransport_detail(){
			return this.transport_detail_;
		}
		
		public void SetTransport_detail(string value){
			this.transport_detail_ = value;
		}
		public string GetTransport_number(){
			return this.transport_number_;
		}
		
		public void SetTransport_number(string value){
			this.transport_number_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetCarrier_name(){
			return this.carrier_name_;
		}
		
		public void SetCarrier_name(string value){
			this.carrier_name_ = value;
		}
		public string GetAdd_time(){
			return this.add_time_;
		}
		
		public void SetAdd_time(string value){
			this.add_time_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		
	}
	
}