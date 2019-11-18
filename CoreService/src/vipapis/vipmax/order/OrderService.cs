using System;
using System.Collections.Generic;

namespace vipapis.vipmax.order{
	
	
	public interface OrderService {
		
		
		vipapis.vipmax.order.GetVipmaxOrdersResponse getVipmaxOders( vipapis.vipmax.order.GetVipmaxOrdersRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.vipmax.order.SyncOrderResponse syncOrder( vipapis.vipmax.order.SyncOrderRequest request_ );
		
		vipapis.vipmax.order.SyncRefundOrderResponse syncRefundOrder( vipapis.vipmax.order.SyncRefundOrderRequest request_ );
		
	}
	
}