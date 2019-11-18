using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class DecryptData {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 解密内容
		///</summary>
		
		private List<vipapis.marketplace.delivery.DecryptItem> decrypt_items_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public List<vipapis.marketplace.delivery.DecryptItem> GetDecrypt_items(){
			return this.decrypt_items_;
		}
		
		public void SetDecrypt_items(List<vipapis.marketplace.delivery.DecryptItem> value){
			this.decrypt_items_ = value;
		}
		
	}
	
}