using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class BuyAndCutInfo {
		
		///<summary>
		/// 满元/件
		///</summary>
		
		private string buy_;
		
		///<summary>
		/// 减元/件/折
		///</summary>
		
		private string cut_;
		
		public string GetBuy(){
			return this.buy_;
		}
		
		public void SetBuy(string value){
			this.buy_ = value;
		}
		public string GetCut(){
			return this.cut_;
		}
		
		public void SetCut(string value){
			this.cut_ = value;
		}
		
	}
	
}