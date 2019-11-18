using System;
using System.Collections.Generic;

namespace vipapis.activity{
	
	
	public interface ActivityService {
		
		
		List<vipapis.activity.Coupon> checkIn( string activityId_,   string mobile_ );
		
		vipapis.activity.CheckInResult checkInV2( string activityId_,   string mobile_ );
		
		vipapis.activity.CheckInResult checkInV3( string activityId_,   string mobile_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}