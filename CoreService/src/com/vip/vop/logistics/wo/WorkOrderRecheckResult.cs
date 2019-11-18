using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class WorkOrderRecheckResult {
		
		///<summary>
		/// 承运商编码
		/// @sampleValue carrier_code shunfeng
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 工单复核处理结果
		///</summary>
		
		private com.vip.vop.logistics.wo.RecheckRelyContent reckeck_reply_content_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public com.vip.vop.logistics.wo.RecheckRelyContent GetReckeck_reply_content(){
			return this.reckeck_reply_content_;
		}
		
		public void SetReckeck_reply_content(com.vip.vop.logistics.wo.RecheckRelyContent value){
			this.reckeck_reply_content_ = value;
		}
		
	}
	
}