using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.invoice{
	
	
	
	
	
	public class ConfirmInvoiceResponse {
		
		///<summary>
		/// 错误信息列表
		///</summary>
		
		private List<string> fail_messages_;
		
		public List<string> GetFail_messages(){
			return this.fail_messages_;
		}
		
		public void SetFail_messages(List<string> value){
			this.fail_messages_ = value;
		}
		
	}
	
}