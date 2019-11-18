using System;
using System.Collections.Generic;

namespace vipapis.cup.freight{
	
	
	public interface FreightService {
		
		
		com.vip.vop.cup.api.freight.GetOrderFreightResult getOrderFreight( List<com.vip.vop.cup.api.freight.GetOrderFreightReq> get_order_freight_req_list_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}