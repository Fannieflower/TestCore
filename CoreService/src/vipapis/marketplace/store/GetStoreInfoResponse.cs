using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.store{
	
	
	
	
	
	public class GetStoreInfoResponse {
		
		///<summary>
		/// 店铺ID
		///</summary>
		
		private string store_id_;
		
		///<summary>
		/// 商家ID
		///</summary>
		
		private string seller_id_;
		
		///<summary>
		/// 店铺名称
		///</summary>
		
		private string store_name_;
		
		///<summary>
		/// 店铺状态(1-NOT_READY:未激活,2-OPEN:正常运营,3-SUSPEND:暂停运营,4-FROZEN:冻结运营,5-CLOSED:已关停)
		///</summary>
		
		private string store_status_;
		
		///<summary>
		/// 店铺LOGO地址
		///</summary>
		
		private string store_logo_;
		
		public string GetStore_id(){
			return this.store_id_;
		}
		
		public void SetStore_id(string value){
			this.store_id_ = value;
		}
		public string GetSeller_id(){
			return this.seller_id_;
		}
		
		public void SetSeller_id(string value){
			this.seller_id_ = value;
		}
		public string GetStore_name(){
			return this.store_name_;
		}
		
		public void SetStore_name(string value){
			this.store_name_ = value;
		}
		public string GetStore_status(){
			return this.store_status_;
		}
		
		public void SetStore_status(string value){
			this.store_status_ = value;
		}
		public string GetStore_logo(){
			return this.store_logo_;
		}
		
		public void SetStore_logo(string value){
			this.store_logo_ = value;
		}
		
	}
	
}