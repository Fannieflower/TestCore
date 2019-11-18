using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class GetAscInfoRequest {
		
		///<summary>
		/// 售后申请单号
		///</summary>
		
		private string asc_sn_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operator_;
		
		public string GetAsc_sn(){
			return this.asc_sn_;
		}
		
		public void SetAsc_sn(string value){
			this.asc_sn_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}