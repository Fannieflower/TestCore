using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	public interface RefundService {
		
		
		void dealRefund( com.vip.vop.vcloud.invoice.api.Refund refund_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		long? matchReturnApplication( com.vip.vop.vcloud.invoice.api.QueryRefundReq req_ );
		
		void pullRefundFromVdg( System.DateTime? lastUpdateTime_ );
		
		com.vip.vop.vcloud.invoice.api.QueryRefundRes queryRefunds( com.vip.vop.vcloud.invoice.api.QueryRefundReq req_ );
		
		void receiveRefund( com.vip.vop.vcloud.invoice.api.Refund refund_ );
		
		void updateDealType( long id_ );
		
	}
	
}