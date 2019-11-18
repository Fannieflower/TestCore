using System;
using System.Collections.Generic;

namespace vipapis.vipmax.coupon{
	
	
	public interface CouponService {
		
		
		vipapis.vipmax.coupon.CheckCouponInfoResponse checkCouponInfo( vipapis.vipmax.coupon.CheckCouponInfoRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.vipmax.coupon.ReturnCouponResponse returnCoupon( vipapis.vipmax.coupon.ReturnCouponRequest request_ );
		
		void rollbackUseCoupon( vipapis.vipmax.coupon.RollbackCouponRequest request_ );
		
		vipapis.vipmax.coupon.SubmitCouponInfoResponse submitCouponInfo( vipapis.vipmax.coupon.SubmitCouponInfoRequest request_ );
		
	}
	
}