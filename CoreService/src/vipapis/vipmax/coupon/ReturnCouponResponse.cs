using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class ReturnCouponResponse {
		
		///<summary>
		/// 已退回的优惠券
		///</summary>
		
		private List<string> returnCoupons_;
		
		public List<string> GetReturnCoupons(){
			return this.returnCoupons_;
		}
		
		public void SetReturnCoupons(List<string> value){
			this.returnCoupons_ = value;
		}
		
	}
	
}