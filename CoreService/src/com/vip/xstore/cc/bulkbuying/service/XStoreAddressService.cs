using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	public interface XStoreAddressService {
		
		
		com.vip.xstore.cc.bulkbuying.service.AddressCommonRes create( com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel model_ );
		
		com.vip.xstore.cc.bulkbuying.service.AddressCommonRes delete( long id_ );
		
		com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel detail( long id_ );
		
		void fixFullAddressData();
		
		List<com.vip.xstore.cc.bulkbuying.service.AddressSimpleInfo> getTmsAddressByParent( string parentCode_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> listByCompanyCode( string companyCode_ );
		
		List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> listByIds( List<long?> ids_ );
		
		com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageRes page( com.vip.xstore.cc.bulkbuying.service.XStoreAddressPageReq req_ );
		
	}
	
}