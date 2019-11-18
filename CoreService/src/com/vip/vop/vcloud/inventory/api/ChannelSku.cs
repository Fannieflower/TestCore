using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class ChannelSku {
		
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
	
}