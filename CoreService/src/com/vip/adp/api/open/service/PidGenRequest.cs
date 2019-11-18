using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class PidGenRequest {
		
		///<summary>
		/// 需要生成的推广位名称列表
		///注：
		///1、一次支持批量最大100个
		///2、每个推广位的名称最长50个字符
		///</summary>
		
		private List<string> pidNameList_;
		
		///<summary>
		/// 请求id：UUID。调用方自行定义的唯一标示，用于追踪单次请求。
		///</summary>
		
		private string requestId_;
		
		public List<string> GetPidNameList(){
			return this.pidNameList_;
		}
		
		public void SetPidNameList(List<string> value){
			this.pidNameList_ = value;
		}
		public string GetRequestId(){
			return this.requestId_;
		}
		
		public void SetRequestId(string value){
			this.requestId_ = value;
		}
		
	}
	
}