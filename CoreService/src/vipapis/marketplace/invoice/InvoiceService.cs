using System;
using System.Collections.Generic;

namespace vipapis.marketplace.invoice{
	
	
	public interface InvoiceService {
		
		
		vipapis.marketplace.invoice.ConfirmInvoiceResponse confirmInvoice( vipapis.marketplace.invoice.ConfirmInvoiceRequest request_ );
		
		vipapis.marketplace.invoice.GetInvoicesResponse getInvoices( vipapis.marketplace.invoice.GetInvoicesRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}