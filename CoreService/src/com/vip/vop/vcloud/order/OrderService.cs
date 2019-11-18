using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.order{
	
	
	public interface OrderService {
		
		
		void acceptOrder( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		void appointOrderStore( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		void cancelShipment( long? partnerId_,   string orderSn_,   long? channelId_,   string account_,   long? storeId_ );
		
		bool? checkMultiParcel( long partnerId_,   string orderSn_,   string subOrderSn_,   long channelId_ );
		
		List<com.vip.vop.vcloud.order.Express> confirmDelivery( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		void confirmDeliveryPartly( com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq req_ );
		
		void confirmNoStock( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		List<com.vip.vop.vcloud.order.Express> confirmShipment( long partnerId_,   string orderSn_,   long channelId_,   string account_,   long? storeId_ );
		
		void confirmUserRefuse( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		com.vip.vop.vcloud.order.WayBillResponse getChannelOrderAndDetail( long? partnerId_,   long? channelId_,   int? orderType_,   com.vip.vop.vcloud.common.api.Pagination pagination_,   List<long?> warehouses_ );
		
		com.vip.vop.vcloud.order.OrderItem getChannelOrderByOrderSn( long? partnerId_,   string orderSn_,   string subOrderSn_,   long? channelId_,   long? storeId_ );
		
		com.vip.vop.vcloud.order.OrderResponse getChannelOrderItems( com.vip.vop.vcloud.order.OrderQueryRequest orderQueryRequest_ );
		
		com.vip.vop.vcloud.order.OfficialMember getOfficialMemberByOrderSn( long? partnerId_,   string orderSn_,   long? channelId_ );
		
		com.vip.vop.vcloud.order.OrderItem getOrderByChannelIdAndOrderSn( long channelId_,   string orderSn_ );
		
		com.vip.vop.vcloud.order.OrderItem getOrderByExpressNo( long? partnerId_,   string orderSn_,   string subOrderSn_,   long? channelId_,   string expressNo_ );
		
		List<com.vip.vop.vcloud.order.OrderLogistics> getOrderLogisticsByOrderSn( long? partnerId_,   string orderSn_,   long? channelId_,   long? storeId_,   string subOrderSn_ );
		
		List<com.vip.vop.vcloud.order.OrderOptLog> getOrderOptLog( long? partnerId_,   string orderSn_,   long? channelId_,   long? storeId_,   string subOrderSn_ );
		
		com.vip.vop.vcloud.order.WayBillResponse getWaybillDetails( long? partnerId_,   long? channelId_,   long? startTime_,   long? endTime_,   com.vip.vop.vcloud.common.api.Pagination pagination_,   List<long?> warehouses_,   int? orderType_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.vcloud.order.SubOrder> listSubOrder( long partnerId_,   string orderSn_,   long channelId_,   string subOrderSn_ );
		
		List<com.vip.vop.vcloud.warehouse.api.Warehouse> listWarehouseByOrderSn( long? partnerId_,   long? channelId_,   string orderSn_ );
		
		void pullOrders( long? channelId_,   long? partnerId_,   string orderSn_,   System.DateTime? beginTime_,   System.DateTime? endTime_ );
		
		void refuseOrder( com.vip.vop.vcloud.order.OrderStoreReq req_ );
		
		void storeConfirmed( long channelId_,   string subOrderSn_,   int? isConfirmed_ );
		
		void updateDeliveryStatus( long? partnerId_,   string orderSn_,   string deliveryNo_,   long? acceptTime_,   string acceptAddress_,   string remark_,   string opCode_,   string opId_ );
		
		void updateOrderLogisticsBySubOrderSn( long? partnerId_,   long? channelId_,   string subOrderSn_,   string expressCompany_,   string expressNo_ );
		
		void updateRemark( long channelId_,   string subOrderSn_,   string remark_ );
		
	}
	
}