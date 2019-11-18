using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetChangeWarehouseWorkflowResult {
		
		///<summary>
		/// 请求流水号
		///</summary>
		
		private string request_id_;
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 工单号
		///</summary>
		
		private string workflow_sn_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 工单状态
		///</summary>
		
		private string workflow_state_;
		
		///<summary>
		/// 旧发货仓库
		///</summary>
		
		private string old_delivery_warehouse_;
		
		///<summary>
		/// 新发货仓库
		///</summary>
		
		private string new_delivery_warehouse_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private long? update_time_;
		
		///<summary>
		/// 备注  workflow_state = 400 驳回 时为非空
		///</summary>
		
		private string reject_remark_;
		
		public string GetRequest_id(){
			return this.request_id_;
		}
		
		public void SetRequest_id(string value){
			this.request_id_ = value;
		}
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public string GetWorkflow_sn(){
			return this.workflow_sn_;
		}
		
		public void SetWorkflow_sn(string value){
			this.workflow_sn_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetWorkflow_state(){
			return this.workflow_state_;
		}
		
		public void SetWorkflow_state(string value){
			this.workflow_state_ = value;
		}
		public string GetOld_delivery_warehouse(){
			return this.old_delivery_warehouse_;
		}
		
		public void SetOld_delivery_warehouse(string value){
			this.old_delivery_warehouse_ = value;
		}
		public string GetNew_delivery_warehouse(){
			return this.new_delivery_warehouse_;
		}
		
		public void SetNew_delivery_warehouse(string value){
			this.new_delivery_warehouse_ = value;
		}
		public long? GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(long? value){
			this.update_time_ = value;
		}
		public string GetReject_remark(){
			return this.reject_remark_;
		}
		
		public void SetReject_remark(string value){
			this.reject_remark_ = value;
		}
		
	}
	
}