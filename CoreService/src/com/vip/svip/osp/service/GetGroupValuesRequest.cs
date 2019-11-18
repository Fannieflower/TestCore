using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetGroupValuesRequest {
		
		///<summary>
		/// 分组
		///</summary>
		
		private string group_code_;
		
		public string GetGroup_code(){
			return this.group_code_;
		}
		
		public void SetGroup_code(string value){
			this.group_code_ = value;
		}
		
	}
	
}