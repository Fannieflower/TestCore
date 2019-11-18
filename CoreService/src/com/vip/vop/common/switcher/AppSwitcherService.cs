using System;
using System.Collections.Generic;

namespace com.vip.vop.common.switcher{
	
	
	public interface AppSwitcherService {
		
		
		bool? closeSwitcher( string domainName_,   string moduleName_ );
		
		bool? createSwitcher( string domainName_,   string moduleName_,   string remark_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		bool? isOpenSwither( string domainName_,   string moduleName_ );
		
		bool? openSwitcher( string domainName_,   string moduleName_ );
		
	}
	
}