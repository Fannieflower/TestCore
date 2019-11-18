using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class ChannelSkuInventory {
		
		///<summary>
		/// 渠道id
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// sku id
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 占用库存值
		///</summary>
		
		private int? holdQuantity_;
		
		///<summary>
		/// 库存值
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 总库存值
		///</summary>
		
		private int? totalQuantity_;
		
		///<summary>
		/// 剩余库存值
		///</summary>
		
		private int? leavings_;
		
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
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
		public int? GetHoldQuantity(){
			return this.holdQuantity_;
		}
		
		public void SetHoldQuantity(int? value){
			this.holdQuantity_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public int? GetTotalQuantity(){
			return this.totalQuantity_;
		}
		
		public void SetTotalQuantity(int? value){
			this.totalQuantity_ = value;
		}
		public int? GetLeavings(){
			return this.leavings_;
		}
		
		public void SetLeavings(int? value){
			this.leavings_ = value;
		}
		
	}
	
}