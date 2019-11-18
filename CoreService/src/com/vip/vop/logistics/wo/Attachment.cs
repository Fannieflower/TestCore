using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class Attachment {
		
		///<summary>
		/// 附件链接地址
		/// @sampleValue attach_url http://vip.com/xxxxx.jpg
		///</summary>
		
		private string attach_url_;
		
		///<summary>
		/// 创建时间 （单位:毫秒）
		/// @sampleValue create_time 1566437975000
		///</summary>
		
		private long? create_time_;
		
		public string GetAttach_url(){
			return this.attach_url_;
		}
		
		public void SetAttach_url(string value){
			this.attach_url_ = value;
		}
		public long? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(long? value){
			this.create_time_ = value;
		}
		
	}
	
}