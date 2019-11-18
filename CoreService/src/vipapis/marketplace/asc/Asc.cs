using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class Asc {
		
		///<summary>
		/// 售后申请单概要
		///</summary>
		
		private vipapis.marketplace.asc.AscBrief asc_brief_;
		
		///<summary>
		/// 关联工单，全部是工单号码
		///</summary>
		
		private List<string> problem_order_sns_;
		
		public vipapis.marketplace.asc.AscBrief GetAsc_brief(){
			return this.asc_brief_;
		}
		
		public void SetAsc_brief(vipapis.marketplace.asc.AscBrief value){
			this.asc_brief_ = value;
		}
		public List<string> GetProblem_order_sns(){
			return this.problem_order_sns_;
		}
		
		public void SetProblem_order_sns(List<string> value){
			this.problem_order_sns_ = value;
		}
		
	}
	
}