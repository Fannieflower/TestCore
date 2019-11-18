using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class PidQueryRequest {
		
		///<summary>
		/// 推广为Id。
		///该参数不传时，会返回该userId下对应的所有的pid信息列表。
		///</summary>
		
		private List<string> pidList_;
		
		///<summary>
		/// 请求id：UUID。调用方自行定义的唯一标示，用于追踪单次请求。
		///</summary>
		
		private string requestId_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 页面大小：默认100
		///</summary>
		
		private int? pageSize_;
		
		public List<string> GetPidList(){
			return this.pidList_;
		}
		
		public void SetPidList(List<string> value){
			this.pidList_ = value;
		}
		public string GetRequestId(){
			return this.requestId_;
		}
		
		public void SetRequestId(string value){
			this.requestId_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}