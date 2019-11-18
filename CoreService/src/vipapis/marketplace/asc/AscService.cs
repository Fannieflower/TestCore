using System;
using System.Collections.Generic;

namespace vipapis.marketplace.asc{
	
	
	public interface AscService {
		
		
		void applyRefund( vipapis.marketplace.asc.ApplyRefundRequest request_ );
		
		void approveAsc( vipapis.marketplace.asc.ApproveAscRequest request_ );
		
		void cancelAsc( vipapis.marketplace.asc.CancelAscRequest request_ );
		
		void confirmRefund( vipapis.marketplace.asc.RejectApplyRefundRequest request_ );
		
		vipapis.marketplace.asc.GetAscInfoResponse getAscInfo( vipapis.marketplace.asc.GetAscInfoRequest request_ );
		
		vipapis.marketplace.asc.GetAscsResponse getAscs( vipapis.marketplace.asc.GetAscsRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void refuseRefund( vipapis.marketplace.asc.RefuseRefundRequest request_ );
		
	}
	
}