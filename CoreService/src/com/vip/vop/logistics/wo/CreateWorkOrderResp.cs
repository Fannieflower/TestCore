using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class CreateWorkOrderResp {
		
		///<summary>
		/// 工单号
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		
	}
	
}