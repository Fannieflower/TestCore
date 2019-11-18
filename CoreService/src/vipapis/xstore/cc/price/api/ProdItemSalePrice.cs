using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class ProdItemSalePrice {
		
		///<summary>
		/// 价格变动编号
		///</summary>
		
		private string sale_price_change_no_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string store_code_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 建议零售价
		///</summary>
		
		private string suggestion_retail_price_;
		
		///<summary>
		/// 折扣 (0~1)，0.8表示8折
		///</summary>
		
		private string discount_;
		
		///<summary>
		/// 销售价（折扣价）
		///</summary>
		
		private string sale_price_;
		
		///<summary>
		/// 开始生效时间
		///</summary>
		
		private System.DateTime? start_effective_time_;
		
		///<summary>
		/// 结束生效时间
		///</summary>
		
		private System.DateTime? end_effective_time_;
		
		///<summary>
		/// 是否全国门店维度，若为true，则改销售价对全国所有门店有效
		///</summary>
		
		private bool? is_global_;
		
		///<summary>
		/// 变价生成时间
		///</summary>
		
		private System.DateTime? create_time_;
		
		public string GetSale_price_change_no(){
			return this.sale_price_change_no_;
		}
		
		public void SetSale_price_change_no(string value){
			this.sale_price_change_no_ = value;
		}
		public string GetStore_code(){
			return this.store_code_;
		}
		
		public void SetStore_code(string value){
			this.store_code_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetSuggestion_retail_price(){
			return this.suggestion_retail_price_;
		}
		
		public void SetSuggestion_retail_price(string value){
			this.suggestion_retail_price_ = value;
		}
		public string GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(string value){
			this.discount_ = value;
		}
		public string GetSale_price(){
			return this.sale_price_;
		}
		
		public void SetSale_price(string value){
			this.sale_price_ = value;
		}
		public System.DateTime? GetStart_effective_time(){
			return this.start_effective_time_;
		}
		
		public void SetStart_effective_time(System.DateTime? value){
			this.start_effective_time_ = value;
		}
		public System.DateTime? GetEnd_effective_time(){
			return this.end_effective_time_;
		}
		
		public void SetEnd_effective_time(System.DateTime? value){
			this.end_effective_time_ = value;
		}
		public bool? GetIs_global(){
			return this.is_global_;
		}
		
		public void SetIs_global(bool? value){
			this.is_global_ = value;
		}
		public System.DateTime? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(System.DateTime? value){
			this.create_time_ = value;
		}
		
	}
	
}