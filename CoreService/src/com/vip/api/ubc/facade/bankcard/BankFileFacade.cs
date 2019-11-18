using System;
using System.Collections.Generic;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	public interface BankFileFacade {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.api.ubc.facade.bankcard.BankDataResponse receiveBankData( com.vip.api.ubc.facade.bankcard.BankDataRequest request_ );
		
		com.vip.api.ubc.facade.bankcard.BankFileResponse receiveBankFile( com.vip.api.ubc.facade.bankcard.BankFileRequest request_ );
		
	}
	
}