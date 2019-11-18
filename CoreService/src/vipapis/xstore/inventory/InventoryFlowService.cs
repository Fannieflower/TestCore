using System;
using System.Collections.Generic;

namespace vipapis.xstore.inventory{
	
	
	public interface InventoryFlowService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		long? pushUnknownFlows( long id_,   string companyCode_ );
		
		Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> receiving( List<vipapis.xstore.inventory.InventoryFlow> items_ );
		
	}
	
}