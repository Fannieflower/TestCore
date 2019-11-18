using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class ShutDownPoParam {
		
		///<summary>
		/// po采购单号
		///</summary>
		
		private string po_;
		
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		
	}
	
}