using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderSelectAllReq {
		
		///<summary>
		/// 采购类型:0=内采,1=外采
		///</summary>
		
		private byte? purchaseType_;
		
		public byte? GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(byte? value){
			this.purchaseType_ = value;
		}
		
	}
	
}