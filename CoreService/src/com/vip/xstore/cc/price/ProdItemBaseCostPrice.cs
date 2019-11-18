using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class ProdItemBaseCostPrice {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 基础成本价
		///</summary>
		
		private string baseCostPrice_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetBaseCostPrice(){
			return this.baseCostPrice_;
		}
		
		public void SetBaseCostPrice(string value){
			this.baseCostPrice_ = value;
		}
		
	}
	
}