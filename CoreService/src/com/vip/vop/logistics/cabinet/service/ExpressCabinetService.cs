using System;
using System.Collections.Generic;

namespace com.vip.vop.logistics.cabinet.service{
	
	
	public interface ExpressCabinetService {
		
		
		com.vip.vop.logistics.cabinet.GetShippingResp getShippingByLogisticsNos( com.vip.vop.logistics.cabinet.GetShippingReq shippingReq_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.logistics.cabinet.ShipmentTraceResp reportTraces( com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq traceReq_ );
		
	}
	
}