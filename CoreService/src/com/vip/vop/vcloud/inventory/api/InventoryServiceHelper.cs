using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	public class InventoryServiceHelper {
		
		
		
		public class batchForceHoldChannelInventory_args {
			
			///<summary>
			/// 批量占用渠道库存请求
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value){
				this.reqList_ = value;
			}
			
		}
		
		
		
		
		public class batchForceHoldOneWarehouseInventory_args {
			
			///<summary>
			/// 指定仓库强制预占库存请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold holdReq_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold GetHoldReq(){
				return this.holdReq_;
			}
			
			public void SetHoldReq(com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold value){
				this.holdReq_ = value;
			}
			
		}
		
		
		
		
		public class batchFullUpdateChannelSkuInventory_args {
			
			///<summary>
			/// 请求列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> value){
				this.reqList_ = value;
			}
			
		}
		
		
		
		
		public class batchFullUpdateWarehouseSkuInventory_args {
			
			///<summary>
			/// 请求列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_;
			
			///<summary>
			/// 数据源, 0:调整单, 1: 订单发货, 2:ERP同步
			///</summary>
			
			private int? source_;
			
			public List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> value){
				this.reqList_ = value;
			}
			public int? GetSource(){
				return this.source_;
			}
			
			public void SetSource(int? value){
				this.source_ = value;
			}
			
		}
		
		
		
		
		public class batchHoldChannelInventory_args {
			
			///<summary>
			/// 批量占用渠道库存请求
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value){
				this.reqList_ = value;
			}
			
		}
		
		
		
		
		public class batchHoldOneWarehouseInventory_args {
			
			///<summary>
			/// 占用仓库库存请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold holdReq_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold GetHoldReq(){
				return this.holdReq_;
			}
			
			public void SetHoldReq(com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold value){
				this.holdReq_ = value;
			}
			
		}
		
		
		
		
		public class batchIncrUpdateChannelSkuInventory_args {
			
			///<summary>
			/// 请求列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> value){
				this.reqList_ = value;
			}
			
		}
		
		
		
		
		public class batchIncrUpdateWarehouseSkuInventory_args {
			
			///<summary>
			/// 请求列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_;
			
			///<summary>
			/// 数据源, 0:调整单, 1: 订单发货, 2:ERP同步
			///</summary>
			
			private int? source_;
			
			public List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> value){
				this.reqList_ = value;
			}
			public int? GetSource(){
				return this.source_;
			}
			
			public void SetSource(int? value){
				this.source_ = value;
			}
			
		}
		
		
		
		
		public class batchReleaseChannelHold_args {
			
			///<summary>
			/// 批量释放渠道库存请求
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> reqList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> GetReqList(){
				return this.reqList_;
			}
			
			public void SetReqList(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> value){
				this.reqList_ = value;
			}
			
		}
		
		
		
		
		public class fullUpdateChannelSkuInventory_args {
			
			///<summary>
			/// 流水号
			///</summary>
			
			private string transId_;
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 库存数量
			///</summary>
			
			private int? quantity_;
			
			public string GetTransId(){
				return this.transId_;
			}
			
			public void SetTransId(string value){
				this.transId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetQuantity(){
				return this.quantity_;
			}
			
			public void SetQuantity(int? value){
				this.quantity_ = value;
			}
			
		}
		
		
		
		
		public class fullUpdateWarehouseSkuInventory_args {
			
			///<summary>
			/// 流水号
			///</summary>
			
			private string transId_;
			
			///<summary>
			/// 仓库id
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 库存数量
			///</summary>
			
			private int? quantity_;
			
			///<summary>
			/// 数据源, 0:调整单, 1: 订单发货, 2:ERP同步
			///</summary>
			
			private int? source_;
			
			public string GetTransId(){
				return this.transId_;
			}
			
			public void SetTransId(string value){
				this.transId_ = value;
			}
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetQuantity(){
				return this.quantity_;
			}
			
			public void SetQuantity(int? value){
				this.quantity_ = value;
			}
			public int? GetSource(){
				return this.source_;
			}
			
			public void SetSource(int? value){
				this.source_ = value;
			}
			
		}
		
		
		
		
		public class getChannelSkuInventory_args {
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			
		}
		
		
		
		
		public class getSumChannelQuantity_args {
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class getSumWarehouseQuantity_args {
			
			///<summary>
			/// 仓库id
			///</summary>
			
			private long? warehouseId_;
			
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			
		}
		
		
		
		
		public class getWarehouseSkuInventory_args {
			
			///<summary>
			/// 仓库id
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class holdChannelInventory_args {
			
			///<summary>
			/// 占用渠道库存请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_;
			
			public com.vip.vop.vcloud.inventory.api.ChannelInventoryHold GetHoldReq(){
				return this.holdReq_;
			}
			
			public void SetHoldReq(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold value){
				this.holdReq_ = value;
			}
			
		}
		
		
		
		
		public class holdForceChannelInventory_args {
			
			///<summary>
			/// 占用渠道库存请求结构体
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_;
			
			public com.vip.vop.vcloud.inventory.api.ChannelInventoryHold GetHoldReq(){
				return this.holdReq_;
			}
			
			public void SetHoldReq(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold value){
				this.holdReq_ = value;
			}
			
		}
		
		
		
		
		public class incrUpdateChannelSkuInventory_args {
			
			///<summary>
			/// 流水号
			///</summary>
			
			private string transId_;
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 库存数量
			///</summary>
			
			private int? quantity_;
			
			public string GetTransId(){
				return this.transId_;
			}
			
			public void SetTransId(string value){
				this.transId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetQuantity(){
				return this.quantity_;
			}
			
			public void SetQuantity(int? value){
				this.quantity_ = value;
			}
			
		}
		
		
		
		
		public class incrUpdateWarehouseSkuInventory_args {
			
			///<summary>
			/// 流水号
			///</summary>
			
			private string transId_;
			
			///<summary>
			/// 渠道id
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 库存数量
			///</summary>
			
			private int? quantity_;
			
			///<summary>
			/// 数据源, 0:调整单, 1: 订单发货, 2:ERP同步
			///</summary>
			
			private int? source_;
			
			public string GetTransId(){
				return this.transId_;
			}
			
			public void SetTransId(string value){
				this.transId_ = value;
			}
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetQuantity(){
				return this.quantity_;
			}
			
			public void SetQuantity(int? value){
				this.quantity_ = value;
			}
			public int? GetSource(){
				return this.source_;
			}
			
			public void SetSource(int? value){
				this.source_ = value;
			}
			
		}
		
		
		
		
		public class listByWarehouseInventoryLogQueryCriteria_args {
			
			///<summary>
			/// 查询条件
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria criteria_;
			
			///<summary>
			/// 分页结构体
			///</summary>
			
			private com.vip.vop.vcloud.common.api.Pagination pagination_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria GetCriteria(){
				return this.criteria_;
			}
			
			public void SetCriteria(com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria value){
				this.criteria_ = value;
			}
			public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
				return this.pagination_;
			}
			
			public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
				this.pagination_ = value;
			}
			
		}
		
		
		
		
		public class listChannelSkuInventory_args {
			
			///<summary>
			/// sku列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelSku> skuList_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelSku> GetSkuList(){
				return this.skuList_;
			}
			
			public void SetSkuList(List<com.vip.vop.vcloud.inventory.api.ChannelSku> value){
				this.skuList_ = value;
			}
			
		}
		
		
		
		
		public class listChannelSkuInventoryByChannelId_args {
			
			///<summary>
			/// 仓库id
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 分页结构体
			///</summary>
			
			private com.vip.vop.vcloud.common.api.Pagination pagination_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
				return this.pagination_;
			}
			
			public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
				this.pagination_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseSkuInventory_args {
			
			///<summary>
			/// sku 列表
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.WarehouseSku> skuList_;
			
			public List<com.vip.vop.vcloud.inventory.api.WarehouseSku> GetSkuList(){
				return this.skuList_;
			}
			
			public void SetSkuList(List<com.vip.vop.vcloud.inventory.api.WarehouseSku> value){
				this.skuList_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseSkuInventoryByWarehouseId_args {
			
			///<summary>
			/// 仓库id
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// 分页结构体
			///</summary>
			
			private com.vip.vop.vcloud.common.api.Pagination pagination_;
			
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
				return this.pagination_;
			}
			
			public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
				this.pagination_ = value;
			}
			
		}
		
		
		
		
		public class releaseChannelHold_args {
			
			///<summary>
			/// 释放渠道库存请求
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease releaseReq_;
			
			public com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease GetReleaseReq(){
				return this.releaseReq_;
			}
			
			public void SetReleaseReq(com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease value){
				this.releaseReq_ = value;
			}
			
		}
		
		
		
		
		public class setWarehouseSkuDisabled_args {
			
			///<summary>
			/// 仓库ID
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 是否停售仓库SKU，0=启售，1=停售
			///</summary>
			
			private int? disabled_;
			
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetDisabled(){
				return this.disabled_;
			}
			
			public void SetDisabled(int? value){
				this.disabled_ = value;
			}
			
		}
		
		
		
		
		public class setWarehouseSkuSafeQuantity_args {
			
			///<summary>
			/// 仓库ID
			///</summary>
			
			private long? warehouseId_;
			
			///<summary>
			/// sku id
			///</summary>
			
			private long? skuId_;
			
			///<summary>
			/// 安全库存数量
			///</summary>
			
			private int? safeQuantity_;
			
			public long? GetWarehouseId(){
				return this.warehouseId_;
			}
			
			public void SetWarehouseId(long? value){
				this.warehouseId_ = value;
			}
			public long? GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(long? value){
				this.skuId_ = value;
			}
			public int? GetSafeQuantity(){
				return this.safeQuantity_;
			}
			
			public void SetSafeQuantity(int? value){
				this.safeQuantity_ = value;
			}
			
		}
		
		
		
		
		public class updateInventory_args {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest request_;
			
			public com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class batchForceHoldChannelInventory_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> success_;
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchForceHoldOneWarehouseInventory_result {
			
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
		
		
		
		
		public class batchFullUpdateChannelSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.UpdateResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchFullUpdateWarehouseSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.UpdateResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchHoldChannelInventory_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> success_;
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchHoldOneWarehouseInventory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.warehouse.api.Warehouse success_;
			
			public com.vip.vop.vcloud.warehouse.api.Warehouse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.warehouse.api.Warehouse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchIncrUpdateChannelSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.UpdateResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchIncrUpdateWarehouseSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.UpdateResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchReleaseChannelHold_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> success_;
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class fullUpdateChannelSkuInventory_result {
			
			
		}
		
		
		
		
		public class fullUpdateWarehouseSkuInventory_result {
			
			
		}
		
		
		
		
		public class getChannelSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.ChannelSkuInventory success_;
			
			public com.vip.vop.vcloud.inventory.api.ChannelSkuInventory GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.inventory.api.ChannelSkuInventory value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSumChannelQuantity_result {
			
			///<summary>
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSumWarehouseQuantity_result {
			
			///<summary>
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getWarehouseSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory success_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory value){
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
		
		
		
		
		public class holdChannelInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class holdForceChannelInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class incrUpdateChannelSkuInventory_result {
			
			
		}
		
		
		
		
		public class incrUpdateWarehouseSkuInventory_result {
			
			
		}
		
		
		
		
		public class listByWarehouseInventoryLogQueryCriteria_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult success_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listChannelSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listChannelSkuInventoryByChannelId_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult success_;
			
			public com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listWarehouseSkuInventoryByWarehouseId_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult success_;
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class releaseChannelHold_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> success_;
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class setWarehouseSkuDisabled_result {
			
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
		
		
		
		
		public class setWarehouseSkuSafeQuantity_result {
			
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
		
		
		
		
		public class updateInventory_result {
			
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
		
		
		
		
		
		public class batchForceHoldChannelInventory_argsHelper : TBeanSerializer<batchForceHoldChannelInventory_args>
		{
			
			public static batchForceHoldChannelInventory_argsHelper OBJ = new batchForceHoldChannelInventory_argsHelper();
			
			public static batchForceHoldChannelInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchForceHoldChannelInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHold elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHold();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchForceHoldChannelInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("reqList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchForceHoldChannelInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchForceHoldOneWarehouseInventory_argsHelper : TBeanSerializer<batchForceHoldOneWarehouseInventory_args>
		{
			
			public static batchForceHoldOneWarehouseInventory_argsHelper OBJ = new batchForceHoldOneWarehouseInventory_argsHelper();
			
			public static batchForceHoldOneWarehouseInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchForceHoldOneWarehouseInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold();
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHoldHelper.getInstance().Read(value, iprot);
					
					structs.SetHoldReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchForceHoldOneWarehouseInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHoldReq() != null) {
					
					oprot.WriteFieldBegin("holdReq");
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHoldHelper.getInstance().Write(structs.GetHoldReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("holdReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchForceHoldOneWarehouseInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchFullUpdateChannelSkuInventory_argsHelper : TBeanSerializer<batchFullUpdateChannelSkuInventory_args>
		{
			
			public static batchFullUpdateChannelSkuInventory_argsHelper OBJ = new batchFullUpdateChannelSkuInventory_argsHelper();
			
			public static batchFullUpdateChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchFullUpdateChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq();
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReqHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchFullUpdateChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchFullUpdateChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchFullUpdateWarehouseSkuInventory_argsHelper : TBeanSerializer<batchFullUpdateWarehouseSkuInventory_args>
		{
			
			public static batchFullUpdateWarehouseSkuInventory_argsHelper OBJ = new batchFullUpdateWarehouseSkuInventory_argsHelper();
			
			public static batchFullUpdateWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchFullUpdateWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq elem1;
							
							elem1 = new com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq();
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSource(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchFullUpdateWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSource() != null) {
					
					oprot.WriteFieldBegin("source");
					oprot.WriteI32((int)structs.GetSource()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchFullUpdateWarehouseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchHoldChannelInventory_argsHelper : TBeanSerializer<batchHoldChannelInventory_args>
		{
			
			public static batchHoldChannelInventory_argsHelper OBJ = new batchHoldChannelInventory_argsHelper();
			
			public static batchHoldChannelInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchHoldChannelInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHold elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHold();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchHoldChannelInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("reqList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchHoldChannelInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchHoldOneWarehouseInventory_argsHelper : TBeanSerializer<batchHoldOneWarehouseInventory_args>
		{
			
			public static batchHoldOneWarehouseInventory_argsHelper OBJ = new batchHoldOneWarehouseInventory_argsHelper();
			
			public static batchHoldOneWarehouseInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchHoldOneWarehouseInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold();
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryHoldHelper.getInstance().Read(value, iprot);
					
					structs.SetHoldReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchHoldOneWarehouseInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHoldReq() != null) {
					
					oprot.WriteFieldBegin("holdReq");
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryHoldHelper.getInstance().Write(structs.GetHoldReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("holdReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchHoldOneWarehouseInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchIncrUpdateChannelSkuInventory_argsHelper : TBeanSerializer<batchIncrUpdateChannelSkuInventory_args>
		{
			
			public static batchIncrUpdateChannelSkuInventory_argsHelper OBJ = new batchIncrUpdateChannelSkuInventory_argsHelper();
			
			public static batchIncrUpdateChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchIncrUpdateChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq();
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReqHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchIncrUpdateChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchIncrUpdateChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchIncrUpdateWarehouseSkuInventory_argsHelper : TBeanSerializer<batchIncrUpdateWarehouseSkuInventory_args>
		{
			
			public static batchIncrUpdateWarehouseSkuInventory_argsHelper OBJ = new batchIncrUpdateWarehouseSkuInventory_argsHelper();
			
			public static batchIncrUpdateWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchIncrUpdateWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq elem1;
							
							elem1 = new com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq();
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSource(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchIncrUpdateWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSource() != null) {
					
					oprot.WriteFieldBegin("source");
					oprot.WriteI32((int)structs.GetSource()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchIncrUpdateWarehouseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchReleaseChannelHold_argsHelper : TBeanSerializer<batchReleaseChannelHold_args>
		{
			
			public static batchReleaseChannelHold_argsHelper OBJ = new batchReleaseChannelHold_argsHelper();
			
			public static batchReleaseChannelHold_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchReleaseChannelHold_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryReleaseHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReqList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchReleaseChannelHold_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqList() != null) {
					
					oprot.WriteFieldBegin("reqList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease _item0 in structs.GetReqList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryReleaseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("reqList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchReleaseChannelHold_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fullUpdateChannelSkuInventory_argsHelper : TBeanSerializer<fullUpdateChannelSkuInventory_args>
		{
			
			public static fullUpdateChannelSkuInventory_argsHelper OBJ = new fullUpdateChannelSkuInventory_argsHelper();
			
			public static fullUpdateChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fullUpdateChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetQuantity(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fullUpdateChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransId() != null) {
					
					oprot.WriteFieldBegin("transId");
					oprot.WriteString(structs.GetTransId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetQuantity() != null) {
					
					oprot.WriteFieldBegin("quantity");
					oprot.WriteI32((int)structs.GetQuantity()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fullUpdateChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fullUpdateWarehouseSkuInventory_argsHelper : TBeanSerializer<fullUpdateWarehouseSkuInventory_args>
		{
			
			public static fullUpdateWarehouseSkuInventory_argsHelper OBJ = new fullUpdateWarehouseSkuInventory_argsHelper();
			
			public static fullUpdateWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fullUpdateWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetQuantity(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSource(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fullUpdateWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransId() != null) {
					
					oprot.WriteFieldBegin("transId");
					oprot.WriteString(structs.GetTransId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetQuantity() != null) {
					
					oprot.WriteFieldBegin("quantity");
					oprot.WriteI32((int)structs.GetQuantity()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSource() != null) {
					
					oprot.WriteFieldBegin("source");
					oprot.WriteI32((int)structs.GetSource()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fullUpdateWarehouseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelSkuInventory_argsHelper : TBeanSerializer<getChannelSkuInventory_args>
		{
			
			public static getChannelSkuInventory_argsHelper OBJ = new getChannelSkuInventory_argsHelper();
			
			public static getChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumChannelQuantity_argsHelper : TBeanSerializer<getSumChannelQuantity_args>
		{
			
			public static getSumChannelQuantity_argsHelper OBJ = new getSumChannelQuantity_argsHelper();
			
			public static getSumChannelQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumChannelQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumChannelQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumChannelQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumWarehouseQuantity_argsHelper : TBeanSerializer<getSumWarehouseQuantity_args>
		{
			
			public static getSumWarehouseQuantity_argsHelper OBJ = new getSumWarehouseQuantity_argsHelper();
			
			public static getSumWarehouseQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumWarehouseQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumWarehouseQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumWarehouseQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouseSkuInventory_argsHelper : TBeanSerializer<getWarehouseSkuInventory_args>
		{
			
			public static getWarehouseSkuInventory_argsHelper OBJ = new getWarehouseSkuInventory_argsHelper();
			
			public static getWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouseSkuInventory_args bean){
				
				
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
		
		
		
		
		public class holdChannelInventory_argsHelper : TBeanSerializer<holdChannelInventory_args>
		{
			
			public static holdChannelInventory_argsHelper OBJ = new holdChannelInventory_argsHelper();
			
			public static holdChannelInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(holdChannelInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHold value;
					
					value = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHold();
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Read(value, iprot);
					
					structs.SetHoldReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(holdChannelInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHoldReq() != null) {
					
					oprot.WriteFieldBegin("holdReq");
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Write(structs.GetHoldReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(holdChannelInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class holdForceChannelInventory_argsHelper : TBeanSerializer<holdForceChannelInventory_args>
		{
			
			public static holdForceChannelInventory_argsHelper OBJ = new holdForceChannelInventory_argsHelper();
			
			public static holdForceChannelInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(holdForceChannelInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHold value;
					
					value = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHold();
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Read(value, iprot);
					
					structs.SetHoldReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(holdForceChannelInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHoldReq() != null) {
					
					oprot.WriteFieldBegin("holdReq");
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Write(structs.GetHoldReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(holdForceChannelInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class incrUpdateChannelSkuInventory_argsHelper : TBeanSerializer<incrUpdateChannelSkuInventory_args>
		{
			
			public static incrUpdateChannelSkuInventory_argsHelper OBJ = new incrUpdateChannelSkuInventory_argsHelper();
			
			public static incrUpdateChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(incrUpdateChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetQuantity(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(incrUpdateChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransId() != null) {
					
					oprot.WriteFieldBegin("transId");
					oprot.WriteString(structs.GetTransId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetQuantity() != null) {
					
					oprot.WriteFieldBegin("quantity");
					oprot.WriteI32((int)structs.GetQuantity()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(incrUpdateChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class incrUpdateWarehouseSkuInventory_argsHelper : TBeanSerializer<incrUpdateWarehouseSkuInventory_args>
		{
			
			public static incrUpdateWarehouseSkuInventory_argsHelper OBJ = new incrUpdateWarehouseSkuInventory_argsHelper();
			
			public static incrUpdateWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(incrUpdateWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTransId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetQuantity(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSource(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(incrUpdateWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTransId() != null) {
					
					oprot.WriteFieldBegin("transId");
					oprot.WriteString(structs.GetTransId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetQuantity() != null) {
					
					oprot.WriteFieldBegin("quantity");
					oprot.WriteI32((int)structs.GetQuantity()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSource() != null) {
					
					oprot.WriteFieldBegin("source");
					oprot.WriteI32((int)structs.GetSource()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(incrUpdateWarehouseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listByWarehouseInventoryLogQueryCriteria_argsHelper : TBeanSerializer<listByWarehouseInventoryLogQueryCriteria_args>
		{
			
			public static listByWarehouseInventoryLogQueryCriteria_argsHelper OBJ = new listByWarehouseInventoryLogQueryCriteria_argsHelper();
			
			public static listByWarehouseInventoryLogQueryCriteria_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByWarehouseInventoryLogQueryCriteria_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria();
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteriaHelper.getInstance().Read(value, iprot);
					
					structs.SetCriteria(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.common.api.Pagination value;
					
					value = new com.vip.vop.vcloud.common.api.Pagination();
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
					
					structs.SetPagination(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listByWarehouseInventoryLogQueryCriteria_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCriteria() != null) {
					
					oprot.WriteFieldBegin("criteria");
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteriaHelper.getInstance().Write(structs.GetCriteria(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPagination() != null) {
					
					oprot.WriteFieldBegin("pagination");
					
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByWarehouseInventoryLogQueryCriteria_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listChannelSkuInventory_argsHelper : TBeanSerializer<listChannelSkuInventory_args>
		{
			
			public static listChannelSkuInventory_argsHelper OBJ = new listChannelSkuInventory_argsHelper();
			
			public static listChannelSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listChannelSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelSku> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelSku>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelSku elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelSku();
							com.vip.vop.vcloud.inventory.api.ChannelSkuHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSkuList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listChannelSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuList() != null) {
					
					oprot.WriteFieldBegin("skuList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelSku _item0 in structs.GetSkuList()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelSkuHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listChannelSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listChannelSkuInventoryByChannelId_argsHelper : TBeanSerializer<listChannelSkuInventoryByChannelId_args>
		{
			
			public static listChannelSkuInventoryByChannelId_argsHelper OBJ = new listChannelSkuInventoryByChannelId_argsHelper();
			
			public static listChannelSkuInventoryByChannelId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listChannelSkuInventoryByChannelId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.common.api.Pagination value;
					
					value = new com.vip.vop.vcloud.common.api.Pagination();
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
					
					structs.SetPagination(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listChannelSkuInventoryByChannelId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPagination() != null) {
					
					oprot.WriteFieldBegin("pagination");
					
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listChannelSkuInventoryByChannelId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseSkuInventory_argsHelper : TBeanSerializer<listWarehouseSkuInventory_args>
		{
			
			public static listWarehouseSkuInventory_argsHelper OBJ = new listWarehouseSkuInventory_argsHelper();
			
			public static listWarehouseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.WarehouseSku> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.WarehouseSku>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.WarehouseSku elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.WarehouseSku();
							com.vip.vop.vcloud.inventory.api.WarehouseSkuHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSkuList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listWarehouseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuList() != null) {
					
					oprot.WriteFieldBegin("skuList");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.WarehouseSku _item0 in structs.GetSkuList()){
						
						
						com.vip.vop.vcloud.inventory.api.WarehouseSkuHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("skuList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseSkuInventoryByWarehouseId_argsHelper : TBeanSerializer<listWarehouseSkuInventoryByWarehouseId_args>
		{
			
			public static listWarehouseSkuInventoryByWarehouseId_argsHelper OBJ = new listWarehouseSkuInventoryByWarehouseId_argsHelper();
			
			public static listWarehouseSkuInventoryByWarehouseId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseSkuInventoryByWarehouseId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.common.api.Pagination value;
					
					value = new com.vip.vop.vcloud.common.api.Pagination();
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
					
					structs.SetPagination(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listWarehouseSkuInventoryByWarehouseId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPagination() != null) {
					
					oprot.WriteFieldBegin("pagination");
					
					com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseSkuInventoryByWarehouseId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class releaseChannelHold_argsHelper : TBeanSerializer<releaseChannelHold_args>
		{
			
			public static releaseChannelHold_argsHelper OBJ = new releaseChannelHold_argsHelper();
			
			public static releaseChannelHold_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(releaseChannelHold_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease value;
					
					value = new com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease();
					com.vip.vop.vcloud.inventory.api.ChannelInventoryReleaseHelper.getInstance().Read(value, iprot);
					
					structs.SetReleaseReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(releaseChannelHold_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReleaseReq() != null) {
					
					oprot.WriteFieldBegin("releaseReq");
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryReleaseHelper.getInstance().Write(structs.GetReleaseReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(releaseChannelHold_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setWarehouseSkuDisabled_argsHelper : TBeanSerializer<setWarehouseSkuDisabled_args>
		{
			
			public static setWarehouseSkuDisabled_argsHelper OBJ = new setWarehouseSkuDisabled_argsHelper();
			
			public static setWarehouseSkuDisabled_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setWarehouseSkuDisabled_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetDisabled(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setWarehouseSkuDisabled_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDisabled() != null) {
					
					oprot.WriteFieldBegin("disabled");
					oprot.WriteI32((int)structs.GetDisabled()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setWarehouseSkuDisabled_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setWarehouseSkuSafeQuantity_argsHelper : TBeanSerializer<setWarehouseSkuSafeQuantity_args>
		{
			
			public static setWarehouseSkuSafeQuantity_argsHelper OBJ = new setWarehouseSkuSafeQuantity_argsHelper();
			
			public static setWarehouseSkuSafeQuantity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setWarehouseSkuSafeQuantity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetWarehouseId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSafeQuantity(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setWarehouseSkuSafeQuantity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseId() != null) {
					
					oprot.WriteFieldBegin("warehouseId");
					oprot.WriteI64((long)structs.GetWarehouseId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteI64((long)structs.GetSkuId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSafeQuantity() != null) {
					
					oprot.WriteFieldBegin("safeQuantity");
					oprot.WriteI32((int)structs.GetSafeQuantity()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setWarehouseSkuSafeQuantity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateInventory_argsHelper : TBeanSerializer<updateInventory_args>
		{
			
			public static updateInventory_argsHelper OBJ = new updateInventory_argsHelper();
			
			public static updateInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest value;
					
					value = new com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest();
					com.vip.vop.vcloud.inventory.api.InventoryUpdateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.vop.vcloud.inventory.api.InventoryUpdateRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchForceHoldChannelInventory_resultHelper : TBeanSerializer<batchForceHoldChannelInventory_result>
		{
			
			public static batchForceHoldChannelInventory_resultHelper OBJ = new batchForceHoldChannelInventory_resultHelper();
			
			public static batchForceHoldChannelInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchForceHoldChannelInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value;
					
					value = new Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							long _key0;
							List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _val0;
							_key0 = iprot.ReadI64(); 
							
							
							_val0 = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem1;
									
									elem1 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem1, iprot);
									
									_val0.Add(elem1);
								}
								catch(Exception e){
									
									
									break;
								}
							}
							
							iprot.ReadListEnd();
							
							value.Add(_key0, _val0);
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
			
			
			public void Write(batchForceHoldChannelInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> > _ir0 in structs.GetSuccess()){
						
						long? _key0 = _ir0.Key;
						List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _value0 = _ir0.Value;
						oprot.WriteI64((long)_key0); 
						
						
						oprot.WriteListBegin();
						foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item1 in _value0){
							
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item1, oprot);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchForceHoldChannelInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchForceHoldOneWarehouseInventory_resultHelper : TBeanSerializer<batchForceHoldOneWarehouseInventory_result>
		{
			
			public static batchForceHoldOneWarehouseInventory_resultHelper OBJ = new batchForceHoldOneWarehouseInventory_resultHelper();
			
			public static batchForceHoldOneWarehouseInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchForceHoldOneWarehouseInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchForceHoldOneWarehouseInventory_result structs, Protocol oprot){
				
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
			
			
			public void Validate(batchForceHoldOneWarehouseInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchFullUpdateChannelSkuInventory_resultHelper : TBeanSerializer<batchFullUpdateChannelSkuInventory_result>
		{
			
			public static batchFullUpdateChannelSkuInventory_resultHelper OBJ = new batchFullUpdateChannelSkuInventory_resultHelper();
			
			public static batchFullUpdateChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchFullUpdateChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.UpdateResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.UpdateResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.UpdateResult elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.UpdateResult();
							com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(batchFullUpdateChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.UpdateResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchFullUpdateChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchFullUpdateWarehouseSkuInventory_resultHelper : TBeanSerializer<batchFullUpdateWarehouseSkuInventory_result>
		{
			
			public static batchFullUpdateWarehouseSkuInventory_resultHelper OBJ = new batchFullUpdateWarehouseSkuInventory_resultHelper();
			
			public static batchFullUpdateWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchFullUpdateWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.UpdateResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.UpdateResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.UpdateResult elem1;
							
							elem1 = new com.vip.vop.vcloud.inventory.api.UpdateResult();
							com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchFullUpdateWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.UpdateResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchFullUpdateWarehouseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchHoldChannelInventory_resultHelper : TBeanSerializer<batchHoldChannelInventory_result>
		{
			
			public static batchHoldChannelInventory_resultHelper OBJ = new batchHoldChannelInventory_resultHelper();
			
			public static batchHoldChannelInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchHoldChannelInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value;
					
					value = new Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							long _key1;
							List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _val1;
							_key1 = iprot.ReadI64(); 
							
							
							_val1 = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem2;
									
									elem2 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem2, iprot);
									
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
			
			
			public void Write(batchHoldChannelInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> > _ir0 in structs.GetSuccess()){
						
						long? _key0 = _ir0.Key;
						List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _value0 = _ir0.Value;
						oprot.WriteI64((long)_key0); 
						
						
						oprot.WriteListBegin();
						foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item1 in _value0){
							
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item1, oprot);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchHoldChannelInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchHoldOneWarehouseInventory_resultHelper : TBeanSerializer<batchHoldOneWarehouseInventory_result>
		{
			
			public static batchHoldOneWarehouseInventory_resultHelper OBJ = new batchHoldOneWarehouseInventory_resultHelper();
			
			public static batchHoldOneWarehouseInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchHoldOneWarehouseInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.warehouse.api.Warehouse value;
					
					value = new com.vip.vop.vcloud.warehouse.api.Warehouse();
					com.vip.vop.vcloud.warehouse.api.WarehouseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchHoldOneWarehouseInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.warehouse.api.WarehouseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchHoldOneWarehouseInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchIncrUpdateChannelSkuInventory_resultHelper : TBeanSerializer<batchIncrUpdateChannelSkuInventory_result>
		{
			
			public static batchIncrUpdateChannelSkuInventory_resultHelper OBJ = new batchIncrUpdateChannelSkuInventory_resultHelper();
			
			public static batchIncrUpdateChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchIncrUpdateChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.UpdateResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.UpdateResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.UpdateResult elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.UpdateResult();
							com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(batchIncrUpdateChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.UpdateResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchIncrUpdateChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchIncrUpdateWarehouseSkuInventory_resultHelper : TBeanSerializer<batchIncrUpdateWarehouseSkuInventory_result>
		{
			
			public static batchIncrUpdateWarehouseSkuInventory_resultHelper OBJ = new batchIncrUpdateWarehouseSkuInventory_resultHelper();
			
			public static batchIncrUpdateWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchIncrUpdateWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.UpdateResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.UpdateResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.UpdateResult elem1;
							
							elem1 = new com.vip.vop.vcloud.inventory.api.UpdateResult();
							com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchIncrUpdateWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.UpdateResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.UpdateResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchIncrUpdateWarehouseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchReleaseChannelHold_resultHelper : TBeanSerializer<batchReleaseChannelHold_result>
		{
			
			public static batchReleaseChannelHold_resultHelper OBJ = new batchReleaseChannelHold_resultHelper();
			
			public static batchReleaseChannelHold_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchReleaseChannelHold_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> value;
					
					value = new Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							long _key1;
							List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _val1;
							_key1 = iprot.ReadI64(); 
							
							
							_val1 = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem2;
									
									elem2 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
									com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem2, iprot);
									
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
			
			
			public void Write(batchReleaseChannelHold_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> > _ir0 in structs.GetSuccess()){
						
						long? _key0 = _ir0.Key;
						List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> _value0 = _ir0.Value;
						oprot.WriteI64((long)_key0); 
						
						
						oprot.WriteListBegin();
						foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item1 in _value0){
							
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item1, oprot);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchReleaseChannelHold_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fullUpdateChannelSkuInventory_resultHelper : TBeanSerializer<fullUpdateChannelSkuInventory_result>
		{
			
			public static fullUpdateChannelSkuInventory_resultHelper OBJ = new fullUpdateChannelSkuInventory_resultHelper();
			
			public static fullUpdateChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fullUpdateChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fullUpdateChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fullUpdateChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fullUpdateWarehouseSkuInventory_resultHelper : TBeanSerializer<fullUpdateWarehouseSkuInventory_result>
		{
			
			public static fullUpdateWarehouseSkuInventory_resultHelper OBJ = new fullUpdateWarehouseSkuInventory_resultHelper();
			
			public static fullUpdateWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fullUpdateWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fullUpdateWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fullUpdateWarehouseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChannelSkuInventory_resultHelper : TBeanSerializer<getChannelSkuInventory_result>
		{
			
			public static getChannelSkuInventory_resultHelper OBJ = new getChannelSkuInventory_resultHelper();
			
			public static getChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.ChannelSkuInventory value;
					
					value = new com.vip.vop.vcloud.inventory.api.ChannelSkuInventory();
					com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumChannelQuantity_resultHelper : TBeanSerializer<getSumChannelQuantity_result>
		{
			
			public static getSumChannelQuantity_resultHelper OBJ = new getSumChannelQuantity_resultHelper();
			
			public static getSumChannelQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumChannelQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumChannelQuantity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumChannelQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumWarehouseQuantity_resultHelper : TBeanSerializer<getSumWarehouseQuantity_result>
		{
			
			public static getSumWarehouseQuantity_resultHelper OBJ = new getSumWarehouseQuantity_resultHelper();
			
			public static getSumWarehouseQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumWarehouseQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumWarehouseQuantity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumWarehouseQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouseSkuInventory_resultHelper : TBeanSerializer<getWarehouseSkuInventory_result>
		{
			
			public static getWarehouseSkuInventory_resultHelper OBJ = new getWarehouseSkuInventory_resultHelper();
			
			public static getWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory();
					com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouseSkuInventory_result bean){
				
				
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
		
		
		
		
		public class holdChannelInventory_resultHelper : TBeanSerializer<holdChannelInventory_result>
		{
			
			public static holdChannelInventory_resultHelper OBJ = new holdChannelInventory_resultHelper();
			
			public static holdChannelInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(holdChannelInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(holdChannelInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(holdChannelInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class holdForceChannelInventory_resultHelper : TBeanSerializer<holdForceChannelInventory_result>
		{
			
			public static holdForceChannelInventory_resultHelper OBJ = new holdForceChannelInventory_resultHelper();
			
			public static holdForceChannelInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(holdForceChannelInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem1;
							
							elem1 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(holdForceChannelInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(holdForceChannelInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class incrUpdateChannelSkuInventory_resultHelper : TBeanSerializer<incrUpdateChannelSkuInventory_result>
		{
			
			public static incrUpdateChannelSkuInventory_resultHelper OBJ = new incrUpdateChannelSkuInventory_resultHelper();
			
			public static incrUpdateChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(incrUpdateChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(incrUpdateChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(incrUpdateChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class incrUpdateWarehouseSkuInventory_resultHelper : TBeanSerializer<incrUpdateWarehouseSkuInventory_result>
		{
			
			public static incrUpdateWarehouseSkuInventory_resultHelper OBJ = new incrUpdateWarehouseSkuInventory_resultHelper();
			
			public static incrUpdateWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(incrUpdateWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(incrUpdateWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(incrUpdateWarehouseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listByWarehouseInventoryLogQueryCriteria_resultHelper : TBeanSerializer<listByWarehouseInventoryLogQueryCriteria_result>
		{
			
			public static listByWarehouseInventoryLogQueryCriteria_resultHelper OBJ = new listByWarehouseInventoryLogQueryCriteria_resultHelper();
			
			public static listByWarehouseInventoryLogQueryCriteria_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listByWarehouseInventoryLogQueryCriteria_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult();
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listByWarehouseInventoryLogQueryCriteria_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listByWarehouseInventoryLogQueryCriteria_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listChannelSkuInventory_resultHelper : TBeanSerializer<listChannelSkuInventory_result>
		{
			
			public static listChannelSkuInventory_resultHelper OBJ = new listChannelSkuInventory_resultHelper();
			
			public static listChannelSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listChannelSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventory elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelSkuInventory();
							com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(listChannelSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelSkuInventory _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listChannelSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listChannelSkuInventoryByChannelId_resultHelper : TBeanSerializer<listChannelSkuInventoryByChannelId_result>
		{
			
			public static listChannelSkuInventoryByChannelId_resultHelper OBJ = new listChannelSkuInventoryByChannelId_resultHelper();
			
			public static listChannelSkuInventoryByChannelId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listChannelSkuInventoryByChannelId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult value;
					
					value = new com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult();
					com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listChannelSkuInventoryByChannelId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listChannelSkuInventoryByChannelId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseSkuInventory_resultHelper : TBeanSerializer<listWarehouseSkuInventory_result>
		{
			
			public static listWarehouseSkuInventory_resultHelper OBJ = new listWarehouseSkuInventory_resultHelper();
			
			public static listWarehouseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory();
							com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(listWarehouseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listWarehouseSkuInventoryByWarehouseId_resultHelper : TBeanSerializer<listWarehouseSkuInventoryByWarehouseId_result>
		{
			
			public static listWarehouseSkuInventoryByWarehouseId_resultHelper OBJ = new listWarehouseSkuInventoryByWarehouseId_resultHelper();
			
			public static listWarehouseSkuInventoryByWarehouseId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listWarehouseSkuInventoryByWarehouseId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult value;
					
					value = new com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult();
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listWarehouseSkuInventoryByWarehouseId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listWarehouseSkuInventoryByWarehouseId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class releaseChannelHold_resultHelper : TBeanSerializer<releaseChannelHold_result>
		{
			
			public static releaseChannelHold_resultHelper OBJ = new releaseChannelHold_resultHelper();
			
			public static releaseChannelHold_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(releaseChannelHold_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> value;
					
					value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult elem0;
							
							elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult();
							com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(releaseChannelHold_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(releaseChannelHold_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setWarehouseSkuDisabled_resultHelper : TBeanSerializer<setWarehouseSkuDisabled_result>
		{
			
			public static setWarehouseSkuDisabled_resultHelper OBJ = new setWarehouseSkuDisabled_resultHelper();
			
			public static setWarehouseSkuDisabled_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setWarehouseSkuDisabled_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setWarehouseSkuDisabled_result structs, Protocol oprot){
				
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
			
			
			public void Validate(setWarehouseSkuDisabled_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setWarehouseSkuSafeQuantity_resultHelper : TBeanSerializer<setWarehouseSkuSafeQuantity_result>
		{
			
			public static setWarehouseSkuSafeQuantity_resultHelper OBJ = new setWarehouseSkuSafeQuantity_resultHelper();
			
			public static setWarehouseSkuSafeQuantity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setWarehouseSkuSafeQuantity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setWarehouseSkuSafeQuantity_result structs, Protocol oprot){
				
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
			
			
			public void Validate(setWarehouseSkuSafeQuantity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateInventory_resultHelper : TBeanSerializer<updateInventory_result>
		{
			
			public static updateInventory_resultHelper OBJ = new updateInventory_resultHelper();
			
			public static updateInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateInventory_result structs, Protocol oprot){
				
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
			
			
			public void Validate(updateInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class InventoryServiceClient : OspRestStub , InventoryService  {
			
			
			public InventoryServiceClient():base("com.vip.vop.vcloud.inventory.api.InventoryService","1.0.0") {
				
				
			}
			
			
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchForceHoldChannelInventory(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_) {
				
				send_batchForceHoldChannelInventory(reqList_);
				return recv_batchForceHoldChannelInventory(); 
				
			}
			
			
			private void send_batchForceHoldChannelInventory(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_){
				
				InitInvocation("batchForceHoldChannelInventory");
				
				batchForceHoldChannelInventory_args args = new batchForceHoldChannelInventory_args();
				args.SetReqList(reqList_);
				
				SendBase(args, batchForceHoldChannelInventory_argsHelper.getInstance());
			}
			
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> recv_batchForceHoldChannelInventory(){
				
				batchForceHoldChannelInventory_result result = new batchForceHoldChannelInventory_result();
				ReceiveBase(result, batchForceHoldChannelInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? batchForceHoldOneWarehouseInventory(com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold holdReq_) {
				
				send_batchForceHoldOneWarehouseInventory(holdReq_);
				return recv_batchForceHoldOneWarehouseInventory(); 
				
			}
			
			
			private void send_batchForceHoldOneWarehouseInventory(com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold holdReq_){
				
				InitInvocation("batchForceHoldOneWarehouseInventory");
				
				batchForceHoldOneWarehouseInventory_args args = new batchForceHoldOneWarehouseInventory_args();
				args.SetHoldReq(holdReq_);
				
				SendBase(args, batchForceHoldOneWarehouseInventory_argsHelper.getInstance());
			}
			
			
			private bool? recv_batchForceHoldOneWarehouseInventory(){
				
				batchForceHoldOneWarehouseInventory_result result = new batchForceHoldOneWarehouseInventory_result();
				ReceiveBase(result, batchForceHoldOneWarehouseInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchFullUpdateChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_) {
				
				send_batchFullUpdateChannelSkuInventory(reqList_);
				return recv_batchFullUpdateChannelSkuInventory(); 
				
			}
			
			
			private void send_batchFullUpdateChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_){
				
				InitInvocation("batchFullUpdateChannelSkuInventory");
				
				batchFullUpdateChannelSkuInventory_args args = new batchFullUpdateChannelSkuInventory_args();
				args.SetReqList(reqList_);
				
				SendBase(args, batchFullUpdateChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> recv_batchFullUpdateChannelSkuInventory(){
				
				batchFullUpdateChannelSkuInventory_result result = new batchFullUpdateChannelSkuInventory_result();
				ReceiveBase(result, batchFullUpdateChannelSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchFullUpdateWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,int? source_) {
				
				send_batchFullUpdateWarehouseSkuInventory(reqList_,source_);
				return recv_batchFullUpdateWarehouseSkuInventory(); 
				
			}
			
			
			private void send_batchFullUpdateWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,int? source_){
				
				InitInvocation("batchFullUpdateWarehouseSkuInventory");
				
				batchFullUpdateWarehouseSkuInventory_args args = new batchFullUpdateWarehouseSkuInventory_args();
				args.SetReqList(reqList_);
				args.SetSource(source_);
				
				SendBase(args, batchFullUpdateWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> recv_batchFullUpdateWarehouseSkuInventory(){
				
				batchFullUpdateWarehouseSkuInventory_result result = new batchFullUpdateWarehouseSkuInventory_result();
				ReceiveBase(result, batchFullUpdateWarehouseSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchHoldChannelInventory(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_) {
				
				send_batchHoldChannelInventory(reqList_);
				return recv_batchHoldChannelInventory(); 
				
			}
			
			
			private void send_batchHoldChannelInventory(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_){
				
				InitInvocation("batchHoldChannelInventory");
				
				batchHoldChannelInventory_args args = new batchHoldChannelInventory_args();
				args.SetReqList(reqList_);
				
				SendBase(args, batchHoldChannelInventory_argsHelper.getInstance());
			}
			
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> recv_batchHoldChannelInventory(){
				
				batchHoldChannelInventory_result result = new batchHoldChannelInventory_result();
				ReceiveBase(result, batchHoldChannelInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.warehouse.api.Warehouse batchHoldOneWarehouseInventory(com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold holdReq_) {
				
				send_batchHoldOneWarehouseInventory(holdReq_);
				return recv_batchHoldOneWarehouseInventory(); 
				
			}
			
			
			private void send_batchHoldOneWarehouseInventory(com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold holdReq_){
				
				InitInvocation("batchHoldOneWarehouseInventory");
				
				batchHoldOneWarehouseInventory_args args = new batchHoldOneWarehouseInventory_args();
				args.SetHoldReq(holdReq_);
				
				SendBase(args, batchHoldOneWarehouseInventory_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.warehouse.api.Warehouse recv_batchHoldOneWarehouseInventory(){
				
				batchHoldOneWarehouseInventory_result result = new batchHoldOneWarehouseInventory_result();
				ReceiveBase(result, batchHoldOneWarehouseInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchIncrUpdateChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_) {
				
				send_batchIncrUpdateChannelSkuInventory(reqList_);
				return recv_batchIncrUpdateChannelSkuInventory(); 
				
			}
			
			
			private void send_batchIncrUpdateChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_){
				
				InitInvocation("batchIncrUpdateChannelSkuInventory");
				
				batchIncrUpdateChannelSkuInventory_args args = new batchIncrUpdateChannelSkuInventory_args();
				args.SetReqList(reqList_);
				
				SendBase(args, batchIncrUpdateChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> recv_batchIncrUpdateChannelSkuInventory(){
				
				batchIncrUpdateChannelSkuInventory_result result = new batchIncrUpdateChannelSkuInventory_result();
				ReceiveBase(result, batchIncrUpdateChannelSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchIncrUpdateWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,int? source_) {
				
				send_batchIncrUpdateWarehouseSkuInventory(reqList_,source_);
				return recv_batchIncrUpdateWarehouseSkuInventory(); 
				
			}
			
			
			private void send_batchIncrUpdateWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,int? source_){
				
				InitInvocation("batchIncrUpdateWarehouseSkuInventory");
				
				batchIncrUpdateWarehouseSkuInventory_args args = new batchIncrUpdateWarehouseSkuInventory_args();
				args.SetReqList(reqList_);
				args.SetSource(source_);
				
				SendBase(args, batchIncrUpdateWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.UpdateResult> recv_batchIncrUpdateWarehouseSkuInventory(){
				
				batchIncrUpdateWarehouseSkuInventory_result result = new batchIncrUpdateWarehouseSkuInventory_result();
				ReceiveBase(result, batchIncrUpdateWarehouseSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchReleaseChannelHold(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> reqList_) {
				
				send_batchReleaseChannelHold(reqList_);
				return recv_batchReleaseChannelHold(); 
				
			}
			
			
			private void send_batchReleaseChannelHold(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> reqList_){
				
				InitInvocation("batchReleaseChannelHold");
				
				batchReleaseChannelHold_args args = new batchReleaseChannelHold_args();
				args.SetReqList(reqList_);
				
				SendBase(args, batchReleaseChannelHold_argsHelper.getInstance());
			}
			
			
			private Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> recv_batchReleaseChannelHold(){
				
				batchReleaseChannelHold_result result = new batchReleaseChannelHold_result();
				ReceiveBase(result, batchReleaseChannelHold_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void fullUpdateChannelSkuInventory(string transId_,long? channelId_,long? skuId_,int? quantity_) {
				
				send_fullUpdateChannelSkuInventory(transId_,channelId_,skuId_,quantity_);
				recv_fullUpdateChannelSkuInventory();
				
			}
			
			
			private void send_fullUpdateChannelSkuInventory(string transId_,long? channelId_,long? skuId_,int? quantity_){
				
				InitInvocation("fullUpdateChannelSkuInventory");
				
				fullUpdateChannelSkuInventory_args args = new fullUpdateChannelSkuInventory_args();
				args.SetTransId(transId_);
				args.SetChannelId(channelId_);
				args.SetSkuId(skuId_);
				args.SetQuantity(quantity_);
				
				SendBase(args, fullUpdateChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private void recv_fullUpdateChannelSkuInventory(){
				
				fullUpdateChannelSkuInventory_result result = new fullUpdateChannelSkuInventory_result();
				ReceiveBase(result, fullUpdateChannelSkuInventory_resultHelper.getInstance());
				
				
			}
			
			
			public void fullUpdateWarehouseSkuInventory(string transId_,long? warehouseId_,long? skuId_,int? quantity_,int? source_) {
				
				send_fullUpdateWarehouseSkuInventory(transId_,warehouseId_,skuId_,quantity_,source_);
				recv_fullUpdateWarehouseSkuInventory();
				
			}
			
			
			private void send_fullUpdateWarehouseSkuInventory(string transId_,long? warehouseId_,long? skuId_,int? quantity_,int? source_){
				
				InitInvocation("fullUpdateWarehouseSkuInventory");
				
				fullUpdateWarehouseSkuInventory_args args = new fullUpdateWarehouseSkuInventory_args();
				args.SetTransId(transId_);
				args.SetWarehouseId(warehouseId_);
				args.SetSkuId(skuId_);
				args.SetQuantity(quantity_);
				args.SetSource(source_);
				
				SendBase(args, fullUpdateWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private void recv_fullUpdateWarehouseSkuInventory(){
				
				fullUpdateWarehouseSkuInventory_result result = new fullUpdateWarehouseSkuInventory_result();
				ReceiveBase(result, fullUpdateWarehouseSkuInventory_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.vop.vcloud.inventory.api.ChannelSkuInventory getChannelSkuInventory(long? channelId_,long? skuId_) {
				
				send_getChannelSkuInventory(channelId_,skuId_);
				return recv_getChannelSkuInventory(); 
				
			}
			
			
			private void send_getChannelSkuInventory(long? channelId_,long? skuId_){
				
				InitInvocation("getChannelSkuInventory");
				
				getChannelSkuInventory_args args = new getChannelSkuInventory_args();
				args.SetChannelId(channelId_);
				args.SetSkuId(skuId_);
				
				SendBase(args, getChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.inventory.api.ChannelSkuInventory recv_getChannelSkuInventory(){
				
				getChannelSkuInventory_result result = new getChannelSkuInventory_result();
				ReceiveBase(result, getChannelSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public long? getSumChannelQuantity(long? channelId_) {
				
				send_getSumChannelQuantity(channelId_);
				return recv_getSumChannelQuantity(); 
				
			}
			
			
			private void send_getSumChannelQuantity(long? channelId_){
				
				InitInvocation("getSumChannelQuantity");
				
				getSumChannelQuantity_args args = new getSumChannelQuantity_args();
				args.SetChannelId(channelId_);
				
				SendBase(args, getSumChannelQuantity_argsHelper.getInstance());
			}
			
			
			private long? recv_getSumChannelQuantity(){
				
				getSumChannelQuantity_result result = new getSumChannelQuantity_result();
				ReceiveBase(result, getSumChannelQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public long? getSumWarehouseQuantity(long? warehouseId_) {
				
				send_getSumWarehouseQuantity(warehouseId_);
				return recv_getSumWarehouseQuantity(); 
				
			}
			
			
			private void send_getSumWarehouseQuantity(long? warehouseId_){
				
				InitInvocation("getSumWarehouseQuantity");
				
				getSumWarehouseQuantity_args args = new getSumWarehouseQuantity_args();
				args.SetWarehouseId(warehouseId_);
				
				SendBase(args, getSumWarehouseQuantity_argsHelper.getInstance());
			}
			
			
			private long? recv_getSumWarehouseQuantity(){
				
				getSumWarehouseQuantity_result result = new getSumWarehouseQuantity_result();
				ReceiveBase(result, getSumWarehouseQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory getWarehouseSkuInventory(long? warehouseId_,long? skuId_) {
				
				send_getWarehouseSkuInventory(warehouseId_,skuId_);
				return recv_getWarehouseSkuInventory(); 
				
			}
			
			
			private void send_getWarehouseSkuInventory(long? warehouseId_,long? skuId_){
				
				InitInvocation("getWarehouseSkuInventory");
				
				getWarehouseSkuInventory_args args = new getWarehouseSkuInventory_args();
				args.SetWarehouseId(warehouseId_);
				args.SetSkuId(skuId_);
				
				SendBase(args, getWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory recv_getWarehouseSkuInventory(){
				
				getWarehouseSkuInventory_result result = new getWarehouseSkuInventory_result();
				ReceiveBase(result, getWarehouseSkuInventory_resultHelper.getInstance());
				
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
			
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> holdChannelInventory(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_) {
				
				send_holdChannelInventory(holdReq_);
				return recv_holdChannelInventory(); 
				
			}
			
			
			private void send_holdChannelInventory(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_){
				
				InitInvocation("holdChannelInventory");
				
				holdChannelInventory_args args = new holdChannelInventory_args();
				args.SetHoldReq(holdReq_);
				
				SendBase(args, holdChannelInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> recv_holdChannelInventory(){
				
				holdChannelInventory_result result = new holdChannelInventory_result();
				ReceiveBase(result, holdChannelInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> holdForceChannelInventory(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_) {
				
				send_holdForceChannelInventory(holdReq_);
				return recv_holdForceChannelInventory(); 
				
			}
			
			
			private void send_holdForceChannelInventory(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_){
				
				InitInvocation("holdForceChannelInventory");
				
				holdForceChannelInventory_args args = new holdForceChannelInventory_args();
				args.SetHoldReq(holdReq_);
				
				SendBase(args, holdForceChannelInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> recv_holdForceChannelInventory(){
				
				holdForceChannelInventory_result result = new holdForceChannelInventory_result();
				ReceiveBase(result, holdForceChannelInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void incrUpdateChannelSkuInventory(string transId_,long? channelId_,long? skuId_,int? quantity_) {
				
				send_incrUpdateChannelSkuInventory(transId_,channelId_,skuId_,quantity_);
				recv_incrUpdateChannelSkuInventory();
				
			}
			
			
			private void send_incrUpdateChannelSkuInventory(string transId_,long? channelId_,long? skuId_,int? quantity_){
				
				InitInvocation("incrUpdateChannelSkuInventory");
				
				incrUpdateChannelSkuInventory_args args = new incrUpdateChannelSkuInventory_args();
				args.SetTransId(transId_);
				args.SetChannelId(channelId_);
				args.SetSkuId(skuId_);
				args.SetQuantity(quantity_);
				
				SendBase(args, incrUpdateChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private void recv_incrUpdateChannelSkuInventory(){
				
				incrUpdateChannelSkuInventory_result result = new incrUpdateChannelSkuInventory_result();
				ReceiveBase(result, incrUpdateChannelSkuInventory_resultHelper.getInstance());
				
				
			}
			
			
			public void incrUpdateWarehouseSkuInventory(string transId_,long? warehouseId_,long? skuId_,int? quantity_,int? source_) {
				
				send_incrUpdateWarehouseSkuInventory(transId_,warehouseId_,skuId_,quantity_,source_);
				recv_incrUpdateWarehouseSkuInventory();
				
			}
			
			
			private void send_incrUpdateWarehouseSkuInventory(string transId_,long? warehouseId_,long? skuId_,int? quantity_,int? source_){
				
				InitInvocation("incrUpdateWarehouseSkuInventory");
				
				incrUpdateWarehouseSkuInventory_args args = new incrUpdateWarehouseSkuInventory_args();
				args.SetTransId(transId_);
				args.SetWarehouseId(warehouseId_);
				args.SetSkuId(skuId_);
				args.SetQuantity(quantity_);
				args.SetSource(source_);
				
				SendBase(args, incrUpdateWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private void recv_incrUpdateWarehouseSkuInventory(){
				
				incrUpdateWarehouseSkuInventory_result result = new incrUpdateWarehouseSkuInventory_result();
				ReceiveBase(result, incrUpdateWarehouseSkuInventory_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult listByWarehouseInventoryLogQueryCriteria(com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria criteria_,com.vip.vop.vcloud.common.api.Pagination pagination_) {
				
				send_listByWarehouseInventoryLogQueryCriteria(criteria_,pagination_);
				return recv_listByWarehouseInventoryLogQueryCriteria(); 
				
			}
			
			
			private void send_listByWarehouseInventoryLogQueryCriteria(com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria criteria_,com.vip.vop.vcloud.common.api.Pagination pagination_){
				
				InitInvocation("listByWarehouseInventoryLogQueryCriteria");
				
				listByWarehouseInventoryLogQueryCriteria_args args = new listByWarehouseInventoryLogQueryCriteria_args();
				args.SetCriteria(criteria_);
				args.SetPagination(pagination_);
				
				SendBase(args, listByWarehouseInventoryLogQueryCriteria_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult recv_listByWarehouseInventoryLogQueryCriteria(){
				
				listByWarehouseInventoryLogQueryCriteria_result result = new listByWarehouseInventoryLogQueryCriteria_result();
				ReceiveBase(result, listByWarehouseInventoryLogQueryCriteria_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> listChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSku> skuList_) {
				
				send_listChannelSkuInventory(skuList_);
				return recv_listChannelSkuInventory(); 
				
			}
			
			
			private void send_listChannelSkuInventory(List<com.vip.vop.vcloud.inventory.api.ChannelSku> skuList_){
				
				InitInvocation("listChannelSkuInventory");
				
				listChannelSkuInventory_args args = new listChannelSkuInventory_args();
				args.SetSkuList(skuList_);
				
				SendBase(args, listChannelSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> recv_listChannelSkuInventory(){
				
				listChannelSkuInventory_result result = new listChannelSkuInventory_result();
				ReceiveBase(result, listChannelSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult listChannelSkuInventoryByChannelId(long? channelId_,com.vip.vop.vcloud.common.api.Pagination pagination_) {
				
				send_listChannelSkuInventoryByChannelId(channelId_,pagination_);
				return recv_listChannelSkuInventoryByChannelId(); 
				
			}
			
			
			private void send_listChannelSkuInventoryByChannelId(long? channelId_,com.vip.vop.vcloud.common.api.Pagination pagination_){
				
				InitInvocation("listChannelSkuInventoryByChannelId");
				
				listChannelSkuInventoryByChannelId_args args = new listChannelSkuInventoryByChannelId_args();
				args.SetChannelId(channelId_);
				args.SetPagination(pagination_);
				
				SendBase(args, listChannelSkuInventoryByChannelId_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult recv_listChannelSkuInventoryByChannelId(){
				
				listChannelSkuInventoryByChannelId_result result = new listChannelSkuInventoryByChannelId_result();
				ReceiveBase(result, listChannelSkuInventoryByChannelId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> listWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSku> skuList_) {
				
				send_listWarehouseSkuInventory(skuList_);
				return recv_listWarehouseSkuInventory(); 
				
			}
			
			
			private void send_listWarehouseSkuInventory(List<com.vip.vop.vcloud.inventory.api.WarehouseSku> skuList_){
				
				InitInvocation("listWarehouseSkuInventory");
				
				listWarehouseSkuInventory_args args = new listWarehouseSkuInventory_args();
				args.SetSkuList(skuList_);
				
				SendBase(args, listWarehouseSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> recv_listWarehouseSkuInventory(){
				
				listWarehouseSkuInventory_result result = new listWarehouseSkuInventory_result();
				ReceiveBase(result, listWarehouseSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult listWarehouseSkuInventoryByWarehouseId(long? warehouseId_,com.vip.vop.vcloud.common.api.Pagination pagination_) {
				
				send_listWarehouseSkuInventoryByWarehouseId(warehouseId_,pagination_);
				return recv_listWarehouseSkuInventoryByWarehouseId(); 
				
			}
			
			
			private void send_listWarehouseSkuInventoryByWarehouseId(long? warehouseId_,com.vip.vop.vcloud.common.api.Pagination pagination_){
				
				InitInvocation("listWarehouseSkuInventoryByWarehouseId");
				
				listWarehouseSkuInventoryByWarehouseId_args args = new listWarehouseSkuInventoryByWarehouseId_args();
				args.SetWarehouseId(warehouseId_);
				args.SetPagination(pagination_);
				
				SendBase(args, listWarehouseSkuInventoryByWarehouseId_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult recv_listWarehouseSkuInventoryByWarehouseId(){
				
				listWarehouseSkuInventoryByWarehouseId_result result = new listWarehouseSkuInventoryByWarehouseId_result();
				ReceiveBase(result, listWarehouseSkuInventoryByWarehouseId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> releaseChannelHold(com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease releaseReq_) {
				
				send_releaseChannelHold(releaseReq_);
				return recv_releaseChannelHold(); 
				
			}
			
			
			private void send_releaseChannelHold(com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease releaseReq_){
				
				InitInvocation("releaseChannelHold");
				
				releaseChannelHold_args args = new releaseChannelHold_args();
				args.SetReleaseReq(releaseReq_);
				
				SendBase(args, releaseChannelHold_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> recv_releaseChannelHold(){
				
				releaseChannelHold_result result = new releaseChannelHold_result();
				ReceiveBase(result, releaseChannelHold_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? setWarehouseSkuDisabled(long? warehouseId_,long? skuId_,int? disabled_) {
				
				send_setWarehouseSkuDisabled(warehouseId_,skuId_,disabled_);
				return recv_setWarehouseSkuDisabled(); 
				
			}
			
			
			private void send_setWarehouseSkuDisabled(long? warehouseId_,long? skuId_,int? disabled_){
				
				InitInvocation("setWarehouseSkuDisabled");
				
				setWarehouseSkuDisabled_args args = new setWarehouseSkuDisabled_args();
				args.SetWarehouseId(warehouseId_);
				args.SetSkuId(skuId_);
				args.SetDisabled(disabled_);
				
				SendBase(args, setWarehouseSkuDisabled_argsHelper.getInstance());
			}
			
			
			private bool? recv_setWarehouseSkuDisabled(){
				
				setWarehouseSkuDisabled_result result = new setWarehouseSkuDisabled_result();
				ReceiveBase(result, setWarehouseSkuDisabled_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? setWarehouseSkuSafeQuantity(long? warehouseId_,long? skuId_,int? safeQuantity_) {
				
				send_setWarehouseSkuSafeQuantity(warehouseId_,skuId_,safeQuantity_);
				return recv_setWarehouseSkuSafeQuantity(); 
				
			}
			
			
			private void send_setWarehouseSkuSafeQuantity(long? warehouseId_,long? skuId_,int? safeQuantity_){
				
				InitInvocation("setWarehouseSkuSafeQuantity");
				
				setWarehouseSkuSafeQuantity_args args = new setWarehouseSkuSafeQuantity_args();
				args.SetWarehouseId(warehouseId_);
				args.SetSkuId(skuId_);
				args.SetSafeQuantity(safeQuantity_);
				
				SendBase(args, setWarehouseSkuSafeQuantity_argsHelper.getInstance());
			}
			
			
			private bool? recv_setWarehouseSkuSafeQuantity(){
				
				setWarehouseSkuSafeQuantity_result result = new setWarehouseSkuSafeQuantity_result();
				ReceiveBase(result, setWarehouseSkuSafeQuantity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? updateInventory(com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest request_) {
				
				send_updateInventory(request_);
				return recv_updateInventory(); 
				
			}
			
			
			private void send_updateInventory(com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest request_){
				
				InitInvocation("updateInventory");
				
				updateInventory_args args = new updateInventory_args();
				args.SetRequest(request_);
				
				SendBase(args, updateInventory_argsHelper.getInstance());
			}
			
			
			private bool? recv_updateInventory(){
				
				updateInventory_result result = new updateInventory_result();
				ReceiveBase(result, updateInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}