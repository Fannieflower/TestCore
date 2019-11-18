using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidEpcDetailModel {
		
		///<summary>
		/// epc
		///</summary>
		
		private string epc_;
		
		///<summary>
		/// 箱号
		///</summary>
		
		private string cazeNo_;
		
		///<summary>
		/// 新条码
		///</summary>
		
		private string barcode_;
		
		public string GetEpc(){
			return this.epc_;
		}
		
		public void SetEpc(string value){
			this.epc_ = value;
		}
		public string GetCazeNo(){
			return this.cazeNo_;
		}
		
		public void SetCazeNo(string value){
			this.cazeNo_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		
	}
	
}