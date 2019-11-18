using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class UpdateTransItemQtyApiResult {
		
		///<summary>
		/// key为barcode+purchase_no，value为更新收货数量结果
		///</summary>
		
		private Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiInfo> update_result_map_;
		
		public Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiInfo> GetUpdate_result_map(){
			return this.update_result_map_;
		}
		
		public void SetUpdate_result_map(Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiInfo> value){
			this.update_result_map_ = value;
		}
		
	}
	
}