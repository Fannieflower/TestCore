using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class AddressSimpleInfo {
		
		///<summary>
		/// 地址编码
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 地址名称
		///</summary>
		
		private string name_;
		
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		
	}
	
}