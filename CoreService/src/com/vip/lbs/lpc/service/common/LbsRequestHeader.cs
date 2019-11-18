using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.common{
	
	
	
	
	
	public class LbsRequestHeader {
		
		///<summary>
		/// 请求方系统域名
		///</summary>
		
		private string calledDomain_;
		
		///<summary>
		/// 请求方请求时间
		///</summary>
		
		private long? requestTime_;
		
		public string GetCalledDomain(){
			return this.calledDomain_;
		}
		
		public void SetCalledDomain(string value){
			this.calledDomain_ = value;
		}
		public long? GetRequestTime(){
			return this.requestTime_;
		}
		
		public void SetRequestTime(long? value){
			this.requestTime_ = value;
		}
		
	}
	
}