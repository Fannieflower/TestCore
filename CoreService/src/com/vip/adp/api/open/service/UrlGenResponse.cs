using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class UrlGenResponse {
		
		///<summary>
		/// 链接数据
		///</summary>
		
		private List<com.vip.adp.api.open.service.UrlInfo> urlInfoList_;
		
		public List<com.vip.adp.api.open.service.UrlInfo> GetUrlInfoList(){
			return this.urlInfoList_;
		}
		
		public void SetUrlInfoList(List<com.vip.adp.api.open.service.UrlInfo> value){
			this.urlInfoList_ = value;
		}
		
	}
	
}