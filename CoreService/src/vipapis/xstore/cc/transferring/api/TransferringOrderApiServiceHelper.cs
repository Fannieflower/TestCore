using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.transferring.api{
	
	
	public class TransferringOrderApiServiceHelper {
		
		
		
		public class completeTransferringOrder_args {
			
			///<summary>
			/// 调拨单完结请求
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.CompleteOrderRequest request_;
			
			public vipapis.xstore.cc.transferring.api.CompleteOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.xstore.cc.transferring.api.CompleteOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class confirmTransferringDelivery_args {
			
			///<summary>
			/// 出库拉取确认请求
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq request_;
			
			public vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class confirmTransferringOrder_args {
			
			///<summary>
			/// 单据编号清单（最大100
			///</summary>
			
			private List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> confirm_transferring_order_;
			
			public List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> GetConfirm_transferring_order(){
				return this.confirm_transferring_order_;
			}
			
			public void SetConfirm_transferring_order(List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> value){
				this.confirm_transferring_order_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryTransferringDelivery_args {
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? start_delivery_time_;
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? end_delivery_time_;
			
			///<summary>
			/// 调拨类型，1:大仓-门店；2:门店-门店；3:门店-大仓；4:大仓-大仓
			///</summary>
			
			private byte? transferring_type_;
			
			///<summary>
			/// 分页默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页限制,默认20, 最大100
			///</summary>
			
			private int? page_size_;
			
			public System.DateTime? GetStart_delivery_time(){
				return this.start_delivery_time_;
			}
			
			public void SetStart_delivery_time(System.DateTime? value){
				this.start_delivery_time_ = value;
			}
			public System.DateTime? GetEnd_delivery_time(){
				return this.end_delivery_time_;
			}
			
			public void SetEnd_delivery_time(System.DateTime? value){
				this.end_delivery_time_ = value;
			}
			public byte? GetTransferring_type(){
				return this.transferring_type_;
			}
			
			public void SetTransferring_type(byte? value){
				this.transferring_type_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringDeliveryForPDA_args {
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? start_delivery_time_;
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? end_delivery_time_;
			
			///<summary>
			/// 调拨类型，1:大仓-门店；2:门店-门店；3:门店-大仓；4:大仓-大仓
			///</summary>
			
			private List<byte?> transferring_type_;
			
			///<summary>
			/// 分页默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页限制,默认20, 最大100
			///</summary>
			
			private int? page_size_;
			
			public System.DateTime? GetStart_delivery_time(){
				return this.start_delivery_time_;
			}
			
			public void SetStart_delivery_time(System.DateTime? value){
				this.start_delivery_time_ = value;
			}
			public System.DateTime? GetEnd_delivery_time(){
				return this.end_delivery_time_;
			}
			
			public void SetEnd_delivery_time(System.DateTime? value){
				this.end_delivery_time_ = value;
			}
			public List<byte?> GetTransferring_type(){
				return this.transferring_type_;
			}
			
			public void SetTransferring_type(List<byte?> value){
				this.transferring_type_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringDeliveryItem_args {
			
			///<summary>
			/// 中台调拨单号
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// 默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 默认20，最大100
			///</summary>
			
			private int? page_size_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrder_args {
			
			///<summary>
			/// 调拨类型，1:大仓-门店(铺货调拨)；2:门店-门店；3:门店-大仓
			///</summary>
			
			private byte? transferring_type_;
			
			///<summary>
			/// 查询时间段的开始时间，返回订单审核时间在此时间段内的结果
			///</summary>
			
			private System.DateTime? create_time_start_;
			
			///<summary>
			/// 查询时间段的结束时间，返回订单审核时间在此时间段内的结果
			///</summary>
			
			private System.DateTime? create_time_end_;
			
			///<summary>
			/// 页码
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 分页大小
			///</summary>
			
			private int? page_size_;
			
			///<summary>
			/// 0：未确认；1：已确认
			///</summary>
			
			private string confirm_status_;
			
			public byte? GetTransferring_type(){
				return this.transferring_type_;
			}
			
			public void SetTransferring_type(byte? value){
				this.transferring_type_ = value;
			}
			public System.DateTime? GetCreate_time_start(){
				return this.create_time_start_;
			}
			
			public void SetCreate_time_start(System.DateTime? value){
				this.create_time_start_ = value;
			}
			public System.DateTime? GetCreate_time_end(){
				return this.create_time_end_;
			}
			
			public void SetCreate_time_end(System.DateTime? value){
				this.create_time_end_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			public string GetConfirm_status(){
				return this.confirm_status_;
			}
			
			public void SetConfirm_status(string value){
				this.confirm_status_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrderForPDA_args {
			
			///<summary>
			/// 调拨类型，1:大仓-门店(铺货调拨)；2:门店-门店；3:门店-大仓
			///</summary>
			
			private List<byte?> transferring_types_;
			
			///<summary>
			/// 查询时间段的开始时间，返回订单审核时间在此时间段内的结果
			///</summary>
			
			private System.DateTime? create_time_start_;
			
			///<summary>
			/// 查询时间段的结束时间，返回订单审核时间在此时间段内的结果
			///</summary>
			
			private System.DateTime? create_time_end_;
			
			///<summary>
			/// 页码
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 分页大小
			///</summary>
			
			private int? page_size_;
			
			///<summary>
			/// 0：未确认；1：已确认
			///</summary>
			
			private string confirm_status_;
			
			public List<byte?> GetTransferring_types(){
				return this.transferring_types_;
			}
			
			public void SetTransferring_types(List<byte?> value){
				this.transferring_types_ = value;
			}
			public System.DateTime? GetCreate_time_start(){
				return this.create_time_start_;
			}
			
			public void SetCreate_time_start(System.DateTime? value){
				this.create_time_start_ = value;
			}
			public System.DateTime? GetCreate_time_end(){
				return this.create_time_end_;
			}
			
			public void SetCreate_time_end(System.DateTime? value){
				this.create_time_end_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			public string GetConfirm_status(){
				return this.confirm_status_;
			}
			
			public void SetConfirm_status(string value){
				this.confirm_status_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrderItem_args {
			
			///<summary>
			/// 中台单据编号
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// 页码 默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 默认20，最大100
			///</summary>
			
			private int? page_size_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringReceipt_args {
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? start_received_time_;
			
			///<summary>
			/// 按调拨单实际入库日期查询，仅查询调拨单完全入库的单据
			///</summary>
			
			private System.DateTime? end_received_time_;
			
			///<summary>
			/// 调拨类型，1:大仓-门店；2:门店-门店；3:门店-大仓
			///</summary>
			
			private int? transferring_type_;
			
			///<summary>
			/// 默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 默认20，最大100
			///</summary>
			
			private int? page_size_;
			
			public System.DateTime? GetStart_received_time(){
				return this.start_received_time_;
			}
			
			public void SetStart_received_time(System.DateTime? value){
				this.start_received_time_ = value;
			}
			public System.DateTime? GetEnd_received_time(){
				return this.end_received_time_;
			}
			
			public void SetEnd_received_time(System.DateTime? value){
				this.end_received_time_ = value;
			}
			public int? GetTransferring_type(){
				return this.transferring_type_;
			}
			
			public void SetTransferring_type(int? value){
				this.transferring_type_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringReceiptItem_args {
			
			///<summary>
			/// 中台调拨单号
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// 默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 默认20，最大100
			///</summary>
			
			private int? page_size_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchCancel_args {
			
			///<summary>
			/// 调拨批次号
			///</summary>
			
			private string batch_no_;
			
			public string GetBatch_no(){
				return this.batch_no_;
			}
			
			public void SetBatch_no(string value){
				this.batch_no_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchCreate_args {
			
			///<summary>
			/// 调拨单批次创建请求
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq req_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchEmpty_args {
			
			///<summary>
			/// 调拨批次号
			///</summary>
			
			private string batch_no_;
			
			public string GetBatch_no(){
				return this.batch_no_;
			}
			
			public void SetBatch_no(string value){
				this.batch_no_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchImportDetail_args {
			
			///<summary>
			/// 调拨单批次明细导入请求
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq req_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchSubmit_args {
			
			///<summary>
			/// 调拨批次号
			///</summary>
			
			private string batch_no_;
			
			public string GetBatch_no(){
				return this.batch_no_;
			}
			
			public void SetBatch_no(string value){
				this.batch_no_ = value;
			}
			
		}
		
		
		
		
		public class transferringOrderCancel_args {
			
			///<summary>
			/// 调拨单号
			///</summary>
			
			private string transferringOrderNo_;
			
			public string GetTransferringOrderNo(){
				return this.transferringOrderNo_;
			}
			
			public void SetTransferringOrderNo(string value){
				this.transferringOrderNo_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringItemQuantity_args {
			
			///<summary>
			/// 中台单据编号（WOP按erpOrderSn传入数据）
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// 实际发货时间（不支持分批出库）
			///</summary>
			
			private System.DateTime? delivery_date_;
			
			///<summary>
			/// 实际发货仓库代码
			///</summary>
			
			private string ship_warehouse_code_;
			
			///<summary>
			/// 实际发货明细
			///</summary>
			
			private List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> transferring_order_items_;
			
			///<summary>
			/// 承运商
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 承运商名称
			///</summary>
			
			private string carrier_name_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string transport_no_;
			
			///<summary>
			/// 总条数
			///</summary>
			
			private int? total_row_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public System.DateTime? GetDelivery_date(){
				return this.delivery_date_;
			}
			
			public void SetDelivery_date(System.DateTime? value){
				this.delivery_date_ = value;
			}
			public string GetShip_warehouse_code(){
				return this.ship_warehouse_code_;
			}
			
			public void SetShip_warehouse_code(string value){
				this.ship_warehouse_code_ = value;
			}
			public List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> GetTransferring_order_items(){
				return this.transferring_order_items_;
			}
			
			public void SetTransferring_order_items(List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> value){
				this.transferring_order_items_ = value;
			}
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public string GetCarrier_name(){
				return this.carrier_name_;
			}
			
			public void SetCarrier_name(string value){
				this.carrier_name_ = value;
			}
			public string GetTransport_no(){
				return this.transport_no_;
			}
			
			public void SetTransport_no(string value){
				this.transport_no_ = value;
			}
			public int? GetTotal_row(){
				return this.total_row_;
			}
			
			public void SetTotal_row(int? value){
				this.total_row_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringReceivedQuantity_args {
			
			///<summary>
			/// 中台单据编号
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// 实际收货时间（不支持分批入库）
			///</summary>
			
			private System.DateTime? received_date_;
			
			///<summary>
			/// 实际收货仓库代码
			///</summary>
			
			private string received_warehouse_code_;
			
			///<summary>
			/// 实际收货明细
			///</summary>
			
			private List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> transferring_order_received_;
			
			///<summary>
			/// 总条数
			///</summary>
			
			private int? total_row_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public System.DateTime? GetReceived_date(){
				return this.received_date_;
			}
			
			public void SetReceived_date(System.DateTime? value){
				this.received_date_ = value;
			}
			public string GetReceived_warehouse_code(){
				return this.received_warehouse_code_;
			}
			
			public void SetReceived_warehouse_code(string value){
				this.received_warehouse_code_ = value;
			}
			public List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> GetTransferring_order_received(){
				return this.transferring_order_received_;
			}
			
			public void SetTransferring_order_received(List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> value){
				this.transferring_order_received_ = value;
			}
			public int? GetTotal_row(){
				return this.total_row_;
			}
			
			public void SetTotal_row(int? value){
				this.total_row_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringWopReceivedQuantity_args {
			
			///<summary>
			/// 中台调拨单单据编号
			///</summary>
			
			private string transferring_order_no_;
			
			///<summary>
			/// WOP上抛批次号
			///</summary>
			
			private string batch_no_;
			
			///<summary>
			/// WOP上抛批次行数
			///</summary>
			
			private int? batch_line_count_;
			
			///<summary>
			/// 外部系统单据号(WOP PO系统号)
			///</summary>
			
			private string out_order_no_;
			
			///<summary>
			/// 实际收货仓库代码
			///</summary>
			
			private string received_warehouse_code_;
			
			///<summary>
			/// 实际收货日期，精确到秒
			///</summary>
			
			private System.DateTime? received_date_;
			
			///<summary>
			/// 商品收货明细
			///</summary>
			
			private List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> received_items_;
			
			///<summary>
			/// 总行数
			///</summary>
			
			private int? total_row_;
			
			public string GetTransferring_order_no(){
				return this.transferring_order_no_;
			}
			
			public void SetTransferring_order_no(string value){
				this.transferring_order_no_ = value;
			}
			public string GetBatch_no(){
				return this.batch_no_;
			}
			
			public void SetBatch_no(string value){
				this.batch_no_ = value;
			}
			public int? GetBatch_line_count(){
				return this.batch_line_count_;
			}
			
			public void SetBatch_line_count(int? value){
				this.batch_line_count_ = value;
			}
			public string GetOut_order_no(){
				return this.out_order_no_;
			}
			
			public void SetOut_order_no(string value){
				this.out_order_no_ = value;
			}
			public string GetReceived_warehouse_code(){
				return this.received_warehouse_code_;
			}
			
			public void SetReceived_warehouse_code(string value){
				this.received_warehouse_code_ = value;
			}
			public System.DateTime? GetReceived_date(){
				return this.received_date_;
			}
			
			public void SetReceived_date(System.DateTime? value){
				this.received_date_ = value;
			}
			public List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> GetReceived_items(){
				return this.received_items_;
			}
			
			public void SetReceived_items(List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> value){
				this.received_items_ = value;
			}
			public int? GetTotal_row(){
				return this.total_row_;
			}
			
			public void SetTotal_row(int? value){
				this.total_row_ = value;
			}
			
		}
		
		
		
		
		public class completeTransferringOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.CompleteOrderResponse success_;
			
			public vipapis.xstore.cc.transferring.api.CompleteOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.CompleteOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmTransferringDelivery_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes success_;
			
			public vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmTransferringOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult value){
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
		
		
		
		
		public class queryTransferringDelivery_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult success_;
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringDeliveryForPDA_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult success_;
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringDeliveryItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult success_;
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrderForPDA_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringOrderItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringReceipt_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult success_;
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryTransferringReceiptItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult success_;
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchCancel_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringBatchRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchCreate_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchEmpty_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringBatchRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchImportDetail_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringBatchSubmit_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class transferringOrderCancel_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes success_;
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringItemQuantity_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult success_;
			
			public vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringReceivedQuantity_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult success_;
			
			public vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateTransferringWopReceivedQuantity_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult success_;
			
			public vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class completeTransferringOrder_argsHelper : TBeanSerializer<completeTransferringOrder_args>
		{
			
			public static completeTransferringOrder_argsHelper OBJ = new completeTransferringOrder_argsHelper();
			
			public static completeTransferringOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(completeTransferringOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.CompleteOrderRequest value;
					
					value = new vipapis.xstore.cc.transferring.api.CompleteOrderRequest();
					vipapis.xstore.cc.transferring.api.CompleteOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(completeTransferringOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.xstore.cc.transferring.api.CompleteOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(completeTransferringOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmTransferringDelivery_argsHelper : TBeanSerializer<confirmTransferringDelivery_args>
		{
			
			public static confirmTransferringDelivery_argsHelper OBJ = new confirmTransferringDelivery_argsHelper();
			
			public static confirmTransferringDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmTransferringDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq value;
					
					value = new vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq();
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReqHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmTransferringDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReqHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmTransferringDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmTransferringOrder_argsHelper : TBeanSerializer<confirmTransferringOrder_args>
		{
			
			public static confirmTransferringOrder_argsHelper OBJ = new confirmTransferringOrder_argsHelper();
			
			public static confirmTransferringOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmTransferringOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> value;
					
					value = new List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery elem0;
							
							elem0 = new vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery();
							vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQueryHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetConfirm_transferring_order(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmTransferringOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetConfirm_transferring_order() != null) {
					
					oprot.WriteFieldBegin("confirm_transferring_order");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery _item0 in structs.GetConfirm_transferring_order()){
						
						
						vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQueryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("confirm_transferring_order can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmTransferringOrder_args bean){
				
				
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
		
		
		
		
		public class queryTransferringDelivery_argsHelper : TBeanSerializer<queryTransferringDelivery_args>
		{
			
			public static queryTransferringDelivery_argsHelper OBJ = new queryTransferringDelivery_argsHelper();
			
			public static queryTransferringDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetStart_delivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEnd_delivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					byte value;
					value = iprot.ReadByte(); 
					
					structs.SetTransferring_type(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStart_delivery_time() != null) {
					
					oprot.WriteFieldBegin("start_delivery_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_delivery_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("start_delivery_time can not be null!");
				}
				
				
				if(structs.GetEnd_delivery_time() != null) {
					
					oprot.WriteFieldBegin("end_delivery_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_delivery_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("end_delivery_time can not be null!");
				}
				
				
				if(structs.GetTransferring_type() != null) {
					
					oprot.WriteFieldBegin("transferring_type");
					oprot.WriteByte((byte)structs.GetTransferring_type()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_type can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringDeliveryForPDA_argsHelper : TBeanSerializer<queryTransferringDeliveryForPDA_args>
		{
			
			public static queryTransferringDeliveryForPDA_argsHelper OBJ = new queryTransferringDeliveryForPDA_argsHelper();
			
			public static queryTransferringDeliveryForPDA_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDeliveryForPDA_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetStart_delivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEnd_delivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					List<byte?> value;
					
					value = new List<byte?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							byte elem0;
							elem0 = iprot.ReadByte(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTransferring_type(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDeliveryForPDA_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStart_delivery_time() != null) {
					
					oprot.WriteFieldBegin("start_delivery_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_delivery_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("start_delivery_time can not be null!");
				}
				
				
				if(structs.GetEnd_delivery_time() != null) {
					
					oprot.WriteFieldBegin("end_delivery_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_delivery_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("end_delivery_time can not be null!");
				}
				
				
				if(structs.GetTransferring_type() != null) {
					
					oprot.WriteFieldBegin("transferring_type");
					
					oprot.WriteListBegin();
					foreach(byte _item0 in structs.GetTransferring_type()){
						
						oprot.WriteByte((byte)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_type can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDeliveryForPDA_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringDeliveryItem_argsHelper : TBeanSerializer<queryTransferringDeliveryItem_args>
		{
			
			public static queryTransferringDeliveryItem_argsHelper OBJ = new queryTransferringDeliveryItem_argsHelper();
			
			public static queryTransferringDeliveryItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDeliveryItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDeliveryItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_order_no can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDeliveryItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrder_argsHelper : TBeanSerializer<queryTransferringOrder_args>
		{
			
			public static queryTransferringOrder_argsHelper OBJ = new queryTransferringOrder_argsHelper();
			
			public static queryTransferringOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					byte? value;
					value = iprot.ReadByte(); 
					
					structs.SetTransferring_type(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetCreate_time_start(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetCreate_time_end(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetConfirm_status(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_type() != null) {
					
					oprot.WriteFieldBegin("transferring_type");
					oprot.WriteByte((byte)structs.GetTransferring_type()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_time_start() != null) {
					
					oprot.WriteFieldBegin("create_time_start");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time_start())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_time_end() != null) {
					
					oprot.WriteFieldBegin("create_time_end");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time_end())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetConfirm_status() != null) {
					
					oprot.WriteFieldBegin("confirm_status");
					oprot.WriteString(structs.GetConfirm_status());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("confirm_status can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrderForPDA_argsHelper : TBeanSerializer<queryTransferringOrderForPDA_args>
		{
			
			public static queryTransferringOrderForPDA_argsHelper OBJ = new queryTransferringOrderForPDA_argsHelper();
			
			public static queryTransferringOrderForPDA_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrderForPDA_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<byte?> value;
					
					value = new List<byte?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							byte elem0;
							elem0 = iprot.ReadByte(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTransferring_types(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetCreate_time_start(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetCreate_time_end(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetConfirm_status(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrderForPDA_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_types() != null) {
					
					oprot.WriteFieldBegin("transferring_types");
					
					oprot.WriteListBegin();
					foreach(byte _item0 in structs.GetTransferring_types()){
						
						oprot.WriteByte((byte)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_time_start() != null) {
					
					oprot.WriteFieldBegin("create_time_start");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time_start())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_time_end() != null) {
					
					oprot.WriteFieldBegin("create_time_end");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time_end())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetConfirm_status() != null) {
					
					oprot.WriteFieldBegin("confirm_status");
					oprot.WriteString(structs.GetConfirm_status());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("confirm_status can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrderForPDA_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrderItem_argsHelper : TBeanSerializer<queryTransferringOrderItem_args>
		{
			
			public static queryTransferringOrderItem_argsHelper OBJ = new queryTransferringOrderItem_argsHelper();
			
			public static queryTransferringOrderItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrderItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrderItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_order_no can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrderItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringReceipt_argsHelper : TBeanSerializer<queryTransferringReceipt_args>
		{
			
			public static queryTransferringReceipt_argsHelper OBJ = new queryTransferringReceipt_argsHelper();
			
			public static queryTransferringReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringReceipt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetStart_received_time(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEnd_received_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetTransferring_type(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStart_received_time() != null) {
					
					oprot.WriteFieldBegin("start_received_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_received_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("start_received_time can not be null!");
				}
				
				
				if(structs.GetEnd_received_time() != null) {
					
					oprot.WriteFieldBegin("end_received_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_received_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("end_received_time can not be null!");
				}
				
				
				if(structs.GetTransferring_type() != null) {
					
					oprot.WriteFieldBegin("transferring_type");
					oprot.WriteI32((int)structs.GetTransferring_type()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringReceiptItem_argsHelper : TBeanSerializer<queryTransferringReceiptItem_args>
		{
			
			public static queryTransferringReceiptItem_argsHelper OBJ = new queryTransferringReceiptItem_argsHelper();
			
			public static queryTransferringReceiptItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringReceiptItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringReceiptItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_order_no can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringReceiptItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchCancel_argsHelper : TBeanSerializer<transferringBatchCancel_args>
		{
			
			public static transferringBatchCancel_argsHelper OBJ = new transferringBatchCancel_argsHelper();
			
			public static transferringBatchCancel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchCancel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBatch_no(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchCancel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBatch_no() != null) {
					
					oprot.WriteFieldBegin("batch_no");
					oprot.WriteString(structs.GetBatch_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batch_no can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchCancel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchCreate_argsHelper : TBeanSerializer<transferringBatchCreate_args>
		{
			
			public static transferringBatchCreate_argsHelper OBJ = new transferringBatchCreate_argsHelper();
			
			public static transferringBatchCreate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchCreate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq();
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchCreate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchCreate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchEmpty_argsHelper : TBeanSerializer<transferringBatchEmpty_args>
		{
			
			public static transferringBatchEmpty_argsHelper OBJ = new transferringBatchEmpty_argsHelper();
			
			public static transferringBatchEmpty_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchEmpty_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBatch_no(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchEmpty_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBatch_no() != null) {
					
					oprot.WriteFieldBegin("batch_no");
					oprot.WriteString(structs.GetBatch_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batch_no can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchEmpty_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchImportDetail_argsHelper : TBeanSerializer<transferringBatchImportDetail_args>
		{
			
			public static transferringBatchImportDetail_argsHelper OBJ = new transferringBatchImportDetail_argsHelper();
			
			public static transferringBatchImportDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchImportDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq();
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchImportDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchImportDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchSubmit_argsHelper : TBeanSerializer<transferringBatchSubmit_args>
		{
			
			public static transferringBatchSubmit_argsHelper OBJ = new transferringBatchSubmit_argsHelper();
			
			public static transferringBatchSubmit_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchSubmit_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBatch_no(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchSubmit_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBatch_no() != null) {
					
					oprot.WriteFieldBegin("batch_no");
					oprot.WriteString(structs.GetBatch_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batch_no can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchSubmit_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringOrderCancel_argsHelper : TBeanSerializer<transferringOrderCancel_args>
		{
			
			public static transferringOrderCancel_argsHelper OBJ = new transferringOrderCancel_argsHelper();
			
			public static transferringOrderCancel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringOrderCancel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferringOrderNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringOrderCancel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferringOrderNo() != null) {
					
					oprot.WriteFieldBegin("transferringOrderNo");
					oprot.WriteString(structs.GetTransferringOrderNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferringOrderNo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringOrderCancel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringItemQuantity_argsHelper : TBeanSerializer<updateTransferringItemQuantity_args>
		{
			
			public static updateTransferringItemQuantity_argsHelper OBJ = new updateTransferringItemQuantity_argsHelper();
			
			public static updateTransferringItemQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringItemQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetDelivery_date(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetShip_warehouse_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> value;
					
					value = new List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel elem0;
							
							elem0 = new vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel();
							vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTransferring_order_items(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_name(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransport_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetTotal_row(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringItemQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDelivery_date() != null) {
					
					oprot.WriteFieldBegin("delivery_date");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDelivery_date())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetShip_warehouse_code() != null) {
					
					oprot.WriteFieldBegin("ship_warehouse_code");
					oprot.WriteString(structs.GetShip_warehouse_code());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTransferring_order_items() != null) {
					
					oprot.WriteFieldBegin("transferring_order_items");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel _item0 in structs.GetTransferring_order_items()){
						
						
						vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCarrier_name() != null) {
					
					oprot.WriteFieldBegin("carrier_name");
					oprot.WriteString(structs.GetCarrier_name());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTransport_no() != null) {
					
					oprot.WriteFieldBegin("transport_no");
					oprot.WriteString(structs.GetTransport_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTotal_row() != null) {
					
					oprot.WriteFieldBegin("total_row");
					oprot.WriteI32((int)structs.GetTotal_row()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringItemQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringReceivedQuantity_argsHelper : TBeanSerializer<updateTransferringReceivedQuantity_args>
		{
			
			public static updateTransferringReceivedQuantity_argsHelper OBJ = new updateTransferringReceivedQuantity_argsHelper();
			
			public static updateTransferringReceivedQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringReceivedQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetReceived_date(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReceived_warehouse_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> value;
					
					value = new List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel elem0;
							
							elem0 = new vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel();
							vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTransferring_order_received(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetTotal_row(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringReceivedQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetReceived_date() != null) {
					
					oprot.WriteFieldBegin("received_date");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetReceived_date())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetReceived_warehouse_code() != null) {
					
					oprot.WriteFieldBegin("received_warehouse_code");
					oprot.WriteString(structs.GetReceived_warehouse_code());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTransferring_order_received() != null) {
					
					oprot.WriteFieldBegin("transferring_order_received");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel _item0 in structs.GetTransferring_order_received()){
						
						
						vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTotal_row() != null) {
					
					oprot.WriteFieldBegin("total_row");
					oprot.WriteI32((int)structs.GetTotal_row()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringReceivedQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringWopReceivedQuantity_argsHelper : TBeanSerializer<updateTransferringWopReceivedQuantity_args>
		{
			
			public static updateTransferringWopReceivedQuantity_argsHelper OBJ = new updateTransferringWopReceivedQuantity_argsHelper();
			
			public static updateTransferringWopReceivedQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringWopReceivedQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransferring_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBatch_no(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetBatch_line_count(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOut_order_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetReceived_warehouse_code(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetReceived_date(value);
				}
				
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> value;
					
					value = new List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty elem0;
							
							elem0 = new vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty();
							vipapis.xstore.cc.transferring.api.TransferringWopReceivedQtyHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReceived_items(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetTotal_row(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringWopReceivedQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransferring_order_no() != null) {
					
					oprot.WriteFieldBegin("transferring_order_no");
					oprot.WriteString(structs.GetTransferring_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("transferring_order_no can not be null!");
				}
				
				
				if(structs.GetBatch_no() != null) {
					
					oprot.WriteFieldBegin("batch_no");
					oprot.WriteString(structs.GetBatch_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batch_no can not be null!");
				}
				
				
				if(structs.GetBatch_line_count() != null) {
					
					oprot.WriteFieldBegin("batch_line_count");
					oprot.WriteI32((int)structs.GetBatch_line_count()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batch_line_count can not be null!");
				}
				
				
				if(structs.GetOut_order_no() != null) {
					
					oprot.WriteFieldBegin("out_order_no");
					oprot.WriteString(structs.GetOut_order_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("out_order_no can not be null!");
				}
				
				
				if(structs.GetReceived_warehouse_code() != null) {
					
					oprot.WriteFieldBegin("received_warehouse_code");
					oprot.WriteString(structs.GetReceived_warehouse_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("received_warehouse_code can not be null!");
				}
				
				
				if(structs.GetReceived_date() != null) {
					
					oprot.WriteFieldBegin("received_date");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetReceived_date())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("received_date can not be null!");
				}
				
				
				if(structs.GetReceived_items() != null) {
					
					oprot.WriteFieldBegin("received_items");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty _item0 in structs.GetReceived_items()){
						
						
						vipapis.xstore.cc.transferring.api.TransferringWopReceivedQtyHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("received_items can not be null!");
				}
				
				
				if(structs.GetTotal_row() != null) {
					
					oprot.WriteFieldBegin("total_row");
					oprot.WriteI32((int)structs.GetTotal_row()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringWopReceivedQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class completeTransferringOrder_resultHelper : TBeanSerializer<completeTransferringOrder_result>
		{
			
			public static completeTransferringOrder_resultHelper OBJ = new completeTransferringOrder_resultHelper();
			
			public static completeTransferringOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(completeTransferringOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.CompleteOrderResponse value;
					
					value = new vipapis.xstore.cc.transferring.api.CompleteOrderResponse();
					vipapis.xstore.cc.transferring.api.CompleteOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(completeTransferringOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.CompleteOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(completeTransferringOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmTransferringDelivery_resultHelper : TBeanSerializer<confirmTransferringDelivery_result>
		{
			
			public static confirmTransferringDelivery_resultHelper OBJ = new confirmTransferringDelivery_resultHelper();
			
			public static confirmTransferringDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmTransferringDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes value;
					
					value = new vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes();
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmTransferringDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmTransferringDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmTransferringOrder_resultHelper : TBeanSerializer<confirmTransferringOrder_result>
		{
			
			public static confirmTransferringOrder_resultHelper OBJ = new confirmTransferringOrder_resultHelper();
			
			public static confirmTransferringOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmTransferringOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult();
					vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmTransferringOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmTransferringOrder_result bean){
				
				
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
		
		
		
		
		public class queryTransferringDelivery_resultHelper : TBeanSerializer<queryTransferringDelivery_result>
		{
			
			public static queryTransferringDelivery_resultHelper OBJ = new queryTransferringDelivery_resultHelper();
			
			public static queryTransferringDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult value;
					
					value = new vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult();
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringDeliveryForPDA_resultHelper : TBeanSerializer<queryTransferringDeliveryForPDA_result>
		{
			
			public static queryTransferringDeliveryForPDA_resultHelper OBJ = new queryTransferringDeliveryForPDA_resultHelper();
			
			public static queryTransferringDeliveryForPDA_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDeliveryForPDA_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult value;
					
					value = new vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult();
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDeliveryForPDA_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDeliveryForPDA_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringDeliveryItem_resultHelper : TBeanSerializer<queryTransferringDeliveryItem_result>
		{
			
			public static queryTransferringDeliveryItem_resultHelper OBJ = new queryTransferringDeliveryItem_resultHelper();
			
			public static queryTransferringDeliveryItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringDeliveryItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult value;
					
					value = new vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult();
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringDeliveryItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringDeliveryItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrder_resultHelper : TBeanSerializer<queryTransferringOrder_result>
		{
			
			public static queryTransferringOrder_resultHelper OBJ = new queryTransferringOrder_resultHelper();
			
			public static queryTransferringOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel();
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrderForPDA_resultHelper : TBeanSerializer<queryTransferringOrderForPDA_result>
		{
			
			public static queryTransferringOrderForPDA_resultHelper OBJ = new queryTransferringOrderForPDA_resultHelper();
			
			public static queryTransferringOrderForPDA_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrderForPDA_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel();
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrderForPDA_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrderForPDA_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringOrderItem_resultHelper : TBeanSerializer<queryTransferringOrderItem_result>
		{
			
			public static queryTransferringOrderItem_resultHelper OBJ = new queryTransferringOrderItem_resultHelper();
			
			public static queryTransferringOrderItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringOrderItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult();
					vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringOrderItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringOrderItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringReceipt_resultHelper : TBeanSerializer<queryTransferringReceipt_result>
		{
			
			public static queryTransferringReceipt_resultHelper OBJ = new queryTransferringReceipt_resultHelper();
			
			public static queryTransferringReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult value;
					
					value = new vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult();
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryTransferringReceiptItem_resultHelper : TBeanSerializer<queryTransferringReceiptItem_result>
		{
			
			public static queryTransferringReceiptItem_resultHelper OBJ = new queryTransferringReceiptItem_resultHelper();
			
			public static queryTransferringReceiptItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryTransferringReceiptItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult value;
					
					value = new vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult();
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryTransferringReceiptItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryTransferringReceiptItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchCancel_resultHelper : TBeanSerializer<transferringBatchCancel_result>
		{
			
			public static transferringBatchCancel_resultHelper OBJ = new transferringBatchCancel_resultHelper();
			
			public static transferringBatchCancel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchCancel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchRes();
					vipapis.xstore.cc.transferring.api.TransferringBatchResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchCancel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchCancel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchCreate_resultHelper : TBeanSerializer<transferringBatchCreate_result>
		{
			
			public static transferringBatchCreate_resultHelper OBJ = new transferringBatchCreate_resultHelper();
			
			public static transferringBatchCreate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchCreate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes();
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchCreate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchCreateResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchCreate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchEmpty_resultHelper : TBeanSerializer<transferringBatchEmpty_result>
		{
			
			public static transferringBatchEmpty_resultHelper OBJ = new transferringBatchEmpty_resultHelper();
			
			public static transferringBatchEmpty_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchEmpty_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchRes();
					vipapis.xstore.cc.transferring.api.TransferringBatchResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchEmpty_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchEmpty_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchImportDetail_resultHelper : TBeanSerializer<transferringBatchImportDetail_result>
		{
			
			public static transferringBatchImportDetail_resultHelper OBJ = new transferringBatchImportDetail_resultHelper();
			
			public static transferringBatchImportDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchImportDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes();
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchImportDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchImportDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringBatchSubmit_resultHelper : TBeanSerializer<transferringBatchSubmit_result>
		{
			
			public static transferringBatchSubmit_resultHelper OBJ = new transferringBatchSubmit_resultHelper();
			
			public static transferringBatchSubmit_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringBatchSubmit_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes();
					vipapis.xstore.cc.transferring.api.TransferringBatchSubmitResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringBatchSubmit_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringBatchSubmitResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringBatchSubmit_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class transferringOrderCancel_resultHelper : TBeanSerializer<transferringOrderCancel_result>
		{
			
			public static transferringOrderCancel_resultHelper OBJ = new transferringOrderCancel_resultHelper();
			
			public static transferringOrderCancel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(transferringOrderCancel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes value;
					
					value = new vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes();
					vipapis.xstore.cc.transferring.api.TransferringOrderCancelResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(transferringOrderCancel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.TransferringOrderCancelResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(transferringOrderCancel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringItemQuantity_resultHelper : TBeanSerializer<updateTransferringItemQuantity_result>
		{
			
			public static updateTransferringItemQuantity_resultHelper OBJ = new updateTransferringItemQuantity_resultHelper();
			
			public static updateTransferringItemQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringItemQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult value;
					
					value = new vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult();
					vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringItemQuantity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringItemQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringReceivedQuantity_resultHelper : TBeanSerializer<updateTransferringReceivedQuantity_result>
		{
			
			public static updateTransferringReceivedQuantity_resultHelper OBJ = new updateTransferringReceivedQuantity_resultHelper();
			
			public static updateTransferringReceivedQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringReceivedQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult value;
					
					value = new vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult();
					vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringReceivedQuantity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringReceivedQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateTransferringWopReceivedQuantity_resultHelper : TBeanSerializer<updateTransferringWopReceivedQuantity_result>
		{
			
			public static updateTransferringWopReceivedQuantity_resultHelper OBJ = new updateTransferringWopReceivedQuantity_resultHelper();
			
			public static updateTransferringWopReceivedQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTransferringWopReceivedQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult value;
					
					value = new vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult();
					vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTransferringWopReceivedQuantity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTransferringWopReceivedQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class TransferringOrderApiServiceClient : OspRestStub , TransferringOrderApiService  {
			
			
			public TransferringOrderApiServiceClient():base("vipapis.xstore.cc.transferring.api.TransferringOrderApiService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.xstore.cc.transferring.api.CompleteOrderResponse completeTransferringOrder(vipapis.xstore.cc.transferring.api.CompleteOrderRequest request_) {
				
				send_completeTransferringOrder(request_);
				return recv_completeTransferringOrder(); 
				
			}
			
			
			private void send_completeTransferringOrder(vipapis.xstore.cc.transferring.api.CompleteOrderRequest request_){
				
				InitInvocation("completeTransferringOrder");
				
				completeTransferringOrder_args args = new completeTransferringOrder_args();
				args.SetRequest(request_);
				
				SendBase(args, completeTransferringOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.CompleteOrderResponse recv_completeTransferringOrder(){
				
				completeTransferringOrder_result result = new completeTransferringOrder_result();
				ReceiveBase(result, completeTransferringOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes confirmTransferringDelivery(vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq request_) {
				
				send_confirmTransferringDelivery(request_);
				return recv_confirmTransferringDelivery(); 
				
			}
			
			
			private void send_confirmTransferringDelivery(vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryReq request_){
				
				InitInvocation("confirmTransferringDelivery");
				
				confirmTransferringDelivery_args args = new confirmTransferringDelivery_args();
				args.SetRequest(request_);
				
				SendBase(args, confirmTransferringDelivery_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.ConfirmTransferringDeliveryRes recv_confirmTransferringDelivery(){
				
				confirmTransferringDelivery_result result = new confirmTransferringDelivery_result();
				ReceiveBase(result, confirmTransferringDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult confirmTransferringOrder(List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> confirm_transferring_order_) {
				
				send_confirmTransferringOrder(confirm_transferring_order_);
				return recv_confirmTransferringOrder(); 
				
			}
			
			
			private void send_confirmTransferringOrder(List<vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmQuery> confirm_transferring_order_){
				
				InitInvocation("confirmTransferringOrder");
				
				confirmTransferringOrder_args args = new confirmTransferringOrder_args();
				args.SetConfirm_transferring_order(confirm_transferring_order_);
				
				SendBase(args, confirmTransferringOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiConfirmResult recv_confirmTransferringOrder(){
				
				confirmTransferringOrder_result result = new confirmTransferringOrder_result();
				ReceiveBase(result, confirmTransferringOrder_resultHelper.getInstance());
				
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
			
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult queryTransferringDelivery(System.DateTime start_delivery_time_,System.DateTime end_delivery_time_,byte transferring_type_,int? page_,int? page_size_) {
				
				send_queryTransferringDelivery(start_delivery_time_,end_delivery_time_,transferring_type_,page_,page_size_);
				return recv_queryTransferringDelivery(); 
				
			}
			
			
			private void send_queryTransferringDelivery(System.DateTime start_delivery_time_,System.DateTime end_delivery_time_,byte transferring_type_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringDelivery");
				
				queryTransferringDelivery_args args = new queryTransferringDelivery_args();
				args.SetStart_delivery_time(start_delivery_time_);
				args.SetEnd_delivery_time(end_delivery_time_);
				args.SetTransferring_type(transferring_type_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringDelivery_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult recv_queryTransferringDelivery(){
				
				queryTransferringDelivery_result result = new queryTransferringDelivery_result();
				ReceiveBase(result, queryTransferringDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult queryTransferringDeliveryForPDA(System.DateTime start_delivery_time_,System.DateTime end_delivery_time_,List<byte?> transferring_type_,int? page_,int? page_size_) {
				
				send_queryTransferringDeliveryForPDA(start_delivery_time_,end_delivery_time_,transferring_type_,page_,page_size_);
				return recv_queryTransferringDeliveryForPDA(); 
				
			}
			
			
			private void send_queryTransferringDeliveryForPDA(System.DateTime start_delivery_time_,System.DateTime end_delivery_time_,List<byte?> transferring_type_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringDeliveryForPDA");
				
				queryTransferringDeliveryForPDA_args args = new queryTransferringDeliveryForPDA_args();
				args.SetStart_delivery_time(start_delivery_time_);
				args.SetEnd_delivery_time(end_delivery_time_);
				args.SetTransferring_type(transferring_type_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringDeliveryForPDA_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryResult recv_queryTransferringDeliveryForPDA(){
				
				queryTransferringDeliveryForPDA_result result = new queryTransferringDeliveryForPDA_result();
				ReceiveBase(result, queryTransferringDeliveryForPDA_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult queryTransferringDeliveryItem(string transferring_order_no_,int? page_,int? page_size_) {
				
				send_queryTransferringDeliveryItem(transferring_order_no_,page_,page_size_);
				return recv_queryTransferringDeliveryItem(); 
				
			}
			
			
			private void send_queryTransferringDeliveryItem(string transferring_order_no_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringDeliveryItem");
				
				queryTransferringDeliveryItem_args args = new queryTransferringDeliveryItem_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringDeliveryItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringDeliveryItemResult recv_queryTransferringDeliveryItem(){
				
				queryTransferringDeliveryItem_result result = new queryTransferringDeliveryItem_result();
				ReceiveBase(result, queryTransferringDeliveryItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel queryTransferringOrder(byte? transferring_type_,System.DateTime? create_time_start_,System.DateTime? create_time_end_,int? page_,int? page_size_,string confirm_status_) {
				
				send_queryTransferringOrder(transferring_type_,create_time_start_,create_time_end_,page_,page_size_,confirm_status_);
				return recv_queryTransferringOrder(); 
				
			}
			
			
			private void send_queryTransferringOrder(byte? transferring_type_,System.DateTime? create_time_start_,System.DateTime? create_time_end_,int? page_,int? page_size_,string confirm_status_){
				
				InitInvocation("queryTransferringOrder");
				
				queryTransferringOrder_args args = new queryTransferringOrder_args();
				args.SetTransferring_type(transferring_type_);
				args.SetCreate_time_start(create_time_start_);
				args.SetCreate_time_end(create_time_end_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				args.SetConfirm_status(confirm_status_);
				
				SendBase(args, queryTransferringOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel recv_queryTransferringOrder(){
				
				queryTransferringOrder_result result = new queryTransferringOrder_result();
				ReceiveBase(result, queryTransferringOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel queryTransferringOrderForPDA(List<byte?> transferring_types_,System.DateTime? create_time_start_,System.DateTime? create_time_end_,int? page_,int? page_size_,string confirm_status_) {
				
				send_queryTransferringOrderForPDA(transferring_types_,create_time_start_,create_time_end_,page_,page_size_,confirm_status_);
				return recv_queryTransferringOrderForPDA(); 
				
			}
			
			
			private void send_queryTransferringOrderForPDA(List<byte?> transferring_types_,System.DateTime? create_time_start_,System.DateTime? create_time_end_,int? page_,int? page_size_,string confirm_status_){
				
				InitInvocation("queryTransferringOrderForPDA");
				
				queryTransferringOrderForPDA_args args = new queryTransferringOrderForPDA_args();
				args.SetTransferring_types(transferring_types_);
				args.SetCreate_time_start(create_time_start_);
				args.SetCreate_time_end(create_time_end_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				args.SetConfirm_status(confirm_status_);
				
				SendBase(args, queryTransferringOrderForPDA_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderApiResultModel recv_queryTransferringOrderForPDA(){
				
				queryTransferringOrderForPDA_result result = new queryTransferringOrderForPDA_result();
				ReceiveBase(result, queryTransferringOrderForPDA_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult queryTransferringOrderItem(string transferring_order_no_,int? page_,int? page_size_) {
				
				send_queryTransferringOrderItem(transferring_order_no_,page_,page_size_);
				return recv_queryTransferringOrderItem(); 
				
			}
			
			
			private void send_queryTransferringOrderItem(string transferring_order_no_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringOrderItem");
				
				queryTransferringOrderItem_args args = new queryTransferringOrderItem_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringOrderItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderItemApiResult recv_queryTransferringOrderItem(){
				
				queryTransferringOrderItem_result result = new queryTransferringOrderItem_result();
				ReceiveBase(result, queryTransferringOrderItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult queryTransferringReceipt(System.DateTime start_received_time_,System.DateTime end_received_time_,int? transferring_type_,int? page_,int? page_size_) {
				
				send_queryTransferringReceipt(start_received_time_,end_received_time_,transferring_type_,page_,page_size_);
				return recv_queryTransferringReceipt(); 
				
			}
			
			
			private void send_queryTransferringReceipt(System.DateTime start_received_time_,System.DateTime end_received_time_,int? transferring_type_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringReceipt");
				
				queryTransferringReceipt_args args = new queryTransferringReceipt_args();
				args.SetStart_received_time(start_received_time_);
				args.SetEnd_received_time(end_received_time_);
				args.SetTransferring_type(transferring_type_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringReceipt_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringReceiptResult recv_queryTransferringReceipt(){
				
				queryTransferringReceipt_result result = new queryTransferringReceipt_result();
				ReceiveBase(result, queryTransferringReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult queryTransferringReceiptItem(string transferring_order_no_,int? page_,int? page_size_) {
				
				send_queryTransferringReceiptItem(transferring_order_no_,page_,page_size_);
				return recv_queryTransferringReceiptItem(); 
				
			}
			
			
			private void send_queryTransferringReceiptItem(string transferring_order_no_,int? page_,int? page_size_){
				
				InitInvocation("queryTransferringReceiptItem");
				
				queryTransferringReceiptItem_args args = new queryTransferringReceiptItem_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, queryTransferringReceiptItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.QueryTransferringReceiptItemResult recv_queryTransferringReceiptItem(){
				
				queryTransferringReceiptItem_result result = new queryTransferringReceiptItem_result();
				ReceiveBase(result, queryTransferringReceiptItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchRes transferringBatchCancel(string batch_no_) {
				
				send_transferringBatchCancel(batch_no_);
				return recv_transferringBatchCancel(); 
				
			}
			
			
			private void send_transferringBatchCancel(string batch_no_){
				
				InitInvocation("transferringBatchCancel");
				
				transferringBatchCancel_args args = new transferringBatchCancel_args();
				args.SetBatch_no(batch_no_);
				
				SendBase(args, transferringBatchCancel_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchRes recv_transferringBatchCancel(){
				
				transferringBatchCancel_result result = new transferringBatchCancel_result();
				ReceiveBase(result, transferringBatchCancel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes transferringBatchCreate(vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq req_) {
				
				send_transferringBatchCreate(req_);
				return recv_transferringBatchCreate(); 
				
			}
			
			
			private void send_transferringBatchCreate(vipapis.xstore.cc.transferring.api.TransferringBatchCreateReq req_){
				
				InitInvocation("transferringBatchCreate");
				
				transferringBatchCreate_args args = new transferringBatchCreate_args();
				args.SetReq(req_);
				
				SendBase(args, transferringBatchCreate_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchCreateRes recv_transferringBatchCreate(){
				
				transferringBatchCreate_result result = new transferringBatchCreate_result();
				ReceiveBase(result, transferringBatchCreate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchRes transferringBatchEmpty(string batch_no_) {
				
				send_transferringBatchEmpty(batch_no_);
				return recv_transferringBatchEmpty(); 
				
			}
			
			
			private void send_transferringBatchEmpty(string batch_no_){
				
				InitInvocation("transferringBatchEmpty");
				
				transferringBatchEmpty_args args = new transferringBatchEmpty_args();
				args.SetBatch_no(batch_no_);
				
				SendBase(args, transferringBatchEmpty_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchRes recv_transferringBatchEmpty(){
				
				transferringBatchEmpty_result result = new transferringBatchEmpty_result();
				ReceiveBase(result, transferringBatchEmpty_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes transferringBatchImportDetail(vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq req_) {
				
				send_transferringBatchImportDetail(req_);
				return recv_transferringBatchImportDetail(); 
				
			}
			
			
			private void send_transferringBatchImportDetail(vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailReq req_){
				
				InitInvocation("transferringBatchImportDetail");
				
				transferringBatchImportDetail_args args = new transferringBatchImportDetail_args();
				args.SetReq(req_);
				
				SendBase(args, transferringBatchImportDetail_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchImportDetailRes recv_transferringBatchImportDetail(){
				
				transferringBatchImportDetail_result result = new transferringBatchImportDetail_result();
				ReceiveBase(result, transferringBatchImportDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes transferringBatchSubmit(string batch_no_) {
				
				send_transferringBatchSubmit(batch_no_);
				return recv_transferringBatchSubmit(); 
				
			}
			
			
			private void send_transferringBatchSubmit(string batch_no_){
				
				InitInvocation("transferringBatchSubmit");
				
				transferringBatchSubmit_args args = new transferringBatchSubmit_args();
				args.SetBatch_no(batch_no_);
				
				SendBase(args, transferringBatchSubmit_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringBatchSubmitRes recv_transferringBatchSubmit(){
				
				transferringBatchSubmit_result result = new transferringBatchSubmit_result();
				ReceiveBase(result, transferringBatchSubmit_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes transferringOrderCancel(string transferringOrderNo_) {
				
				send_transferringOrderCancel(transferringOrderNo_);
				return recv_transferringOrderCancel(); 
				
			}
			
			
			private void send_transferringOrderCancel(string transferringOrderNo_){
				
				InitInvocation("transferringOrderCancel");
				
				transferringOrderCancel_args args = new transferringOrderCancel_args();
				args.SetTransferringOrderNo(transferringOrderNo_);
				
				SendBase(args, transferringOrderCancel_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.TransferringOrderCancelRes recv_transferringOrderCancel(){
				
				transferringOrderCancel_result result = new transferringOrderCancel_result();
				ReceiveBase(result, transferringOrderCancel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult updateTransferringItemQuantity(string transferring_order_no_,System.DateTime? delivery_date_,string ship_warehouse_code_,List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> transferring_order_items_,string carrier_code_,string carrier_name_,string transport_no_,int? total_row_) {
				
				send_updateTransferringItemQuantity(transferring_order_no_,delivery_date_,ship_warehouse_code_,transferring_order_items_,carrier_code_,carrier_name_,transport_no_,total_row_);
				return recv_updateTransferringItemQuantity(); 
				
			}
			
			
			private void send_updateTransferringItemQuantity(string transferring_order_no_,System.DateTime? delivery_date_,string ship_warehouse_code_,List<vipapis.xstore.cc.transferring.api.UpdateTransOrderItemApiModel> transferring_order_items_,string carrier_code_,string carrier_name_,string transport_no_,int? total_row_){
				
				InitInvocation("updateTransferringItemQuantity");
				
				updateTransferringItemQuantity_args args = new updateTransferringItemQuantity_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetDelivery_date(delivery_date_);
				args.SetShip_warehouse_code(ship_warehouse_code_);
				args.SetTransferring_order_items(transferring_order_items_);
				args.SetCarrier_code(carrier_code_);
				args.SetCarrier_name(carrier_name_);
				args.SetTransport_no(transport_no_);
				args.SetTotal_row(total_row_);
				
				SendBase(args, updateTransferringItemQuantity_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.UpdateTransItemQtyApiResult recv_updateTransferringItemQuantity(){
				
				updateTransferringItemQuantity_result result = new updateTransferringItemQuantity_result();
				ReceiveBase(result, updateTransferringItemQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult updateTransferringReceivedQuantity(string transferring_order_no_,System.DateTime? received_date_,string received_warehouse_code_,List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> transferring_order_received_,int? total_row_) {
				
				send_updateTransferringReceivedQuantity(transferring_order_no_,received_date_,received_warehouse_code_,transferring_order_received_,total_row_);
				return recv_updateTransferringReceivedQuantity(); 
				
			}
			
			
			private void send_updateTransferringReceivedQuantity(string transferring_order_no_,System.DateTime? received_date_,string received_warehouse_code_,List<vipapis.xstore.cc.transferring.api.UpdateTransferringOrderReceivedApiModel> transferring_order_received_,int? total_row_){
				
				InitInvocation("updateTransferringReceivedQuantity");
				
				updateTransferringReceivedQuantity_args args = new updateTransferringReceivedQuantity_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetReceived_date(received_date_);
				args.SetReceived_warehouse_code(received_warehouse_code_);
				args.SetTransferring_order_received(transferring_order_received_);
				args.SetTotal_row(total_row_);
				
				SendBase(args, updateTransferringReceivedQuantity_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiResult recv_updateTransferringReceivedQuantity(){
				
				updateTransferringReceivedQuantity_result result = new updateTransferringReceivedQuantity_result();
				ReceiveBase(result, updateTransferringReceivedQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult updateTransferringWopReceivedQuantity(string transferring_order_no_,string batch_no_,int batch_line_count_,string out_order_no_,string received_warehouse_code_,System.DateTime received_date_,List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> received_items_,int? total_row_) {
				
				send_updateTransferringWopReceivedQuantity(transferring_order_no_,batch_no_,batch_line_count_,out_order_no_,received_warehouse_code_,received_date_,received_items_,total_row_);
				return recv_updateTransferringWopReceivedQuantity(); 
				
			}
			
			
			private void send_updateTransferringWopReceivedQuantity(string transferring_order_no_,string batch_no_,int batch_line_count_,string out_order_no_,string received_warehouse_code_,System.DateTime received_date_,List<vipapis.xstore.cc.transferring.api.TransferringWopReceivedQty> received_items_,int? total_row_){
				
				InitInvocation("updateTransferringWopReceivedQuantity");
				
				updateTransferringWopReceivedQuantity_args args = new updateTransferringWopReceivedQuantity_args();
				args.SetTransferring_order_no(transferring_order_no_);
				args.SetBatch_no(batch_no_);
				args.SetBatch_line_count(batch_line_count_);
				args.SetOut_order_no(out_order_no_);
				args.SetReceived_warehouse_code(received_warehouse_code_);
				args.SetReceived_date(received_date_);
				args.SetReceived_items(received_items_);
				args.SetTotal_row(total_row_);
				
				SendBase(args, updateTransferringWopReceivedQuantity_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.transferring.api.UpdateTransferringWopReceivedQuantityResult recv_updateTransferringWopReceivedQuantity(){
				
				updateTransferringWopReceivedQuantity_result result = new updateTransferringWopReceivedQuantity_result();
				ReceiveBase(result, updateTransferringWopReceivedQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}