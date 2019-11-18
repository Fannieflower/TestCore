using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidDataRequest {
		
		///<summary>
		/// 商品rfid
		///</summary>
		
		private string rfid_;
		
		///<summary>
		/// 商品barcode
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 主体
		///</summary>
		
		private string owner_;
		
		public string GetRfid(){
			return this.rfid_;
		}
		
		public void SetRfid(string value){
			this.rfid_ = value;
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