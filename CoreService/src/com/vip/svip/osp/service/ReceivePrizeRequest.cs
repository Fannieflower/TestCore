using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class ReceivePrizeRequest {
		
		///<summary>
		/// 业务编码
		///</summary>
		
		private string bizCode_;
		
		public string GetBizCode(){
			return this.bizCode_;
		}
		
		public void SetBizCode(string value){
			this.bizCode_ = value;
		}
		
	}
	
}