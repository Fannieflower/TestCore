using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.top.carrier.bizservice{
	
	
	public class CarrierServiceHelper {
		
		
		
		public class fetchTransportNos_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.FetchTransportNosRequestModel requestModel_;
			
			public com.vip.top.carrier.bizservice.FetchTransportNosRequestModel GetRequestModel(){
				return this.requestModel_;
			}
			
			public void SetRequestModel(com.vip.top.carrier.bizservice.FetchTransportNosRequestModel value){
				this.requestModel_ = value;
			}
			
		}
		
		
		
		
		public class getAllExpressCo_args {
			
			
		}
		
		
		
		
		public class getCarrier_args {
			
			///<summary>
			/// 承运商编号
			///</summary>
			
			private string custNo_;
			
			public string GetCustNo(){
				return this.custNo_;
			}
			
			public void SetCustNo(string value){
				this.custNo_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierByCustNo_args {
			
			///<summary>
			///</summary>
			
			private long? custNo_;
			
			public long? GetCustNo(){
				return this.custNo_;
			}
			
			public void SetCustNo(long? value){
				this.custNo_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierByName_args {
			
			///<summary>
			/// 承运商名称
			///</summary>
			
			private string custName_;
			
			public string GetCustName(){
				return this.custName_;
			}
			
			public void SetCustName(string value){
				this.custName_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierListByWareHouse_args {
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getCarriers_args {
			
			///<summary>
			///</summary>
			
			private List<string> custNos_;
			
			public List<string> GetCustNos(){
				return this.custNos_;
			}
			
			public void SetCustNos(List<string> value){
				this.custNos_ = value;
			}
			
		}
		
		
		
		
		public class getForwarderCompanyVO_args {
			
			///<summary>
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getLefengOrderDeliveryInfo_args {
			
			///<summary>
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getOrderDeliveryInfo_args {
			
			///<summary>
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getPickInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.PickupQueryInfo info_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			///<summary>
			///</summary>
			
			private int? limit_;
			
			///<summary>
			///</summary>
			
			private int? offset_;
			
			public com.vip.top.carrier.bizservice.PickupQueryInfo GetInfo(){
				return this.info_;
			}
			
			public void SetInfo(com.vip.top.carrier.bizservice.PickupQueryInfo value){
				this.info_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			public int? GetOffset(){
				return this.offset_;
			}
			
			public void SetOffset(int? value){
				this.offset_ = value;
			}
			
		}
		
		
		
		
		public class getPickInfoTotalNum_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.PickupQueryInfo info_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public com.vip.top.carrier.bizservice.PickupQueryInfo GetInfo(){
				return this.info_;
			}
			
			public void SetInfo(com.vip.top.carrier.bizservice.PickupQueryInfo value){
				this.info_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getPickingInfoByAddress_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.PickingInfoRequest pickingInfoRequest_;
			
			public com.vip.top.carrier.bizservice.PickingInfoRequest GetPickingInfoRequest(){
				return this.pickingInfoRequest_;
			}
			
			public void SetPickingInfoRequest(com.vip.top.carrier.bizservice.PickingInfoRequest value){
				this.pickingInfoRequest_ = value;
			}
			
		}
		
		
		
		
		public class getReturnOrderInfo_args {
			
			///<summary>
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class getSortingInfoByAddress_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.SortingInfoRequestHead sortingInfoRequestHead_;
			
			///<summary>
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> sortingInfoRequestItems_;
			
			public com.vip.top.carrier.bizservice.SortingInfoRequestHead GetSortingInfoRequestHead(){
				return this.sortingInfoRequestHead_;
			}
			
			public void SetSortingInfoRequestHead(com.vip.top.carrier.bizservice.SortingInfoRequestHead value){
				this.sortingInfoRequestHead_ = value;
			}
			public List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> GetSortingInfoRequestItems(){
				return this.sortingInfoRequestItems_;
			}
			
			public void SetSortingInfoRequestItems(List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> value){
				this.sortingInfoRequestItems_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNosByOrderDetail_args {
			
			///<summary>
			///</summary>
			
			private string sysKey_;
			
			///<summary>
			///</summary>
			
			private string vendorCode_;
			
			///<summary>
			///</summary>
			
			private string thirdCustCode_;
			
			///<summary>
			///</summary>
			
			private int? size_;
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.TmsOrderDetailModel tmsOrderDetailModel_;
			
			public string GetSysKey(){
				return this.sysKey_;
			}
			
			public void SetSysKey(string value){
				this.sysKey_ = value;
			}
			public string GetVendorCode(){
				return this.vendorCode_;
			}
			
			public void SetVendorCode(string value){
				this.vendorCode_ = value;
			}
			public string GetThirdCustCode(){
				return this.thirdCustCode_;
			}
			
			public void SetThirdCustCode(string value){
				this.thirdCustCode_ = value;
			}
			public int? GetSize(){
				return this.size_;
			}
			
			public void SetSize(int? value){
				this.size_ = value;
			}
			public com.vip.top.carrier.bizservice.TmsOrderDetailModel GetTmsOrderDetailModel(){
				return this.tmsOrderDetailModel_;
			}
			
			public void SetTmsOrderDetailModel(com.vip.top.carrier.bizservice.TmsOrderDetailModel value){
				this.tmsOrderDetailModel_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNosByThirdCustCode_args {
			
			///<summary>
			///</summary>
			
			private string sysKey_;
			
			///<summary>
			///</summary>
			
			private string vendorCode_;
			
			///<summary>
			///</summary>
			
			private string thirdCustCode_;
			
			///<summary>
			///</summary>
			
			private int? size_;
			
			///<summary>
			///</summary>
			
			private string orderSn_;
			
			public string GetSysKey(){
				return this.sysKey_;
			}
			
			public void SetSysKey(string value){
				this.sysKey_ = value;
			}
			public string GetVendorCode(){
				return this.vendorCode_;
			}
			
			public void SetVendorCode(string value){
				this.vendorCode_ = value;
			}
			public string GetThirdCustCode(){
				return this.thirdCustCode_;
			}
			
			public void SetThirdCustCode(string value){
				this.thirdCustCode_ = value;
			}
			public int? GetSize(){
				return this.size_;
			}
			
			public void SetSize(int? value){
				this.size_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			
		}
		
		
		
		
		public class getVisitHourOption_args {
			
			///<summary>
			///</summary>
			
			private string returnApplyTime_;
			
			///<summary>
			///</summary>
			
			private string lastAddressCode_;
			
			public string GetReturnApplyTime(){
				return this.returnApplyTime_;
			}
			
			public void SetReturnApplyTime(string value){
				this.returnApplyTime_ = value;
			}
			public string GetLastAddressCode(){
				return this.lastAddressCode_;
			}
			
			public void SetLastAddressCode(string value){
				this.lastAddressCode_ = value;
			}
			
		}
		
		
		
		
		public class getVisitTimeOption_args {
			
			///<summary>
			///</summary>
			
			private string returnApplyTime_;
			
			///<summary>
			///</summary>
			
			private string lastAddressCode_;
			
			public string GetReturnApplyTime(){
				return this.returnApplyTime_;
			}
			
			public void SetReturnApplyTime(string value){
				this.returnApplyTime_ = value;
			}
			public string GetLastAddressCode(){
				return this.lastAddressCode_;
			}
			
			public void SetLastAddressCode(string value){
				this.lastAddressCode_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class listCarriers_args {
			
			///<summary>
			/// 类型：1: TMS承运商（默认）2:旧B2C承运商
			///</summary>
			
			private int? type_;
			
			///<summary>
			/// 是否显示包括停用的承运商 0:不显示停用的;1:显示包括停用的全部
			///</summary>
			
			private bool? showAll_;
			
			public int? GetType(){
				return this.type_;
			}
			
			public void SetType(int? value){
				this.type_ = value;
			}
			public bool? GetShowAll(){
				return this.showAll_;
			}
			
			public void SetShowAll(bool? value){
				this.showAll_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrier_args {
			
			///<summary>
			/// List<TmsOrderInfoModel> 需要匹配承运商的订单信息对象列表
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> tmsOrderInfoModels_;
			
			///<summary>
			/// 所属仓库(数据库分库关键字，必填)
			///</summary>
			
			private string warehouse_;
			
			public List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> GetTmsOrderInfoModels(){
				return this.tmsOrderInfoModels_;
			}
			
			public void SetTmsOrderInfoModels(List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> value){
				this.tmsOrderInfoModels_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrierById_args {
			
			///<summary>
			/// List<String> 需要匹配承运商的订单ID列表
			///</summary>
			
			private List<string> tmsOrderIds_;
			
			///<summary>
			/// 所属仓库(Venus框架分库所必须的)
			///</summary>
			
			private string warehouse_;
			
			public List<string> GetTmsOrderIds(){
				return this.tmsOrderIds_;
			}
			
			public void SetTmsOrderIds(List<string> value){
				this.tmsOrderIds_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrierByIdWithPriority_args {
			
			///<summary>
			///</summary>
			
			private List<string> tmsOrderIds_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public List<string> GetTmsOrderIds(){
				return this.tmsOrderIds_;
			}
			
			public void SetTmsOrderIds(List<string> value){
				this.tmsOrderIds_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class queryCustStandardNameByUncode_args {
			
			///<summary>
			///</summary>
			
			private string custUncode_;
			
			public string GetCustUncode(){
				return this.custUncode_;
			}
			
			public void SetCustUncode(string value){
				this.custUncode_ = value;
			}
			
		}
		
		
		
		
		public class queryTransportNosByOrderSn_args {
			
			///<summary>
			///</summary>
			
			private List<string> orderSns_;
			
			public List<string> GetOrderSns(){
				return this.orderSns_;
			}
			
			public void SetOrderSns(List<string> value){
				this.orderSns_ = value;
			}
			
		}
		
		
		
		
		public class refreshCrmCustRuleAllocationByCreatedOffice_args {
			
			///<summary>
			///</summary>
			
			private string createdOffice_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetCreatedOffice(){
				return this.createdOffice_;
			}
			
			public void SetCreatedOffice(string value){
				this.createdOffice_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshCustPickupGoodsTime_args {
			
			///<summary>
			/// 承运商ID
			///</summary>
			
			private string crmCustId_;
			
			///<summary>
			/// 分库关键字
			///</summary>
			
			private string warehouse_;
			
			public string GetCrmCustId(){
				return this.crmCustId_;
			}
			
			public void SetCrmCustId(string value){
				this.crmCustId_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshCustPointInfo_args {
			
			///<summary>
			/// 承运商站点ID
			///</summary>
			
			private string crmCustPointId_;
			
			///<summary>
			/// 分库关键字
			///</summary>
			
			private string warehouse_;
			
			public string GetCrmCustPointId(){
				return this.crmCustPointId_;
			}
			
			public void SetCrmCustPointId(string value){
				this.crmCustPointId_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshCustRelevantCache_args {
			
			///<summary>
			/// RefreshCacheParam刷新缓存的参数对象
			///</summary>
			
			private com.vip.top.carrier.cache.RefreshCacheParam param_;
			
			///<summary>
			/// 所属仓库(数据库分库关键字，必填)
			///</summary>
			
			private string warehouse_;
			
			public com.vip.top.carrier.cache.RefreshCacheParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.top.carrier.cache.RefreshCacheParam value){
				this.param_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshInfConfiguration_args {
			
			///<summary>
			///</summary>
			
			private string pkKey_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetPkKey(){
				return this.pkKey_;
			}
			
			public void SetPkKey(string value){
				this.pkKey_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshPickingInfo_args {
			
			///<summary>
			/// 承运商
			///</summary>
			
			private string crmCustId_;
			
			///<summary>
			/// 分库关键字
			///</summary>
			
			private string warehouse_;
			
			public string GetCrmCustId(){
				return this.crmCustId_;
			}
			
			public void SetCrmCustId(string value){
				this.crmCustId_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshSbDeliverPointByRegion_args {
			
			///<summary>
			/// 所属仓库
			///</summary>
			
			private string createdOffice_;
			
			///<summary>
			/// 县区
			///</summary>
			
			private string regionCode_;
			
			///<summary>
			/// 分库关键字
			///</summary>
			
			private string warehouse_;
			
			public string GetCreatedOffice(){
				return this.createdOffice_;
			}
			
			public void SetCreatedOffice(string value){
				this.createdOffice_ = value;
			}
			public string GetRegionCode(){
				return this.regionCode_;
			}
			
			public void SetRegionCode(string value){
				this.regionCode_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class refreshTmsSysParamByParamKey_args {
			
			///<summary>
			///</summary>
			
			private string paramKey_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public string GetParamKey(){
				return this.paramKey_;
			}
			
			public void SetParamKey(string value){
				this.paramKey_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class fetchTransportNos_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.TransportNosResponseModel success_;
			
			public com.vip.top.carrier.bizservice.TransportNosResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.TransportNosResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getAllExpressCo_result {
			
			///<summary>
			/// 
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.ExpressCo> success_;
			
			public List<com.vip.top.carrier.bizservice.ExpressCo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.carrier.bizservice.ExpressCo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCarrier_result {
			
			///<summary>
			/// 
			///</summary>
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel success_;
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierByCustNo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel success_;
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierByName_result {
			
			///<summary>
			/// 
			///</summary>
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel success_;
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCarrierListByWareHouse_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> success_;
			
			public List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCarriers_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> success_;
			
			public Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getForwarderCompanyVO_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.ForwarderCompanyVO success_;
			
			public com.vip.top.carrier.bizservice.ForwarderCompanyVO GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.ForwarderCompanyVO value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getLefengOrderDeliveryInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.OrderDeliveryInfo success_;
			
			public com.vip.top.carrier.bizservice.OrderDeliveryInfo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.OrderDeliveryInfo value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderDeliveryInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.OrderDeliveryInfo success_;
			
			public com.vip.top.carrier.bizservice.OrderDeliveryInfo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.OrderDeliveryInfo value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPickInfo_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.PickupQueryResult> success_;
			
			public List<com.vip.top.carrier.bizservice.PickupQueryResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.carrier.bizservice.PickupQueryResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPickInfoTotalNum_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPickingInfoByAddress_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.PickingInfoResult success_;
			
			public com.vip.top.carrier.bizservice.PickingInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.PickingInfoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getReturnOrderInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.ReturnOrderInfo success_;
			
			public com.vip.top.carrier.bizservice.ReturnOrderInfo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.ReturnOrderInfo value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSortingInfoByAddress_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.SortingInfoResult success_;
			
			public com.vip.top.carrier.bizservice.SortingInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.SortingInfoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNosByOrderDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.TransportNoInfosResponseModel success_;
			
			public com.vip.top.carrier.bizservice.TransportNoInfosResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.TransportNoInfosResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNosByThirdCustCode_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.TransportNosResponseModel success_;
			
			public com.vip.top.carrier.bizservice.TransportNosResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.TransportNosResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getVisitHourOption_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.top.carrier.service.GetPackageTimeVo> success_;
			
			public List<com.vip.top.carrier.service.GetPackageTimeVo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.carrier.service.GetPackageTimeVo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getVisitTimeOption_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listCarriers_result {
			
			///<summary>
			/// List<RegisteredCarrierModelModel>
			///</summary>
			
			private List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> success_;
			
			public List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrier_result {
			
			///<summary>
			/// Map<String, MatchResultInfo> key为tmsOrderId(物流单ID) value为匹配结果对象
			///</summary>
			
			private Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> success_;
			
			public Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrierById_result {
			
			///<summary>
			/// Map<String, MatchResultInfo> key为tmsOrderId(物流单ID) value为匹配结果对象
			///</summary>
			
			private Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> success_;
			
			public Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class matchCarrierByIdWithPriority_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> success_;
			
			public Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryCustStandardNameByUncode_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransportNosByOrderSn_result {
			
			///<summary>
			///</summary>
			
			private com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel success_;
			
			public com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class refreshCrmCustRuleAllocationByCreatedOffice_result {
			
			
		}
		
		
		
		
		public class refreshCustPickupGoodsTime_result {
			
			
		}
		
		
		
		
		public class refreshCustPointInfo_result {
			
			
		}
		
		
		
		
		public class refreshCustRelevantCache_result {
			
			
		}
		
		
		
		
		public class refreshInfConfiguration_result {
			
			
		}
		
		
		
		
		public class refreshPickingInfo_result {
			
			
		}
		
		
		
		
		public class refreshSbDeliverPointByRegion_result {
			
			
		}
		
		
		
		
		public class refreshTmsSysParamByParamKey_result {
			
			
		}
		
		
		
		
		
		public class fetchTransportNos_argsHelper : TBeanSerializer<fetchTransportNos_args>
		{
			
			public static fetchTransportNos_argsHelper OBJ = new fetchTransportNos_argsHelper();
			
			public static fetchTransportNos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchTransportNos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.FetchTransportNosRequestModel value;
					
					value = new com.vip.top.carrier.bizservice.FetchTransportNosRequestModel();
					com.vip.top.carrier.bizservice.FetchTransportNosRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchTransportNos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequestModel() != null) {
					
					oprot.WriteFieldBegin("requestModel");
					
					com.vip.top.carrier.bizservice.FetchTransportNosRequestModelHelper.getInstance().Write(structs.GetRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchTransportNos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAllExpressCo_argsHelper : TBeanSerializer<getAllExpressCo_args>
		{
			
			public static getAllExpressCo_argsHelper OBJ = new getAllExpressCo_argsHelper();
			
			public static getAllExpressCo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAllExpressCo_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAllExpressCo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAllExpressCo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrier_argsHelper : TBeanSerializer<getCarrier_args>
		{
			
			public static getCarrier_argsHelper OBJ = new getCarrier_argsHelper();
			
			public static getCarrier_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrier_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCustNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrier_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCustNo() != null) {
					
					oprot.WriteFieldBegin("custNo");
					oprot.WriteString(structs.GetCustNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrier_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierByCustNo_argsHelper : TBeanSerializer<getCarrierByCustNo_args>
		{
			
			public static getCarrierByCustNo_argsHelper OBJ = new getCarrierByCustNo_argsHelper();
			
			public static getCarrierByCustNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierByCustNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetCustNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierByCustNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCustNo() != null) {
					
					oprot.WriteFieldBegin("custNo");
					oprot.WriteI64((long)structs.GetCustNo()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierByCustNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierByName_argsHelper : TBeanSerializer<getCarrierByName_args>
		{
			
			public static getCarrierByName_argsHelper OBJ = new getCarrierByName_argsHelper();
			
			public static getCarrierByName_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierByName_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCustName(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierByName_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCustName() != null) {
					
					oprot.WriteFieldBegin("custName");
					oprot.WriteString(structs.GetCustName());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierByName_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierListByWareHouse_argsHelper : TBeanSerializer<getCarrierListByWareHouse_args>
		{
			
			public static getCarrierListByWareHouse_argsHelper OBJ = new getCarrierListByWareHouse_argsHelper();
			
			public static getCarrierListByWareHouse_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierListByWareHouse_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierListByWareHouse_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierListByWareHouse_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarriers_argsHelper : TBeanSerializer<getCarriers_args>
		{
			
			public static getCarriers_argsHelper OBJ = new getCarriers_argsHelper();
			
			public static getCarriers_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarriers_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCustNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarriers_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCustNos() != null) {
					
					oprot.WriteFieldBegin("custNos");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetCustNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarriers_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getForwarderCompanyVO_argsHelper : TBeanSerializer<getForwarderCompanyVO_args>
		{
			
			public static getForwarderCompanyVO_argsHelper OBJ = new getForwarderCompanyVO_argsHelper();
			
			public static getForwarderCompanyVO_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getForwarderCompanyVO_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getForwarderCompanyVO_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getForwarderCompanyVO_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getLefengOrderDeliveryInfo_argsHelper : TBeanSerializer<getLefengOrderDeliveryInfo_args>
		{
			
			public static getLefengOrderDeliveryInfo_argsHelper OBJ = new getLefengOrderDeliveryInfo_argsHelper();
			
			public static getLefengOrderDeliveryInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getLefengOrderDeliveryInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getLefengOrderDeliveryInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getLefengOrderDeliveryInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderDeliveryInfo_argsHelper : TBeanSerializer<getOrderDeliveryInfo_args>
		{
			
			public static getOrderDeliveryInfo_argsHelper OBJ = new getOrderDeliveryInfo_argsHelper();
			
			public static getOrderDeliveryInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderDeliveryInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderDeliveryInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderDeliveryInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickInfo_argsHelper : TBeanSerializer<getPickInfo_args>
		{
			
			public static getPickInfo_argsHelper OBJ = new getPickInfo_argsHelper();
			
			public static getPickInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.PickupQueryInfo value;
					
					value = new com.vip.top.carrier.bizservice.PickupQueryInfo();
					com.vip.top.carrier.bizservice.PickupQueryInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetInfo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetOffset(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInfo() != null) {
					
					oprot.WriteFieldBegin("info");
					
					com.vip.top.carrier.bizservice.PickupQueryInfoHelper.getInstance().Write(structs.GetInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOffset() != null) {
					
					oprot.WriteFieldBegin("offset");
					oprot.WriteI32((int)structs.GetOffset()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickInfoTotalNum_argsHelper : TBeanSerializer<getPickInfoTotalNum_args>
		{
			
			public static getPickInfoTotalNum_argsHelper OBJ = new getPickInfoTotalNum_argsHelper();
			
			public static getPickInfoTotalNum_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickInfoTotalNum_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.PickupQueryInfo value;
					
					value = new com.vip.top.carrier.bizservice.PickupQueryInfo();
					com.vip.top.carrier.bizservice.PickupQueryInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetInfo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickInfoTotalNum_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInfo() != null) {
					
					oprot.WriteFieldBegin("info");
					
					com.vip.top.carrier.bizservice.PickupQueryInfoHelper.getInstance().Write(structs.GetInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickInfoTotalNum_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickingInfoByAddress_argsHelper : TBeanSerializer<getPickingInfoByAddress_args>
		{
			
			public static getPickingInfoByAddress_argsHelper OBJ = new getPickingInfoByAddress_argsHelper();
			
			public static getPickingInfoByAddress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickingInfoByAddress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.PickingInfoRequest value;
					
					value = new com.vip.top.carrier.bizservice.PickingInfoRequest();
					com.vip.top.carrier.bizservice.PickingInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPickingInfoRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickingInfoByAddress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPickingInfoRequest() != null) {
					
					oprot.WriteFieldBegin("pickingInfoRequest");
					
					com.vip.top.carrier.bizservice.PickingInfoRequestHelper.getInstance().Write(structs.GetPickingInfoRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickingInfoByAddress_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnOrderInfo_argsHelper : TBeanSerializer<getReturnOrderInfo_args>
		{
			
			public static getReturnOrderInfo_argsHelper OBJ = new getReturnOrderInfo_argsHelper();
			
			public static getReturnOrderInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnOrderInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getReturnOrderInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getReturnOrderInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSortingInfoByAddress_argsHelper : TBeanSerializer<getSortingInfoByAddress_args>
		{
			
			public static getSortingInfoByAddress_argsHelper OBJ = new getSortingInfoByAddress_argsHelper();
			
			public static getSortingInfoByAddress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSortingInfoByAddress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.SortingInfoRequestHead value;
					
					value = new com.vip.top.carrier.bizservice.SortingInfoRequestHead();
					com.vip.top.carrier.bizservice.SortingInfoRequestHeadHelper.getInstance().Read(value, iprot);
					
					structs.SetSortingInfoRequestHead(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> value;
					
					value = new List<com.vip.top.carrier.bizservice.SortingInfoRequestItem>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.SortingInfoRequestItem elem1;
							
							elem1 = new com.vip.top.carrier.bizservice.SortingInfoRequestItem();
							com.vip.top.carrier.bizservice.SortingInfoRequestItemHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSortingInfoRequestItems(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSortingInfoByAddress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSortingInfoRequestHead() != null) {
					
					oprot.WriteFieldBegin("sortingInfoRequestHead");
					
					com.vip.top.carrier.bizservice.SortingInfoRequestHeadHelper.getInstance().Write(structs.GetSortingInfoRequestHead(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSortingInfoRequestItems() != null) {
					
					oprot.WriteFieldBegin("sortingInfoRequestItems");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.SortingInfoRequestItem _item0 in structs.GetSortingInfoRequestItems()){
						
						
						com.vip.top.carrier.bizservice.SortingInfoRequestItemHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSortingInfoByAddress_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNosByOrderDetail_argsHelper : TBeanSerializer<getTransportNosByOrderDetail_args>
		{
			
			public static getTransportNosByOrderDetail_argsHelper OBJ = new getTransportNosByOrderDetail_argsHelper();
			
			public static getTransportNosByOrderDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNosByOrderDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSysKey(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendorCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetThirdCustCode(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSize(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.TmsOrderDetailModel value;
					
					value = new com.vip.top.carrier.bizservice.TmsOrderDetailModel();
					com.vip.top.carrier.bizservice.TmsOrderDetailModelHelper.getInstance().Read(value, iprot);
					
					structs.SetTmsOrderDetailModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNosByOrderDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSysKey() != null) {
					
					oprot.WriteFieldBegin("sysKey");
					oprot.WriteString(structs.GetSysKey());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendorCode() != null) {
					
					oprot.WriteFieldBegin("vendorCode");
					oprot.WriteString(structs.GetVendorCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetThirdCustCode() != null) {
					
					oprot.WriteFieldBegin("thirdCustCode");
					oprot.WriteString(structs.GetThirdCustCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSize() != null) {
					
					oprot.WriteFieldBegin("size");
					oprot.WriteI32((int)structs.GetSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("size can not be null!");
				}
				
				
				if(structs.GetTmsOrderDetailModel() != null) {
					
					oprot.WriteFieldBegin("tmsOrderDetailModel");
					
					com.vip.top.carrier.bizservice.TmsOrderDetailModelHelper.getInstance().Write(structs.GetTmsOrderDetailModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNosByOrderDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNosByThirdCustCode_argsHelper : TBeanSerializer<getTransportNosByThirdCustCode_args>
		{
			
			public static getTransportNosByThirdCustCode_argsHelper OBJ = new getTransportNosByThirdCustCode_argsHelper();
			
			public static getTransportNosByThirdCustCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNosByThirdCustCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSysKey(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendorCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetThirdCustCode(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSize(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNosByThirdCustCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSysKey() != null) {
					
					oprot.WriteFieldBegin("sysKey");
					oprot.WriteString(structs.GetSysKey());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendorCode() != null) {
					
					oprot.WriteFieldBegin("vendorCode");
					oprot.WriteString(structs.GetVendorCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetThirdCustCode() != null) {
					
					oprot.WriteFieldBegin("thirdCustCode");
					oprot.WriteString(structs.GetThirdCustCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSize() != null) {
					
					oprot.WriteFieldBegin("size");
					oprot.WriteI32((int)structs.GetSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("size can not be null!");
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNosByThirdCustCode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVisitHourOption_argsHelper : TBeanSerializer<getVisitHourOption_args>
		{
			
			public static getVisitHourOption_argsHelper OBJ = new getVisitHourOption_argsHelper();
			
			public static getVisitHourOption_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVisitHourOption_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReturnApplyTime(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetLastAddressCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVisitHourOption_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReturnApplyTime() != null) {
					
					oprot.WriteFieldBegin("returnApplyTime");
					oprot.WriteString(structs.GetReturnApplyTime());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLastAddressCode() != null) {
					
					oprot.WriteFieldBegin("lastAddressCode");
					oprot.WriteString(structs.GetLastAddressCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVisitHourOption_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVisitTimeOption_argsHelper : TBeanSerializer<getVisitTimeOption_args>
		{
			
			public static getVisitTimeOption_argsHelper OBJ = new getVisitTimeOption_argsHelper();
			
			public static getVisitTimeOption_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVisitTimeOption_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReturnApplyTime(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetLastAddressCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVisitTimeOption_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReturnApplyTime() != null) {
					
					oprot.WriteFieldBegin("returnApplyTime");
					oprot.WriteString(structs.GetReturnApplyTime());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLastAddressCode() != null) {
					
					oprot.WriteFieldBegin("lastAddressCode");
					oprot.WriteString(structs.GetLastAddressCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVisitTimeOption_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listCarriers_argsHelper : TBeanSerializer<listCarriers_args>
		{
			
			public static listCarriers_argsHelper OBJ = new listCarriers_argsHelper();
			
			public static listCarriers_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listCarriers_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetType(value);
				}
				
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetShowAll(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listCarriers_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetType() != null) {
					
					oprot.WriteFieldBegin("type");
					oprot.WriteI32((int)structs.GetType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetShowAll() != null) {
					
					oprot.WriteFieldBegin("showAll");
					oprot.WriteBool((bool)structs.GetShowAll());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listCarriers_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrier_argsHelper : TBeanSerializer<matchCarrier_args>
		{
			
			public static matchCarrier_argsHelper OBJ = new matchCarrier_argsHelper();
			
			public static matchCarrier_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrier_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> value;
					
					value = new List<com.vip.top.carrier.bizservice.TmsOrderInfoModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.TmsOrderInfoModel elem0;
							
							elem0 = new com.vip.top.carrier.bizservice.TmsOrderInfoModel();
							com.vip.top.carrier.bizservice.TmsOrderInfoModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTmsOrderInfoModels(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrier_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderInfoModels() != null) {
					
					oprot.WriteFieldBegin("tmsOrderInfoModels");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.TmsOrderInfoModel _item0 in structs.GetTmsOrderInfoModels()){
						
						
						com.vip.top.carrier.bizservice.TmsOrderInfoModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrier_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrierById_argsHelper : TBeanSerializer<matchCarrierById_args>
		{
			
			public static matchCarrierById_argsHelper OBJ = new matchCarrierById_argsHelper();
			
			public static matchCarrierById_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrierById_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTmsOrderIds(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrierById_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderIds() != null) {
					
					oprot.WriteFieldBegin("tmsOrderIds");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetTmsOrderIds()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrierById_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrierByIdWithPriority_argsHelper : TBeanSerializer<matchCarrierByIdWithPriority_args>
		{
			
			public static matchCarrierByIdWithPriority_argsHelper OBJ = new matchCarrierByIdWithPriority_argsHelper();
			
			public static matchCarrierByIdWithPriority_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrierByIdWithPriority_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTmsOrderIds(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrierByIdWithPriority_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderIds() != null) {
					
					oprot.WriteFieldBegin("tmsOrderIds");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetTmsOrderIds()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrierByIdWithPriority_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCustStandardNameByUncode_argsHelper : TBeanSerializer<queryCustStandardNameByUncode_args>
		{
			
			public static queryCustStandardNameByUncode_argsHelper OBJ = new queryCustStandardNameByUncode_argsHelper();
			
			public static queryCustStandardNameByUncode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCustStandardNameByUncode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCustUncode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCustStandardNameByUncode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCustUncode() != null) {
					
					oprot.WriteFieldBegin("custUncode");
					oprot.WriteString(structs.GetCustUncode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCustStandardNameByUncode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransportNosByOrderSn_argsHelper : TBeanSerializer<queryTransportNosByOrderSn_args>
		{
			
			public static queryTransportNosByOrderSn_argsHelper OBJ = new queryTransportNosByOrderSn_argsHelper();
			
			public static queryTransportNosByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransportNosByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetOrderSns(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransportNosByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSns() != null) {
					
					oprot.WriteFieldBegin("orderSns");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetOrderSns()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransportNosByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCrmCustRuleAllocationByCreatedOffice_argsHelper : TBeanSerializer<refreshCrmCustRuleAllocationByCreatedOffice_args>
		{
			
			public static refreshCrmCustRuleAllocationByCreatedOffice_argsHelper OBJ = new refreshCrmCustRuleAllocationByCreatedOffice_argsHelper();
			
			public static refreshCrmCustRuleAllocationByCreatedOffice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCrmCustRuleAllocationByCreatedOffice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCreatedOffice(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCrmCustRuleAllocationByCreatedOffice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreatedOffice() != null) {
					
					oprot.WriteFieldBegin("createdOffice");
					oprot.WriteString(structs.GetCreatedOffice());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCrmCustRuleAllocationByCreatedOffice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustPickupGoodsTime_argsHelper : TBeanSerializer<refreshCustPickupGoodsTime_args>
		{
			
			public static refreshCustPickupGoodsTime_argsHelper OBJ = new refreshCustPickupGoodsTime_argsHelper();
			
			public static refreshCustPickupGoodsTime_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustPickupGoodsTime_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCrmCustId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustPickupGoodsTime_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCrmCustId() != null) {
					
					oprot.WriteFieldBegin("crmCustId");
					oprot.WriteString(structs.GetCrmCustId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustPickupGoodsTime_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustPointInfo_argsHelper : TBeanSerializer<refreshCustPointInfo_args>
		{
			
			public static refreshCustPointInfo_argsHelper OBJ = new refreshCustPointInfo_argsHelper();
			
			public static refreshCustPointInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustPointInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCrmCustPointId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustPointInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCrmCustPointId() != null) {
					
					oprot.WriteFieldBegin("crmCustPointId");
					oprot.WriteString(structs.GetCrmCustPointId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustPointInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustRelevantCache_argsHelper : TBeanSerializer<refreshCustRelevantCache_args>
		{
			
			public static refreshCustRelevantCache_argsHelper OBJ = new refreshCustRelevantCache_argsHelper();
			
			public static refreshCustRelevantCache_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustRelevantCache_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.cache.RefreshCacheParam value;
					
					value = new com.vip.top.carrier.cache.RefreshCacheParam();
					com.vip.top.carrier.cache.RefreshCacheParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustRelevantCache_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.top.carrier.cache.RefreshCacheParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustRelevantCache_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshInfConfiguration_argsHelper : TBeanSerializer<refreshInfConfiguration_args>
		{
			
			public static refreshInfConfiguration_argsHelper OBJ = new refreshInfConfiguration_argsHelper();
			
			public static refreshInfConfiguration_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshInfConfiguration_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPkKey(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshInfConfiguration_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPkKey() != null) {
					
					oprot.WriteFieldBegin("pkKey");
					oprot.WriteString(structs.GetPkKey());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshInfConfiguration_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshPickingInfo_argsHelper : TBeanSerializer<refreshPickingInfo_args>
		{
			
			public static refreshPickingInfo_argsHelper OBJ = new refreshPickingInfo_argsHelper();
			
			public static refreshPickingInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshPickingInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCrmCustId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshPickingInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCrmCustId() != null) {
					
					oprot.WriteFieldBegin("crmCustId");
					oprot.WriteString(structs.GetCrmCustId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshPickingInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshSbDeliverPointByRegion_argsHelper : TBeanSerializer<refreshSbDeliverPointByRegion_args>
		{
			
			public static refreshSbDeliverPointByRegion_argsHelper OBJ = new refreshSbDeliverPointByRegion_argsHelper();
			
			public static refreshSbDeliverPointByRegion_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshSbDeliverPointByRegion_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCreatedOffice(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRegionCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshSbDeliverPointByRegion_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreatedOffice() != null) {
					
					oprot.WriteFieldBegin("createdOffice");
					oprot.WriteString(structs.GetCreatedOffice());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetRegionCode() != null) {
					
					oprot.WriteFieldBegin("regionCode");
					oprot.WriteString(structs.GetRegionCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshSbDeliverPointByRegion_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshTmsSysParamByParamKey_argsHelper : TBeanSerializer<refreshTmsSysParamByParamKey_args>
		{
			
			public static refreshTmsSysParamByParamKey_argsHelper OBJ = new refreshTmsSysParamByParamKey_argsHelper();
			
			public static refreshTmsSysParamByParamKey_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshTmsSysParamByParamKey_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetParamKey(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshTmsSysParamByParamKey_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParamKey() != null) {
					
					oprot.WriteFieldBegin("paramKey");
					oprot.WriteString(structs.GetParamKey());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshTmsSysParamByParamKey_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchTransportNos_resultHelper : TBeanSerializer<fetchTransportNos_result>
		{
			
			public static fetchTransportNos_resultHelper OBJ = new fetchTransportNos_resultHelper();
			
			public static fetchTransportNos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchTransportNos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.TransportNosResponseModel value;
					
					value = new com.vip.top.carrier.bizservice.TransportNosResponseModel();
					com.vip.top.carrier.bizservice.TransportNosResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchTransportNos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.TransportNosResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchTransportNos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAllExpressCo_resultHelper : TBeanSerializer<getAllExpressCo_result>
		{
			
			public static getAllExpressCo_resultHelper OBJ = new getAllExpressCo_resultHelper();
			
			public static getAllExpressCo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAllExpressCo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.ExpressCo> value;
					
					value = new List<com.vip.top.carrier.bizservice.ExpressCo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.ExpressCo elem0;
							
							elem0 = new com.vip.top.carrier.bizservice.ExpressCo();
							com.vip.top.carrier.bizservice.ExpressCoHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAllExpressCo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.ExpressCo _item0 in structs.GetSuccess()){
						
						
						com.vip.top.carrier.bizservice.ExpressCoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAllExpressCo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrier_resultHelper : TBeanSerializer<getCarrier_result>
		{
			
			public static getCarrier_resultHelper OBJ = new getCarrier_resultHelper();
			
			public static getCarrier_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrier_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value;
					
					value = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrier_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrier_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierByCustNo_resultHelper : TBeanSerializer<getCarrierByCustNo_result>
		{
			
			public static getCarrierByCustNo_resultHelper OBJ = new getCarrierByCustNo_resultHelper();
			
			public static getCarrierByCustNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierByCustNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value;
					
					value = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierByCustNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierByCustNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierByName_resultHelper : TBeanSerializer<getCarrierByName_result>
		{
			
			public static getCarrierByName_resultHelper OBJ = new getCarrierByName_resultHelper();
			
			public static getCarrierByName_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierByName_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModel value;
					
					value = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierByName_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierByName_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarrierListByWareHouse_resultHelper : TBeanSerializer<getCarrierListByWareHouse_result>
		{
			
			public static getCarrierListByWareHouse_resultHelper OBJ = new getCarrierListByWareHouse_resultHelper();
			
			public static getCarrierListByWareHouse_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarrierListByWareHouse_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value;
					
					value = new List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModel elem0;
							
							elem0 = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarrierListByWareHouse_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.RegisteredCarrierModelModel _item0 in structs.GetSuccess()){
						
						
						com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarrierListByWareHouse_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCarriers_resultHelper : TBeanSerializer<getCarriers_result>
		{
			
			public static getCarriers_resultHelper OBJ = new getCarriers_resultHelper();
			
			public static getCarriers_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCarriers_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value;
					
					value = new Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModel _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCarriers_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						com.vip.top.carrier.bizservice.RegisteredCarrierModelModel _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCarriers_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getForwarderCompanyVO_resultHelper : TBeanSerializer<getForwarderCompanyVO_result>
		{
			
			public static getForwarderCompanyVO_resultHelper OBJ = new getForwarderCompanyVO_resultHelper();
			
			public static getForwarderCompanyVO_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getForwarderCompanyVO_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.ForwarderCompanyVO value;
					
					value = new com.vip.top.carrier.bizservice.ForwarderCompanyVO();
					com.vip.top.carrier.bizservice.ForwarderCompanyVOHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getForwarderCompanyVO_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.ForwarderCompanyVOHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getForwarderCompanyVO_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getLefengOrderDeliveryInfo_resultHelper : TBeanSerializer<getLefengOrderDeliveryInfo_result>
		{
			
			public static getLefengOrderDeliveryInfo_resultHelper OBJ = new getLefengOrderDeliveryInfo_resultHelper();
			
			public static getLefengOrderDeliveryInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getLefengOrderDeliveryInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.OrderDeliveryInfo value;
					
					value = new com.vip.top.carrier.bizservice.OrderDeliveryInfo();
					com.vip.top.carrier.bizservice.OrderDeliveryInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getLefengOrderDeliveryInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.OrderDeliveryInfoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getLefengOrderDeliveryInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderDeliveryInfo_resultHelper : TBeanSerializer<getOrderDeliveryInfo_result>
		{
			
			public static getOrderDeliveryInfo_resultHelper OBJ = new getOrderDeliveryInfo_resultHelper();
			
			public static getOrderDeliveryInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderDeliveryInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.OrderDeliveryInfo value;
					
					value = new com.vip.top.carrier.bizservice.OrderDeliveryInfo();
					com.vip.top.carrier.bizservice.OrderDeliveryInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderDeliveryInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.OrderDeliveryInfoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderDeliveryInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickInfo_resultHelper : TBeanSerializer<getPickInfo_result>
		{
			
			public static getPickInfo_resultHelper OBJ = new getPickInfo_resultHelper();
			
			public static getPickInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.PickupQueryResult> value;
					
					value = new List<com.vip.top.carrier.bizservice.PickupQueryResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.PickupQueryResult elem0;
							
							elem0 = new com.vip.top.carrier.bizservice.PickupQueryResult();
							com.vip.top.carrier.bizservice.PickupQueryResultHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.PickupQueryResult _item0 in structs.GetSuccess()){
						
						
						com.vip.top.carrier.bizservice.PickupQueryResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickInfoTotalNum_resultHelper : TBeanSerializer<getPickInfoTotalNum_result>
		{
			
			public static getPickInfoTotalNum_resultHelper OBJ = new getPickInfoTotalNum_resultHelper();
			
			public static getPickInfoTotalNum_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickInfoTotalNum_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickInfoTotalNum_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickInfoTotalNum_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickingInfoByAddress_resultHelper : TBeanSerializer<getPickingInfoByAddress_result>
		{
			
			public static getPickingInfoByAddress_resultHelper OBJ = new getPickingInfoByAddress_resultHelper();
			
			public static getPickingInfoByAddress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickingInfoByAddress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.PickingInfoResult value;
					
					value = new com.vip.top.carrier.bizservice.PickingInfoResult();
					com.vip.top.carrier.bizservice.PickingInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickingInfoByAddress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.PickingInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickingInfoByAddress_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnOrderInfo_resultHelper : TBeanSerializer<getReturnOrderInfo_result>
		{
			
			public static getReturnOrderInfo_resultHelper OBJ = new getReturnOrderInfo_resultHelper();
			
			public static getReturnOrderInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnOrderInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.ReturnOrderInfo value;
					
					value = new com.vip.top.carrier.bizservice.ReturnOrderInfo();
					com.vip.top.carrier.bizservice.ReturnOrderInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getReturnOrderInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.ReturnOrderInfoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getReturnOrderInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSortingInfoByAddress_resultHelper : TBeanSerializer<getSortingInfoByAddress_result>
		{
			
			public static getSortingInfoByAddress_resultHelper OBJ = new getSortingInfoByAddress_resultHelper();
			
			public static getSortingInfoByAddress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSortingInfoByAddress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.SortingInfoResult value;
					
					value = new com.vip.top.carrier.bizservice.SortingInfoResult();
					com.vip.top.carrier.bizservice.SortingInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSortingInfoByAddress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.SortingInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSortingInfoByAddress_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNosByOrderDetail_resultHelper : TBeanSerializer<getTransportNosByOrderDetail_result>
		{
			
			public static getTransportNosByOrderDetail_resultHelper OBJ = new getTransportNosByOrderDetail_resultHelper();
			
			public static getTransportNosByOrderDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNosByOrderDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.TransportNoInfosResponseModel value;
					
					value = new com.vip.top.carrier.bizservice.TransportNoInfosResponseModel();
					com.vip.top.carrier.bizservice.TransportNoInfosResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNosByOrderDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.TransportNoInfosResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNosByOrderDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNosByThirdCustCode_resultHelper : TBeanSerializer<getTransportNosByThirdCustCode_result>
		{
			
			public static getTransportNosByThirdCustCode_resultHelper OBJ = new getTransportNosByThirdCustCode_resultHelper();
			
			public static getTransportNosByThirdCustCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNosByThirdCustCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.TransportNosResponseModel value;
					
					value = new com.vip.top.carrier.bizservice.TransportNosResponseModel();
					com.vip.top.carrier.bizservice.TransportNosResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNosByThirdCustCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.TransportNosResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNosByThirdCustCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVisitHourOption_resultHelper : TBeanSerializer<getVisitHourOption_result>
		{
			
			public static getVisitHourOption_resultHelper OBJ = new getVisitHourOption_resultHelper();
			
			public static getVisitHourOption_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVisitHourOption_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.service.GetPackageTimeVo> value;
					
					value = new List<com.vip.top.carrier.service.GetPackageTimeVo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.service.GetPackageTimeVo elem0;
							
							elem0 = new com.vip.top.carrier.service.GetPackageTimeVo();
							com.vip.top.carrier.service.GetPackageTimeVoHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVisitHourOption_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.service.GetPackageTimeVo _item0 in structs.GetSuccess()){
						
						
						com.vip.top.carrier.service.GetPackageTimeVoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVisitHourOption_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVisitTimeOption_resultHelper : TBeanSerializer<getVisitTimeOption_result>
		{
			
			public static getVisitTimeOption_resultHelper OBJ = new getVisitTimeOption_resultHelper();
			
			public static getVisitTimeOption_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVisitTimeOption_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVisitTimeOption_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVisitTimeOption_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listCarriers_resultHelper : TBeanSerializer<listCarriers_result>
		{
			
			public static listCarriers_resultHelper OBJ = new listCarriers_resultHelper();
			
			public static listCarriers_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listCarriers_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> value;
					
					value = new List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModel elem0;
							
							elem0 = new com.vip.top.carrier.bizservice.RegisteredCarrierModelModel();
							com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listCarriers_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.RegisteredCarrierModelModel _item0 in structs.GetSuccess()){
						
						
						com.vip.top.carrier.bizservice.RegisteredCarrierModelModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listCarriers_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrier_resultHelper : TBeanSerializer<matchCarrier_result>
		{
			
			public static matchCarrier_resultHelper OBJ = new matchCarrier_resultHelper();
			
			public static matchCarrier_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrier_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> value;
					
					value = new Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							com.vip.top.carrier.bizservice.MatchResultInfo _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new com.vip.top.carrier.bizservice.MatchResultInfo();
							com.vip.top.carrier.bizservice.MatchResultInfoHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrier_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, com.vip.top.carrier.bizservice.MatchResultInfo > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						com.vip.top.carrier.bizservice.MatchResultInfo _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						com.vip.top.carrier.bizservice.MatchResultInfoHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrier_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrierById_resultHelper : TBeanSerializer<matchCarrierById_result>
		{
			
			public static matchCarrierById_resultHelper OBJ = new matchCarrierById_resultHelper();
			
			public static matchCarrierById_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrierById_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> value;
					
					value = new Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							com.vip.top.carrier.bizservice.MatchResultInfo _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new com.vip.top.carrier.bizservice.MatchResultInfo();
							com.vip.top.carrier.bizservice.MatchResultInfoHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrierById_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, com.vip.top.carrier.bizservice.MatchResultInfo > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						com.vip.top.carrier.bizservice.MatchResultInfo _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						com.vip.top.carrier.bizservice.MatchResultInfoHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrierById_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class matchCarrierByIdWithPriority_resultHelper : TBeanSerializer<matchCarrierByIdWithPriority_result>
		{
			
			public static matchCarrierByIdWithPriority_resultHelper OBJ = new matchCarrierByIdWithPriority_resultHelper();
			
			public static matchCarrierByIdWithPriority_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrierByIdWithPriority_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> value;
					
					value = new Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							List<com.vip.top.carrier.bizservice.MatchProcessResultInfo> _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									com.vip.top.carrier.bizservice.MatchProcessResultInfo elem2;
									
									elem2 = new com.vip.top.carrier.bizservice.MatchProcessResultInfo();
									com.vip.top.carrier.bizservice.MatchProcessResultInfoHelper.getInstance().Read(elem2, iprot);
									
									_val1.Add(elem2);
								}
								catch(Exception e){
									
									
									break;
								}
							}
							
							iprot.ReadListEnd();
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrierByIdWithPriority_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo> > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						List<com.vip.top.carrier.bizservice.MatchProcessResultInfo> _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						oprot.WriteListBegin();
						foreach(com.vip.top.carrier.bizservice.MatchProcessResultInfo _item1 in _value0){
							
							
							com.vip.top.carrier.bizservice.MatchProcessResultInfoHelper.getInstance().Write(_item1, oprot);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrierByIdWithPriority_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCustStandardNameByUncode_resultHelper : TBeanSerializer<queryCustStandardNameByUncode_result>
		{
			
			public static queryCustStandardNameByUncode_resultHelper OBJ = new queryCustStandardNameByUncode_resultHelper();
			
			public static queryCustStandardNameByUncode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCustStandardNameByUncode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCustStandardNameByUncode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCustStandardNameByUncode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransportNosByOrderSn_resultHelper : TBeanSerializer<queryTransportNosByOrderSn_result>
		{
			
			public static queryTransportNosByOrderSn_resultHelper OBJ = new queryTransportNosByOrderSn_resultHelper();
			
			public static queryTransportNosByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransportNosByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel value;
					
					value = new com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel();
					com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransportNosByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransportNosByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCrmCustRuleAllocationByCreatedOffice_resultHelper : TBeanSerializer<refreshCrmCustRuleAllocationByCreatedOffice_result>
		{
			
			public static refreshCrmCustRuleAllocationByCreatedOffice_resultHelper OBJ = new refreshCrmCustRuleAllocationByCreatedOffice_resultHelper();
			
			public static refreshCrmCustRuleAllocationByCreatedOffice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCrmCustRuleAllocationByCreatedOffice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCrmCustRuleAllocationByCreatedOffice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCrmCustRuleAllocationByCreatedOffice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustPickupGoodsTime_resultHelper : TBeanSerializer<refreshCustPickupGoodsTime_result>
		{
			
			public static refreshCustPickupGoodsTime_resultHelper OBJ = new refreshCustPickupGoodsTime_resultHelper();
			
			public static refreshCustPickupGoodsTime_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustPickupGoodsTime_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustPickupGoodsTime_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustPickupGoodsTime_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustPointInfo_resultHelper : TBeanSerializer<refreshCustPointInfo_result>
		{
			
			public static refreshCustPointInfo_resultHelper OBJ = new refreshCustPointInfo_resultHelper();
			
			public static refreshCustPointInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustPointInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustPointInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustPointInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshCustRelevantCache_resultHelper : TBeanSerializer<refreshCustRelevantCache_result>
		{
			
			public static refreshCustRelevantCache_resultHelper OBJ = new refreshCustRelevantCache_resultHelper();
			
			public static refreshCustRelevantCache_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshCustRelevantCache_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshCustRelevantCache_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshCustRelevantCache_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshInfConfiguration_resultHelper : TBeanSerializer<refreshInfConfiguration_result>
		{
			
			public static refreshInfConfiguration_resultHelper OBJ = new refreshInfConfiguration_resultHelper();
			
			public static refreshInfConfiguration_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshInfConfiguration_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshInfConfiguration_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshInfConfiguration_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshPickingInfo_resultHelper : TBeanSerializer<refreshPickingInfo_result>
		{
			
			public static refreshPickingInfo_resultHelper OBJ = new refreshPickingInfo_resultHelper();
			
			public static refreshPickingInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshPickingInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshPickingInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshPickingInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshSbDeliverPointByRegion_resultHelper : TBeanSerializer<refreshSbDeliverPointByRegion_result>
		{
			
			public static refreshSbDeliverPointByRegion_resultHelper OBJ = new refreshSbDeliverPointByRegion_resultHelper();
			
			public static refreshSbDeliverPointByRegion_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshSbDeliverPointByRegion_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshSbDeliverPointByRegion_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshSbDeliverPointByRegion_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshTmsSysParamByParamKey_resultHelper : TBeanSerializer<refreshTmsSysParamByParamKey_result>
		{
			
			public static refreshTmsSysParamByParamKey_resultHelper OBJ = new refreshTmsSysParamByParamKey_resultHelper();
			
			public static refreshTmsSysParamByParamKey_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshTmsSysParamByParamKey_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshTmsSysParamByParamKey_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshTmsSysParamByParamKey_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class CarrierServiceClient : OspRestStub , CarrierService  {
			
			
			public CarrierServiceClient():base("com.vip.top.carrier.bizservice.CarrierService","1.4.0") {
				
				
			}
			
			
			
			public com.vip.top.carrier.bizservice.TransportNosResponseModel fetchTransportNos(com.vip.top.carrier.bizservice.FetchTransportNosRequestModel requestModel_) {
				
				send_fetchTransportNos(requestModel_);
				return recv_fetchTransportNos(); 
				
			}
			
			
			private void send_fetchTransportNos(com.vip.top.carrier.bizservice.FetchTransportNosRequestModel requestModel_){
				
				InitInvocation("fetchTransportNos");
				
				fetchTransportNos_args args = new fetchTransportNos_args();
				args.SetRequestModel(requestModel_);
				
				SendBase(args, fetchTransportNos_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.TransportNosResponseModel recv_fetchTransportNos(){
				
				fetchTransportNos_result result = new fetchTransportNos_result();
				ReceiveBase(result, fetchTransportNos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.carrier.bizservice.ExpressCo> getAllExpressCo() {
				
				send_getAllExpressCo();
				return recv_getAllExpressCo(); 
				
			}
			
			
			private void send_getAllExpressCo(){
				
				InitInvocation("getAllExpressCo");
				
				getAllExpressCo_args args = new getAllExpressCo_args();
				
				SendBase(args, getAllExpressCo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.carrier.bizservice.ExpressCo> recv_getAllExpressCo(){
				
				getAllExpressCo_result result = new getAllExpressCo_result();
				ReceiveBase(result, getAllExpressCo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrier(string custNo_) {
				
				send_getCarrier(custNo_);
				return recv_getCarrier(); 
				
			}
			
			
			private void send_getCarrier(string custNo_){
				
				InitInvocation("getCarrier");
				
				getCarrier_args args = new getCarrier_args();
				args.SetCustNo(custNo_);
				
				SendBase(args, getCarrier_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel recv_getCarrier(){
				
				getCarrier_result result = new getCarrier_result();
				ReceiveBase(result, getCarrier_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrierByCustNo(long? custNo_) {
				
				send_getCarrierByCustNo(custNo_);
				return recv_getCarrierByCustNo(); 
				
			}
			
			
			private void send_getCarrierByCustNo(long? custNo_){
				
				InitInvocation("getCarrierByCustNo");
				
				getCarrierByCustNo_args args = new getCarrierByCustNo_args();
				args.SetCustNo(custNo_);
				
				SendBase(args, getCarrierByCustNo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel recv_getCarrierByCustNo(){
				
				getCarrierByCustNo_result result = new getCarrierByCustNo_result();
				ReceiveBase(result, getCarrierByCustNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.RegisteredCarrierModelModel getCarrierByName(string custName_) {
				
				send_getCarrierByName(custName_);
				return recv_getCarrierByName(); 
				
			}
			
			
			private void send_getCarrierByName(string custName_){
				
				InitInvocation("getCarrierByName");
				
				getCarrierByName_args args = new getCarrierByName_args();
				args.SetCustName(custName_);
				
				SendBase(args, getCarrierByName_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.RegisteredCarrierModelModel recv_getCarrierByName(){
				
				getCarrierByName_result result = new getCarrierByName_result();
				ReceiveBase(result, getCarrierByName_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> getCarrierListByWareHouse(string warehouse_) {
				
				send_getCarrierListByWareHouse(warehouse_);
				return recv_getCarrierListByWareHouse(); 
				
			}
			
			
			private void send_getCarrierListByWareHouse(string warehouse_){
				
				InitInvocation("getCarrierListByWareHouse");
				
				getCarrierListByWareHouse_args args = new getCarrierListByWareHouse_args();
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getCarrierListByWareHouse_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> recv_getCarrierListByWareHouse(){
				
				getCarrierListByWareHouse_result result = new getCarrierListByWareHouse_result();
				ReceiveBase(result, getCarrierListByWareHouse_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> getCarriers(List<string> custNos_) {
				
				send_getCarriers(custNos_);
				return recv_getCarriers(); 
				
			}
			
			
			private void send_getCarriers(List<string> custNos_){
				
				InitInvocation("getCarriers");
				
				getCarriers_args args = new getCarriers_args();
				args.SetCustNos(custNos_);
				
				SendBase(args, getCarriers_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> recv_getCarriers(){
				
				getCarriers_result result = new getCarriers_result();
				ReceiveBase(result, getCarriers_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.ForwarderCompanyVO getForwarderCompanyVO(string orderSn_,string warehouse_) {
				
				send_getForwarderCompanyVO(orderSn_,warehouse_);
				return recv_getForwarderCompanyVO(); 
				
			}
			
			
			private void send_getForwarderCompanyVO(string orderSn_,string warehouse_){
				
				InitInvocation("getForwarderCompanyVO");
				
				getForwarderCompanyVO_args args = new getForwarderCompanyVO_args();
				args.SetOrderSn(orderSn_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getForwarderCompanyVO_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.ForwarderCompanyVO recv_getForwarderCompanyVO(){
				
				getForwarderCompanyVO_result result = new getForwarderCompanyVO_result();
				ReceiveBase(result, getForwarderCompanyVO_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.OrderDeliveryInfo getLefengOrderDeliveryInfo(string orderSn_,string warehouse_) {
				
				send_getLefengOrderDeliveryInfo(orderSn_,warehouse_);
				return recv_getLefengOrderDeliveryInfo(); 
				
			}
			
			
			private void send_getLefengOrderDeliveryInfo(string orderSn_,string warehouse_){
				
				InitInvocation("getLefengOrderDeliveryInfo");
				
				getLefengOrderDeliveryInfo_args args = new getLefengOrderDeliveryInfo_args();
				args.SetOrderSn(orderSn_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getLefengOrderDeliveryInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.OrderDeliveryInfo recv_getLefengOrderDeliveryInfo(){
				
				getLefengOrderDeliveryInfo_result result = new getLefengOrderDeliveryInfo_result();
				ReceiveBase(result, getLefengOrderDeliveryInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.OrderDeliveryInfo getOrderDeliveryInfo(string orderSn_,string warehouse_) {
				
				send_getOrderDeliveryInfo(orderSn_,warehouse_);
				return recv_getOrderDeliveryInfo(); 
				
			}
			
			
			private void send_getOrderDeliveryInfo(string orderSn_,string warehouse_){
				
				InitInvocation("getOrderDeliveryInfo");
				
				getOrderDeliveryInfo_args args = new getOrderDeliveryInfo_args();
				args.SetOrderSn(orderSn_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getOrderDeliveryInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.OrderDeliveryInfo recv_getOrderDeliveryInfo(){
				
				getOrderDeliveryInfo_result result = new getOrderDeliveryInfo_result();
				ReceiveBase(result, getOrderDeliveryInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.carrier.bizservice.PickupQueryResult> getPickInfo(com.vip.top.carrier.bizservice.PickupQueryInfo info_,string warehouse_,int? limit_,int? offset_) {
				
				send_getPickInfo(info_,warehouse_,limit_,offset_);
				return recv_getPickInfo(); 
				
			}
			
			
			private void send_getPickInfo(com.vip.top.carrier.bizservice.PickupQueryInfo info_,string warehouse_,int? limit_,int? offset_){
				
				InitInvocation("getPickInfo");
				
				getPickInfo_args args = new getPickInfo_args();
				args.SetInfo(info_);
				args.SetWarehouse(warehouse_);
				args.SetLimit(limit_);
				args.SetOffset(offset_);
				
				SendBase(args, getPickInfo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.carrier.bizservice.PickupQueryResult> recv_getPickInfo(){
				
				getPickInfo_result result = new getPickInfo_result();
				ReceiveBase(result, getPickInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? getPickInfoTotalNum(com.vip.top.carrier.bizservice.PickupQueryInfo info_,string warehouse_) {
				
				send_getPickInfoTotalNum(info_,warehouse_);
				return recv_getPickInfoTotalNum(); 
				
			}
			
			
			private void send_getPickInfoTotalNum(com.vip.top.carrier.bizservice.PickupQueryInfo info_,string warehouse_){
				
				InitInvocation("getPickInfoTotalNum");
				
				getPickInfoTotalNum_args args = new getPickInfoTotalNum_args();
				args.SetInfo(info_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getPickInfoTotalNum_argsHelper.getInstance());
			}
			
			
			private int? recv_getPickInfoTotalNum(){
				
				getPickInfoTotalNum_result result = new getPickInfoTotalNum_result();
				ReceiveBase(result, getPickInfoTotalNum_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.PickingInfoResult getPickingInfoByAddress(com.vip.top.carrier.bizservice.PickingInfoRequest pickingInfoRequest_) {
				
				send_getPickingInfoByAddress(pickingInfoRequest_);
				return recv_getPickingInfoByAddress(); 
				
			}
			
			
			private void send_getPickingInfoByAddress(com.vip.top.carrier.bizservice.PickingInfoRequest pickingInfoRequest_){
				
				InitInvocation("getPickingInfoByAddress");
				
				getPickingInfoByAddress_args args = new getPickingInfoByAddress_args();
				args.SetPickingInfoRequest(pickingInfoRequest_);
				
				SendBase(args, getPickingInfoByAddress_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.PickingInfoResult recv_getPickingInfoByAddress(){
				
				getPickingInfoByAddress_result result = new getPickingInfoByAddress_result();
				ReceiveBase(result, getPickingInfoByAddress_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.ReturnOrderInfo getReturnOrderInfo(string orderSn_,string warehouse_) {
				
				send_getReturnOrderInfo(orderSn_,warehouse_);
				return recv_getReturnOrderInfo(); 
				
			}
			
			
			private void send_getReturnOrderInfo(string orderSn_,string warehouse_){
				
				InitInvocation("getReturnOrderInfo");
				
				getReturnOrderInfo_args args = new getReturnOrderInfo_args();
				args.SetOrderSn(orderSn_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getReturnOrderInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.ReturnOrderInfo recv_getReturnOrderInfo(){
				
				getReturnOrderInfo_result result = new getReturnOrderInfo_result();
				ReceiveBase(result, getReturnOrderInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.SortingInfoResult getSortingInfoByAddress(com.vip.top.carrier.bizservice.SortingInfoRequestHead sortingInfoRequestHead_,List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> sortingInfoRequestItems_) {
				
				send_getSortingInfoByAddress(sortingInfoRequestHead_,sortingInfoRequestItems_);
				return recv_getSortingInfoByAddress(); 
				
			}
			
			
			private void send_getSortingInfoByAddress(com.vip.top.carrier.bizservice.SortingInfoRequestHead sortingInfoRequestHead_,List<com.vip.top.carrier.bizservice.SortingInfoRequestItem> sortingInfoRequestItems_){
				
				InitInvocation("getSortingInfoByAddress");
				
				getSortingInfoByAddress_args args = new getSortingInfoByAddress_args();
				args.SetSortingInfoRequestHead(sortingInfoRequestHead_);
				args.SetSortingInfoRequestItems(sortingInfoRequestItems_);
				
				SendBase(args, getSortingInfoByAddress_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.SortingInfoResult recv_getSortingInfoByAddress(){
				
				getSortingInfoByAddress_result result = new getSortingInfoByAddress_result();
				ReceiveBase(result, getSortingInfoByAddress_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.TransportNoInfosResponseModel getTransportNosByOrderDetail(string sysKey_,string vendorCode_,string thirdCustCode_,int size_,com.vip.top.carrier.bizservice.TmsOrderDetailModel tmsOrderDetailModel_) {
				
				send_getTransportNosByOrderDetail(sysKey_,vendorCode_,thirdCustCode_,size_,tmsOrderDetailModel_);
				return recv_getTransportNosByOrderDetail(); 
				
			}
			
			
			private void send_getTransportNosByOrderDetail(string sysKey_,string vendorCode_,string thirdCustCode_,int size_,com.vip.top.carrier.bizservice.TmsOrderDetailModel tmsOrderDetailModel_){
				
				InitInvocation("getTransportNosByOrderDetail");
				
				getTransportNosByOrderDetail_args args = new getTransportNosByOrderDetail_args();
				args.SetSysKey(sysKey_);
				args.SetVendorCode(vendorCode_);
				args.SetThirdCustCode(thirdCustCode_);
				args.SetSize(size_);
				args.SetTmsOrderDetailModel(tmsOrderDetailModel_);
				
				SendBase(args, getTransportNosByOrderDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.TransportNoInfosResponseModel recv_getTransportNosByOrderDetail(){
				
				getTransportNosByOrderDetail_result result = new getTransportNosByOrderDetail_result();
				ReceiveBase(result, getTransportNosByOrderDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.TransportNosResponseModel getTransportNosByThirdCustCode(string sysKey_,string vendorCode_,string thirdCustCode_,int size_,string orderSn_) {
				
				send_getTransportNosByThirdCustCode(sysKey_,vendorCode_,thirdCustCode_,size_,orderSn_);
				return recv_getTransportNosByThirdCustCode(); 
				
			}
			
			
			private void send_getTransportNosByThirdCustCode(string sysKey_,string vendorCode_,string thirdCustCode_,int size_,string orderSn_){
				
				InitInvocation("getTransportNosByThirdCustCode");
				
				getTransportNosByThirdCustCode_args args = new getTransportNosByThirdCustCode_args();
				args.SetSysKey(sysKey_);
				args.SetVendorCode(vendorCode_);
				args.SetThirdCustCode(thirdCustCode_);
				args.SetSize(size_);
				args.SetOrderSn(orderSn_);
				
				SendBase(args, getTransportNosByThirdCustCode_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.TransportNosResponseModel recv_getTransportNosByThirdCustCode(){
				
				getTransportNosByThirdCustCode_result result = new getTransportNosByThirdCustCode_result();
				ReceiveBase(result, getTransportNosByThirdCustCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.carrier.service.GetPackageTimeVo> getVisitHourOption(string returnApplyTime_,string lastAddressCode_) {
				
				send_getVisitHourOption(returnApplyTime_,lastAddressCode_);
				return recv_getVisitHourOption(); 
				
			}
			
			
			private void send_getVisitHourOption(string returnApplyTime_,string lastAddressCode_){
				
				InitInvocation("getVisitHourOption");
				
				getVisitHourOption_args args = new getVisitHourOption_args();
				args.SetReturnApplyTime(returnApplyTime_);
				args.SetLastAddressCode(lastAddressCode_);
				
				SendBase(args, getVisitHourOption_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.carrier.service.GetPackageTimeVo> recv_getVisitHourOption(){
				
				getVisitHourOption_result result = new getVisitHourOption_result();
				ReceiveBase(result, getVisitHourOption_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getVisitTimeOption(string returnApplyTime_,string lastAddressCode_) {
				
				send_getVisitTimeOption(returnApplyTime_,lastAddressCode_);
				return recv_getVisitTimeOption(); 
				
			}
			
			
			private void send_getVisitTimeOption(string returnApplyTime_,string lastAddressCode_){
				
				InitInvocation("getVisitTimeOption");
				
				getVisitTimeOption_args args = new getVisitTimeOption_args();
				args.SetReturnApplyTime(returnApplyTime_);
				args.SetLastAddressCode(lastAddressCode_);
				
				SendBase(args, getVisitTimeOption_argsHelper.getInstance());
			}
			
			
			private string recv_getVisitTimeOption(){
				
				getVisitTimeOption_result result = new getVisitTimeOption_result();
				ReceiveBase(result, getVisitTimeOption_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> listCarriers(int? type_,bool? showAll_) {
				
				send_listCarriers(type_,showAll_);
				return recv_listCarriers(); 
				
			}
			
			
			private void send_listCarriers(int? type_,bool? showAll_){
				
				InitInvocation("listCarriers");
				
				listCarriers_args args = new listCarriers_args();
				args.SetType(type_);
				args.SetShowAll(showAll_);
				
				SendBase(args, listCarriers_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.carrier.bizservice.RegisteredCarrierModelModel> recv_listCarriers(){
				
				listCarriers_result result = new listCarriers_result();
				ReceiveBase(result, listCarriers_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> matchCarrier(List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> tmsOrderInfoModels_,string warehouse_) {
				
				send_matchCarrier(tmsOrderInfoModels_,warehouse_);
				return recv_matchCarrier(); 
				
			}
			
			
			private void send_matchCarrier(List<com.vip.top.carrier.bizservice.TmsOrderInfoModel> tmsOrderInfoModels_,string warehouse_){
				
				InitInvocation("matchCarrier");
				
				matchCarrier_args args = new matchCarrier_args();
				args.SetTmsOrderInfoModels(tmsOrderInfoModels_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, matchCarrier_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> recv_matchCarrier(){
				
				matchCarrier_result result = new matchCarrier_result();
				ReceiveBase(result, matchCarrier_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> matchCarrierById(List<string> tmsOrderIds_,string warehouse_) {
				
				send_matchCarrierById(tmsOrderIds_,warehouse_);
				return recv_matchCarrierById(); 
				
			}
			
			
			private void send_matchCarrierById(List<string> tmsOrderIds_,string warehouse_){
				
				InitInvocation("matchCarrierById");
				
				matchCarrierById_args args = new matchCarrierById_args();
				args.SetTmsOrderIds(tmsOrderIds_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, matchCarrierById_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, com.vip.top.carrier.bizservice.MatchResultInfo> recv_matchCarrierById(){
				
				matchCarrierById_result result = new matchCarrierById_result();
				ReceiveBase(result, matchCarrierById_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> matchCarrierByIdWithPriority(List<string> tmsOrderIds_,string warehouse_) {
				
				send_matchCarrierByIdWithPriority(tmsOrderIds_,warehouse_);
				return recv_matchCarrierByIdWithPriority(); 
				
			}
			
			
			private void send_matchCarrierByIdWithPriority(List<string> tmsOrderIds_,string warehouse_){
				
				InitInvocation("matchCarrierByIdWithPriority");
				
				matchCarrierByIdWithPriority_args args = new matchCarrierByIdWithPriority_args();
				args.SetTmsOrderIds(tmsOrderIds_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, matchCarrierByIdWithPriority_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, List<com.vip.top.carrier.bizservice.MatchProcessResultInfo>> recv_matchCarrierByIdWithPriority(){
				
				matchCarrierByIdWithPriority_result result = new matchCarrierByIdWithPriority_result();
				ReceiveBase(result, matchCarrierByIdWithPriority_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string queryCustStandardNameByUncode(string custUncode_) {
				
				send_queryCustStandardNameByUncode(custUncode_);
				return recv_queryCustStandardNameByUncode(); 
				
			}
			
			
			private void send_queryCustStandardNameByUncode(string custUncode_){
				
				InitInvocation("queryCustStandardNameByUncode");
				
				queryCustStandardNameByUncode_args args = new queryCustStandardNameByUncode_args();
				args.SetCustUncode(custUncode_);
				
				SendBase(args, queryCustStandardNameByUncode_argsHelper.getInstance());
			}
			
			
			private string recv_queryCustStandardNameByUncode(){
				
				queryCustStandardNameByUncode_result result = new queryCustStandardNameByUncode_result();
				ReceiveBase(result, queryCustStandardNameByUncode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel queryTransportNosByOrderSn(List<string> orderSns_) {
				
				send_queryTransportNosByOrderSn(orderSns_);
				return recv_queryTransportNosByOrderSn(); 
				
			}
			
			
			private void send_queryTransportNosByOrderSn(List<string> orderSns_){
				
				InitInvocation("queryTransportNosByOrderSn");
				
				queryTransportNosByOrderSn_args args = new queryTransportNosByOrderSn_args();
				args.SetOrderSns(orderSns_);
				
				SendBase(args, queryTransportNosByOrderSn_argsHelper.getInstance());
			}
			
			
			private com.vip.top.carrier.bizservice.TransportNoInfosMapResponseModel recv_queryTransportNosByOrderSn(){
				
				queryTransportNosByOrderSn_result result = new queryTransportNosByOrderSn_result();
				ReceiveBase(result, queryTransportNosByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void refreshCrmCustRuleAllocationByCreatedOffice(string createdOffice_,string warehouse_) {
				
				send_refreshCrmCustRuleAllocationByCreatedOffice(createdOffice_,warehouse_);
				recv_refreshCrmCustRuleAllocationByCreatedOffice();
				
			}
			
			
			private void send_refreshCrmCustRuleAllocationByCreatedOffice(string createdOffice_,string warehouse_){
				
				InitInvocation("refreshCrmCustRuleAllocationByCreatedOffice");
				
				refreshCrmCustRuleAllocationByCreatedOffice_args args = new refreshCrmCustRuleAllocationByCreatedOffice_args();
				args.SetCreatedOffice(createdOffice_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshCrmCustRuleAllocationByCreatedOffice_argsHelper.getInstance());
			}
			
			
			private void recv_refreshCrmCustRuleAllocationByCreatedOffice(){
				
				refreshCrmCustRuleAllocationByCreatedOffice_result result = new refreshCrmCustRuleAllocationByCreatedOffice_result();
				ReceiveBase(result, refreshCrmCustRuleAllocationByCreatedOffice_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshCustPickupGoodsTime(string crmCustId_,string warehouse_) {
				
				send_refreshCustPickupGoodsTime(crmCustId_,warehouse_);
				recv_refreshCustPickupGoodsTime();
				
			}
			
			
			private void send_refreshCustPickupGoodsTime(string crmCustId_,string warehouse_){
				
				InitInvocation("refreshCustPickupGoodsTime");
				
				refreshCustPickupGoodsTime_args args = new refreshCustPickupGoodsTime_args();
				args.SetCrmCustId(crmCustId_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshCustPickupGoodsTime_argsHelper.getInstance());
			}
			
			
			private void recv_refreshCustPickupGoodsTime(){
				
				refreshCustPickupGoodsTime_result result = new refreshCustPickupGoodsTime_result();
				ReceiveBase(result, refreshCustPickupGoodsTime_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshCustPointInfo(string crmCustPointId_,string warehouse_) {
				
				send_refreshCustPointInfo(crmCustPointId_,warehouse_);
				recv_refreshCustPointInfo();
				
			}
			
			
			private void send_refreshCustPointInfo(string crmCustPointId_,string warehouse_){
				
				InitInvocation("refreshCustPointInfo");
				
				refreshCustPointInfo_args args = new refreshCustPointInfo_args();
				args.SetCrmCustPointId(crmCustPointId_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshCustPointInfo_argsHelper.getInstance());
			}
			
			
			private void recv_refreshCustPointInfo(){
				
				refreshCustPointInfo_result result = new refreshCustPointInfo_result();
				ReceiveBase(result, refreshCustPointInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshCustRelevantCache(com.vip.top.carrier.cache.RefreshCacheParam param_,string warehouse_) {
				
				send_refreshCustRelevantCache(param_,warehouse_);
				recv_refreshCustRelevantCache();
				
			}
			
			
			private void send_refreshCustRelevantCache(com.vip.top.carrier.cache.RefreshCacheParam param_,string warehouse_){
				
				InitInvocation("refreshCustRelevantCache");
				
				refreshCustRelevantCache_args args = new refreshCustRelevantCache_args();
				args.SetParam(param_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshCustRelevantCache_argsHelper.getInstance());
			}
			
			
			private void recv_refreshCustRelevantCache(){
				
				refreshCustRelevantCache_result result = new refreshCustRelevantCache_result();
				ReceiveBase(result, refreshCustRelevantCache_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshInfConfiguration(string pkKey_,string warehouse_) {
				
				send_refreshInfConfiguration(pkKey_,warehouse_);
				recv_refreshInfConfiguration();
				
			}
			
			
			private void send_refreshInfConfiguration(string pkKey_,string warehouse_){
				
				InitInvocation("refreshInfConfiguration");
				
				refreshInfConfiguration_args args = new refreshInfConfiguration_args();
				args.SetPkKey(pkKey_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshInfConfiguration_argsHelper.getInstance());
			}
			
			
			private void recv_refreshInfConfiguration(){
				
				refreshInfConfiguration_result result = new refreshInfConfiguration_result();
				ReceiveBase(result, refreshInfConfiguration_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshPickingInfo(string crmCustId_,string warehouse_) {
				
				send_refreshPickingInfo(crmCustId_,warehouse_);
				recv_refreshPickingInfo();
				
			}
			
			
			private void send_refreshPickingInfo(string crmCustId_,string warehouse_){
				
				InitInvocation("refreshPickingInfo");
				
				refreshPickingInfo_args args = new refreshPickingInfo_args();
				args.SetCrmCustId(crmCustId_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshPickingInfo_argsHelper.getInstance());
			}
			
			
			private void recv_refreshPickingInfo(){
				
				refreshPickingInfo_result result = new refreshPickingInfo_result();
				ReceiveBase(result, refreshPickingInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshSbDeliverPointByRegion(string createdOffice_,string regionCode_,string warehouse_) {
				
				send_refreshSbDeliverPointByRegion(createdOffice_,regionCode_,warehouse_);
				recv_refreshSbDeliverPointByRegion();
				
			}
			
			
			private void send_refreshSbDeliverPointByRegion(string createdOffice_,string regionCode_,string warehouse_){
				
				InitInvocation("refreshSbDeliverPointByRegion");
				
				refreshSbDeliverPointByRegion_args args = new refreshSbDeliverPointByRegion_args();
				args.SetCreatedOffice(createdOffice_);
				args.SetRegionCode(regionCode_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshSbDeliverPointByRegion_argsHelper.getInstance());
			}
			
			
			private void recv_refreshSbDeliverPointByRegion(){
				
				refreshSbDeliverPointByRegion_result result = new refreshSbDeliverPointByRegion_result();
				ReceiveBase(result, refreshSbDeliverPointByRegion_resultHelper.getInstance());
				
				
			}
			
			
			public void refreshTmsSysParamByParamKey(string paramKey_,string warehouse_) {
				
				send_refreshTmsSysParamByParamKey(paramKey_,warehouse_);
				recv_refreshTmsSysParamByParamKey();
				
			}
			
			
			private void send_refreshTmsSysParamByParamKey(string paramKey_,string warehouse_){
				
				InitInvocation("refreshTmsSysParamByParamKey");
				
				refreshTmsSysParamByParamKey_args args = new refreshTmsSysParamByParamKey_args();
				args.SetParamKey(paramKey_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, refreshTmsSysParamByParamKey_argsHelper.getInstance());
			}
			
			
			private void recv_refreshTmsSysParamByParamKey(){
				
				refreshTmsSysParamByParamKey_result result = new refreshTmsSysParamByParamKey_result();
				ReceiveBase(result, refreshTmsSysParamByParamKey_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}