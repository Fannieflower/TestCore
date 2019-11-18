using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class OrderLabel {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 包裹序号
		///</summary>
		
		private int? box_no_;
		
		///<summary>
		/// 包裹总数
		///</summary>
		
		private int? total_package_;
		
		///<summary>
		/// 面单内容，html/json
		///</summary>
		
		private string order_label_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public int? GetBox_no(){
			return this.box_no_;
		}
		
		public void SetBox_no(int? value){
			this.box_no_ = value;
		}
		public int? GetTotal_package(){
			return this.total_package_;
		}
		
		public void SetTotal_package(int? value){
			this.total_package_ = value;
		}
		public string GetOrder_label(){
			return this.order_label_;
		}
		
		public void SetOrder_label(string value){
			this.order_label_ = value;
		}
		
	}
	
}