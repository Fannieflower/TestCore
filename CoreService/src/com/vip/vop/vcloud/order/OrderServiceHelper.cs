using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.order{
	
	
	public class OrderServiceHelper {
		
		
		
		public class acceptOrder_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class appointOrderStore_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class cancelShipment_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 操作人账号
			///</summary>
			
			private string account_;
			
			///<summary>
			/// 门店ID
			///</summary>
			
			private long? storeId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetAccount(){
				return this.account_;
			}
			
			public void SetAccount(string value){
				this.account_ = value;
			}
			public long? GetStoreId(){
				return this.storeId_;
			}
			
			public void SetStoreId(long? value){
				this.storeId_ = value;
			}
			
		}
		
		
		
		
		public class checkMultiParcel_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class confirmDelivery_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmDeliveryPartly_args {
			
			///<summary>
			/// 部分发货请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq req_;
			
			public com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmNoStock_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmShipment_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 操作人账号
			///</summary>
			
			private string account_;
			
			///<summary>
			/// 门店ID
			///</summary>
			
			private long? storeId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetAccount(){
				return this.account_;
			}
			
			public void SetAccount(string value){
				this.account_ = value;
			}
			public long? GetStoreId(){
				return this.storeId_;
			}
			
			public void SetStoreId(long? value){
				this.storeId_ = value;
			}
			
		}
		
		
		
		
		public class confirmUserRefuse_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getChannelOrderAndDetail_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// orderType
			///</summary>
			
			private int? orderType_;
			
			///<summary>
			/// 分页器
			///</summary>
			
			private com.vip.vop.vcloud.common.api.Pagination pagination_;
			
			///<summary>
			/// warehouses
			///</summary>
			
			private List<long?> warehouses_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public int? GetOrderType(){
				return this.orderType_;
			}
			
			public void SetOrderType(int? value){
				this.orderType_ = value;
			}
			public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
				return this.pagination_;
			}
			
			public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
				this.pagination_ = value;
			}
			public List<long?> GetWarehouses(){
				return this.warehouses_;
			}
			
			public void SetWarehouses(List<long?> value){
				this.warehouses_ = value;
			}
			
		}
		
		
		
		
		public class getChannelOrderByOrderSn_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 门店ID（如果有传门店ID，则返回门店相关订单）
			///</summary>
			
			private long? storeId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetStoreId(){
				return this.storeId_;
			}
			
			public void SetStoreId(long? value){
				this.storeId_ = value;
			}
			
		}
		
		
		
		
		public class getChannelOrderItems_args {
			
			///<summary>
			/// 订单查询请求
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderQueryRequest orderQueryRequest_;
			
			public com.vip.vop.vcloud.order.OrderQueryRequest GetOrderQueryRequest(){
				return this.orderQueryRequest_;
			}
			
			public void SetOrderQueryRequest(com.vip.vop.vcloud.order.OrderQueryRequest value){
				this.orderQueryRequest_ = value;
			}
			
		}
		
		
		
		
		public class getOfficialMemberByOrderSn_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class getOrderByChannelIdAndOrderSn_args {
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 母订单号
			///</summary>
			
			private string orderSn_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			
		}
		
		
		
		
		public class getOrderByExpressNo_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string expressNo_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetExpressNo(){
				return this.expressNo_;
			}
			
			public void SetExpressNo(string value){
				this.expressNo_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLogisticsByOrderSn_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 门店ID
			///</summary>
			
			private long? storeId_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetStoreId(){
				return this.storeId_;
			}
			
			public void SetStoreId(long? value){
				this.storeId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			
		}
		
		
		
		
		public class getOrderOptLog_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 门店ID
			///</summary>
			
			private long? storeId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string subOrderSn_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetStoreId(){
				return this.storeId_;
			}
			
			public void SetStoreId(long? value){
				this.storeId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			
		}
		
		
		
		
		public class getWaybillDetails_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 开始时间
			///</summary>
			
			private long? startTime_;
			
			///<summary>
			/// 结束时间
			///</summary>
			
			private long? endTime_;
			
			///<summary>
			/// 分页器
			///</summary>
			
			private com.vip.vop.vcloud.common.api.Pagination pagination_;
			
			///<summary>
			/// warehouses
			///</summary>
			
			private List<long?> warehouses_;
			
			///<summary>
			/// orderType
			///</summary>
			
			private int? orderType_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetStartTime(){
				return this.startTime_;
			}
			
			public void SetStartTime(long? value){
				this.startTime_ = value;
			}
			public long? GetEndTime(){
				return this.endTime_;
			}
			
			public void SetEndTime(long? value){
				this.endTime_ = value;
			}
			public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
				return this.pagination_;
			}
			
			public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
				this.pagination_ = value;
			}
			public List<long?> GetWarehouses(){
				return this.warehouses_;
			}
			
			public void SetWarehouses(List<long?> value){
				this.warehouses_ = value;
			}
			public int? GetOrderType(){
				return this.orderType_;
			}
			
			public void SetOrderType(int? value){
				this.orderType_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class listSubOrder_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseByOrderSn_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			
		}
		
		
		
		
		public class pullOrders_args {
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 开始时间
			///</summary>
			
			private System.DateTime? beginTime_;
			
			///<summary>
			/// 结束时间
			///</summary>
			
			private System.DateTime? endTime_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public System.DateTime? GetBeginTime(){
				return this.beginTime_;
			}
			
			public void SetBeginTime(System.DateTime? value){
				this.beginTime_ = value;
			}
			public System.DateTime? GetEndTime(){
				return this.endTime_;
			}
			
			public void SetEndTime(System.DateTime? value){
				this.endTime_ = value;
			}
			
		}
		
		
		
		
		public class refuseOrder_args {
			
			///<summary>
			/// 订单门店请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderStoreReq req_;
			
			public com.vip.vop.vcloud.order.OrderStoreReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.order.OrderStoreReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class storeConfirmed_args {
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 确认标识 0-未确认 1-已确认
			///</summary>
			
			private int? isConfirmed_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public int? GetIsConfirmed(){
				return this.isConfirmed_;
			}
			
			public void SetIsConfirmed(int? value){
				this.isConfirmed_ = value;
			}
			
		}
		
		
		
		
		public class updateDeliveryStatus_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 订单号
			///</summary>
			
			private string orderSn_;
			
			///<summary>
			/// 快递单号
			///</summary>
			
			private string deliveryNo_;
			
			///<summary>
			/// 节点时间
			///</summary>
			
			private long? acceptTime_;
			
			///<summary>
			/// 节点城市
			///</summary>
			
			private string acceptAddress_;
			
			///<summary>
			/// 节点描述
			///</summary>
			
			private string remark_;
			
			///<summary>
			/// 操作码
			///</summary>
			
			private string opCode_;
			
			///<summary>
			/// 物流节点ID
			///</summary>
			
			private string opId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public string GetOrderSn(){
				return this.orderSn_;
			}
			
			public void SetOrderSn(string value){
				this.orderSn_ = value;
			}
			public string GetDeliveryNo(){
				return this.deliveryNo_;
			}
			
			public void SetDeliveryNo(string value){
				this.deliveryNo_ = value;
			}
			public long? GetAcceptTime(){
				return this.acceptTime_;
			}
			
			public void SetAcceptTime(long? value){
				this.acceptTime_ = value;
			}
			public string GetAcceptAddress(){
				return this.acceptAddress_;
			}
			
			public void SetAcceptAddress(string value){
				this.acceptAddress_ = value;
			}
			public string GetRemark(){
				return this.remark_;
			}
			
			public void SetRemark(string value){
				this.remark_ = value;
			}
			public string GetOpCode(){
				return this.opCode_;
			}
			
			public void SetOpCode(string value){
				this.opCode_ = value;
			}
			public string GetOpId(){
				return this.opId_;
			}
			
			public void SetOpId(string value){
				this.opId_ = value;
			}
			
		}
		
		
		
		
		public class updateOrderLogisticsBySubOrderSn_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 物流公司
			///</summary>
			
			private string expressCompany_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string expressNo_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public string GetExpressCompany(){
				return this.expressCompany_;
			}
			
			public void SetExpressCompany(string value){
				this.expressCompany_ = value;
			}
			public string GetExpressNo(){
				return this.expressNo_;
			}
			
			public void SetExpressNo(string value){
				this.expressNo_ = value;
			}
			
		}
		
		
		
		
		public class updateRemark_args {
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 子订单号
			///</summary>
			
			private string subOrderSn_;
			
			///<summary>
			/// 门店备注
			///</summary>
			
			private string remark_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public string GetSubOrderSn(){
				return this.subOrderSn_;
			}
			
			public void SetSubOrderSn(string value){
				this.subOrderSn_ = value;
			}
			public string GetRemark(){
				return this.remark_;
			}
			
			public void SetRemark(string value){
				this.remark_ = value;
			}
			
		}
		
		
		
		
		public class acceptOrder_result {
			
			
		}
		
		
		
		
		public class appointOrderStore_result {
			
			
		}
		
		
		
		
		public class cancelShipment_result {
			
			
		}
		
		
		
		
		public class checkMultiParcel_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmDelivery_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.order.Express> success_;
			
			public List<com.vip.vop.vcloud.order.Express> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.order.Express> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmDeliveryPartly_result {
			
			
		}
		
		
		
		
		public class confirmNoStock_result {
			
			
		}
		
		
		
		
		public class confirmShipment_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.order.Express> success_;
			
			public List<com.vip.vop.vcloud.order.Express> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.order.Express> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmUserRefuse_result {
			
			
		}
		
		
		
		
		public class getChannelOrderAndDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.WayBillResponse success_;
			
			public com.vip.vop.vcloud.order.WayBillResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.WayBillResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getChannelOrderByOrderSn_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderItem success_;
			
			public com.vip.vop.vcloud.order.OrderItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.OrderItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getChannelOrderItems_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderResponse success_;
			
			public com.vip.vop.vcloud.order.OrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.OrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOfficialMemberByOrderSn_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.OfficialMember success_;
			
			public com.vip.vop.vcloud.order.OfficialMember GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.OfficialMember value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderByChannelIdAndOrderSn_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderItem success_;
			
			public com.vip.vop.vcloud.order.OrderItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.OrderItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderByExpressNo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.OrderItem success_;
			
			public com.vip.vop.vcloud.order.OrderItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.OrderItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLogisticsByOrderSn_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.order.OrderLogistics> success_;
			
			public List<com.vip.vop.vcloud.order.OrderLogistics> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.order.OrderLogistics> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderOptLog_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.order.OrderOptLog> success_;
			
			public List<com.vip.vop.vcloud.order.OrderOptLog> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.order.OrderOptLog> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getWaybillDetails_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.order.WayBillResponse success_;
			
			public com.vip.vop.vcloud.order.WayBillResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.order.WayBillResponse value){
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
		
		
		
		
		public class listSubOrder_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.order.SubOrder> success_;
			
			public List<com.vip.vop.vcloud.order.SubOrder> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.order.SubOrder> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseByOrderSn_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.warehouse.api.Warehouse> success_;
			
			public List<com.vip.vop.vcloud.warehouse.api.Warehouse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.warehouse.api.Warehouse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class pullOrders_result {
			
			
		}
		
		
		
		
		public class refuseOrder_result {
			
			
		}
		
		
		
		
		public class storeConfirmed_result {
			
			
		}
		
		
		
		
		public class updateDeliveryStatus_result {
			
			
		}
		
		
		
		
		public class updateOrderLogisticsBySubOrderSn_result {
			
			
		}
		
		
		
		
		public class updateRemark_result {
			
			
		}
		
		
		
		
		
		public class acceptOrder_argsHelper : TBeanSerializer<acceptOrder_args>
		{
			
			public static acceptOrder_argsHelper OBJ = new acceptOrder_argsHelper();
			
			public static acceptOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class appointOrderStore_argsHelper : TBeanSerializer<appointOrderStore_args>
		{
			
			public static appointOrderStore_argsHelper OBJ = new appointOrderStore_argsHelper();
			
			public static appointOrderStore_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(appointOrderStore_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(appointOrderStore_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(appointOrderStore_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelShipment_argsHelper : TBeanSerializer<cancelShipment_args>
		{
			
			public static cancelShipment_argsHelper OBJ = new cancelShipment_argsHelper();
			
			public static cancelShipment_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelShipment_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAccount(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStoreId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelShipment_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetAccount() != null) {
					
					oprot.WriteFieldBegin("account");
					oprot.WriteString(structs.GetAccount());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreId() != null) {
					
					oprot.WriteFieldBegin("storeId");
					oprot.WriteI64((long)structs.GetStoreId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelShipment_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkMultiParcel_argsHelper : TBeanSerializer<checkMultiParcel_args>
		{
			
			public static checkMultiParcel_argsHelper OBJ = new checkMultiParcel_argsHelper();
			
			public static checkMultiParcel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkMultiParcel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkMultiParcel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkMultiParcel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmDelivery_argsHelper : TBeanSerializer<confirmDelivery_args>
		{
			
			public static confirmDelivery_argsHelper OBJ = new confirmDelivery_argsHelper();
			
			public static confirmDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmDeliveryPartly_argsHelper : TBeanSerializer<confirmDeliveryPartly_args>
		{
			
			public static confirmDeliveryPartly_argsHelper OBJ = new confirmDeliveryPartly_argsHelper();
			
			public static confirmDeliveryPartly_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDeliveryPartly_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq value;
					
					value = new com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq();
					com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmDeliveryPartly_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDeliveryPartly_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmNoStock_argsHelper : TBeanSerializer<confirmNoStock_args>
		{
			
			public static confirmNoStock_argsHelper OBJ = new confirmNoStock_argsHelper();
			
			public static confirmNoStock_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmNoStock_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmNoStock_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmNoStock_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmShipment_argsHelper : TBeanSerializer<confirmShipment_args>
		{
			
			public static confirmShipment_argsHelper OBJ = new confirmShipment_argsHelper();
			
			public static confirmShipment_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmShipment_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAccount(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStoreId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmShipment_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("orderSn can not be null!");
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				if(structs.GetAccount() != null) {
					
					oprot.WriteFieldBegin("account");
					oprot.WriteString(structs.GetAccount());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("account can not be null!");
				}
				
				
				if(structs.GetStoreId() != null) {
					
					oprot.WriteFieldBegin("storeId");
					oprot.WriteI64((long)structs.GetStoreId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmShipment_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmUserRefuse_argsHelper : TBeanSerializer<confirmUserRefuse_args>
		{
			
			public static confirmUserRefuse_argsHelper OBJ = new confirmUserRefuse_argsHelper();
			
			public static confirmUserRefuse_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmUserRefuse_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmUserRefuse_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmUserRefuse_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderAndDetail_argsHelper : TBeanSerializer<getChannelOrderAndDetail_args>
		{
			
			public static getChannelOrderAndDetail_argsHelper OBJ = new getChannelOrderAndDetail_argsHelper();
			
			public static getChannelOrderAndDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderAndDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetOrderType(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.common.api.Pagination value;
					
					value = new com.vip.vop.vcloud.common.api.Pagination();
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
					
					structs.SetPagination(value);
				}
				
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem1;
							elem1 = iprot.ReadI64(); 
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetWarehouses(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderAndDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderType() != null) {
					
					oprot.WriteFieldBegin("orderType");
					oprot.WriteI32((int)structs.GetOrderType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPagination() != null) {
					
					oprot.WriteFieldBegin("pagination");
					
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouses() != null) {
					
					oprot.WriteFieldBegin("warehouses");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetWarehouses()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderAndDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderByOrderSn_argsHelper : TBeanSerializer<getChannelOrderByOrderSn_args>
		{
			
			public static getChannelOrderByOrderSn_argsHelper OBJ = new getChannelOrderByOrderSn_argsHelper();
			
			public static getChannelOrderByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStoreId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreId() != null) {
					
					oprot.WriteFieldBegin("storeId");
					oprot.WriteI64((long)structs.GetStoreId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderItems_argsHelper : TBeanSerializer<getChannelOrderItems_args>
		{
			
			public static getChannelOrderItems_argsHelper OBJ = new getChannelOrderItems_argsHelper();
			
			public static getChannelOrderItems_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderItems_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderQueryRequest value;
					
					value = new com.vip.vop.vcloud.order.OrderQueryRequest();
					com.vip.vop.vcloud.order.OrderQueryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetOrderQueryRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderItems_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderQueryRequest() != null) {
					
					oprot.WriteFieldBegin("orderQueryRequest");
					
					com.vip.vop.vcloud.order.OrderQueryRequestHelper.getInstance().Write(structs.GetOrderQueryRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderItems_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOfficialMemberByOrderSn_argsHelper : TBeanSerializer<getOfficialMemberByOrderSn_args>
		{
			
			public static getOfficialMemberByOrderSn_argsHelper OBJ = new getOfficialMemberByOrderSn_argsHelper();
			
			public static getOfficialMemberByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOfficialMemberByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOfficialMemberByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOfficialMemberByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderByChannelIdAndOrderSn_argsHelper : TBeanSerializer<getOrderByChannelIdAndOrderSn_args>
		{
			
			public static getOrderByChannelIdAndOrderSn_argsHelper OBJ = new getOrderByChannelIdAndOrderSn_argsHelper();
			
			public static getOrderByChannelIdAndOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderByChannelIdAndOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderByChannelIdAndOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderByChannelIdAndOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderByExpressNo_argsHelper : TBeanSerializer<getOrderByExpressNo_args>
		{
			
			public static getOrderByExpressNo_argsHelper OBJ = new getOrderByExpressNo_argsHelper();
			
			public static getOrderByExpressNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderByExpressNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetExpressNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderByExpressNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetExpressNo() != null) {
					
					oprot.WriteFieldBegin("expressNo");
					oprot.WriteString(structs.GetExpressNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderByExpressNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLogisticsByOrderSn_argsHelper : TBeanSerializer<getOrderLogisticsByOrderSn_args>
		{
			
			public static getOrderLogisticsByOrderSn_argsHelper OBJ = new getOrderLogisticsByOrderSn_argsHelper();
			
			public static getOrderLogisticsByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLogisticsByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStoreId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderLogisticsByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreId() != null) {
					
					oprot.WriteFieldBegin("storeId");
					oprot.WriteI64((long)structs.GetStoreId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLogisticsByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderOptLog_argsHelper : TBeanSerializer<getOrderOptLog_args>
		{
			
			public static getOrderOptLog_argsHelper OBJ = new getOrderOptLog_argsHelper();
			
			public static getOrderOptLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderOptLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStoreId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderOptLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreId() != null) {
					
					oprot.WriteFieldBegin("storeId");
					oprot.WriteI64((long)structs.GetStoreId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderOptLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWaybillDetails_argsHelper : TBeanSerializer<getWaybillDetails_args>
		{
			
			public static getWaybillDetails_argsHelper OBJ = new getWaybillDetails_argsHelper();
			
			public static getWaybillDetails_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWaybillDetails_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetStartTime(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetEndTime(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.common.api.Pagination value;
					
					value = new com.vip.vop.vcloud.common.api.Pagination();
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
					
					structs.SetPagination(value);
				}
				
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem1;
							elem1 = iprot.ReadI64(); 
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetWarehouses(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetOrderType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWaybillDetails_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStartTime() != null) {
					
					oprot.WriteFieldBegin("startTime");
					oprot.WriteI64((long)structs.GetStartTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEndTime() != null) {
					
					oprot.WriteFieldBegin("endTime");
					oprot.WriteI64((long)structs.GetEndTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPagination() != null) {
					
					oprot.WriteFieldBegin("pagination");
					
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouses() != null) {
					
					oprot.WriteFieldBegin("warehouses");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetWarehouses()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderType() != null) {
					
					oprot.WriteFieldBegin("orderType");
					oprot.WriteI32((int)structs.GetOrderType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWaybillDetails_args bean){
				
				
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
		
		
		
		
		public class listSubOrder_argsHelper : TBeanSerializer<listSubOrder_args>
		{
			
			public static listSubOrder_argsHelper OBJ = new listSubOrder_argsHelper();
			
			public static listSubOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listSubOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listSubOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listSubOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseByOrderSn_argsHelper : TBeanSerializer<listWarehouseByOrderSn_args>
		{
			
			public static listWarehouseByOrderSn_argsHelper OBJ = new listWarehouseByOrderSn_argsHelper();
			
			public static listWarehouseByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listWarehouseByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pullOrders_argsHelper : TBeanSerializer<pullOrders_args>
		{
			
			public static pullOrders_argsHelper OBJ = new pullOrders_argsHelper();
			
			public static pullOrders_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullOrders_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetBeginTime(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEndTime(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pullOrders_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBeginTime() != null) {
					
					oprot.WriteFieldBegin("beginTime");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetBeginTime())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEndTime() != null) {
					
					oprot.WriteFieldBegin("endTime");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEndTime())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullOrders_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refuseOrder_argsHelper : TBeanSerializer<refuseOrder_args>
		{
			
			public static refuseOrder_argsHelper OBJ = new refuseOrder_argsHelper();
			
			public static refuseOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refuseOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderStoreReq value;
					
					value = new com.vip.vop.vcloud.order.OrderStoreReq();
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refuseOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.order.OrderStoreReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refuseOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class storeConfirmed_argsHelper : TBeanSerializer<storeConfirmed_args>
		{
			
			public static storeConfirmed_argsHelper OBJ = new storeConfirmed_argsHelper();
			
			public static storeConfirmed_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(storeConfirmed_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetIsConfirmed(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(storeConfirmed_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("subOrderSn can not be null!");
				}
				
				
				if(structs.GetIsConfirmed() != null) {
					
					oprot.WriteFieldBegin("isConfirmed");
					oprot.WriteI32((int)structs.GetIsConfirmed()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(storeConfirmed_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateDeliveryStatus_argsHelper : TBeanSerializer<updateDeliveryStatus_args>
		{
			
			public static updateDeliveryStatus_argsHelper OBJ = new updateDeliveryStatus_argsHelper();
			
			public static updateDeliveryStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateDeliveryStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDeliveryNo(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetAcceptTime(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAcceptAddress(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRemark(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOpCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOpId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateDeliveryStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrderSn() != null) {
					
					oprot.WriteFieldBegin("orderSn");
					oprot.WriteString(structs.GetOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDeliveryNo() != null) {
					
					oprot.WriteFieldBegin("deliveryNo");
					oprot.WriteString(structs.GetDeliveryNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetAcceptTime() != null) {
					
					oprot.WriteFieldBegin("acceptTime");
					oprot.WriteI64((long)structs.GetAcceptTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetAcceptAddress() != null) {
					
					oprot.WriteFieldBegin("acceptAddress");
					oprot.WriteString(structs.GetAcceptAddress());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetRemark() != null) {
					
					oprot.WriteFieldBegin("remark");
					oprot.WriteString(structs.GetRemark());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOpCode() != null) {
					
					oprot.WriteFieldBegin("opCode");
					oprot.WriteString(structs.GetOpCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOpId() != null) {
					
					oprot.WriteFieldBegin("opId");
					oprot.WriteString(structs.GetOpId());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateDeliveryStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateOrderLogisticsBySubOrderSn_argsHelper : TBeanSerializer<updateOrderLogisticsBySubOrderSn_args>
		{
			
			public static updateOrderLogisticsBySubOrderSn_argsHelper OBJ = new updateOrderLogisticsBySubOrderSn_argsHelper();
			
			public static updateOrderLogisticsBySubOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateOrderLogisticsBySubOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetExpressCompany(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetExpressNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateOrderLogisticsBySubOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetExpressCompany() != null) {
					
					oprot.WriteFieldBegin("expressCompany");
					oprot.WriteString(structs.GetExpressCompany());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetExpressNo() != null) {
					
					oprot.WriteFieldBegin("expressNo");
					oprot.WriteString(structs.GetExpressNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateOrderLogisticsBySubOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateRemark_argsHelper : TBeanSerializer<updateRemark_args>
		{
			
			public static updateRemark_argsHelper OBJ = new updateRemark_argsHelper();
			
			public static updateRemark_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateRemark_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSubOrderSn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRemark(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateRemark_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelId can not be null!");
				}
				
				
				if(structs.GetSubOrderSn() != null) {
					
					oprot.WriteFieldBegin("subOrderSn");
					oprot.WriteString(structs.GetSubOrderSn());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("subOrderSn can not be null!");
				}
				
				
				if(structs.GetRemark() != null) {
					
					oprot.WriteFieldBegin("remark");
					oprot.WriteString(structs.GetRemark());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateRemark_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class acceptOrder_resultHelper : TBeanSerializer<acceptOrder_result>
		{
			
			public static acceptOrder_resultHelper OBJ = new acceptOrder_resultHelper();
			
			public static acceptOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptOrder_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class appointOrderStore_resultHelper : TBeanSerializer<appointOrderStore_result>
		{
			
			public static appointOrderStore_resultHelper OBJ = new appointOrderStore_resultHelper();
			
			public static appointOrderStore_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(appointOrderStore_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(appointOrderStore_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(appointOrderStore_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelShipment_resultHelper : TBeanSerializer<cancelShipment_result>
		{
			
			public static cancelShipment_resultHelper OBJ = new cancelShipment_resultHelper();
			
			public static cancelShipment_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelShipment_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelShipment_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelShipment_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkMultiParcel_resultHelper : TBeanSerializer<checkMultiParcel_result>
		{
			
			public static checkMultiParcel_resultHelper OBJ = new checkMultiParcel_resultHelper();
			
			public static checkMultiParcel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkMultiParcel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkMultiParcel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkMultiParcel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmDelivery_resultHelper : TBeanSerializer<confirmDelivery_result>
		{
			
			public static confirmDelivery_resultHelper OBJ = new confirmDelivery_resultHelper();
			
			public static confirmDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.order.Express> value;
					
					value = new List<com.vip.vop.vcloud.order.Express>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.order.Express elem0;
							
							elem0 = new com.vip.vop.vcloud.order.Express();
							com.vip.vop.vcloud.order.ExpressHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(confirmDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.order.Express _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.order.ExpressHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmDeliveryPartly_resultHelper : TBeanSerializer<confirmDeliveryPartly_result>
		{
			
			public static confirmDeliveryPartly_resultHelper OBJ = new confirmDeliveryPartly_resultHelper();
			
			public static confirmDeliveryPartly_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDeliveryPartly_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmDeliveryPartly_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDeliveryPartly_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmNoStock_resultHelper : TBeanSerializer<confirmNoStock_result>
		{
			
			public static confirmNoStock_resultHelper OBJ = new confirmNoStock_resultHelper();
			
			public static confirmNoStock_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmNoStock_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmNoStock_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmNoStock_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmShipment_resultHelper : TBeanSerializer<confirmShipment_result>
		{
			
			public static confirmShipment_resultHelper OBJ = new confirmShipment_resultHelper();
			
			public static confirmShipment_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmShipment_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.order.Express> value;
					
					value = new List<com.vip.vop.vcloud.order.Express>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.order.Express elem1;
							
							elem1 = new com.vip.vop.vcloud.order.Express();
							com.vip.vop.vcloud.order.ExpressHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(confirmShipment_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.order.Express _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.order.ExpressHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmShipment_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmUserRefuse_resultHelper : TBeanSerializer<confirmUserRefuse_result>
		{
			
			public static confirmUserRefuse_resultHelper OBJ = new confirmUserRefuse_resultHelper();
			
			public static confirmUserRefuse_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmUserRefuse_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmUserRefuse_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmUserRefuse_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderAndDetail_resultHelper : TBeanSerializer<getChannelOrderAndDetail_result>
		{
			
			public static getChannelOrderAndDetail_resultHelper OBJ = new getChannelOrderAndDetail_resultHelper();
			
			public static getChannelOrderAndDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderAndDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.WayBillResponse value;
					
					value = new com.vip.vop.vcloud.order.WayBillResponse();
					com.vip.vop.vcloud.order.WayBillResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderAndDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.WayBillResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderAndDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderByOrderSn_resultHelper : TBeanSerializer<getChannelOrderByOrderSn_result>
		{
			
			public static getChannelOrderByOrderSn_resultHelper OBJ = new getChannelOrderByOrderSn_resultHelper();
			
			public static getChannelOrderByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderItem value;
					
					value = new com.vip.vop.vcloud.order.OrderItem();
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelOrderItems_resultHelper : TBeanSerializer<getChannelOrderItems_result>
		{
			
			public static getChannelOrderItems_resultHelper OBJ = new getChannelOrderItems_resultHelper();
			
			public static getChannelOrderItems_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelOrderItems_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderResponse value;
					
					value = new com.vip.vop.vcloud.order.OrderResponse();
					com.vip.vop.vcloud.order.OrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelOrderItems_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.OrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelOrderItems_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOfficialMemberByOrderSn_resultHelper : TBeanSerializer<getOfficialMemberByOrderSn_result>
		{
			
			public static getOfficialMemberByOrderSn_resultHelper OBJ = new getOfficialMemberByOrderSn_resultHelper();
			
			public static getOfficialMemberByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOfficialMemberByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OfficialMember value;
					
					value = new com.vip.vop.vcloud.order.OfficialMember();
					com.vip.vop.vcloud.order.OfficialMemberHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOfficialMemberByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.OfficialMemberHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOfficialMemberByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderByChannelIdAndOrderSn_resultHelper : TBeanSerializer<getOrderByChannelIdAndOrderSn_result>
		{
			
			public static getOrderByChannelIdAndOrderSn_resultHelper OBJ = new getOrderByChannelIdAndOrderSn_resultHelper();
			
			public static getOrderByChannelIdAndOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderByChannelIdAndOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderItem value;
					
					value = new com.vip.vop.vcloud.order.OrderItem();
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderByChannelIdAndOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderByChannelIdAndOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderByExpressNo_resultHelper : TBeanSerializer<getOrderByExpressNo_result>
		{
			
			public static getOrderByExpressNo_resultHelper OBJ = new getOrderByExpressNo_resultHelper();
			
			public static getOrderByExpressNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderByExpressNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.OrderItem value;
					
					value = new com.vip.vop.vcloud.order.OrderItem();
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderByExpressNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.OrderItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderByExpressNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLogisticsByOrderSn_resultHelper : TBeanSerializer<getOrderLogisticsByOrderSn_result>
		{
			
			public static getOrderLogisticsByOrderSn_resultHelper OBJ = new getOrderLogisticsByOrderSn_resultHelper();
			
			public static getOrderLogisticsByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLogisticsByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.order.OrderLogistics> value;
					
					value = new List<com.vip.vop.vcloud.order.OrderLogistics>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.order.OrderLogistics elem0;
							
							elem0 = new com.vip.vop.vcloud.order.OrderLogistics();
							com.vip.vop.vcloud.order.OrderLogisticsHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getOrderLogisticsByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.order.OrderLogistics _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.order.OrderLogisticsHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLogisticsByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderOptLog_resultHelper : TBeanSerializer<getOrderOptLog_result>
		{
			
			public static getOrderOptLog_resultHelper OBJ = new getOrderOptLog_resultHelper();
			
			public static getOrderOptLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderOptLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.order.OrderOptLog> value;
					
					value = new List<com.vip.vop.vcloud.order.OrderOptLog>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.order.OrderOptLog elem1;
							
							elem1 = new com.vip.vop.vcloud.order.OrderOptLog();
							com.vip.vop.vcloud.order.OrderOptLogHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getOrderOptLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.order.OrderOptLog _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.order.OrderOptLogHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderOptLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWaybillDetails_resultHelper : TBeanSerializer<getWaybillDetails_result>
		{
			
			public static getWaybillDetails_resultHelper OBJ = new getWaybillDetails_resultHelper();
			
			public static getWaybillDetails_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWaybillDetails_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.order.WayBillResponse value;
					
					value = new com.vip.vop.vcloud.order.WayBillResponse();
					com.vip.vop.vcloud.order.WayBillResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWaybillDetails_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.order.WayBillResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWaybillDetails_result bean){
				
				
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
		
		
		
		
		public class listSubOrder_resultHelper : TBeanSerializer<listSubOrder_result>
		{
			
			public static listSubOrder_resultHelper OBJ = new listSubOrder_resultHelper();
			
			public static listSubOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listSubOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.order.SubOrder> value;
					
					value = new List<com.vip.vop.vcloud.order.SubOrder>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.order.SubOrder elem0;
							
							elem0 = new com.vip.vop.vcloud.order.SubOrder();
							com.vip.vop.vcloud.order.SubOrderHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(listSubOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.order.SubOrder _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.order.SubOrderHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listSubOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseByOrderSn_resultHelper : TBeanSerializer<listWarehouseByOrderSn_result>
		{
			
			public static listWarehouseByOrderSn_resultHelper OBJ = new listWarehouseByOrderSn_resultHelper();
			
			public static listWarehouseByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.warehouse.api.Warehouse> value;
					
					value = new List<com.vip.vop.vcloud.warehouse.api.Warehouse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.warehouse.api.Warehouse elem1;
							
							elem1 = new com.vip.vop.vcloud.warehouse.api.Warehouse();
							com.vip.vop.vcloud.warehouse.api.WarehouseHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(listWarehouseByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.warehouse.api.Warehouse _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.warehouse.api.WarehouseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pullOrders_resultHelper : TBeanSerializer<pullOrders_result>
		{
			
			public static pullOrders_resultHelper OBJ = new pullOrders_resultHelper();
			
			public static pullOrders_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullOrders_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pullOrders_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullOrders_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refuseOrder_resultHelper : TBeanSerializer<refuseOrder_result>
		{
			
			public static refuseOrder_resultHelper OBJ = new refuseOrder_resultHelper();
			
			public static refuseOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refuseOrder_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refuseOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refuseOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class storeConfirmed_resultHelper : TBeanSerializer<storeConfirmed_result>
		{
			
			public static storeConfirmed_resultHelper OBJ = new storeConfirmed_resultHelper();
			
			public static storeConfirmed_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(storeConfirmed_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(storeConfirmed_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(storeConfirmed_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateDeliveryStatus_resultHelper : TBeanSerializer<updateDeliveryStatus_result>
		{
			
			public static updateDeliveryStatus_resultHelper OBJ = new updateDeliveryStatus_resultHelper();
			
			public static updateDeliveryStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateDeliveryStatus_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateDeliveryStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateDeliveryStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateOrderLogisticsBySubOrderSn_resultHelper : TBeanSerializer<updateOrderLogisticsBySubOrderSn_result>
		{
			
			public static updateOrderLogisticsBySubOrderSn_resultHelper OBJ = new updateOrderLogisticsBySubOrderSn_resultHelper();
			
			public static updateOrderLogisticsBySubOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateOrderLogisticsBySubOrderSn_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateOrderLogisticsBySubOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateOrderLogisticsBySubOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateRemark_resultHelper : TBeanSerializer<updateRemark_result>
		{
			
			public static updateRemark_resultHelper OBJ = new updateRemark_resultHelper();
			
			public static updateRemark_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateRemark_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateRemark_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateRemark_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class OrderServiceClient : OspRestStub , OrderService  {
			
			
			public OrderServiceClient():base("com.vip.vop.vcloud.order.OrderService","1.0.0") {
				
				
			}
			
			
			
			public void acceptOrder(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_acceptOrder(req_);
				recv_acceptOrder();
				
			}
			
			
			private void send_acceptOrder(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("acceptOrder");
				
				acceptOrder_args args = new acceptOrder_args();
				args.SetReq(req_);
				
				SendBase(args, acceptOrder_argsHelper.getInstance());
			}
			
			
			private void recv_acceptOrder(){
				
				acceptOrder_result result = new acceptOrder_result();
				ReceiveBase(result, acceptOrder_resultHelper.getInstance());
				
				
			}
			
			
			public void appointOrderStore(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_appointOrderStore(req_);
				recv_appointOrderStore();
				
			}
			
			
			private void send_appointOrderStore(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("appointOrderStore");
				
				appointOrderStore_args args = new appointOrderStore_args();
				args.SetReq(req_);
				
				SendBase(args, appointOrderStore_argsHelper.getInstance());
			}
			
			
			private void recv_appointOrderStore(){
				
				appointOrderStore_result result = new appointOrderStore_result();
				ReceiveBase(result, appointOrderStore_resultHelper.getInstance());
				
				
			}
			
			
			public void cancelShipment(long? partnerId_,string orderSn_,long? channelId_,string account_,long? storeId_) {
				
				send_cancelShipment(partnerId_,orderSn_,channelId_,account_,storeId_);
				recv_cancelShipment();
				
			}
			
			
			private void send_cancelShipment(long? partnerId_,string orderSn_,long? channelId_,string account_,long? storeId_){
				
				InitInvocation("cancelShipment");
				
				cancelShipment_args args = new cancelShipment_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				args.SetAccount(account_);
				args.SetStoreId(storeId_);
				
				SendBase(args, cancelShipment_argsHelper.getInstance());
			}
			
			
			private void recv_cancelShipment(){
				
				cancelShipment_result result = new cancelShipment_result();
				ReceiveBase(result, cancelShipment_resultHelper.getInstance());
				
				
			}
			
			
			public bool? checkMultiParcel(long partnerId_,string orderSn_,string subOrderSn_,long channelId_) {
				
				send_checkMultiParcel(partnerId_,orderSn_,subOrderSn_,channelId_);
				return recv_checkMultiParcel(); 
				
			}
			
			
			private void send_checkMultiParcel(long partnerId_,string orderSn_,string subOrderSn_,long channelId_){
				
				InitInvocation("checkMultiParcel");
				
				checkMultiParcel_args args = new checkMultiParcel_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetChannelId(channelId_);
				
				SendBase(args, checkMultiParcel_argsHelper.getInstance());
			}
			
			
			private bool? recv_checkMultiParcel(){
				
				checkMultiParcel_result result = new checkMultiParcel_result();
				ReceiveBase(result, checkMultiParcel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.order.Express> confirmDelivery(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_confirmDelivery(req_);
				return recv_confirmDelivery(); 
				
			}
			
			
			private void send_confirmDelivery(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("confirmDelivery");
				
				confirmDelivery_args args = new confirmDelivery_args();
				args.SetReq(req_);
				
				SendBase(args, confirmDelivery_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.order.Express> recv_confirmDelivery(){
				
				confirmDelivery_result result = new confirmDelivery_result();
				ReceiveBase(result, confirmDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void confirmDeliveryPartly(com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq req_) {
				
				send_confirmDeliveryPartly(req_);
				recv_confirmDeliveryPartly();
				
			}
			
			
			private void send_confirmDeliveryPartly(com.vip.vop.vcloud.order.ConfirmDeliveryPartlyReq req_){
				
				InitInvocation("confirmDeliveryPartly");
				
				confirmDeliveryPartly_args args = new confirmDeliveryPartly_args();
				args.SetReq(req_);
				
				SendBase(args, confirmDeliveryPartly_argsHelper.getInstance());
			}
			
			
			private void recv_confirmDeliveryPartly(){
				
				confirmDeliveryPartly_result result = new confirmDeliveryPartly_result();
				ReceiveBase(result, confirmDeliveryPartly_resultHelper.getInstance());
				
				
			}
			
			
			public void confirmNoStock(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_confirmNoStock(req_);
				recv_confirmNoStock();
				
			}
			
			
			private void send_confirmNoStock(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("confirmNoStock");
				
				confirmNoStock_args args = new confirmNoStock_args();
				args.SetReq(req_);
				
				SendBase(args, confirmNoStock_argsHelper.getInstance());
			}
			
			
			private void recv_confirmNoStock(){
				
				confirmNoStock_result result = new confirmNoStock_result();
				ReceiveBase(result, confirmNoStock_resultHelper.getInstance());
				
				
			}
			
			
			public List<com.vip.vop.vcloud.order.Express> confirmShipment(long partnerId_,string orderSn_,long channelId_,string account_,long? storeId_) {
				
				send_confirmShipment(partnerId_,orderSn_,channelId_,account_,storeId_);
				return recv_confirmShipment(); 
				
			}
			
			
			private void send_confirmShipment(long partnerId_,string orderSn_,long channelId_,string account_,long? storeId_){
				
				InitInvocation("confirmShipment");
				
				confirmShipment_args args = new confirmShipment_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				args.SetAccount(account_);
				args.SetStoreId(storeId_);
				
				SendBase(args, confirmShipment_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.order.Express> recv_confirmShipment(){
				
				confirmShipment_result result = new confirmShipment_result();
				ReceiveBase(result, confirmShipment_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void confirmUserRefuse(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_confirmUserRefuse(req_);
				recv_confirmUserRefuse();
				
			}
			
			
			private void send_confirmUserRefuse(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("confirmUserRefuse");
				
				confirmUserRefuse_args args = new confirmUserRefuse_args();
				args.SetReq(req_);
				
				SendBase(args, confirmUserRefuse_argsHelper.getInstance());
			}
			
			
			private void recv_confirmUserRefuse(){
				
				confirmUserRefuse_result result = new confirmUserRefuse_result();
				ReceiveBase(result, confirmUserRefuse_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.vop.vcloud.order.WayBillResponse getChannelOrderAndDetail(long? partnerId_,long? channelId_,int? orderType_,com.vip.vop.vcloud.common.api.Pagination pagination_,List<long?> warehouses_) {
				
				send_getChannelOrderAndDetail(partnerId_,channelId_,orderType_,pagination_,warehouses_);
				return recv_getChannelOrderAndDetail(); 
				
			}
			
			
			private void send_getChannelOrderAndDetail(long? partnerId_,long? channelId_,int? orderType_,com.vip.vop.vcloud.common.api.Pagination pagination_,List<long?> warehouses_){
				
				InitInvocation("getChannelOrderAndDetail");
				
				getChannelOrderAndDetail_args args = new getChannelOrderAndDetail_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				args.SetOrderType(orderType_);
				args.SetPagination(pagination_);
				args.SetWarehouses(warehouses_);
				
				SendBase(args, getChannelOrderAndDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.WayBillResponse recv_getChannelOrderAndDetail(){
				
				getChannelOrderAndDetail_result result = new getChannelOrderAndDetail_result();
				ReceiveBase(result, getChannelOrderAndDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.OrderItem getChannelOrderByOrderSn(long? partnerId_,string orderSn_,string subOrderSn_,long? channelId_,long? storeId_) {
				
				send_getChannelOrderByOrderSn(partnerId_,orderSn_,subOrderSn_,channelId_,storeId_);
				return recv_getChannelOrderByOrderSn(); 
				
			}
			
			
			private void send_getChannelOrderByOrderSn(long? partnerId_,string orderSn_,string subOrderSn_,long? channelId_,long? storeId_){
				
				InitInvocation("getChannelOrderByOrderSn");
				
				getChannelOrderByOrderSn_args args = new getChannelOrderByOrderSn_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetChannelId(channelId_);
				args.SetStoreId(storeId_);
				
				SendBase(args, getChannelOrderByOrderSn_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.OrderItem recv_getChannelOrderByOrderSn(){
				
				getChannelOrderByOrderSn_result result = new getChannelOrderByOrderSn_result();
				ReceiveBase(result, getChannelOrderByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.OrderResponse getChannelOrderItems(com.vip.vop.vcloud.order.OrderQueryRequest orderQueryRequest_) {
				
				send_getChannelOrderItems(orderQueryRequest_);
				return recv_getChannelOrderItems(); 
				
			}
			
			
			private void send_getChannelOrderItems(com.vip.vop.vcloud.order.OrderQueryRequest orderQueryRequest_){
				
				InitInvocation("getChannelOrderItems");
				
				getChannelOrderItems_args args = new getChannelOrderItems_args();
				args.SetOrderQueryRequest(orderQueryRequest_);
				
				SendBase(args, getChannelOrderItems_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.OrderResponse recv_getChannelOrderItems(){
				
				getChannelOrderItems_result result = new getChannelOrderItems_result();
				ReceiveBase(result, getChannelOrderItems_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.OfficialMember getOfficialMemberByOrderSn(long? partnerId_,string orderSn_,long? channelId_) {
				
				send_getOfficialMemberByOrderSn(partnerId_,orderSn_,channelId_);
				return recv_getOfficialMemberByOrderSn(); 
				
			}
			
			
			private void send_getOfficialMemberByOrderSn(long? partnerId_,string orderSn_,long? channelId_){
				
				InitInvocation("getOfficialMemberByOrderSn");
				
				getOfficialMemberByOrderSn_args args = new getOfficialMemberByOrderSn_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				
				SendBase(args, getOfficialMemberByOrderSn_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.OfficialMember recv_getOfficialMemberByOrderSn(){
				
				getOfficialMemberByOrderSn_result result = new getOfficialMemberByOrderSn_result();
				ReceiveBase(result, getOfficialMemberByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.OrderItem getOrderByChannelIdAndOrderSn(long channelId_,string orderSn_) {
				
				send_getOrderByChannelIdAndOrderSn(channelId_,orderSn_);
				return recv_getOrderByChannelIdAndOrderSn(); 
				
			}
			
			
			private void send_getOrderByChannelIdAndOrderSn(long channelId_,string orderSn_){
				
				InitInvocation("getOrderByChannelIdAndOrderSn");
				
				getOrderByChannelIdAndOrderSn_args args = new getOrderByChannelIdAndOrderSn_args();
				args.SetChannelId(channelId_);
				args.SetOrderSn(orderSn_);
				
				SendBase(args, getOrderByChannelIdAndOrderSn_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.OrderItem recv_getOrderByChannelIdAndOrderSn(){
				
				getOrderByChannelIdAndOrderSn_result result = new getOrderByChannelIdAndOrderSn_result();
				ReceiveBase(result, getOrderByChannelIdAndOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.OrderItem getOrderByExpressNo(long? partnerId_,string orderSn_,string subOrderSn_,long? channelId_,string expressNo_) {
				
				send_getOrderByExpressNo(partnerId_,orderSn_,subOrderSn_,channelId_,expressNo_);
				return recv_getOrderByExpressNo(); 
				
			}
			
			
			private void send_getOrderByExpressNo(long? partnerId_,string orderSn_,string subOrderSn_,long? channelId_,string expressNo_){
				
				InitInvocation("getOrderByExpressNo");
				
				getOrderByExpressNo_args args = new getOrderByExpressNo_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetChannelId(channelId_);
				args.SetExpressNo(expressNo_);
				
				SendBase(args, getOrderByExpressNo_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.OrderItem recv_getOrderByExpressNo(){
				
				getOrderByExpressNo_result result = new getOrderByExpressNo_result();
				ReceiveBase(result, getOrderByExpressNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.order.OrderLogistics> getOrderLogisticsByOrderSn(long? partnerId_,string orderSn_,long? channelId_,long? storeId_,string subOrderSn_) {
				
				send_getOrderLogisticsByOrderSn(partnerId_,orderSn_,channelId_,storeId_,subOrderSn_);
				return recv_getOrderLogisticsByOrderSn(); 
				
			}
			
			
			private void send_getOrderLogisticsByOrderSn(long? partnerId_,string orderSn_,long? channelId_,long? storeId_,string subOrderSn_){
				
				InitInvocation("getOrderLogisticsByOrderSn");
				
				getOrderLogisticsByOrderSn_args args = new getOrderLogisticsByOrderSn_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				args.SetStoreId(storeId_);
				args.SetSubOrderSn(subOrderSn_);
				
				SendBase(args, getOrderLogisticsByOrderSn_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.order.OrderLogistics> recv_getOrderLogisticsByOrderSn(){
				
				getOrderLogisticsByOrderSn_result result = new getOrderLogisticsByOrderSn_result();
				ReceiveBase(result, getOrderLogisticsByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.order.OrderOptLog> getOrderOptLog(long? partnerId_,string orderSn_,long? channelId_,long? storeId_,string subOrderSn_) {
				
				send_getOrderOptLog(partnerId_,orderSn_,channelId_,storeId_,subOrderSn_);
				return recv_getOrderOptLog(); 
				
			}
			
			
			private void send_getOrderOptLog(long? partnerId_,string orderSn_,long? channelId_,long? storeId_,string subOrderSn_){
				
				InitInvocation("getOrderOptLog");
				
				getOrderOptLog_args args = new getOrderOptLog_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				args.SetStoreId(storeId_);
				args.SetSubOrderSn(subOrderSn_);
				
				SendBase(args, getOrderOptLog_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.order.OrderOptLog> recv_getOrderOptLog(){
				
				getOrderOptLog_result result = new getOrderOptLog_result();
				ReceiveBase(result, getOrderOptLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.order.WayBillResponse getWaybillDetails(long? partnerId_,long? channelId_,long? startTime_,long? endTime_,com.vip.vop.vcloud.common.api.Pagination pagination_,List<long?> warehouses_,int? orderType_) {
				
				send_getWaybillDetails(partnerId_,channelId_,startTime_,endTime_,pagination_,warehouses_,orderType_);
				return recv_getWaybillDetails(); 
				
			}
			
			
			private void send_getWaybillDetails(long? partnerId_,long? channelId_,long? startTime_,long? endTime_,com.vip.vop.vcloud.common.api.Pagination pagination_,List<long?> warehouses_,int? orderType_){
				
				InitInvocation("getWaybillDetails");
				
				getWaybillDetails_args args = new getWaybillDetails_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				args.SetStartTime(startTime_);
				args.SetEndTime(endTime_);
				args.SetPagination(pagination_);
				args.SetWarehouses(warehouses_);
				args.SetOrderType(orderType_);
				
				SendBase(args, getWaybillDetails_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.order.WayBillResponse recv_getWaybillDetails(){
				
				getWaybillDetails_result result = new getWaybillDetails_result();
				ReceiveBase(result, getWaybillDetails_resultHelper.getInstance());
				
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
			
			
			public List<com.vip.vop.vcloud.order.SubOrder> listSubOrder(long partnerId_,string orderSn_,long channelId_,string subOrderSn_) {
				
				send_listSubOrder(partnerId_,orderSn_,channelId_,subOrderSn_);
				return recv_listSubOrder(); 
				
			}
			
			
			private void send_listSubOrder(long partnerId_,string orderSn_,long channelId_,string subOrderSn_){
				
				InitInvocation("listSubOrder");
				
				listSubOrder_args args = new listSubOrder_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetChannelId(channelId_);
				args.SetSubOrderSn(subOrderSn_);
				
				SendBase(args, listSubOrder_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.order.SubOrder> recv_listSubOrder(){
				
				listSubOrder_result result = new listSubOrder_result();
				ReceiveBase(result, listSubOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.warehouse.api.Warehouse> listWarehouseByOrderSn(long? partnerId_,long? channelId_,string orderSn_) {
				
				send_listWarehouseByOrderSn(partnerId_,channelId_,orderSn_);
				return recv_listWarehouseByOrderSn(); 
				
			}
			
			
			private void send_listWarehouseByOrderSn(long? partnerId_,long? channelId_,string orderSn_){
				
				InitInvocation("listWarehouseByOrderSn");
				
				listWarehouseByOrderSn_args args = new listWarehouseByOrderSn_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				args.SetOrderSn(orderSn_);
				
				SendBase(args, listWarehouseByOrderSn_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.warehouse.api.Warehouse> recv_listWarehouseByOrderSn(){
				
				listWarehouseByOrderSn_result result = new listWarehouseByOrderSn_result();
				ReceiveBase(result, listWarehouseByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void pullOrders(long? channelId_,long? partnerId_,string orderSn_,System.DateTime? beginTime_,System.DateTime? endTime_) {
				
				send_pullOrders(channelId_,partnerId_,orderSn_,beginTime_,endTime_);
				recv_pullOrders();
				
			}
			
			
			private void send_pullOrders(long? channelId_,long? partnerId_,string orderSn_,System.DateTime? beginTime_,System.DateTime? endTime_){
				
				InitInvocation("pullOrders");
				
				pullOrders_args args = new pullOrders_args();
				args.SetChannelId(channelId_);
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetBeginTime(beginTime_);
				args.SetEndTime(endTime_);
				
				SendBase(args, pullOrders_argsHelper.getInstance());
			}
			
			
			private void recv_pullOrders(){
				
				pullOrders_result result = new pullOrders_result();
				ReceiveBase(result, pullOrders_resultHelper.getInstance());
				
				
			}
			
			
			public void refuseOrder(com.vip.vop.vcloud.order.OrderStoreReq req_) {
				
				send_refuseOrder(req_);
				recv_refuseOrder();
				
			}
			
			
			private void send_refuseOrder(com.vip.vop.vcloud.order.OrderStoreReq req_){
				
				InitInvocation("refuseOrder");
				
				refuseOrder_args args = new refuseOrder_args();
				args.SetReq(req_);
				
				SendBase(args, refuseOrder_argsHelper.getInstance());
			}
			
			
			private void recv_refuseOrder(){
				
				refuseOrder_result result = new refuseOrder_result();
				ReceiveBase(result, refuseOrder_resultHelper.getInstance());
				
				
			}
			
			
			public void storeConfirmed(long channelId_,string subOrderSn_,int? isConfirmed_) {
				
				send_storeConfirmed(channelId_,subOrderSn_,isConfirmed_);
				recv_storeConfirmed();
				
			}
			
			
			private void send_storeConfirmed(long channelId_,string subOrderSn_,int? isConfirmed_){
				
				InitInvocation("storeConfirmed");
				
				storeConfirmed_args args = new storeConfirmed_args();
				args.SetChannelId(channelId_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetIsConfirmed(isConfirmed_);
				
				SendBase(args, storeConfirmed_argsHelper.getInstance());
			}
			
			
			private void recv_storeConfirmed(){
				
				storeConfirmed_result result = new storeConfirmed_result();
				ReceiveBase(result, storeConfirmed_resultHelper.getInstance());
				
				
			}
			
			
			public void updateDeliveryStatus(long? partnerId_,string orderSn_,string deliveryNo_,long? acceptTime_,string acceptAddress_,string remark_,string opCode_,string opId_) {
				
				send_updateDeliveryStatus(partnerId_,orderSn_,deliveryNo_,acceptTime_,acceptAddress_,remark_,opCode_,opId_);
				recv_updateDeliveryStatus();
				
			}
			
			
			private void send_updateDeliveryStatus(long? partnerId_,string orderSn_,string deliveryNo_,long? acceptTime_,string acceptAddress_,string remark_,string opCode_,string opId_){
				
				InitInvocation("updateDeliveryStatus");
				
				updateDeliveryStatus_args args = new updateDeliveryStatus_args();
				args.SetPartnerId(partnerId_);
				args.SetOrderSn(orderSn_);
				args.SetDeliveryNo(deliveryNo_);
				args.SetAcceptTime(acceptTime_);
				args.SetAcceptAddress(acceptAddress_);
				args.SetRemark(remark_);
				args.SetOpCode(opCode_);
				args.SetOpId(opId_);
				
				SendBase(args, updateDeliveryStatus_argsHelper.getInstance());
			}
			
			
			private void recv_updateDeliveryStatus(){
				
				updateDeliveryStatus_result result = new updateDeliveryStatus_result();
				ReceiveBase(result, updateDeliveryStatus_resultHelper.getInstance());
				
				
			}
			
			
			public void updateOrderLogisticsBySubOrderSn(long? partnerId_,long? channelId_,string subOrderSn_,string expressCompany_,string expressNo_) {
				
				send_updateOrderLogisticsBySubOrderSn(partnerId_,channelId_,subOrderSn_,expressCompany_,expressNo_);
				recv_updateOrderLogisticsBySubOrderSn();
				
			}
			
			
			private void send_updateOrderLogisticsBySubOrderSn(long? partnerId_,long? channelId_,string subOrderSn_,string expressCompany_,string expressNo_){
				
				InitInvocation("updateOrderLogisticsBySubOrderSn");
				
				updateOrderLogisticsBySubOrderSn_args args = new updateOrderLogisticsBySubOrderSn_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetExpressCompany(expressCompany_);
				args.SetExpressNo(expressNo_);
				
				SendBase(args, updateOrderLogisticsBySubOrderSn_argsHelper.getInstance());
			}
			
			
			private void recv_updateOrderLogisticsBySubOrderSn(){
				
				updateOrderLogisticsBySubOrderSn_result result = new updateOrderLogisticsBySubOrderSn_result();
				ReceiveBase(result, updateOrderLogisticsBySubOrderSn_resultHelper.getInstance());
				
				
			}
			
			
			public void updateRemark(long channelId_,string subOrderSn_,string remark_) {
				
				send_updateRemark(channelId_,subOrderSn_,remark_);
				recv_updateRemark();
				
			}
			
			
			private void send_updateRemark(long channelId_,string subOrderSn_,string remark_){
				
				InitInvocation("updateRemark");
				
				updateRemark_args args = new updateRemark_args();
				args.SetChannelId(channelId_);
				args.SetSubOrderSn(subOrderSn_);
				args.SetRemark(remark_);
				
				SendBase(args, updateRemark_argsHelper.getInstance());
			}
			
			
			private void recv_updateRemark(){
				
				updateRemark_result result = new updateRemark_result();
				ReceiveBase(result, updateRemark_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}