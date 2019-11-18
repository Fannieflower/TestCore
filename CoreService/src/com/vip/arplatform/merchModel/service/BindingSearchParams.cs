using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.arplatform.merchModel.service{
	
	
	
	
	
	public class BindingSearchParams {
		
		///<summary>
		/// 模型ID
		///</summary>
		
		private string materialId_;
		
		///<summary>
		/// spu
		///</summary>
		
		private long? spu_;
		
		///<summary>
		/// barcode
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// vendorId
		///</summary>
		
		private int? vendorId_;
		
		///<summary>
		/// 启用状态, 0=关闭, 1=启用, 2=全部
		///</summary>
		
		private byte? status_;
		
		public string GetMaterialId(){
			return this.materialId_;
		}
		
		public void SetMaterialId(string value){
			this.materialId_ = value;
		}
		public long? GetSpu(){
			return this.spu_;
		}
		
		public void SetSpu(long? value){
			this.spu_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetVendorId(){
			return this.vendorId_;
		}
		
		public void SetVendorId(int? value){
			this.vendorId_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		
	}
	
}