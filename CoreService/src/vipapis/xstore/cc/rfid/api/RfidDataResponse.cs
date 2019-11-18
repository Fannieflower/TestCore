using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidDataResponse {
		
		///<summary>
		/// 商品rfid
		///</summary>
		
		private string rfid_;
		
		///<summary>
		/// 商品barcode
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 返回码, 0: success 1: failed
		///</summary>
		
		private int? code_;
		
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
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		
	}
	
}