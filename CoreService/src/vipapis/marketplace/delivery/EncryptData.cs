using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class EncryptData {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 带解密密文
		///</summary>
		
		private List<string> encrypt_codes_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public List<string> GetEncrypt_codes(){
			return this.encrypt_codes_;
		}
		
		public void SetEncrypt_codes(List<string> value){
			this.encrypt_codes_ = value;
		}
		
	}
	
}