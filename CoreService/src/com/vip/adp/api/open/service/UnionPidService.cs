using System;
using System.Collections.Generic;

namespace com.vip.adp.api.open.service{
	
	
	public interface UnionPidService {
		
		
		com.vip.adp.api.open.service.CpsUnionPidGenResponse genPid( com.vip.adp.api.open.service.PidGenRequest pidGenRequest_ );
		
		com.vip.adp.api.open.service.CpsUnionPidGenResponse genPidWithOauth( com.vip.adp.api.open.service.PidGenRequest pidGenRequest_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.adp.api.open.service.CpsUnionPidQueryResponse queryPid( com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_ );
		
		com.vip.adp.api.open.service.CpsUnionPidQueryResponse queryPidWithOauth( com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_ );
		
	}
	
}