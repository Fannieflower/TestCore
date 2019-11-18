using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class PoCloseMessage {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// PO来源: SI, PR
		///</summary>
		
		private string source_;
		
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		
	}
	
}