using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipUserOperateSignCheck {
		
		///<summary>
		/// 签名的key
		///</summary>
		
		private string appKey_;
		
		///<summary>
		/// 签名
		///</summary>
		
		private string sign_;
		
		public string GetAppKey(){
			return this.appKey_;
		}
		
		public void SetAppKey(string value){
			this.appKey_ = value;
		}
		public string GetSign(){
			return this.sign_;
		}
		
		public void SetSign(string value){
			this.sign_ = value;
		}
		
	}
	
}