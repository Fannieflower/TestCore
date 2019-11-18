using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.price.api{
	
	
	public interface PriceService {
		
		
		Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> confirmPricingReceipt( List<string> pricing_nos_ );
		
		Dictionary<string, vipapis.xstore.cc.price.api.ResultCode> confirmStoreSalePriceChange( vipapis.xstore.cc.price.api.ConfirmStoreSalePriceChangeReq req_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.xstore.cc.price.api.QueryPricingReceiptResp queryPricingReceipt( vipapis.xstore.cc.price.api.QueryPricingReceiptReq req_ );
		
		vipapis.xstore.cc.price.api.QueryPricingReceiptItemResp queryPricingReceiptItem( vipapis.xstore.cc.price.api.QueryPricingReceiptItemReq req_ );
		
		List<vipapis.xstore.cc.price.api.BasePrice> queryProdRetailPrice( List<string> prod_items_ );
		
		vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeResp queryStoreSalePriceChange( vipapis.xstore.cc.price.api.QueryStoreSalePriceChangeReq req_ );
		
	}
	
}