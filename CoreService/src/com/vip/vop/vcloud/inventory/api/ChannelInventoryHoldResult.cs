using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class ChannelInventoryHoldResult {
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// sku id
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 剩余库存
		///</summary>
		
		private int? leavings_;
		
		///<summary>
		/// 占用库存值
		///</summary>
		
		private int? holdQuantity_;
		
		///<summary>
		/// 是否占用/释放成功
		///</summary>
		
		private bool? isOk_;
		
		///<summary>
		/// 错误信息，失败返回此字段
		///</summary>
		
		private string message_;
		
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
		public int? GetLeavings(){
			return this.leavings_;
		}
		
		public void SetLeavings(int? value){
			this.leavings_ = value;
		}
		public int? GetHoldQuantity(){
			return this.holdQuantity_;
		}
		
		public void SetHoldQuantity(int? value){
			this.holdQuantity_ = value;
		}
		public bool? GetIsOk(){
			return this.isOk_;
		}
		
		public void SetIsOk(bool? value){
			this.isOk_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}