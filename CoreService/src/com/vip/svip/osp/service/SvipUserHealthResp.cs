using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipUserHealthResp {
		
		///<summary>
		/// 是否高危SVIP用户
		///</summary>
		
		private bool? highRiskSVIP_;
		
		///<summary>
		/// 用户是否有健康值
		///</summary>
		
		private bool? hasHealthScore_;
		
		public bool? GetHighRiskSVIP(){
			return this.highRiskSVIP_;
		}
		
		public void SetHighRiskSVIP(bool? value){
			this.highRiskSVIP_ = value;
		}
		public bool? GetHasHealthScore(){
			return this.hasHealthScore_;
		}
		
		public void SetHasHealthScore(bool? value){
			this.hasHealthScore_ = value;
		}
		
	}
	
}