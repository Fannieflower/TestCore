using System;
using System.Collections.Generic;

namespace vipapis.jitx{
	
	
	public interface JitXService {
		
		
		vipapis.jitx.CreateWorkflowResp createChangeWarehouseWorkflow( vipapis.jitx.CreateChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_ );
		
		List<vipapis.jitx.FeedbackDeliveryResultResponse> feedbackDeliveryResult( vipapis.jitx.FeedbackDeliveryResultRequest request_ );
		
		vipapis.jitx.GetChangeWarehouseWorkflowResp getChangeWarehouseWorkflows( vipapis.jitx.GetChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_ );
		
		vipapis.jitx.GetDeliveryOrdersResponse getDeliveryOrders( vipapis.jitx.GetDeliveryOrdersRequest request_ );
		
		vipapis.jitx.BelleDeliveryOrderResponse getDeliveryOrdersForBelle( vipapis.jitx.BelleDeliveryOrderRequest request_ );
		
		vipapis.jitx.MutilWarehousingOrderResponse getDeliveryOrdersForMutiSys( vipapis.jitx.MutilWarehousingOrderRequest request_ );
		
		vipapis.jitx.GetOrdersResponse getJitXOrdersForMutiSys( vipapis.jitx.OrderRequest request_ );
		
		List<vipapis.jitx.OrderLabel> getOrderLabel( vipapis.jitx.GetOrderLabelRequest request_ );
		
		List<vipapis.jitx.OrderLabel> getOrderLabelForBelle( vipapis.jitx.BelleOrderLabelRequest request_ );
		
		vipapis.jitx.GetOrdersResponse getOrders( vipapis.jitx.GetOrdersRequest request_ );
		
		vipapis.jitx.GetOrdersResponse getOrdersByOrderSn( vipapis.jitx.GetOrdersByOrderSnRequest request_ );
		
		vipapis.jitx.BelleOrderResponse getOrdersForBelle( vipapis.jitx.BelleOrderRequest request_ );
		
		List<vipapis.jitx.OrderLabel> getPrintTemplate( vipapis.jitx.GetOrderLabelRequest request_ );
		
		List<string> getTransportNos( vipapis.jitx.GetTransportNosRequest request_ );
		
		List<vipapis.jitx.WarehouseInfo> getWarehouses( vipapis.jitx.GetWarehousesRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.jitx.ShipResponse ship( vipapis.jitx.ShipRequest request_ );
		
	}
	
}