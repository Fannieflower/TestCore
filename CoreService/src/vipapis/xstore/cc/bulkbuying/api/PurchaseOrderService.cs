using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	public interface PurchaseOrderService {
		
		
		vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp confirmPoWarehouseReceipt( vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq req_ );
		
		vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp confirmPurchaseOrder( string purchaseNo_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp queryPoWarehouseReceipt( vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq req_ );
		
		vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp queryPoWarehouseReceiptItem( vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq req_ );
		
		vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp queryPurchaseOrder( vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq req_ );
		
		vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp queryPurchaseOrderItem( vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq req_ );
		
		Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> updatePoWarehouseReceiptQty( vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq req_ );
		
	}
	
}