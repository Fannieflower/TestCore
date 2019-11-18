using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetOrdersByOrderSnRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 订单号列表
		///</summary>
		
		private List<string> order_sns_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<string> GetOrder_sns(){
			return this.order_sns_;
		}
		
		public void SetOrder_sns(List<string> value){
			this.order_sns_ = value;
		}
		
	}
	
}