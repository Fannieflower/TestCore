using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.third.service{
	
	
	
	
	
	public class QueryParam {
		
		///<summary>
		/// 查询字符，支持模糊匹配
		///</summary>
		
		private string q_;
		
		///<summary>
		/// 查询数量限制，不填写时默认不限制
		///</summary>
		
		private int? limit_;
		
		public string GetQ(){
			return this.q_;
		}
		
		public void SetQ(string value){
			this.q_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}