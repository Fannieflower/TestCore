using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class SortingInfoRequestHead {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchno_;
		
		public string GetBatchno(){
			return this.batchno_;
		}
		
		public void SetBatchno(string value){
			this.batchno_ = value;
		}
		
	}
	
}