using System;
using System.Collections.Generic;

namespace vipapis.productsale{
	
	
	public interface ProductSaleService {
		
		
		string exportExcel( com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_ );
		
		List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> getProductSaleInfoLogs( long? productSaleInfoId_ );
		
		com.vip.vipapis.productsale.service.ProductSaleInfosResponse getProductSaleInfos( com.vip.vipapis.productsale.service.ProductSaleParam productSaleParam_ );
		
		List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> getProductSaleInfosByIds( List<long?> ids_ );
		
		com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse getProductSaleInfosByParam( com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		bool? updateProductSaleInfos( List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> productSaleInfoModel_ );
		
	}
	
}