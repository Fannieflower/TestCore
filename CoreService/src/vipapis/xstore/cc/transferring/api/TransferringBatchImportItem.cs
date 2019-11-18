using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringBatchImportItem {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? qty_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQty(){
			return this.qty_;
		}
		
		public void SetQty(int? value){
			this.qty_ = value;
		}
		
	}
	
}