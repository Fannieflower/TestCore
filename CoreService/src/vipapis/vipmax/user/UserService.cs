using System;
using System.Collections.Generic;

namespace vipapis.vipmax.user{
	
	
	public interface UserService {
		
		
		vipapis.vipmax.user.GetUserInfoResponse getUserInfo( vipapis.vipmax.user.GetUserInfoRequest getUserInfoRequest_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}