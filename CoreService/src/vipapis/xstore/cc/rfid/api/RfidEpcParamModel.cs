using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidEpcParamModel {
		
		///<summary>
		/// 调拨单号
		///</summary>
		
		private string transferNo_;
		
		///<summary>
		/// 明细数据
		///</summary>
		
		private List<vipapis.xstore.cc.rfid.api.RfidEpcDetailModel> details_;
		
		public string GetTransferNo(){
			return this.transferNo_;
		}
		
		public void SetTransferNo(string value){
			this.transferNo_ = value;
		}
		public List<vipapis.xstore.cc.rfid.api.RfidEpcDetailModel> GetDetails(){
			return this.details_;
		}
		
		public void SetDetails(List<vipapis.xstore.cc.rfid.api.RfidEpcDetailModel> value){
			this.details_ = value;
		}
		
	}
	
}