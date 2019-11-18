using System;
using System.Collections.Generic;

namespace vipapis.cup.order{
	
	
	public interface OrderService {
		
		
		com.vip.vop.cup.api.order.OrderOpResult cancelOrder( List<com.vip.vop.cup.api.order.CancelOrderReq> cancel_order_req_list_ );
		
		com.vip.vop.cup.api.order.OrderOpResult createOrder( List<com.vip.vop.cup.api.order.CreateOrderReq> create_order_req_list_ );
		
		com.vip.vop.cup.api.order.GetOrderStatusResult getOrderStatus( string start_time_,   string end_time_,   int? page_,   int? page_size_ );
		
		com.vip.vop.cup.api.order.GetOrderTransportInfoResult getOrderTransportInfo( string start_time_,   string end_time_,   int? page_,   int? page_size_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.cup.api.order.OrderOpResult updateCancelOrderRefundResult( List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> update_cancel_order_refund_result_req_list_ );
		
		com.vip.vop.cup.api.order.OrderOpResult updateOrderStatus( List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> update_order_status_req_list_ );
		
	}
	
}