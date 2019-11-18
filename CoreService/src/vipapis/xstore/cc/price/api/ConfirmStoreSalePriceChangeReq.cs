using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class ConfirmStoreSalePriceChangeReq {
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string store_code_;
		
		///<summary>
		/// 销售价格变动编码列表，数量不超过100
		///</summary>
		
		private List<string> sale_price_change_nos_;
		
		public string GetStore_code(){
			return this.store_code_;
		}
		
		public void SetStore_code(string value){
			this.store_code_ = value;
		}
		public List<string> GetSale_price_change_nos(){
			return this.sale_price_change_nos_;
		}
		
		public void SetSale_price_change_nos(List<string> value){
			this.sale_price_change_nos_ = value;
		}
		
	}
	
}