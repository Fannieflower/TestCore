using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class ChannelInventoryHold {
		
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
		/// 库存值
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 收货地址
		///</summary>
		
		private com.vip.vop.vcloud.warehouse.api.Address address_;
		
		///<summary>
		/// 唯品会常态合作编码
		///</summary>
		
		private int? vipCooperationNo_;
		
		///<summary>
		/// 唯品会仓库编码
		///</summary>
		
		private string vipWarehouseCode_;
		
		///<summary>
		/// 合作伙伴ID
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 唯品会全渠道常态合作编码类型, 0=非全渠道, 1=全渠道，默认：0
		///</summary>
		
		private int? vipCooperationType_;
		
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
		public com.vip.vop.vcloud.warehouse.api.Address GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(com.vip.vop.vcloud.warehouse.api.Address value){
			this.address_ = value;
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
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public int? GetVipCooperationType(){
			return this.vipCooperationType_;
		}
		
		public void SetVipCooperationType(int? value){
			this.vipCooperationType_ = value;
		}
		
	}
	
}