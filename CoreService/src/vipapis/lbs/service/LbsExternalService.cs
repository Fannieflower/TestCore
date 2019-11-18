using System;
using System.Collections.Generic;

namespace vipapis.lbs.service{
	
	
	public interface LbsExternalService {
		
		
		com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse getExplainedBarcodes( com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest getExplainedBarcodesRequest_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}