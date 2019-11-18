using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetChangeWarehouseWorkflowResp {
		
		///<summary>
		/// 总条数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 工单列表
		///</summary>
		
		private List<vipapis.jitx.GetChangeWarehouseWorkflowResult> results_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.GetChangeWarehouseWorkflowResult> GetResults(){
			return this.results_;
		}
		
		public void SetResults(List<vipapis.jitx.GetChangeWarehouseWorkflowResult> value){
			this.results_ = value;
		}
		
	}
	
}