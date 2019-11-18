using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class ConfirmTransferringDeliveryRes {
		
		///<summary>
		/// 确认结果
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.ConfirmResult> confirmResults_;
		
		public List<vipapis.xstore.cc.transferring.api.ConfirmResult> GetConfirmResults(){
			return this.confirmResults_;
		}
		
		public void SetConfirmResults(List<vipapis.xstore.cc.transferring.api.ConfirmResult> value){
			this.confirmResults_ = value;
		}
		
	}
	
}