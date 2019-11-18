using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	public interface InventoryService {
		
		
		Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchForceHoldChannelInventory( List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_ );
		
		bool? batchForceHoldOneWarehouseInventory( com.vip.vop.vcloud.inventory.api.WarehouseInventoryForceHold holdReq_ );
		
		List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchFullUpdateChannelSkuInventory( List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_ );
		
		List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchFullUpdateWarehouseSkuInventory( List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,   int? source_ );
		
		Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchHoldChannelInventory( List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> reqList_ );
		
		com.vip.vop.vcloud.warehouse.api.Warehouse batchHoldOneWarehouseInventory( com.vip.vop.vcloud.inventory.api.WarehouseInventoryHold holdReq_ );
		
		List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchIncrUpdateChannelSkuInventory( List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryUpdateReq> reqList_ );
		
		List<com.vip.vop.vcloud.inventory.api.UpdateResult> batchIncrUpdateWarehouseSkuInventory( List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventoryUpdateReq> reqList_,   int? source_ );
		
		Dictionary<long?, List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult>> batchReleaseChannelHold( List<com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease> reqList_ );
		
		void fullUpdateChannelSkuInventory( string transId_,   long? channelId_,   long? skuId_,   int? quantity_ );
		
		void fullUpdateWarehouseSkuInventory( string transId_,   long? warehouseId_,   long? skuId_,   int? quantity_,   int? source_ );
		
		com.vip.vop.vcloud.inventory.api.ChannelSkuInventory getChannelSkuInventory( long? channelId_,   long? skuId_ );
		
		long? getSumChannelQuantity( long? channelId_ );
		
		long? getSumWarehouseQuantity( long? warehouseId_ );
		
		com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory getWarehouseSkuInventory( long? warehouseId_,   long? skuId_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> holdChannelInventory( com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_ );
		
		List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> holdForceChannelInventory( com.vip.vop.vcloud.inventory.api.ChannelInventoryHold holdReq_ );
		
		void incrUpdateChannelSkuInventory( string transId_,   long? channelId_,   long? skuId_,   int? quantity_ );
		
		void incrUpdateWarehouseSkuInventory( string transId_,   long? warehouseId_,   long? skuId_,   int? quantity_,   int? source_ );
		
		com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryResult listByWarehouseInventoryLogQueryCriteria( com.vip.vop.vcloud.inventory.api.WarehouseInventoryLogQueryCriteria criteria_,   com.vip.vop.vcloud.common.api.Pagination pagination_ );
		
		List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> listChannelSkuInventory( List<com.vip.vop.vcloud.inventory.api.ChannelSku> skuList_ );
		
		com.vip.vop.vcloud.inventory.api.ChannelInventoryQueryResult listChannelSkuInventoryByChannelId( long? channelId_,   com.vip.vop.vcloud.common.api.Pagination pagination_ );
		
		List<com.vip.vop.vcloud.inventory.api.WarehouseSkuInventory> listWarehouseSkuInventory( List<com.vip.vop.vcloud.inventory.api.WarehouseSku> skuList_ );
		
		com.vip.vop.vcloud.inventory.api.WarehouseInventoryQueryResult listWarehouseSkuInventoryByWarehouseId( long? warehouseId_,   com.vip.vop.vcloud.common.api.Pagination pagination_ );
		
		List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldResult> releaseChannelHold( com.vip.vop.vcloud.inventory.api.ChannelInventoryRelease releaseReq_ );
		
		bool? setWarehouseSkuDisabled( long? warehouseId_,   long? skuId_,   int? disabled_ );
		
		bool? setWarehouseSkuSafeQuantity( long? warehouseId_,   long? skuId_,   int? safeQuantity_ );
		
		bool? updateInventory( com.vip.vop.vcloud.inventory.api.InventoryUpdateRequest request_ );
		
	}
	
}