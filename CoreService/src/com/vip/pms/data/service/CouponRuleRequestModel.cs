using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponRuleRequestModel {
		
		///<summary>
		/// 优惠券规则参数对象
		///</summary>
		
		private com.vip.pms.data.service.CouponRuleCoreModel couponRuleCoreModel_;
		
		public com.vip.pms.data.service.CouponRuleCoreModel GetCouponRuleCoreModel(){
			return this.couponRuleCoreModel_;
		}
		
		public void SetCouponRuleCoreModel(com.vip.pms.data.service.CouponRuleCoreModel value){
			this.couponRuleCoreModel_ = value;
		}
		
	}
	
}