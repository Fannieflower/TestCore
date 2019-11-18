using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class DecryptRequest {
		
		///<summary>
		/// 待解密内容
		///</summary>
		
		private List<vipapis.marketplace.delivery.EncryptData> encrypt_datas_;
		
		///<summary>
		/// 拓展信息(解密业务类型、浏览器、客户端ip等信息)
		///</summary>
		
		private Dictionary<vipapis.marketplace.delivery.DecryptExtendKey?, string> extend_infos_;
		
		public List<vipapis.marketplace.delivery.EncryptData> GetEncrypt_datas(){
			return this.encrypt_datas_;
		}
		
		public void SetEncrypt_datas(List<vipapis.marketplace.delivery.EncryptData> value){
			this.encrypt_datas_ = value;
		}
		public Dictionary<vipapis.marketplace.delivery.DecryptExtendKey?, string> GetExtend_infos(){
			return this.extend_infos_;
		}
		
		public void SetExtend_infos(Dictionary<vipapis.marketplace.delivery.DecryptExtendKey?, string> value){
			this.extend_infos_ = value;
		}
		
	}
	
}