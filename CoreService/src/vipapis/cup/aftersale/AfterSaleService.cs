using System;
using System.Collections.Generic;

namespace vipapis.cup.aftersale{
	
	
	public interface AfterSaleService {
		
		
		com.vip.vop.cup.api.aftersale.CreateReturnApplyResp createReturnApply( List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> req_list_ );
		
		com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp getReturnApplyStatus( string start_time_,   string end_time_,   int? page_,   int? page_size_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp updateReturnApplyStatus( List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> req_list_ );
		
		com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp updateReturnRefundResult( List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> req_list_ );
		
	}
	
}