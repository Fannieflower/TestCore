using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractSalesNameResultModel {
		
		///<summary>
		/// 专场名称结果集
		///</summary>
		
		private List<string> salesNameList_;
		
		public List<string> GetSalesNameList(){
			return this.salesNameList_;
		}
		
		public void SetSalesNameList(List<string> value){
			this.salesNameList_ = value;
		}
		
	}
	
}