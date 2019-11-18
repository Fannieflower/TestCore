using System;
using System.Collections.Generic;

namespace com.vip.xstore.inventory.service.wop{
	
	
	public interface WopInventoryService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> inventoryAdjust( List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> wopInvChgLogReqs_ );
		
		Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> receiving( List<com.vip.xstore.inventory.service.wop.InventoryFlow> items_ );
		
	}
	
}