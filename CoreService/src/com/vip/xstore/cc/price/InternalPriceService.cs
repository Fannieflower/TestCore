using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.price{
	
	
	public interface InternalPriceService {
		
		
		List<com.vip.xstore.cc.price.ProdItemPrice> batchGetPrice( com.vip.xstore.cc.price.BatchGetPriceReq req_ );
		
		List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> batchGetProdItemBaseCostPrice( com.vip.xstore.cc.price.ReqContext context_,   List<com.vip.xstore.cc.price.ProdItemId> items_ );
		
		List<com.vip.xstore.cc.price.StoreProdItemHisPrice> batchGetProdItemHisPrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_,   System.DateTime? queryTime_ );
		
		List<com.vip.xstore.cc.price.StoreProdItemPrice> batchGetProdItemNewestPrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_ );
		
		List<com.vip.xstore.cc.price.ProdItemRetailPrice> batchGetProdItemNewestRetailPrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   List<string> barcodes_ );
		
		List<com.vip.xstore.cc.price.StoreProdItemSalePrice> batchGetProdItemNewestSalePrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_ );
		
		com.vip.xstore.cc.price.ProdItemPrice getPrice( com.vip.xstore.cc.price.GetPriceReq req_ );
		
		com.vip.xstore.cc.price.PricingReceiptResp getPricingReceipt( com.vip.xstore.cc.price.PricingReceiptReq req_ );
		
		com.vip.xstore.cc.price.PricingReceiptItemResp getPricingReceiptItem( com.vip.xstore.cc.price.PricingReceiptItemReq req_ );
		
		com.vip.xstore.cc.price.StoreProdItemPrice getProdItemNewestPrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   string storeCode_,   string barcode_ );
		
		com.vip.xstore.cc.price.ProdItemRetailPrice getProdItemNewestRetailPrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   string barcode_ );
		
		com.vip.xstore.cc.price.StoreProdItemSalePrice getProdItemNewestSalePrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   string storeCode_,   string barcode_ );
		
		List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> getProdItemRecentNTimesSalePrice( com.vip.xstore.cc.price.ReqContext context_,   string companyCode_,   string storeCode_,   string barcode_,   int nTimes_ );
		
		com.vip.xstore.cc.price.ProdItemSettlementPriceResp getProdItemSettlementPrice( com.vip.xstore.cc.price.ProdItemSettlementPriceReq req_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}