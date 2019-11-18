using System;
using System.Collections.Generic;

namespace vipapis.cup.bill{
	
	
	public interface BillService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.cup.api.bill.UpdateBillResult updateBillInfo( com.vip.vop.cup.api.bill.BillHeaderInfo bill_header_info_ );
		
	}
	
}