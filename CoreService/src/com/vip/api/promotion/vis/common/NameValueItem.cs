using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.common{
	
	
	
	
	
	public class NameValueItem {
		
		///<summary>
		/// 名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 值
		///</summary>
		
		private string value_;
		
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetValue(){
			return this.value_;
		}
		
		public void SetValue(string value){
			this.value_ = value;
		}
		
	}
	
}