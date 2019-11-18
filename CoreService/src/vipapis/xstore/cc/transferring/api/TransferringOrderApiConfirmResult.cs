using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderApiConfirmResult {
		
		///<summary>
		/// key为调拨单，value为调拨单确认结果
		///</summary>
		
		private Dictionary<string, vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirm> confirm_result_map_;
		
		public Dictionary<string, vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirm> GetConfirm_result_map(){
			return this.confirm_result_map_;
		}
		
		public void SetConfirm_result_map(Dictionary<string, vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirm> value){
			this.confirm_result_map_ = value;
		}
		
	}
	
}