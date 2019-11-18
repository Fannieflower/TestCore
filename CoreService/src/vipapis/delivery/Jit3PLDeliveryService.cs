using System;
using System.Collections.Generic;

namespace vipapis.delivery{
	
	
	public interface Jit3PLDeliveryService {
		
		
		string confirmDelivery( int operator_id_,   string storage_no_,   string store_sn_ );
		
		vipapis.delivery.CreateDeliveryResponse createDelivery( int operator_id_,   string po_no_,   string delivery_no_,   vipapis.common.Warehouse? warehouse_,   string delivery_time_,   string arrival_time_,   string carrier_name_,   string delivery_method_,   string store_sn_,   string carrier_code_ );
		
		string createMultiPoDelivery( vipapis.delivery.Create3PLMultiPoDeliveryRequest request_ );
		
		List<vipapis.delivery.SimplePick> createPick( string po_no_,   int operator_id_,   string warehouse_,   string store_sn_ );
		
		List<vipapis.delivery.DeleteDeliveryDetail> deleteDeliveryDetail( int operator_id_,   string storage_no_,   string po_no_ );
		
		string editDelivery( int operator_id_,   string storage_no_,   string delivery_no_,   vipapis.common.Warehouse? warehouse_,   string delivery_time_,   string arrival_time_,   string carrier_name_,   string tel_,   string driver_,   string driver_tel_,   string delivery_method_,   string store_sn_,   string carrier_code_ );
		
		bool? editMultiPoDelivery( vipapis.delivery.Edit3PLMultiPoDeliveryRequest request_ );
		
		vipapis.delivery.GetDeliveryGoodsResponse getDeliveryGoods( int operator_id_,   string storage_no_,   int? page_,   int? limit_ );
		
		vipapis.delivery.GetDeliveryListResponse getDeliveryList( int operator_id_,   string po_no_,   string delivery_no_,   vipapis.common.Warehouse? warehouse_,   string out_flag_,   string st_out_time_,   string et_out_time_,   string st_estimate_arrive_time_,   string et_estimate_arrive_time_,   string st_arrive_time_,   string et_arrive_time_,   int? page_,   int? limit_,   string store_sn_,   string storage_no_ );
		
		vipapis.delivery.GetMultiPoPickDetailResponse getMultiPoPickDetail( vipapis.delivery.Get3PLMultiPoPickDetailRequest request_ );
		
		vipapis.delivery.PickDetail getPickDetail( string po_no_,   int operator_id_,   string pick_no_,   int? page_,   int? limit_ );
		
		vipapis.delivery.GetPickListResponse getPickList( int operator_id_,   string po_no_,   string pick_no_,   vipapis.common.Warehouse? warehouse_,   string co_mode_,   string order_cate_,   string st_create_time_,   string et_create_time_,   string st_sell_time_from_,   string et_sell_time_from_,   int? is_export_,   int? page_,   int? limit_,   string store_sn_ );
		
		vipapis.delivery.Get3PLPoListResponse getPoList( string po_no_,   string co_mode_,   int operator_id_,   string st_sell_st_time_,   string et_sell_st_time_,   string st_po_start_time_,   string et_po_start_time_,   int? page_,   int? limit_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		string importDeliveryDetail( int operator_id_,   string po_no_,   string storage_no_,   string store_sn_,   List<vipapis.delivery.Delivery> delivery_list_ );
		
		string importMultiPoDeliveryDetail( int operator_id_,   string po_no_,   string storage_no_,   string store_sn_,   List<vipapis.delivery.Delivery> delivery_list_ );
		
	}
	
}