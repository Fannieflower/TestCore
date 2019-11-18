using System;
using System.Collections.Generic;

namespace com.vip.ofc{
	
	
	public interface OfcVopService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.ofc.response.vop.WmsUpdateOrderStatusResp wmsUpdateOrderStatus( com.vip.ofc.vo.VopRequestHeader header_,   com.vip.ofc.request.vop.WmsUpdateOrderStatusReq req_ );
		
	}
	
}