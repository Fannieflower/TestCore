using System;
using System.Collections.Generic;

namespace vipapis.fcs{
	
	
	public interface MpInvoiceService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel receiveMpInvoiceIssueResult( com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel pushMpInvoiceIssueResultRequestModel_ );
		
	}
	
}