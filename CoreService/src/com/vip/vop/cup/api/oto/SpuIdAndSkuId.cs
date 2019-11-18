using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.oto{
	
	
	
	
	
	public class SpuIdAndSkuId {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_Id_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// SPU ID
		///</summary>
		
		private long? v_spu_id_;
		
		///<summary>
		/// SKU ID
		///</summary>
		
		private long? v_sku_id_;
		
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
		public long? GetV_spu_id(){
			return this.v_spu_id_;
		}
		
		public void SetV_spu_id(long? value){
			this.v_spu_id_ = value;
		}
		public long? GetV_sku_id(){
			return this.v_sku_id_;
		}
		
		public void SetV_sku_id(long? value){
			this.v_sku_id_ = value;
		}
		
	}
	
}