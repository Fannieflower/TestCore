using System;
using System.Collections.Generic;

namespace com.vip.adp.api.open.service{
	
	
	public interface UnionOrderService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.adp.api.open.service.OrderResponse orderList( com.vip.adp.api.open.service.OrderQueryModel queryModel_ );
		
		com.vip.adp.api.open.service.OrderResponse orderListWithOauth( com.vip.adp.api.open.service.OrderQueryModel queryModel_ );
		
		com.vip.adp.api.open.service.RefundOrderResponse refundOrderList( com.vip.adp.api.open.service.RefundOrderRequest request_ );
		
		com.vip.adp.api.open.service.RefundOrderResponse refundOrderListWithOauth( com.vip.adp.api.open.service.RefundOrderRequest request_ );
		
	}
	
}