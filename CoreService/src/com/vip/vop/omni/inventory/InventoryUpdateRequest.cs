using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.omni.inventory{
	
	
	
	
	
	public class InventoryUpdateRequest {
		
		///<summary>
		/// 流水号，需保证流水号唯一，长度不超过20
		///</summary>
		
		private string batch_no_;
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 常态合作编码
		///</summary>
		
		private int? cooperation_no_;
		
		///<summary>
		/// 与store_sn二选一必填<br>如果是全国一盘货，则填写区域代码101<br>如果是OXO-LBS且按照分区仓库同步库存，则填仓库编码
		///</summary>
		
		private List<string> area_codes_;
		
		///<summary>
		/// 与area_codes二选一必填<br>如果按照门店同步库存，则填门店编码
		///</summary>
		
		private string store_sn_;
		
		///<summary>
		/// 商品条形码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 库存更新数量
		///</summary>
		
		private int? quantity_;
		
		public string GetBatch_no(){
			return this.batch_no_;
		}
		
		public void SetBatch_no(string value){
			this.batch_no_ = value;
		}
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public int? GetCooperation_no(){
			return this.cooperation_no_;
		}
		
		public void SetCooperation_no(int? value){
			this.cooperation_no_ = value;
		}
		public List<string> GetArea_codes(){
			return this.area_codes_;
		}
		
		public void SetArea_codes(List<string> value){
			this.area_codes_ = value;
		}
		public string GetStore_sn(){
			return this.store_sn_;
		}
		
		public void SetStore_sn(string value){
			this.store_sn_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		
	}
	
}