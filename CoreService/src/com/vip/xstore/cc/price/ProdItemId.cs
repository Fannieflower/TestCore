using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class ProdItemId {
		
		///<summary>
		/// 公司编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
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
		
	}
	
}