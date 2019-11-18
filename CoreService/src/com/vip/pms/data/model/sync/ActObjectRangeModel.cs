using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class ActObjectRangeModel {
		
		///<summary>
		/// rangeId
		///</summary>
		
		private string rangeId_;
		
		///<summary>
		/// range的名称，专场、商品、品类名称等
		///</summary>
		
		private string rangeName_;
		
		public string GetRangeId(){
			return this.rangeId_;
		}
		
		public void SetRangeId(string value){
			this.rangeId_ = value;
		}
		public string GetRangeName(){
			return this.rangeName_;
		}
		
		public void SetRangeName(string value){
			this.rangeName_ = value;
		}
		
	}
	
}