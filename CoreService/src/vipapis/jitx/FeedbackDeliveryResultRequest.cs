using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class FeedbackDeliveryResultRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 反馈结果列表,最大支持50个反馈结果
		///</summary>
		
		private List<vipapis.jitx.FeedbackDeliveryResult> results_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<vipapis.jitx.FeedbackDeliveryResult> GetResults(){
			return this.results_;
		}
		
		public void SetResults(List<vipapis.jitx.FeedbackDeliveryResult> value){
			this.results_ = value;
		}
		
	}
	
}