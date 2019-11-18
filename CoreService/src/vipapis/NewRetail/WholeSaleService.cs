using System;
using System.Collections.Generic;

namespace vipapis.NewRetail{
	
	
	public interface WholeSaleService {
		
		
		com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse getAfterSaleApplyId( System.DateTime st_query_time_,   System.DateTime? et_query_time_,   int? page_,   int? limit_ );
		
		List<com.vip.vop.cup.api.newretail.AfterSaleDetail> getAfterSaleDetail( List<long?> apply_ids_ );
		
		com.vip.vop.cup.api.newretail.GetOrdersResponse getOrder( System.DateTime st_query_time_,   System.DateTime? et_query_time_,   int? page_,   int? limit_ );
		
		List<com.vip.vop.cup.api.newretail.OrderDetail> getOrderDetail( List<string> order_ids_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}