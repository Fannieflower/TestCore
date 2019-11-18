using System;
using System.Collections.Generic;

namespace com.vip.vop.logistics.wo.service{
	
	
	public interface LogisticsWorkOrderService {
		
		
		com.vip.vop.logistics.wo.CreateWorkOrderResp createWorkOrder( com.vip.vop.logistics.wo.CreateWorkOrderReq createWorkOrderReq_ );
		
		List<com.vip.vop.logistics.wo.WorkOrder> getWorkOrders( com.vip.vop.logistics.wo.WorkOrderQueryReq workOrderQueryReq_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void replyProcessResult( com.vip.vop.logistics.wo.WorkOrderProcessResult processResult_ );
		
		void replyRecheckResult( com.vip.vop.logistics.wo.WorkOrderRecheckResult rechekResult_ );
		
	}
	
}