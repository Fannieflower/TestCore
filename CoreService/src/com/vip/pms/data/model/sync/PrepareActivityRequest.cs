using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class PrepareActivityRequest {
		
		///<summary>
		/// 营销对象名称
		///</summary>
		
		private string name_;
		
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		
	}
	
}