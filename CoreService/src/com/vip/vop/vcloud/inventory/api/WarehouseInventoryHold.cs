using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseInventoryHold {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 合作伙伴ID
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 渠道ID
		///</summary>
		
		private long? channelId_;
		
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
		/// 批量占用渠道库存请求
		///</summary>
		
		private List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> skuList_;
		
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
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
		public List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> GetSkuList(){
			return this.skuList_;
		}
		
		public void SetSkuList(List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value){
			this.skuList_ = value;
		}
		
	}
	
}