using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class CancelUserV2 {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 原因
		///</summary>
		
		private string reasonText_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetReasonText(){
			return this.reasonText_;
		}
		
		public void SetReasonText(string value){
			this.reasonText_ = value;
		}
		
	}
	
}