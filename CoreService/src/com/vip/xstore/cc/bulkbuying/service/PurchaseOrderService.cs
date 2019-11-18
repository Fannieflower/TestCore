using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	public interface PurchaseOrderService {
		
		
		void complementBarcodeOriginOfOuterPurchase();
		
		int? delete( List<string> purchaseNo_ );
		
		com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse doImport( com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest request_ );
		
		com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult export( string purchaseNo_,   int exportType_ );
		
		bool? exportAsync( string purchaseNo_,   string exportType_ );
		
		com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult exportPoHead( string purchaseNo_,   com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult queryMyApprovedPo( com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq req_ );
		
		List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> select( string purchaseNo_ );
		
		List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> selectAll( com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq selectAllReq_ );
		
		com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult selectPage( com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_ );
		
		com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp statPoByGroup( com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq req_ );
		
		bool? update( com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest request_ );
		
		void updatePoDistributableGoodsTime( string purchaseNo_,   System.DateTime distributableGoodsTime_ );
		
	}
	
}