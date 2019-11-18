using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class ConfirmDelivery {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private long? vendor_id_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string store_sn_;
		
		///<summary>
		/// 包裹号
		///</summary>
		
		private string package_no_;
		
		///<summary>
		/// 是否使用预制单
		///</summary>
		
		private bool? is_preformed_;
		
		///<summary>
		/// 订单号(传多个时，其母单号需相同)
		///</summary>
		
		private List<string> orders_;
		
		///<summary>
		/// 预约发货时间
		///</summary>
		
		private long? estimate_delivery_time_;
		
		public long? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(long? value){
			this.vendor_id_ = value;
		}
		public string GetStore_sn(){
			return this.store_sn_;
		}
		
		public void SetStore_sn(string value){
			this.store_sn_ = value;
		}
		public string GetPackage_no(){
			return this.package_no_;
		}
		
		public void SetPackage_no(string value){
			this.package_no_ = value;
		}
		public bool? GetIs_preformed(){
			return this.is_preformed_;
		}
		
		public void SetIs_preformed(bool? value){
			this.is_preformed_ = value;
		}
		public List<string> GetOrders(){
			return this.orders_;
		}
		
		public void SetOrders(List<string> value){
			this.orders_ = value;
		}
		public long? GetEstimate_delivery_time(){
			return this.estimate_delivery_time_;
		}
		
		public void SetEstimate_delivery_time(long? value){
			this.estimate_delivery_time_ = value;
		}
		
	}
	
}