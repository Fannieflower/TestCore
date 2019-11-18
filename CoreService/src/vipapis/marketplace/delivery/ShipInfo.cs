using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class ShipInfo {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 承运商编码（当发货方式为‘门店自提’时，该字段无效；为‘快递’时必传）
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 承运商名称（当发货方式为‘门店自提’时，该字段无效；为‘快递’时必传）
		///</summary>
		
		private string carrier_name_;
		
		///<summary>
		/// 包裹类型：1，单包裹；2，多包裹（当发货方式为‘门店自提’时，传‘单包裹’）
		///</summary>
		
		private int? package_type_;
		
		///<summary>
		/// 包裹信息，规则：当发货方式为快递时必填,门店自提时该字段无效；当包裹类型为“多包裹”时，必须传多个
		///</summary>
		
		private List<vipapis.marketplace.delivery.ShipPackage> packages_;
		
		///<summary>
		/// 发货方式：0，快递（默认） 1，门店自提
		///</summary>
		
		private int? shipping_method_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
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
		public int? GetPackage_type(){
			return this.package_type_;
		}
		
		public void SetPackage_type(int? value){
			this.package_type_ = value;
		}
		public List<vipapis.marketplace.delivery.ShipPackage> GetPackages(){
			return this.packages_;
		}
		
		public void SetPackages(List<vipapis.marketplace.delivery.ShipPackage> value){
			this.packages_ = value;
		}
		public int? GetShipping_method(){
			return this.shipping_method_;
		}
		
		public void SetShipping_method(int? value){
			this.shipping_method_ = value;
		}
		
	}
	
}