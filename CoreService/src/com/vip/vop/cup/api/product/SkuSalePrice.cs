using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class SkuSalePrice {
		
		///<summary>
		/// 分销价
		///</summary>
		
		private string distribution_price_;
		
		///<summary>
		/// 建议零售价
		///</summary>
		
		private string suggest_retail_price_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private string market_price_;
		
		///<summary>
		/// 价格生效时间
		///</summary>
		
		private System.DateTime? effective_start_time_;
		
		///<summary>
		/// 价格失效时间
		///</summary>
		
		private System.DateTime? effective_end_time_;
		
		///<summary>
		/// 取价时间，精确到秒
		///</summary>
		
		private long? price_time_;
		
		public string GetDistribution_price(){
			return this.distribution_price_;
		}
		
		public void SetDistribution_price(string value){
			this.distribution_price_ = value;
		}
		public string GetSuggest_retail_price(){
			return this.suggest_retail_price_;
		}
		
		public void SetSuggest_retail_price(string value){
			this.suggest_retail_price_ = value;
		}
		public string GetMarket_price(){
			return this.market_price_;
		}
		
		public void SetMarket_price(string value){
			this.market_price_ = value;
		}
		public System.DateTime? GetEffective_start_time(){
			return this.effective_start_time_;
		}
		
		public void SetEffective_start_time(System.DateTime? value){
			this.effective_start_time_ = value;
		}
		public System.DateTime? GetEffective_end_time(){
			return this.effective_end_time_;
		}
		
		public void SetEffective_end_time(System.DateTime? value){
			this.effective_end_time_ = value;
		}
		public long? GetPrice_time(){
			return this.price_time_;
		}
		
		public void SetPrice_time(long? value){
			this.price_time_ = value;
		}
		
	}
	
}