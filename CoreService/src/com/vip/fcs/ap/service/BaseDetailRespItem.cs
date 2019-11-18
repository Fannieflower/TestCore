using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class BaseDetailRespItem {
		
		///<summary>
		/// 状态码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 总数据量
		///</summary>
		
		private long? count_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public long? GetCount(){
			return this.count_;
		}
		
		public void SetCount(long? value){
			this.count_ = value;
		}
		
	}
	
}