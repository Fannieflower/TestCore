using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.oto{
	
	
	
	
	
	public class VendorIdAndBarcode {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_Id_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		public int? GetVendor_Id(){
			return this.vendor_Id_;
		}
		
		public void SetVendor_Id(int? value){
			this.vendor_Id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		
	}
	
}