using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class TaxOrderItem {
		
		///<summary>
		/// 条码/sku
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string title_;
		
		///<summary>
		/// 增值税率
		///</summary>
		
		private double? taxRate_;
		
		///<summary>
		/// 税目简称
		///</summary>
		
		private string taxName_;
		
		///<summary>
		/// 税目编码
		///</summary>
		
		private string taxCode_;
		
		///<summary>
		/// 商品数量(最终开票数量)
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 原价
		///</summary>
		
		private double? marketPrice_;
		
		///<summary>
		/// 最终零售价
		///</summary>
		
		private double? salePrice_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		public double? GetTaxRate(){
			return this.taxRate_;
		}
		
		public void SetTaxRate(double? value){
			this.taxRate_ = value;
		}
		public string GetTaxName(){
			return this.taxName_;
		}
		
		public void SetTaxName(string value){
			this.taxName_ = value;
		}
		public string GetTaxCode(){
			return this.taxCode_;
		}
		
		public void SetTaxCode(string value){
			this.taxCode_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public double? GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(double? value){
			this.marketPrice_ = value;
		}
		public double? GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(double? value){
			this.salePrice_ = value;
		}
		
	}
	
}