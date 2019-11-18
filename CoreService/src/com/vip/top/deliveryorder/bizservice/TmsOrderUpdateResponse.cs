using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class TmsOrderUpdateResponse {
		
		///<summary>
		///</summary>
		
		private string respCode_;
		
		///<summary>
		///</summary>
		
		private string respMsg_;
		
		public string GetRespCode(){
			return this.respCode_;
		}
		
		public void SetRespCode(string value){
			this.respCode_ = value;
		}
		public string GetRespMsg(){
			return this.respMsg_;
		}
		
		public void SetRespMsg(string value){
			this.respMsg_ = value;
		}
		
	}
	
}