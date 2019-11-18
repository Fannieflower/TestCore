using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class StoreInfo {
		
		///<summary>
		/// 店铺id
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 店铺名称
		///</summary>
		
		private string storeName_;
		
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public string GetStoreName(){
			return this.storeName_;
		}
		
		public void SetStoreName(string value){
			this.storeName_ = value;
		}
		
	}
	
}