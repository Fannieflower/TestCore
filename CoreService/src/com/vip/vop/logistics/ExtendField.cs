using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class ExtendField {
		
		///<summary>
		/// 扩展字段key
		/// @sampleValue key 
		///</summary>
		
		private string key_;
		
		///<summary>
		/// 扩展字段value
		/// @sampleValue value 
		///</summary>
		
		private string value_;
		
		public string GetKey(){
			return this.key_;
		}
		
		public void SetKey(string value){
			this.key_ = value;
		}
		public string GetValue(){
			return this.value_;
		}
		
		public void SetValue(string value){
			this.value_ = value;
		}
		
	}
	
}