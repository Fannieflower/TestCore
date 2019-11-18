using System;
using System.Collections.Generic;

namespace vipapis.common{
	
	
	public interface ProductCommonService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		string zoomImage( vipapis.common.ZoomImageRequest request_ );
		
	}
	
}