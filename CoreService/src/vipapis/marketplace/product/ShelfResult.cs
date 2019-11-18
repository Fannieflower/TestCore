using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.product{
	
	
	
	
	
	public class ShelfResult {
		
		///<summary>
		/// 操作结果
		///</summary>
		
		private bool? success_;
		
		///<summary>
		/// 操作信息
		///</summary>
		
		private string result_message_;
		
		public bool? GetSuccess(){
			return this.success_;
		}
		
		public void SetSuccess(bool? value){
			this.success_ = value;
		}
		public string GetResult_message(){
			return this.result_message_;
		}
		
		public void SetResult_message(string value){
			this.result_message_ = value;
		}
		
	}
	
}