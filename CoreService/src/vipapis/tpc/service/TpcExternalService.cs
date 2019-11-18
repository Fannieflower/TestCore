using System;
using System.Collections.Generic;

namespace vipapis.tpc.service{
	
	
	public interface TpcExternalService {
		
		
		com.vip.tpc.api.model.AcceptCarLoadDetailResponse acceptCarLoadDetail( com.vip.tpc.api.model.AcceptCarLoadDetailRequest acceptCarLoadDetailRequest_ );
		
		com.vip.tpc.api.model.AnormalExpressResponse anormalExpress( com.vip.tpc.api.model.AnormalExpressRequest anormalExpressRequest_ );
		
		com.vip.tpc.api.model.CarrierTakingAwayResponse carrierTakingAway( com.vip.tpc.api.model.CarrierTakingAwayRequest carrierTakingAwayRequest_ );
		
		com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse carrierTakingAwayGoods( com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest carrierTakingAwayGoodsRequest_ );
		
		com.vip.tpc.api.model.GetReturnAddressResponse getReturnAddress( com.vip.tpc.api.model.GetReturnAddressRequest getReturnAddressRequest_ );
		
		com.vip.tpc.api.model.GetSerialNumberRelationResponse getSerialNumberRelation( com.vip.tpc.api.model.GetSerialNumberRelationRequest getSerialNumberRelationRequest_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.tpc.api.model.InterceptReportResponse interceptReport( com.vip.tpc.api.model.InterceptReportRequest interceptReportRequest_ );
		
		com.vip.tpc.api.model.PackPhysicsAttributeResponse packPhysicsAttribute( com.vip.tpc.api.model.PackPhysicsAttributeRequest packPhysicsAttributeRequest_ );
		
	}
	
}