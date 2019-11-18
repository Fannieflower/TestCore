using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CheckResult {
		
		///<summary>
		/// 结果
		///</summary>
		
		private Dictionary<string, string> resultMap_;
		
		public Dictionary<string, string> GetResultMap(){
			return this.resultMap_;
		}
		
		public void SetResultMap(Dictionary<string, string> value){
			this.resultMap_ = value;
		}
		
	}
	
}