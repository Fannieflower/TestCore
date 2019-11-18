using System;
using System.Collections.Generic;

namespace com.vip.vop.omni.logistics{
	
	
	public interface OmniLogisticsService {
		
		
		com.vip.vop.omni.logistics.LogisticsTrackResponse getOrderLogisticsTrack( com.vip.vop.omni.logistics.LogisticsTrackRequest trackRequest_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void receiveMaxSpeedRouteInfo( com.vip.vop.omni.logistics.MaxSpeedRouteInfo maxSpeedRouteInfo_ );
		
		void receiveRouteInfo( com.vip.vop.omni.logistics.WaybillRoute waybillRoute_ );
		
		void receiveYtoRouteInfo( com.vip.vop.omni.logistics.YtoRouteInfo ytoRouteInfo_ );
		
		void receiveZtoRouteInfo( com.vip.vop.omni.logistics.ZtoRouteInfo ztoRouteInfo_ );
		
	}
	
}