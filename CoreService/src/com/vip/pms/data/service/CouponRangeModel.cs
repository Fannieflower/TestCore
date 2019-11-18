using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponRangeModel {
		
		///<summary>
		/// 专场名称或品类名称
		///</summary>
		
		private string rangeName_;
		
		///<summary>
		/// 专场id或品类id
		///</summary>
		
		private string rangeId_;
		
		public string GetRangeName(){
			return this.rangeName_;
		}
		
		public void SetRangeName(string value){
			this.rangeName_ = value;
		}
		public string GetRangeId(){
			return this.rangeId_;
		}
		
		public void SetRangeId(string value){
			this.rangeId_ = value;
		}
		
	}
	
}