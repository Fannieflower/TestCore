using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderImportRequest {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchaseNo_;
		
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		
	}
	
}