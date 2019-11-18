using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetOrderLabelRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 面单详情列表;最多200个面单
		///</summary>
		
		private List<vipapis.jitx.PrintDetail> print_details_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<vipapis.jitx.PrintDetail> GetPrint_details(){
			return this.print_details_;
		}
		
		public void SetPrint_details(List<vipapis.jitx.PrintDetail> value){
			this.print_details_ = value;
		}
		
	}
	
}