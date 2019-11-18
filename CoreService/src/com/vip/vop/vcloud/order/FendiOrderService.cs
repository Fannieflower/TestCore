using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.order{
	
	
	public interface FendiOrderService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void pushCancelledOrderToFendi( long? partnerId_,   long? channelId_ );
		
		void pushNewOrderToFendi( long? channelId_,   long? partnerId_ );
		
		void pushShippedOrderToFendi( long? partnerId_,   long? channelId_ );
		
	}
	
}