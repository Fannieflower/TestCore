using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class FlushGoodsSurprisePriceModel {
		
		///<summary>
		/// 商品mid
		///</summary>
		
		private string mid_;
		
		///<summary>
		/// 活动编号
		///</summary>
		
		private string activityNo_;
		
		public string GetMid(){
			return this.mid_;
		}
		
		public void SetMid(string value){
			this.mid_ = value;
		}
		public string GetActivityNo(){
			return this.activityNo_;
		}
		
		public void SetActivityNo(string value){
			this.activityNo_ = value;
		}
		
	}
	
}