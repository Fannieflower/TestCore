using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class ChannelInventoryRelease {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 占用流水号
		///</summary>
		
		private string holdTransId_;
		
		///<summary>
		/// 渠道id
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// sku id
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 库存值
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 唯品会常态合作编码
		///</summary>
		
		private int? vipCooperationNo_;
		
		///<summary>
		/// 唯品会仓库编码
		///</summary>
		
		private string vipWarehouseCode_;
		
		///<summary>
		/// 唯品会全渠道常态合作编码类型, 0=非全渠道, 1=全渠道，默认：0
		///</summary>
		
		private int? vipCooperationType_;
		
		///<summary>
		/// 门店ID
		///</summary>
		
		private long? warehouseId_;
		
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public string GetHoldTransId(){
			return this.holdTransId_;
		}
		
		public void SetHoldTransId(string value){
			this.holdTransId_ = value;
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
		public int? GetVipCooperationNo(){
			return this.vipCooperationNo_;
		}
		
		public void SetVipCooperationNo(int? value){
			this.vipCooperationNo_ = value;
		}
		public string GetVipWarehouseCode(){
			return this.vipWarehouseCode_;
		}
		
		public void SetVipWarehouseCode(string value){
			this.vipWarehouseCode_ = value;
		}
		public int? GetVipCooperationType(){
			return this.vipCooperationType_;
		}
		
		public void SetVipCooperationType(int? value){
			this.vipCooperationType_ = value;
		}
		public long? GetWarehouseId(){
			return this.warehouseId_;
		}
		
		public void SetWarehouseId(long? value){
			this.warehouseId_ = value;
		}
		
	}
	
}