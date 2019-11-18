using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ItemDetailModule {
		
		///<summary>
		/// 模块名称（统一使用中文名称）
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 模块内容
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