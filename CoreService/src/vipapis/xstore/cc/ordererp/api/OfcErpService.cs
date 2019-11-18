using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.ordererp.api{
	
	
	public interface OfcErpService {
		
		
		vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp addInfErpOrderInfo( vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq req_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}