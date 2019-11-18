using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidSyncResultResponse {
		
		///<summary>
		/// 同步是否成功
		///</summary>
		
		private bool? result_;
		
		///<summary>
		/// 商品barcode
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 主体
		///</summary>
		
		private string owner_;
		
		public bool? GetResult(){
			return this.result_;
		}
		
		public void SetResult(bool? value){
			this.result_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetOwner(){
			return this.owner_;
		}
		
		public void SetOwner(string value){
			this.owner_ = value;
		}
		
	}
	
}