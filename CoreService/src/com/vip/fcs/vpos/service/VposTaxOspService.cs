using System;
using System.Collections.Generic;

namespace com.vip.fcs.vpos.service{
	
	
	public interface VposTaxOspService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.fcs.vpos.service.TaxOrderRespone queryOrder( string vposOrderNum_ );
		
		com.vip.fcs.vpos.service.TaxInfoRespone syncTaxInfo( com.vip.fcs.vpos.service.TaxInfo taxInfo_ );
		
	}
	
}