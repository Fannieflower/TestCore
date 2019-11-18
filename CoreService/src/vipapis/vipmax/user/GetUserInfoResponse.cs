using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.user{
	
	
	
	
	
	public class GetUserInfoResponse {
		
		///<summary>
		/// Open ID
		///</summary>
		
		private string open_uid_;
		
		public string GetOpen_uid(){
			return this.open_uid_;
		}
		
		public void SetOpen_uid(string value){
			this.open_uid_ = value;
		}
		
	}
	
}