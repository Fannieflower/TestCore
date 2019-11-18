using System;
using System.Collections.Generic;

namespace vipapis.track.service{
	
	
	public interface CarrierLogisticTrackService {
		
		
		com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse acceptLogisticsTrack( com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}