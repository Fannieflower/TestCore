using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class WorkOrderProcessResult {
		
		///<summary>
		/// 承运商编码
		/// @sampleValue carrier_code shunfeng
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 工单处理结果
		///</summary>
		
		private com.vip.vop.logistics.wo.RelyContent rely_content_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public com.vip.vop.logistics.wo.RelyContent GetRely_content(){
			return this.rely_content_;
		}
		
		public void SetRely_content(com.vip.vop.logistics.wo.RelyContent value){
			this.rely_content_ = value;
		}
		
	}
	
}