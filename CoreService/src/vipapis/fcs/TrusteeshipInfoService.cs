using System;
using System.Collections.Generic;

namespace vipapis.fcs{
	
	
	public interface TrusteeshipInfoService {
		
		
		com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel createTrusteeshipInfo( com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel createTrusteeshipInfoRequestModel_ );
		
		com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel getTrusteeshipInfo( com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel getTrusteeshipInfoRequestModel_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel updateTrusteeshipInfo( com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel updateTrusteeshipInfoRequestModel_ );
		
	}
	
}