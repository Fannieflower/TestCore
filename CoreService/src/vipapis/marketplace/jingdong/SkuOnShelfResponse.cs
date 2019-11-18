using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.jingdong{
	
	
	
	
	
	public class SkuOnShelfResponse {
		
		///<summary>
		/// 上架结果，true表示成功，false表示失败
		///</summary>
		
		private bool? op_result_;
		
		public bool? GetOp_result(){
			return this.op_result_;
		}
		
		public void SetOp_result(bool? value){
			this.op_result_ = value;
		}
		
	}
	
}