using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponRuleChannelModel {
		
		///<summary>
		/// 来源
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 限制数量
		///</summary>
		
		private int? limit_;
		
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}