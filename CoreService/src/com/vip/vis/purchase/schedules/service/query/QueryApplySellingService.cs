using System;
using System.Collections.Generic;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	public interface QueryApplySellingService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse queryApplySellingData( com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam queryApplySellingParam_ );
		
		com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse queryScheduleInfoData( com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam queryScheduleInfoApiParam_ );
		
		com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse querySchedulesByShopCode( com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam queryScheduleByShopCodeParam_ );
		
	}
	
}