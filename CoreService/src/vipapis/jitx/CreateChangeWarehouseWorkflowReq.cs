using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class CreateChangeWarehouseWorkflowReq {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 工单列表,最大支持50
		///</summary>
		
		private List<vipapis.jitx.CreateWorkflow> workflows_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<vipapis.jitx.CreateWorkflow> GetWorkflows(){
			return this.workflows_;
		}
		
		public void SetWorkflows(List<vipapis.jitx.CreateWorkflow> value){
			this.workflows_ = value;
		}
		
	}
	
}