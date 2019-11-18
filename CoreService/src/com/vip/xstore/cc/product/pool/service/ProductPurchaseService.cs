using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	public interface ProductPurchaseService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO prodQuery( com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO prodQueryReqDTO_ );
		
		com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO prodValidate( com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO prodValidateReqDTO_ );
		
	}
	
}