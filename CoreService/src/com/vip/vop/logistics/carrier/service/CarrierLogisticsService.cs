using System;
using System.Collections.Generic;

namespace com.vip.vop.logistics.carrier.service{
	
	
	public interface CarrierLogisticsService {
		
		
		List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> collectShipping( string carrier_code_,   List<com.vip.vop.logistics.carrier.service.ShippingCollection> collections_ );
		
		void forwardShipping( string carrier_code_,   List<com.vip.vop.logistics.carrier.service.ForwardShipping> forward_shippings_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.logistics.ShippingAddress> listRefundAddress( string carrier_code_,   List<string> logistics_nos_ );
		
		com.vip.vop.logistics.carrier.service.LoadingListResp reportLoadingListDetail( string carrier_code_,   com.vip.vop.logistics.carrier.service.LoadingListReq loadingListReq_ );
		
		com.vip.vop.logistics.carrier.service.ReportPacketInfoResp reportPacketInfo( string carrier_code_,   List<com.vip.vop.logistics.carrier.service.PacketInfo> packetInfos_ );
		
		List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> reportProblemShipping( string carrier_code_,   List<com.vip.vop.logistics.carrier.service.ProblemShipping> problem_shippings_ );
		
		List<com.vip.vop.logistics.ReportTraceResult> reportTrace( string carrier_code_,   List<com.vip.vop.logistics.ShipmentTraceList> traces_ );
		
		com.vip.vop.logistics.carrier.service.ShippingInterceptResp uploadShippingInterceptResult( string carrier_code_,   List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> intercept_results_ );
		
	}
	
}