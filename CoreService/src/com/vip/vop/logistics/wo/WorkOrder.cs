using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class WorkOrder {
		
		///<summary>
		/// 工单号
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		///<summary>
		/// 处理状态 0-处理中，1-结案，2-放弃
		/// @sampleValue process_state 0
		///</summary>
		
		private int? process_state_;
		
		///<summary>
		/// 跟单超时时间 单位（毫秒）
		/// @sampleValue expire_time 1566437975000
		///</summary>
		
		private long? expire_time_;
		
		///<summary>
		/// 问题描述
		/// @sampleValue problem_desc 配送情况（会员咨询配送到哪)
		///</summary>
		
		private string problem_desc_;
		
		///<summary>
		/// 工单创建时间 单位（毫秒）
		/// @sampleValue create_time 1566437975000
		///</summary>
		
		private long? create_time_;
		
		///<summary>
		/// 工单状态变化状态：下送：delivery，复核：recheck，结案：finish，放弃：abandon，接管：takeover，备注：remark，来电备注：callremark，附件：attachment
		///</summary>
		
		private string action_type_;
		
		///<summary>
		/// 唯一码
		///</summary>
		
		private string work_order_id_;
		
		///<summary>
		/// 问题三级分类编码
		///</summary>
		
		private string pc3_code_;
		
		///<summary>
		/// 问题三级分类名称
		///</summary>
		
		private string pc3_name_;
		
		///<summary>
		/// 工单状态附加信息
		///</summary>
		
		private com.vip.vop.logistics.wo.StateAppendixInfo state_appendix_info_;
		
		///<summary>
		/// 物流单号
		/// @sampleValue logistics_nos 0
		///</summary>
		
		private List<string> logistics_nos_;
		
		///<summary>
		/// 复核结果列表
		///</summary>
		
		private List<com.vip.vop.logistics.wo.RecheckResult> recheck_results_;
		
		///<summary>
		/// 工单附件列表
		///</summary>
		
		private List<com.vip.vop.logistics.wo.Attachment> attachments_;
		
		///<summary>
		/// 历史工单处理列表
		///</summary>
		
		private List<com.vip.vop.logistics.wo.WorkOrderTask> work_order_tasks_;
		
		///<summary>
		/// 硬性选择项列表
		///</summary>
		
		private List<com.vip.vop.logistics.wo.OptionAppendixInfo> option_appendix_infos_;
		
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		public int? GetProcess_state(){
			return this.process_state_;
		}
		
		public void SetProcess_state(int? value){
			this.process_state_ = value;
		}
		public long? GetExpire_time(){
			return this.expire_time_;
		}
		
		public void SetExpire_time(long? value){
			this.expire_time_ = value;
		}
		public string GetProblem_desc(){
			return this.problem_desc_;
		}
		
		public void SetProblem_desc(string value){
			this.problem_desc_ = value;
		}
		public long? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(long? value){
			this.create_time_ = value;
		}
		public string GetAction_type(){
			return this.action_type_;
		}
		
		public void SetAction_type(string value){
			this.action_type_ = value;
		}
		public string GetWork_order_id(){
			return this.work_order_id_;
		}
		
		public void SetWork_order_id(string value){
			this.work_order_id_ = value;
		}
		public string GetPc3_code(){
			return this.pc3_code_;
		}
		
		public void SetPc3_code(string value){
			this.pc3_code_ = value;
		}
		public string GetPc3_name(){
			return this.pc3_name_;
		}
		
		public void SetPc3_name(string value){
			this.pc3_name_ = value;
		}
		public com.vip.vop.logistics.wo.StateAppendixInfo GetState_appendix_info(){
			return this.state_appendix_info_;
		}
		
		public void SetState_appendix_info(com.vip.vop.logistics.wo.StateAppendixInfo value){
			this.state_appendix_info_ = value;
		}
		public List<string> GetLogistics_nos(){
			return this.logistics_nos_;
		}
		
		public void SetLogistics_nos(List<string> value){
			this.logistics_nos_ = value;
		}
		public List<com.vip.vop.logistics.wo.RecheckResult> GetRecheck_results(){
			return this.recheck_results_;
		}
		
		public void SetRecheck_results(List<com.vip.vop.logistics.wo.RecheckResult> value){
			this.recheck_results_ = value;
		}
		public List<com.vip.vop.logistics.wo.Attachment> GetAttachments(){
			return this.attachments_;
		}
		
		public void SetAttachments(List<com.vip.vop.logistics.wo.Attachment> value){
			this.attachments_ = value;
		}
		public List<com.vip.vop.logistics.wo.WorkOrderTask> GetWork_order_tasks(){
			return this.work_order_tasks_;
		}
		
		public void SetWork_order_tasks(List<com.vip.vop.logistics.wo.WorkOrderTask> value){
			this.work_order_tasks_ = value;
		}
		public List<com.vip.vop.logistics.wo.OptionAppendixInfo> GetOption_appendix_infos(){
			return this.option_appendix_infos_;
		}
		
		public void SetOption_appendix_infos(List<com.vip.vop.logistics.wo.OptionAppendixInfo> value){
			this.option_appendix_infos_ = value;
		}
		
	}
	
}