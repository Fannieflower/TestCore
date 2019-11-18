using System;
using System.Collections.Generic;

namespace vipapis.marketplace.store{
	
	
	public interface StoreInfoService {
		
		
		vipapis.marketplace.store.GetStoreInfoResponse getStoreInfo();
		
		vipapis.marketplace.store.GetWarehouseResponse getWarehouse();
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}