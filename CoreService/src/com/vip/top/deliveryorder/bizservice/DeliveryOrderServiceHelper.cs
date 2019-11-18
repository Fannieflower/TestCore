using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	public class DeliveryOrderServiceHelper {
		
		
		
		public class findDeliveryTracks_args {
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transportNo_;
			
			public string GetTransportNo(){
				return this.transportNo_;
			}
			
			public void SetTransportNo(string value){
				this.transportNo_ = value;
			}
			
		}
		
		
		
		
		public class findDeliveryTracksToStorage_args {
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transportNo_;
			
			///<summary>
			/// 仓
			///</summary>
			
			private string storage_;
			
			public string GetTransportNo(){
				return this.transportNo_;
			}
			
			public void SetTransportNo(string value){
				this.transportNo_ = value;
			}
			public string GetStorage(){
				return this.storage_;
			}
			
			public void SetStorage(string value){
				this.storage_ = value;
			}
			
		}
		
		
		
		
		public class findListDeliveryTracks_args {
			
			///<summary>
			/// 运单号集合
			///</summary>
			
			private List<string> transportNoList_;
			
			public List<string> GetTransportNoList(){
				return this.transportNoList_;
			}
			
			public void SetTransportNoList(List<string> value){
				this.transportNoList_ = value;
			}
			
		}
		
		
		
		
		public class findOrderSnByTransportNo_args {
			
			///<summary>
			/// 订单类型(OXO_DS直送)
			///</summary>
			
			private string orderType_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private List<string> transportNoList_;
			
			///<summary>
			/// 仓
			///</summary>
			
			private string storage_;
			
			public string GetOrderType(){
				return this.orderType_;
			}
			
			public void SetOrderType(string value){
				this.orderType_ = value;
			}
			public List<string> GetTransportNoList(){
				return this.transportNoList_;
			}
			
			public void SetTransportNoList(List<string> value){
				this.transportNoList_ = value;
			}
			public string GetStorage(){
				return this.storage_;
			}
			
			public void SetStorage(string value){
				this.storage_ = value;
			}
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhone_args {
			
			///<summary>
			/// 收件人电话/手机号
			///</summary>
			
			private string receiverPhone_;
			
			///<summary>
			/// 当前页第一条数据的位置,从1开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			public string GetReceiverPhone(){
				return this.receiverPhone_;
			}
			
			public void SetReceiverPhone(string value){
				this.receiverPhone_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhoneToStorage_args {
			
			///<summary>
			/// 收件人电话/手机号
			///</summary>
			
			private string receiverPhone_;
			
			///<summary>
			/// 当前页第一条数据的位置,从1开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			///<summary>
			/// 仓
			///</summary>
			
			private string storage_;
			
			public string GetReceiverPhone(){
				return this.receiverPhone_;
			}
			
			public void SetReceiverPhone(string value){
				this.receiverPhone_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			public string GetStorage(){
				return this.storage_;
			}
			
			public void SetStorage(string value){
				this.storage_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByOrderSnAndWareHouse_args {
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 仓库编码
			///</summary>
			
			private string wareHouse_;
			
			///<summary>
			/// 第几页
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页几条
			///</summary>
			
			private int? pageSize_;
			
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetWareHouse(){
				return this.wareHouse_;
			}
			
			public void SetWareHouse(string value){
				this.wareHouse_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNo_args {
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transportNo_;
			
			///<summary>
			/// 当前页第一条数据的位置,从1开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			public string GetTransportNo(){
				return this.transportNo_;
			}
			
			public void SetTransportNo(string value){
				this.transportNo_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoAndWareHouse_args {
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transportNo_;
			
			///<summary>
			/// 仓库名称
			///</summary>
			
			private string wareHouse_;
			
			///<summary>
			/// 当前页第一条数据的位置,从1开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			public string GetTransportNo(){
				return this.transportNo_;
			}
			
			public void SetTransportNo(string value){
				this.transportNo_ = value;
			}
			public string GetWareHouse(){
				return this.wareHouse_;
			}
			
			public void SetWareHouse(string value){
				this.wareHouse_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoToStorage_args {
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transportNo_;
			
			///<summary>
			/// 当前页第一条数据的位置,从1开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			///<summary>
			/// 仓
			///</summary>
			
			private string storage_;
			
			public string GetTransportNo(){
				return this.transportNo_;
			}
			
			public void SetTransportNo(string value){
				this.transportNo_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			public string GetStorage(){
				return this.storage_;
			}
			
			public void SetStorage(string value){
				this.storage_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNoByOrderSn_args {
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 所属仓库
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
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class matchCarrier_args {
			
			///<summary>
			/// 物流单id集合
			///</summary>
			
			private List<string> tmsOrderIds_;
			
			///<summary>
			/// 所属仓库
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
		
		
		
		
		public class modifyTmsOrderInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest tmsOrderModifyRequest_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest GetTmsOrderModifyRequest(){
				return this.tmsOrderModifyRequest_;
			}
			
			public void SetTmsOrderModifyRequest(com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest value){
				this.tmsOrderModifyRequest_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class processOdsMessage_args {
			
			///<summary>
			/// 订单信息(JSON格式字符串)
			///</summary>
			
			private string orderMsg_;
			
			public string GetOrderMsg(){
				return this.orderMsg_;
			}
			
			public void SetOrderMsg(string value){
				this.orderMsg_ = value;
			}
			
		}
		
		
		
		
		public class processOdsOrderStatus_args {
			
			///<summary>
			///</summary>
			
			private string orderMsg_;
			
			public string GetOrderMsg(){
				return this.orderMsg_;
			}
			
			public void SetOrderMsg(string value){
				this.orderMsg_ = value;
			}
			
		}
		
		
		
		
		public class selectPageByReceiverPhone_args {
			
			///<summary>
			/// 查询条件
			///</summary>
			
			private com.vip.top.deliveryorder.service.TmsOrderModel tmsOrderModel_;
			
			///<summary>
			/// 当前页第一条数据的位置,从0开始
			///</summary>
			
			private int? pageIndex_;
			
			///<summary>
			/// 每页的记录数
			///</summary>
			
			private int? pageSize_;
			
			public com.vip.top.deliveryorder.service.TmsOrderModel GetTmsOrderModel(){
				return this.tmsOrderModel_;
			}
			
			public void SetTmsOrderModel(com.vip.top.deliveryorder.service.TmsOrderModel value){
				this.tmsOrderModel_ = value;
			}
			public int? GetPageIndex(){
				return this.pageIndex_;
			}
			
			public void SetPageIndex(int? value){
				this.pageIndex_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class updateTmsOrderInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest tmsOrderUpdateRequest_;
			
			///<summary>
			///</summary>
			
			private string warehouse_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest GetTmsOrderUpdateRequest(){
				return this.tmsOrderUpdateRequest_;
			}
			
			public void SetTmsOrderUpdateRequest(com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest value){
				this.tmsOrderUpdateRequest_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			
		}
		
		
		
		
		public class findDeliveryTracks_result {
			
			///<summary>
			/// 返回运单的轨迹(按时间先后排序后返回)
			///</summary>
			
			private List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> success_;
			
			public List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class findDeliveryTracksToStorage_result {
			
			///<summary>
			/// 返回运单的轨迹(按时间先后排序后返回)
			///</summary>
			
			private List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> success_;
			
			public List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class findListDeliveryTracks_result {
			
			///<summary>
			/// 返回运单的轨迹 （按时间先后排序后返回）
			///</summary>
			
			private Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> success_;
			
			public Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class findOrderSnByTransportNo_result {
			
			///<summary>
			/// 订单号 Map key:运单号;value:订单号
			///</summary>
			
			private Dictionary<string, string> success_;
			
			public Dictionary<string, string> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, string> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhone_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhoneToStorage_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByOrderSnAndWareHouse_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNo_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoAndWareHouse_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoToStorage_result {
			
			///<summary>
			/// TmsOrderPageModel 页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNoByOrderSn_result {
			
			///<summary>
			/// String 运单号
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
		
		
		
		
		public class matchCarrier_result {
			
			
		}
		
		
		
		
		public class modifyTmsOrderInfo_result {
			
			///<summary>
			/// 
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class processOdsMessage_result {
			
			///<summary>
			/// ProcessResult 转物流单处理结果
			///</summary>
			
			private com.vip.top.deliveryorder.service.ProcessResult success_;
			
			public com.vip.top.deliveryorder.service.ProcessResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.service.ProcessResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class processOdsOrderStatus_result {
			
			
		}
		
		
		
		
		public class selectPageByReceiverPhone_result {
			
			///<summary>
			/// pageIndex页记录
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateTmsOrderInfo_result {
			
			///<summary>
			/// 
			///</summary>
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse success_;
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class findDeliveryTracks_argsHelper : TBeanSerializer<findDeliveryTracks_args>
		{
			
			public static findDeliveryTracks_argsHelper OBJ = new findDeliveryTracks_argsHelper();
			
			public static findDeliveryTracks_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findDeliveryTracks_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransportNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findDeliveryTracks_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNo() != null) {
					
					oprot.WriteFieldBegin("transportNo");
					oprot.WriteString(structs.GetTransportNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findDeliveryTracks_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findDeliveryTracksToStorage_argsHelper : TBeanSerializer<findDeliveryTracksToStorage_args>
		{
			
			public static findDeliveryTracksToStorage_argsHelper OBJ = new findDeliveryTracksToStorage_argsHelper();
			
			public static findDeliveryTracksToStorage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findDeliveryTracksToStorage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransportNo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findDeliveryTracksToStorage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNo() != null) {
					
					oprot.WriteFieldBegin("transportNo");
					oprot.WriteString(structs.GetTransportNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStorage() != null) {
					
					oprot.WriteFieldBegin("storage");
					oprot.WriteString(structs.GetStorage());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findDeliveryTracksToStorage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findListDeliveryTracks_argsHelper : TBeanSerializer<findListDeliveryTracks_args>
		{
			
			public static findListDeliveryTracks_argsHelper OBJ = new findListDeliveryTracks_argsHelper();
			
			public static findListDeliveryTracks_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findListDeliveryTracks_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetTransportNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findListDeliveryTracks_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNoList() != null) {
					
					oprot.WriteFieldBegin("transportNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetTransportNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findListDeliveryTracks_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findOrderSnByTransportNo_argsHelper : TBeanSerializer<findOrderSnByTransportNo_args>
		{
			
			public static findOrderSnByTransportNo_argsHelper OBJ = new findOrderSnByTransportNo_argsHelper();
			
			public static findOrderSnByTransportNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findOrderSnByTransportNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderType(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTransportNoList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findOrderSnByTransportNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderType() != null) {
					
					oprot.WriteFieldBegin("orderType");
					oprot.WriteString(structs.GetOrderType());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTransportNoList() != null) {
					
					oprot.WriteFieldBegin("transportNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetTransportNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStorage() != null) {
					
					oprot.WriteFieldBegin("storage");
					oprot.WriteString(structs.GetStorage());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findOrderSnByTransportNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhone_argsHelper : TBeanSerializer<findTmsOrderByReceiverPhone_args>
		{
			
			public static findTmsOrderByReceiverPhone_argsHelper OBJ = new findTmsOrderByReceiverPhone_argsHelper();
			
			public static findTmsOrderByReceiverPhone_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findTmsOrderByReceiverPhone_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReceiverPhone(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findTmsOrderByReceiverPhone_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReceiverPhone() != null) {
					
					oprot.WriteFieldBegin("receiverPhone");
					oprot.WriteString(structs.GetReceiverPhone());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findTmsOrderByReceiverPhone_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhoneToStorage_argsHelper : TBeanSerializer<findTmsOrderByReceiverPhoneToStorage_args>
		{
			
			public static findTmsOrderByReceiverPhoneToStorage_argsHelper OBJ = new findTmsOrderByReceiverPhoneToStorage_argsHelper();
			
			public static findTmsOrderByReceiverPhoneToStorage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findTmsOrderByReceiverPhoneToStorage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReceiverPhone(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findTmsOrderByReceiverPhoneToStorage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReceiverPhone() != null) {
					
					oprot.WriteFieldBegin("receiverPhone");
					oprot.WriteString(structs.GetReceiverPhone());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				if(structs.GetStorage() != null) {
					
					oprot.WriteFieldBegin("storage");
					oprot.WriteString(structs.GetStorage());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findTmsOrderByReceiverPhoneToStorage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByOrderSnAndWareHouse_argsHelper : TBeanSerializer<getTmsOrderByOrderSnAndWareHouse_args>
		{
			
			public static getTmsOrderByOrderSnAndWareHouse_argsHelper OBJ = new getTmsOrderByOrderSnAndWareHouse_argsHelper();
			
			public static getTmsOrderByOrderSnAndWareHouse_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByOrderSnAndWareHouse_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWareHouse(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByOrderSnAndWareHouse_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWareHouse() != null) {
					
					oprot.WriteFieldBegin("wareHouse");
					oprot.WriteString(structs.GetWareHouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByOrderSnAndWareHouse_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNo_argsHelper : TBeanSerializer<getTmsOrderByTransportNo_args>
		{
			
			public static getTmsOrderByTransportNo_argsHelper OBJ = new getTmsOrderByTransportNo_argsHelper();
			
			public static getTmsOrderByTransportNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransportNo(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNo() != null) {
					
					oprot.WriteFieldBegin("transportNo");
					oprot.WriteString(structs.GetTransportNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoAndWareHouse_argsHelper : TBeanSerializer<getTmsOrderByTransportNoAndWareHouse_args>
		{
			
			public static getTmsOrderByTransportNoAndWareHouse_argsHelper OBJ = new getTmsOrderByTransportNoAndWareHouse_argsHelper();
			
			public static getTmsOrderByTransportNoAndWareHouse_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNoAndWareHouse_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransportNo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWareHouse(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNoAndWareHouse_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNo() != null) {
					
					oprot.WriteFieldBegin("transportNo");
					oprot.WriteString(structs.GetTransportNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWareHouse() != null) {
					
					oprot.WriteFieldBegin("wareHouse");
					oprot.WriteString(structs.GetWareHouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNoAndWareHouse_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoToStorage_argsHelper : TBeanSerializer<getTmsOrderByTransportNoToStorage_args>
		{
			
			public static getTmsOrderByTransportNoToStorage_argsHelper OBJ = new getTmsOrderByTransportNoToStorage_argsHelper();
			
			public static getTmsOrderByTransportNoToStorage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNoToStorage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransportNo(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNoToStorage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransportNo() != null) {
					
					oprot.WriteFieldBegin("transportNo");
					oprot.WriteString(structs.GetTransportNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				if(structs.GetStorage() != null) {
					
					oprot.WriteFieldBegin("storage");
					oprot.WriteString(structs.GetStorage());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNoToStorage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNoByOrderSn_argsHelper : TBeanSerializer<getTransportNoByOrderSn_args>
		{
			
			public static getTransportNoByOrderSn_argsHelper OBJ = new getTransportNoByOrderSn_argsHelper();
			
			public static getTransportNoByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNoByOrderSn_args structs, Protocol iprot){
				
				
				
				
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
			
			
			public void Write(getTransportNoByOrderSn_args structs, Protocol oprot){
				
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
			
			
			public void Validate(getTransportNoByOrderSn_args bean){
				
				
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
		
		
		
		
		public class matchCarrier_argsHelper : TBeanSerializer<matchCarrier_args>
		{
			
			public static matchCarrier_argsHelper OBJ = new matchCarrier_argsHelper();
			
			public static matchCarrier_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrier_args structs, Protocol iprot){
				
				
				
				
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
			
			
			public void Write(matchCarrier_args structs, Protocol oprot){
				
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
			
			
			public void Validate(matchCarrier_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyTmsOrderInfo_argsHelper : TBeanSerializer<modifyTmsOrderInfo_args>
		{
			
			public static modifyTmsOrderInfo_argsHelper OBJ = new modifyTmsOrderInfo_argsHelper();
			
			public static modifyTmsOrderInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyTmsOrderInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest();
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetTmsOrderModifyRequest(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyTmsOrderInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderModifyRequest() != null) {
					
					oprot.WriteFieldBegin("tmsOrderModifyRequest");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequestHelper.getInstance().Write(structs.GetTmsOrderModifyRequest(), oprot);
					
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
			
			
			public void Validate(modifyTmsOrderInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class processOdsMessage_argsHelper : TBeanSerializer<processOdsMessage_args>
		{
			
			public static processOdsMessage_argsHelper OBJ = new processOdsMessage_argsHelper();
			
			public static processOdsMessage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processOdsMessage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderMsg(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processOdsMessage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderMsg() != null) {
					
					oprot.WriteFieldBegin("orderMsg");
					oprot.WriteString(structs.GetOrderMsg());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processOdsMessage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class processOdsOrderStatus_argsHelper : TBeanSerializer<processOdsOrderStatus_args>
		{
			
			public static processOdsOrderStatus_argsHelper OBJ = new processOdsOrderStatus_argsHelper();
			
			public static processOdsOrderStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processOdsOrderStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderMsg(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processOdsOrderStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderMsg() != null) {
					
					oprot.WriteFieldBegin("orderMsg");
					oprot.WriteString(structs.GetOrderMsg());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("orderMsg can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processOdsOrderStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectPageByReceiverPhone_argsHelper : TBeanSerializer<selectPageByReceiverPhone_args>
		{
			
			public static selectPageByReceiverPhone_argsHelper OBJ = new selectPageByReceiverPhone_argsHelper();
			
			public static selectPageByReceiverPhone_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectPageByReceiverPhone_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.service.TmsOrderModel value;
					
					value = new com.vip.top.deliveryorder.service.TmsOrderModel();
					com.vip.top.deliveryorder.service.TmsOrderModelHelper.getInstance().Read(value, iprot);
					
					structs.SetTmsOrderModel(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageIndex(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectPageByReceiverPhone_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderModel() != null) {
					
					oprot.WriteFieldBegin("tmsOrderModel");
					
					com.vip.top.deliveryorder.service.TmsOrderModelHelper.getInstance().Write(structs.GetTmsOrderModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageIndex() != null) {
					
					oprot.WriteFieldBegin("pageIndex");
					oprot.WriteI32((int)structs.GetPageIndex()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageIndex can not be null!");
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageSize can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectPageByReceiverPhone_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTmsOrderInfo_argsHelper : TBeanSerializer<updateTmsOrderInfo_args>
		{
			
			public static updateTmsOrderInfo_argsHelper OBJ = new updateTmsOrderInfo_argsHelper();
			
			public static updateTmsOrderInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTmsOrderInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest();
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetTmsOrderUpdateRequest(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTmsOrderInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTmsOrderUpdateRequest() != null) {
					
					oprot.WriteFieldBegin("tmsOrderUpdateRequest");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequestHelper.getInstance().Write(structs.GetTmsOrderUpdateRequest(), oprot);
					
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
			
			
			public void Validate(updateTmsOrderInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findDeliveryTracks_resultHelper : TBeanSerializer<findDeliveryTracks_result>
		{
			
			public static findDeliveryTracks_resultHelper OBJ = new findDeliveryTracks_resultHelper();
			
			public static findDeliveryTracks_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findDeliveryTracks_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> value;
					
					value = new List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.deliveryorder.service.TmsOrderTrackModel elem0;
							
							elem0 = new com.vip.top.deliveryorder.service.TmsOrderTrackModel();
							com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(findDeliveryTracks_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.deliveryorder.service.TmsOrderTrackModel _item0 in structs.GetSuccess()){
						
						
						com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findDeliveryTracks_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findDeliveryTracksToStorage_resultHelper : TBeanSerializer<findDeliveryTracksToStorage_result>
		{
			
			public static findDeliveryTracksToStorage_resultHelper OBJ = new findDeliveryTracksToStorage_resultHelper();
			
			public static findDeliveryTracksToStorage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findDeliveryTracksToStorage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> value;
					
					value = new List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.top.deliveryorder.service.TmsOrderTrackModel elem1;
							
							elem1 = new com.vip.top.deliveryorder.service.TmsOrderTrackModel();
							com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
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
			
			
			public void Write(findDeliveryTracksToStorage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.top.deliveryorder.service.TmsOrderTrackModel _item0 in structs.GetSuccess()){
						
						
						com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findDeliveryTracksToStorage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findListDeliveryTracks_resultHelper : TBeanSerializer<findListDeliveryTracks_result>
		{
			
			public static findListDeliveryTracks_resultHelper OBJ = new findListDeliveryTracks_resultHelper();
			
			public static findListDeliveryTracks_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findListDeliveryTracks_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> value;
					
					value = new Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									com.vip.top.deliveryorder.service.TmsOrderTrackModel elem2;
									
									elem2 = new com.vip.top.deliveryorder.service.TmsOrderTrackModel();
									com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Read(elem2, iprot);
									
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
			
			
			public void Write(findListDeliveryTracks_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						oprot.WriteListBegin();
						foreach(com.vip.top.deliveryorder.service.TmsOrderTrackModel _item1 in _value0){
							
							
							com.vip.top.deliveryorder.service.TmsOrderTrackModelHelper.getInstance().Write(_item1, oprot);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findListDeliveryTracks_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findOrderSnByTransportNo_resultHelper : TBeanSerializer<findOrderSnByTransportNo_result>
		{
			
			public static findOrderSnByTransportNo_resultHelper OBJ = new findOrderSnByTransportNo_resultHelper();
			
			public static findOrderSnByTransportNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findOrderSnByTransportNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, string> value;
					
					value = new Dictionary<string, string>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key2;
							string _val2;
							_key2 = iprot.ReadString();
							
							_val2 = iprot.ReadString();
							
							value.Add(_key2, _val2);
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
			
			
			public void Write(findOrderSnByTransportNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, string > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						string _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						oprot.WriteString(_value0);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findOrderSnByTransportNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhone_resultHelper : TBeanSerializer<findTmsOrderByReceiverPhone_result>
		{
			
			public static findTmsOrderByReceiverPhone_resultHelper OBJ = new findTmsOrderByReceiverPhone_resultHelper();
			
			public static findTmsOrderByReceiverPhone_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findTmsOrderByReceiverPhone_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findTmsOrderByReceiverPhone_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findTmsOrderByReceiverPhone_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class findTmsOrderByReceiverPhoneToStorage_resultHelper : TBeanSerializer<findTmsOrderByReceiverPhoneToStorage_result>
		{
			
			public static findTmsOrderByReceiverPhoneToStorage_resultHelper OBJ = new findTmsOrderByReceiverPhoneToStorage_resultHelper();
			
			public static findTmsOrderByReceiverPhoneToStorage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(findTmsOrderByReceiverPhoneToStorage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(findTmsOrderByReceiverPhoneToStorage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(findTmsOrderByReceiverPhoneToStorage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByOrderSnAndWareHouse_resultHelper : TBeanSerializer<getTmsOrderByOrderSnAndWareHouse_result>
		{
			
			public static getTmsOrderByOrderSnAndWareHouse_resultHelper OBJ = new getTmsOrderByOrderSnAndWareHouse_resultHelper();
			
			public static getTmsOrderByOrderSnAndWareHouse_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByOrderSnAndWareHouse_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByOrderSnAndWareHouse_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByOrderSnAndWareHouse_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNo_resultHelper : TBeanSerializer<getTmsOrderByTransportNo_result>
		{
			
			public static getTmsOrderByTransportNo_resultHelper OBJ = new getTmsOrderByTransportNo_resultHelper();
			
			public static getTmsOrderByTransportNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoAndWareHouse_resultHelper : TBeanSerializer<getTmsOrderByTransportNoAndWareHouse_result>
		{
			
			public static getTmsOrderByTransportNoAndWareHouse_resultHelper OBJ = new getTmsOrderByTransportNoAndWareHouse_resultHelper();
			
			public static getTmsOrderByTransportNoAndWareHouse_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNoAndWareHouse_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNoAndWareHouse_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNoAndWareHouse_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTmsOrderByTransportNoToStorage_resultHelper : TBeanSerializer<getTmsOrderByTransportNoToStorage_result>
		{
			
			public static getTmsOrderByTransportNoToStorage_resultHelper OBJ = new getTmsOrderByTransportNoToStorage_resultHelper();
			
			public static getTmsOrderByTransportNoToStorage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTmsOrderByTransportNoToStorage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTmsOrderByTransportNoToStorage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTmsOrderByTransportNoToStorage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNoByOrderSn_resultHelper : TBeanSerializer<getTransportNoByOrderSn_result>
		{
			
			public static getTransportNoByOrderSn_resultHelper OBJ = new getTransportNoByOrderSn_resultHelper();
			
			public static getTransportNoByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNoByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNoByOrderSn_result structs, Protocol oprot){
				
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
			
			
			public void Validate(getTransportNoByOrderSn_result bean){
				
				
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
		
		
		
		
		public class matchCarrier_resultHelper : TBeanSerializer<matchCarrier_result>
		{
			
			public static matchCarrier_resultHelper OBJ = new matchCarrier_resultHelper();
			
			public static matchCarrier_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchCarrier_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchCarrier_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchCarrier_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyTmsOrderInfo_resultHelper : TBeanSerializer<modifyTmsOrderInfo_result>
		{
			
			public static modifyTmsOrderInfo_resultHelper OBJ = new modifyTmsOrderInfo_resultHelper();
			
			public static modifyTmsOrderInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyTmsOrderInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse();
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyTmsOrderInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyTmsOrderInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class processOdsMessage_resultHelper : TBeanSerializer<processOdsMessage_result>
		{
			
			public static processOdsMessage_resultHelper OBJ = new processOdsMessage_resultHelper();
			
			public static processOdsMessage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processOdsMessage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.service.ProcessResult value;
					
					value = new com.vip.top.deliveryorder.service.ProcessResult();
					com.vip.top.deliveryorder.service.ProcessResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processOdsMessage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.service.ProcessResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processOdsMessage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class processOdsOrderStatus_resultHelper : TBeanSerializer<processOdsOrderStatus_result>
		{
			
			public static processOdsOrderStatus_resultHelper OBJ = new processOdsOrderStatus_resultHelper();
			
			public static processOdsOrderStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processOdsOrderStatus_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processOdsOrderStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processOdsOrderStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectPageByReceiverPhone_resultHelper : TBeanSerializer<selectPageByReceiverPhone_result>
		{
			
			public static selectPageByReceiverPhone_resultHelper OBJ = new selectPageByReceiverPhone_resultHelper();
			
			public static selectPageByReceiverPhone_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectPageByReceiverPhone_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModel value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderPageModel();
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectPageByReceiverPhone_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectPageByReceiverPhone_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTmsOrderInfo_resultHelper : TBeanSerializer<updateTmsOrderInfo_result>
		{
			
			public static updateTmsOrderInfo_resultHelper OBJ = new updateTmsOrderInfo_resultHelper();
			
			public static updateTmsOrderInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTmsOrderInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse value;
					
					value = new com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse();
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTmsOrderInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTmsOrderInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class DeliveryOrderServiceClient : OspRestStub , DeliveryOrderService  {
			
			
			public DeliveryOrderServiceClient():base("com.vip.top.deliveryorder.bizservice.DeliveryOrderService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> findDeliveryTracks(string transportNo_) {
				
				send_findDeliveryTracks(transportNo_);
				return recv_findDeliveryTracks(); 
				
			}
			
			
			private void send_findDeliveryTracks(string transportNo_){
				
				InitInvocation("findDeliveryTracks");
				
				findDeliveryTracks_args args = new findDeliveryTracks_args();
				args.SetTransportNo(transportNo_);
				
				SendBase(args, findDeliveryTracks_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> recv_findDeliveryTracks(){
				
				findDeliveryTracks_result result = new findDeliveryTracks_result();
				ReceiveBase(result, findDeliveryTracks_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> findDeliveryTracksToStorage(string transportNo_,string storage_) {
				
				send_findDeliveryTracksToStorage(transportNo_,storage_);
				return recv_findDeliveryTracksToStorage(); 
				
			}
			
			
			private void send_findDeliveryTracksToStorage(string transportNo_,string storage_){
				
				InitInvocation("findDeliveryTracksToStorage");
				
				findDeliveryTracksToStorage_args args = new findDeliveryTracksToStorage_args();
				args.SetTransportNo(transportNo_);
				args.SetStorage(storage_);
				
				SendBase(args, findDeliveryTracksToStorage_argsHelper.getInstance());
			}
			
			
			private List<com.vip.top.deliveryorder.service.TmsOrderTrackModel> recv_findDeliveryTracksToStorage(){
				
				findDeliveryTracksToStorage_result result = new findDeliveryTracksToStorage_result();
				ReceiveBase(result, findDeliveryTracksToStorage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> findListDeliveryTracks(List<string> transportNoList_) {
				
				send_findListDeliveryTracks(transportNoList_);
				return recv_findListDeliveryTracks(); 
				
			}
			
			
			private void send_findListDeliveryTracks(List<string> transportNoList_){
				
				InitInvocation("findListDeliveryTracks");
				
				findListDeliveryTracks_args args = new findListDeliveryTracks_args();
				args.SetTransportNoList(transportNoList_);
				
				SendBase(args, findListDeliveryTracks_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, List<com.vip.top.deliveryorder.service.TmsOrderTrackModel>> recv_findListDeliveryTracks(){
				
				findListDeliveryTracks_result result = new findListDeliveryTracks_result();
				ReceiveBase(result, findListDeliveryTracks_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, string> findOrderSnByTransportNo(string orderType_,List<string> transportNoList_,string storage_) {
				
				send_findOrderSnByTransportNo(orderType_,transportNoList_,storage_);
				return recv_findOrderSnByTransportNo(); 
				
			}
			
			
			private void send_findOrderSnByTransportNo(string orderType_,List<string> transportNoList_,string storage_){
				
				InitInvocation("findOrderSnByTransportNo");
				
				findOrderSnByTransportNo_args args = new findOrderSnByTransportNo_args();
				args.SetOrderType(orderType_);
				args.SetTransportNoList(transportNoList_);
				args.SetStorage(storage_);
				
				SendBase(args, findOrderSnByTransportNo_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, string> recv_findOrderSnByTransportNo(){
				
				findOrderSnByTransportNo_result result = new findOrderSnByTransportNo_result();
				ReceiveBase(result, findOrderSnByTransportNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel findTmsOrderByReceiverPhone(string receiverPhone_,int pageIndex_,int pageSize_) {
				
				send_findTmsOrderByReceiverPhone(receiverPhone_,pageIndex_,pageSize_);
				return recv_findTmsOrderByReceiverPhone(); 
				
			}
			
			
			private void send_findTmsOrderByReceiverPhone(string receiverPhone_,int pageIndex_,int pageSize_){
				
				InitInvocation("findTmsOrderByReceiverPhone");
				
				findTmsOrderByReceiverPhone_args args = new findTmsOrderByReceiverPhone_args();
				args.SetReceiverPhone(receiverPhone_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, findTmsOrderByReceiverPhone_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_findTmsOrderByReceiverPhone(){
				
				findTmsOrderByReceiverPhone_result result = new findTmsOrderByReceiverPhone_result();
				ReceiveBase(result, findTmsOrderByReceiverPhone_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel findTmsOrderByReceiverPhoneToStorage(string receiverPhone_,int pageIndex_,int pageSize_,string storage_) {
				
				send_findTmsOrderByReceiverPhoneToStorage(receiverPhone_,pageIndex_,pageSize_,storage_);
				return recv_findTmsOrderByReceiverPhoneToStorage(); 
				
			}
			
			
			private void send_findTmsOrderByReceiverPhoneToStorage(string receiverPhone_,int pageIndex_,int pageSize_,string storage_){
				
				InitInvocation("findTmsOrderByReceiverPhoneToStorage");
				
				findTmsOrderByReceiverPhoneToStorage_args args = new findTmsOrderByReceiverPhoneToStorage_args();
				args.SetReceiverPhone(receiverPhone_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				args.SetStorage(storage_);
				
				SendBase(args, findTmsOrderByReceiverPhoneToStorage_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_findTmsOrderByReceiverPhoneToStorage(){
				
				findTmsOrderByReceiverPhoneToStorage_result result = new findTmsOrderByReceiverPhoneToStorage_result();
				ReceiveBase(result, findTmsOrderByReceiverPhoneToStorage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByOrderSnAndWareHouse(string orderSn_,string wareHouse_,int pageIndex_,int pageSize_) {
				
				send_getTmsOrderByOrderSnAndWareHouse(orderSn_,wareHouse_,pageIndex_,pageSize_);
				return recv_getTmsOrderByOrderSnAndWareHouse(); 
				
			}
			
			
			private void send_getTmsOrderByOrderSnAndWareHouse(string orderSn_,string wareHouse_,int pageIndex_,int pageSize_){
				
				InitInvocation("getTmsOrderByOrderSnAndWareHouse");
				
				getTmsOrderByOrderSnAndWareHouse_args args = new getTmsOrderByOrderSnAndWareHouse_args();
				args.SetOrderSn(orderSn_);
				args.SetWareHouse(wareHouse_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, getTmsOrderByOrderSnAndWareHouse_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_getTmsOrderByOrderSnAndWareHouse(){
				
				getTmsOrderByOrderSnAndWareHouse_result result = new getTmsOrderByOrderSnAndWareHouse_result();
				ReceiveBase(result, getTmsOrderByOrderSnAndWareHouse_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNo(string transportNo_,int pageIndex_,int pageSize_) {
				
				send_getTmsOrderByTransportNo(transportNo_,pageIndex_,pageSize_);
				return recv_getTmsOrderByTransportNo(); 
				
			}
			
			
			private void send_getTmsOrderByTransportNo(string transportNo_,int pageIndex_,int pageSize_){
				
				InitInvocation("getTmsOrderByTransportNo");
				
				getTmsOrderByTransportNo_args args = new getTmsOrderByTransportNo_args();
				args.SetTransportNo(transportNo_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, getTmsOrderByTransportNo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_getTmsOrderByTransportNo(){
				
				getTmsOrderByTransportNo_result result = new getTmsOrderByTransportNo_result();
				ReceiveBase(result, getTmsOrderByTransportNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNoAndWareHouse(string transportNo_,string wareHouse_,int pageIndex_,int pageSize_) {
				
				send_getTmsOrderByTransportNoAndWareHouse(transportNo_,wareHouse_,pageIndex_,pageSize_);
				return recv_getTmsOrderByTransportNoAndWareHouse(); 
				
			}
			
			
			private void send_getTmsOrderByTransportNoAndWareHouse(string transportNo_,string wareHouse_,int pageIndex_,int pageSize_){
				
				InitInvocation("getTmsOrderByTransportNoAndWareHouse");
				
				getTmsOrderByTransportNoAndWareHouse_args args = new getTmsOrderByTransportNoAndWareHouse_args();
				args.SetTransportNo(transportNo_);
				args.SetWareHouse(wareHouse_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, getTmsOrderByTransportNoAndWareHouse_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_getTmsOrderByTransportNoAndWareHouse(){
				
				getTmsOrderByTransportNoAndWareHouse_result result = new getTmsOrderByTransportNoAndWareHouse_result();
				ReceiveBase(result, getTmsOrderByTransportNoAndWareHouse_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel getTmsOrderByTransportNoToStorage(string transportNo_,int pageIndex_,int pageSize_,string storage_) {
				
				send_getTmsOrderByTransportNoToStorage(transportNo_,pageIndex_,pageSize_,storage_);
				return recv_getTmsOrderByTransportNoToStorage(); 
				
			}
			
			
			private void send_getTmsOrderByTransportNoToStorage(string transportNo_,int pageIndex_,int pageSize_,string storage_){
				
				InitInvocation("getTmsOrderByTransportNoToStorage");
				
				getTmsOrderByTransportNoToStorage_args args = new getTmsOrderByTransportNoToStorage_args();
				args.SetTransportNo(transportNo_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				args.SetStorage(storage_);
				
				SendBase(args, getTmsOrderByTransportNoToStorage_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_getTmsOrderByTransportNoToStorage(){
				
				getTmsOrderByTransportNoToStorage_result result = new getTmsOrderByTransportNoToStorage_result();
				ReceiveBase(result, getTmsOrderByTransportNoToStorage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getTransportNoByOrderSn(string orderSn_,string warehouse_) {
				
				send_getTransportNoByOrderSn(orderSn_,warehouse_);
				return recv_getTransportNoByOrderSn(); 
				
			}
			
			
			private void send_getTransportNoByOrderSn(string orderSn_,string warehouse_){
				
				InitInvocation("getTransportNoByOrderSn");
				
				getTransportNoByOrderSn_args args = new getTransportNoByOrderSn_args();
				args.SetOrderSn(orderSn_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, getTransportNoByOrderSn_argsHelper.getInstance());
			}
			
			
			private string recv_getTransportNoByOrderSn(){
				
				getTransportNoByOrderSn_result result = new getTransportNoByOrderSn_result();
				ReceiveBase(result, getTransportNoByOrderSn_resultHelper.getInstance());
				
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
			
			
			public void matchCarrier(List<string> tmsOrderIds_,string warehouse_) {
				
				send_matchCarrier(tmsOrderIds_,warehouse_);
				recv_matchCarrier();
				
			}
			
			
			private void send_matchCarrier(List<string> tmsOrderIds_,string warehouse_){
				
				InitInvocation("matchCarrier");
				
				matchCarrier_args args = new matchCarrier_args();
				args.SetTmsOrderIds(tmsOrderIds_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, matchCarrier_argsHelper.getInstance());
			}
			
			
			private void recv_matchCarrier(){
				
				matchCarrier_result result = new matchCarrier_result();
				ReceiveBase(result, matchCarrier_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse modifyTmsOrderInfo(com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest tmsOrderModifyRequest_,string warehouse_) {
				
				send_modifyTmsOrderInfo(tmsOrderModifyRequest_,warehouse_);
				return recv_modifyTmsOrderInfo(); 
				
			}
			
			
			private void send_modifyTmsOrderInfo(com.vip.top.deliveryorder.bizservice.TmsOrderModifyRequest tmsOrderModifyRequest_,string warehouse_){
				
				InitInvocation("modifyTmsOrderInfo");
				
				modifyTmsOrderInfo_args args = new modifyTmsOrderInfo_args();
				args.SetTmsOrderModifyRequest(tmsOrderModifyRequest_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, modifyTmsOrderInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderModifyResponse recv_modifyTmsOrderInfo(){
				
				modifyTmsOrderInfo_result result = new modifyTmsOrderInfo_result();
				ReceiveBase(result, modifyTmsOrderInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.service.ProcessResult processOdsMessage(string orderMsg_) {
				
				send_processOdsMessage(orderMsg_);
				return recv_processOdsMessage(); 
				
			}
			
			
			private void send_processOdsMessage(string orderMsg_){
				
				InitInvocation("processOdsMessage");
				
				processOdsMessage_args args = new processOdsMessage_args();
				args.SetOrderMsg(orderMsg_);
				
				SendBase(args, processOdsMessage_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.service.ProcessResult recv_processOdsMessage(){
				
				processOdsMessage_result result = new processOdsMessage_result();
				ReceiveBase(result, processOdsMessage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void processOdsOrderStatus(string orderMsg_) {
				
				send_processOdsOrderStatus(orderMsg_);
				recv_processOdsOrderStatus();
				
			}
			
			
			private void send_processOdsOrderStatus(string orderMsg_){
				
				InitInvocation("processOdsOrderStatus");
				
				processOdsOrderStatus_args args = new processOdsOrderStatus_args();
				args.SetOrderMsg(orderMsg_);
				
				SendBase(args, processOdsOrderStatus_argsHelper.getInstance());
			}
			
			
			private void recv_processOdsOrderStatus(){
				
				processOdsOrderStatus_result result = new processOdsOrderStatus_result();
				ReceiveBase(result, processOdsOrderStatus_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderPageModel selectPageByReceiverPhone(com.vip.top.deliveryorder.service.TmsOrderModel tmsOrderModel_,int pageIndex_,int pageSize_) {
				
				send_selectPageByReceiverPhone(tmsOrderModel_,pageIndex_,pageSize_);
				return recv_selectPageByReceiverPhone(); 
				
			}
			
			
			private void send_selectPageByReceiverPhone(com.vip.top.deliveryorder.service.TmsOrderModel tmsOrderModel_,int pageIndex_,int pageSize_){
				
				InitInvocation("selectPageByReceiverPhone");
				
				selectPageByReceiverPhone_args args = new selectPageByReceiverPhone_args();
				args.SetTmsOrderModel(tmsOrderModel_);
				args.SetPageIndex(pageIndex_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, selectPageByReceiverPhone_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderPageModel recv_selectPageByReceiverPhone(){
				
				selectPageByReceiverPhone_result result = new selectPageByReceiverPhone_result();
				ReceiveBase(result, selectPageByReceiverPhone_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse updateTmsOrderInfo(com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest tmsOrderUpdateRequest_,string warehouse_) {
				
				send_updateTmsOrderInfo(tmsOrderUpdateRequest_,warehouse_);
				return recv_updateTmsOrderInfo(); 
				
			}
			
			
			private void send_updateTmsOrderInfo(com.vip.top.deliveryorder.bizservice.TmsOrderUpdateRequest tmsOrderUpdateRequest_,string warehouse_){
				
				InitInvocation("updateTmsOrderInfo");
				
				updateTmsOrderInfo_args args = new updateTmsOrderInfo_args();
				args.SetTmsOrderUpdateRequest(tmsOrderUpdateRequest_);
				args.SetWarehouse(warehouse_);
				
				SendBase(args, updateTmsOrderInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.top.deliveryorder.bizservice.TmsOrderUpdateResponse recv_updateTmsOrderInfo(){
				
				updateTmsOrderInfo_result result = new updateTmsOrderInfo_result();
				ReceiveBase(result, updateTmsOrderInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}