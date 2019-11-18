using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.inventory{
	
	
	
	
	
	public class InventoryOpResult {
		
		///<summary>
		/// 结果码,200代表操作成功，201代表操作成功：对应的请求重复执行，其他代表失败
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