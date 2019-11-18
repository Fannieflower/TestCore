using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class SortField {
		
		///<summary>
		/// 排序字段
		///</summary>
		
		private string fieldName_;
		
		///<summary>
		/// 字段说明
		///</summary>
		
		private string fieldDesc_;
		
		public string GetFieldName(){
			return this.fieldName_;
		}
		
		public void SetFieldName(string value){
			this.fieldName_ = value;
		}
		public string GetFieldDesc(){
			return this.fieldDesc_;
		}
		
		public void SetFieldDesc(string value){
			this.fieldDesc_ = value;
		}
		
	}
	
}