using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.transferring.api{
	
	
	public interface TransferringOrderApiService {
		
		
		vipapis.xstore.cc.transferring.api.CompleteOrderResponse completeTransferringOrder( vipapis.xstore.cc.transferring.api.CompleteOrderRequest request_ );
		
		vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes confirmTransferringDelivery( vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq request_ );
		
		vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult confirmTransferringOrder( List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> confirm_transferring_order_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult queryTransferringDelivery( System.DateTime start_delivery_time_,   System.DateTime end_delivery_time_,   byte transferring_type_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult queryTransferringDeliveryForPDA( System.DateTime start_delivery_time_,   System.DateTime end_delivery_time_,   List<byte?> transferring_type_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult queryTransferringDeliveryItem( string transferring_order_no_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel queryTransferringOrder( byte? transferring_type_,   System.DateTime? create_time_start_,   System.DateTime? create_time_end_,   int? page_,   int? page_size_,   string confirm_status_ );
		
		vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel queryTransferringOrderForPDA( List<byte?> transferring_types_,   System.DateTime? create_time_start_,   System.DateTime? create_time_end_,   int? page_,   int? page_size_,   string confirm_status_ );
		
		vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult queryTransferringOrderItem( string transferring_order_no_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult queryTransferringReceipt( System.DateTime start_received_time_,   System.DateTime end_received_time_,   int? transferring_type_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult queryTransferringReceiptItem( string transferring_order_no_,   int? page_,   int? page_size_ );
		
		vipapis.xstore.cc.transferring.api.TransferringBatchRes transferringBatchCancel( string batch_no_ );
		
		vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes transferringBatchCreate( vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq req_ );
		
		vipapis.xstore.cc.transferring.api.TransferringBatchRes transferringBatchEmpty( string batch_no_ );
		
		vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes transferringBatchImportDetail( vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq req_ );
		
		vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes transferringBatchSubmit( string batch_no_ );
		
		vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes transferringOrderCancel( string transferringOrderNo_ );
		
		vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult updateTransferringItemQuantity( string transferring_order_no_,   System.DateTime? delivery_date_,   string ship_warehouse_code_,   List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> transferring_order_items_,   string carrier_code_,   string carrier_name_,   string transport_no_,   int? total_row_ );
		
		vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult updateTransferringReceivedQuantity( string transferring_order_no_,   System.DateTime? received_date_,   string received_warehouse_code_,   List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> transferring_order_received_,   int? total_row_ );
		
		vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult updateTransferringWopReceivedQuantity( string transferring_order_no_,   string batch_no_,   int batch_line_count_,   string out_order_no_,   string received_warehouse_code_,   System.DateTime received_date_,   List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> received_items_,   int? total_row_ );
		
	}
	
}