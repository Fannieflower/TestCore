using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class ConfirmPoWarehouseReceiptResp {
		
		///<summary>
		/// 返回码(0:成功)
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 描述
		///</summary>
		
		private string message_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}