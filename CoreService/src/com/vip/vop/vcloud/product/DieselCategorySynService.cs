using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.product{
	
	
	public interface DieselCategorySynService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void processCategoryItem();
		
	}
	
}