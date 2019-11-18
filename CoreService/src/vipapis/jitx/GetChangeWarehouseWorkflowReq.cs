using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetChangeWarehouseWorkflowReq {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 工单号集合 批量最大支持50<br>（工单号集合 / 订单号集合 / 时间段两个查询条件 需至少三选一）
		///</summary>
		
		private List<string> workflow_sns_;
		
		///<summary>
		/// 订单号集合 批量最大支持50 <br>（工单号集合 / 订单号集合 / 时间段两个查询条件 需至少三选一）
		///</summary>
		
		private List<string> order_sns_;
		
		///<summary>
		/// 工单状态  工单状态：100=新建,200=处理中,300=通过,400=驳回,900=取消
		///</summary>
		
		private List<string> workflow_states_;
		
		///<summary>
		/// 查询开始时间(epoch格式时间戳)，且小于endTime <br>工单号集合 / 订单号集合 / 时间段两个查询条件 需至少三选一 时间段最大支持两周，最早时间最早支持半年前
		///</summary>
		
		private long? start_time_;
		
		///<summary>
		/// 查询结束时间（epoch格式时间戳）<br>工单号集合 / 订单号集合 / 时间段两个查询条件 需至少三选一
		///</summary>
		
		private long? end_time_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页数量 最大100,默认50
		///</summary>
		
		private int? pageSize_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<string> GetWorkflow_sns(){
			return this.workflow_sns_;
		}
		
		public void SetWorkflow_sns(List<string> value){
			this.workflow_sns_ = value;
		}
		public List<string> GetOrder_sns(){
			return this.order_sns_;
		}
		
		public void SetOrder_sns(List<string> value){
			this.order_sns_ = value;
		}
		public List<string> GetWorkflow_states(){
			return this.workflow_states_;
		}
		
		public void SetWorkflow_states(List<string> value){
			this.workflow_states_ = value;
		}
		public long? GetStart_time(){
			return this.start_time_;
		}
		
		public void SetStart_time(long? value){
			this.start_time_ = value;
		}
		public long? GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(long? value){
			this.end_time_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}