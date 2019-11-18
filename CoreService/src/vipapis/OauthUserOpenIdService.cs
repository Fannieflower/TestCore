using System;
using System.Collections.Generic;

namespace vipapis{
	
	
	public interface OauthUserOpenIdService {
		
		
		string getOpenIdByUserId( int userId_ );
		
		long? getUserIdByOpenId( string openId_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}