using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.sims.erp{
	
	
	public interface ErpInventoryVopService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> inventoryAdjust( List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> stockGainModelList_ );
		
	}
	
}