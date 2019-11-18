using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.freight{
	
	
	
	
	
	public class FreightInfo {
		
		///<summary>
		/// 用于区分一整批请求的唯一主键，对应OrderInfo里的key
		///</summary>
		
		private string key_;
		
		///<summary>
		/// 运费
		///</summary>
		
		private string freight_;
		
		public string GetKey(){
			return this.key_;
		}
		
		public void SetKey(string value){
			this.key_ = value;
		}
		public string GetFreight(){
			return this.freight_;
		}
		
		public void SetFreight(string value){
			this.freight_ = value;
		}
		
	}
	
}