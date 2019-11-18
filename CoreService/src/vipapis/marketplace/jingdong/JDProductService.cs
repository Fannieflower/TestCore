using System;
using System.Collections.Generic;

namespace vipapis.marketplace.jingdong{
	
	
	public interface JDProductService {
		
		
		List<vipapis.marketplace.jingdong.OrderActive> getOrderActive( vipapis.marketplace.jingdong.GetOrderActiveRequest request_ );
		
		List<vipapis.marketplace.jingdong.SkuCommission> getSkuCommission( List<string> sku_ids_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.marketplace.jingdong.SkuOffShelfResponse skuOffShelf( string sku_id_ );
		
		vipapis.marketplace.jingdong.SkuOnShelfResponse skuOnShelf( string sku_id_ );
		
	}
	
}