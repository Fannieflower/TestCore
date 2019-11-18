using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.jingdong{
	
	
	
	
	
	public class PromCouponInfo {
		
		///<summary>
		/// 优惠券号
		///</summary>
		
		private string coupon_sn_;
		
		public string GetCoupon_sn(){
			return this.coupon_sn_;
		}
		
		public void SetCoupon_sn(string value){
			this.coupon_sn_ = value;
		}
		
	}
	
}