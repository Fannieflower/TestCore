using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class SMSRequestModel {
		
		///<summary>
		/// 域名，用于标识短信请求的来源。
		///</summary>
		
		private string domain_;
		
		///<summary>
		/// IP地址，用于标识短信请求的来源。
		///</summary>
		
		private string ip_;
		
		///<summary>
		/// “事件发生时间”的毫秒数，不传时，使用服务端“任务接收时间”的毫秒数代替。
		///</summary>
		
		private long? milliseconds_;
		
		///<summary>
		/// 短信内容
		///</summary>
		
		private string msgContent_;
		
		///<summary>
		/// 接收短信的手机号，可以有多个，上限为500个。不传时，从配置中心读取当前域的收信人。
		///</summary>
		
		private List<string> phoneNumbers_;
		
		public string GetDomain(){
			return this.domain_;
		}
		
		public void SetDomain(string value){
			this.domain_ = value;
		}
		public string GetIp(){
			return this.ip_;
		}
		
		public void SetIp(string value){
			this.ip_ = value;
		}
		public long? GetMilliseconds(){
			return this.milliseconds_;
		}
		
		public void SetMilliseconds(long? value){
			this.milliseconds_ = value;
		}
		public string GetMsgContent(){
			return this.msgContent_;
		}
		
		public void SetMsgContent(string value){
			this.msgContent_ = value;
		}
		public List<string> GetPhoneNumbers(){
			return this.phoneNumbers_;
		}
		
		public void SetPhoneNumbers(List<string> value){
			this.phoneNumbers_ = value;
		}
		
	}
	
}