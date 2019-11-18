using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class CreateWorkflowResp {
		
		///<summary>
		/// 总条数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 创建结果
		///</summary>
		
		private List<vipapis.jitx.CreateChangeWarehouseResult> results_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.CreateChangeWarehouseResult> GetResults(){
			return this.results_;
		}
		
		public void SetResults(List<vipapis.jitx.CreateChangeWarehouseResult> value){
			this.results_ = value;
		}
		
	}
	
}