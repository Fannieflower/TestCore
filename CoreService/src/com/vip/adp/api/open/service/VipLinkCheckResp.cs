using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class VipLinkCheckResp {
		
		///<summary>
		/// 解析成功map，key为原始url
		///</summary>
		
		private Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> successMap_;
		
		///<summary>
		/// 解析失败map，key为原始url
		///</summary>
		
		private Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> failMap_;
		
		public Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> GetSuccessMap(){
			return this.successMap_;
		}
		
		public void SetSuccessMap(Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> value){
			this.successMap_ = value;
		}
		public Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> GetFailMap(){
			return this.failMap_;
		}
		
		public void SetFailMap(Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> value){
			this.failMap_ = value;
		}
		
	}
	
}