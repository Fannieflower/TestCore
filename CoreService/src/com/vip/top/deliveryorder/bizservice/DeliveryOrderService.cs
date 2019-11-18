using System;
using System.Collections.Generic;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	public interface DeliveryOrderService {
		
		
		List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> findDeliveryTracks( string transportNo_ );
		
		List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> findDeliveryTracksToStorage( string transportNo_,   string storage_ );
		
		Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> findListDeliveryTracks( List<string> transportNoList_ );
		
		Dictionary<string, string> findOrderSnByTransportNo( string orderType_,   List<string> transportNoList_,   string storage_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel findTmsOrderByReceiverPhone( string receiverPhone_,   int pageIndex_,   int pageSize_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel findTmsOrderByReceiverPhoneToStorage( string receiverPhone_,   int pageIndex_,   int pageSize_,   string storage_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByOrderSnAndWareHouse( string orderSn_,   string wareHouse_,   int pageIndex_,   int pageSize_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNo( string transportNo_,   int pageIndex_,   int pageSize_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNoAndWareHouse( string transportNo_,   string wareHouse_,   int pageIndex_,   int pageSize_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNoToStorage( string transportNo_,   int pageIndex_,   int pageSize_,   string storage_ );
		
		string getTransportNoByOrderSn( string orderSn_,   string warehouse_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void matchCarrier( List<string> tmsOrderIds_,   string warehouse_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse modifyTmsOrderInfo( com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest tmsOrderModifyRequest_,   string warehouse_ );
		
		com.vip.top.deliveryorder.service.ProcessResult processOdsMessage( string orderMsg_ );
		
		void processOdsOrderStatus( string orderMsg_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderPageModel selectPageByReceiverPhone( com.vip.top.deliveryorder.service.TmsOrderModel tmsOrderModel_,   int pageIndex_,   int pageSize_ );
		
		com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse updateTmsOrderInfo( com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest tmsOrderUpdateRequest_,   string warehouse_ );
		
	}
	
}