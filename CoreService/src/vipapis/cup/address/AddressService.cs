using System;
using System.Collections.Generic;

namespace vipapis.cup.address{
	
	
	public interface AddressService {
		
		
		com.vip.vop.cup.api.address.VipAddressInfo getVipAddress( string province_,   string city_,   string county_,   string street_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}