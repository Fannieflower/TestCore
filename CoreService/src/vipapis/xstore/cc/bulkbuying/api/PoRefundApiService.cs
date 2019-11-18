using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	public interface PoRefundApiService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> updatePoRefundRealQty( vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq req_ );
		
	}
	
}