using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class PriceItem {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string mid_;
		
		///<summary>
		/// 唯品价格
		///</summary>
		
		private string vipPrice_;
		
		///<summary>
		/// 超级VIP价格
		///</summary>
		
		private string svipPrice_;
		
		///<summary>
		/// 多sku不同价
		///</summary>
		
		private bool? skuMultiplePrice_;
		
		public string GetMid(){
			return this.mid_;
		}
		
		public void SetMid(string value){
			this.mid_ = value;
		}
		public string GetVipPrice(){
			return this.vipPrice_;
		}
		
		public void SetVipPrice(string value){
			this.vipPrice_ = value;
		}
		public string GetSvipPrice(){
			return this.svipPrice_;
		}
		
		public void SetSvipPrice(string value){
			this.svipPrice_ = value;
		}
		public bool? GetSkuMultiplePrice(){
			return this.skuMultiplePrice_;
		}
		
		public void SetSkuMultiplePrice(bool? value){
			this.skuMultiplePrice_ = value;
		}
		
	}
	
}