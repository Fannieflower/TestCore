using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ItemProperty {
		
		///<summary>
		/// 属性名称，比如：材质
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 属性值，比如：牛皮
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