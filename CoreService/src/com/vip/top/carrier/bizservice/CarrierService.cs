using System;
using System.Collections.Generic;

namespace com.vip.top.carrier.bizservice{
	
	
	public interface CarrierService {
		
		
		com.vip.top.carrier.bizservice.TransportNosResponseModel fetchTransportNos( com.vip.top.carrier.bizservice.FetchTransportNosRequestModel requestModel_ );
		
		List<com.vip.top.carrier.bizservice.ExpressCo> getAllExpressCo();
		
		com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrier( string custNo_ );
		
		com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrierByCustNo( long? custNo_ );
		
		com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrierByName( string custName_ );
		
		List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> getCarrierListByWareHouse( string warehouse_ );
		
		Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> getCarriers( List<string> custNos_ );
		
		com.vip.top.carrier.bizservice.ForwarderCompanyVO getForwarderCompanyVO( string orderSn_,   string warehouse_ );
		
		com.vip.top.carrier.bizservice.OrderDeliveryInfo getLefengOrderDeliveryInfo( string orderSn_,   string warehouse_ );
		
		com.vip.top.carrier.bizservice.OrderDeliveryInfo getOrderDeliveryInfo( string orderSn_,   string warehouse_ );
		
		List<com.vip.top.carrier.bizservice.PickupQueryResult> getPickInfo( com.vip.top.carrier.bizservice.PickupQueryInfo info_,   string warehouse_,   int? limit_,   int? offset_ );
		
		int? getPickInfoTotalNum( com.vip.top.carrier.bizservice.PickupQueryInfo info_,   string warehouse_ );
		
		com.vip.top.carrier.bizservice.PickingInfoResult getPickingInfoByAddress( com.vip.top.carrier.bizservice.PickingInfoRequest pickingInfoRequest_ );
		
		com.vip.top.carrier.bizservice.ReturnOrderInfo getReturnOrderInfo( string orderSn_,   string warehouse_ );
		
		com.vip.top.carrier.bizservice.SortingInfoResult getSortingInfoByAddress( com.vip.top.carrier.bizservice.SortingInfoRequestHead sortingInfoRequestHead_,   List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> sortingInfoRequestItems_ );
		
		com.vip.top.carrier.bizservice.TransportNoInfosResponseModel getTransportNosByOrderDetail( string sysKey_,   string vendorCode_,   string thirdCustCode_,   int size_,   com.vip.top.carrier.bizservice.TmsOrderDetailModel tmsOrderDetailModel_ );
		
		com.vip.top.carrier.bizservice.TransportNosResponseModel getTransportNosByThirdCustCode( string sysKey_,   string vendorCode_,   string thirdCustCode_,   int size_,   string orderSn_ );
		
		List<com.vip.top.carrier.service.GetPackageTimeVo> getVisitHourOption( string returnApplyTime_,   string lastAddressCode_ );
		
		string getVisitTimeOption( string returnApplyTime_,   string lastAddressCode_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> listCarriers( int? type_,   bool? showAll_ );
		
		Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> matchCarrier( List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> tmsOrderInfoModels_,   string warehouse_ );
		
		Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> matchCarrierById( List<string> tmsOrderIds_,   string warehouse_ );
		
		Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> matchCarrierByIdWithPriority( List<string> tmsOrderIds_,   string warehouse_ );
		
		string queryCustStandardNameByUncode( string custUncode_ );
		
		com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel queryTransportNosByOrderSn( List<string> orderSns_ );
		
		void refreshCrmCustRuleAllocationByCreatedOffice( string createdOffice_,   string warehouse_ );
		
		void refreshCustPickupGoodsTime( string crmCustId_,   string warehouse_ );
		
		void refreshCustPointInfo( string crmCustPointId_,   string warehouse_ );
		
		void refreshCustRelevantCache( com.vip.top.carrier.cache.RefreshCacheParam param_,   string warehouse_ );
		
		void refreshInfConfiguration( string pkKey_,   string warehouse_ );
		
		void refreshPickingInfo( string crmCustId_,   string warehouse_ );
		
		void refreshSbDeliverPointByRegion( string createdOffice_,   string regionCode_,   string warehouse_ );
		
		void refreshTmsSysParamByParamKey( string paramKey_,   string warehouse_ );
		
	}
	
}