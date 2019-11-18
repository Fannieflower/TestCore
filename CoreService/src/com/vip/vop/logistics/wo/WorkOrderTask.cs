using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class WorkOrderTask {
		
		///<summary>
		/// 附件链接地址
		/// @sampleValue task_id http://vip.com/xxxxx.jpg
		///</summary>
		
		private int? task_id_;
		
		///<summary>
		/// 任务类型：0-主要步骤，1-备注，4-附件，5-催促，6-跟进复核
		/// @sampleValue task_type 0
		///</summary>
		
		private int? task_type_;
		
		///<summary>
		/// 任务名称
		/// @sampleValue task_name 1566437975000
		///</summary>
		
		private string task_name_;
		
		///<summary>
		/// 处理内容
		/// @sampleValue process_content 1566437975000
		///</summary>
		
		private string process_content_;
		
		///<summary>
		/// 状态描述：处理中,成功,审批中,已结案,失败,审批通过,已放弃,等待审核,审批通过且下送,已下送,审批不通过,接管,审批通过且结案,处理申请变更,编辑
		/// @sampleValue task_state_desc 0
		///</summary>
		
		private string task_state_desc_;
		
		///<summary>
		/// 到期时间 （单位:毫秒）
		/// @sampleValue expire_time 1566437975000
		///</summary>
		
		private long? expire_time_;
		
		///<summary>
		/// 拓展信息
		/// @sampleValue ext_info 
		///</summary>
		
		private string ext_info_;
		
		///<summary>
		/// 创建时间 （单位:毫秒）
		/// @sampleValue create_time 1566437975000
		///</summary>
		
		private long? create_time_;
		
		///<summary>
		/// 工单号
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		public int? GetTask_id(){
			return this.task_id_;
		}
		
		public void SetTask_id(int? value){
			this.task_id_ = value;
		}
		public int? GetTask_type(){
			return this.task_type_;
		}
		
		public void SetTask_type(int? value){
			this.task_type_ = value;
		}
		public string GetTask_name(){
			return this.task_name_;
		}
		
		public void SetTask_name(string value){
			this.task_name_ = value;
		}
		public string GetProcess_content(){
			return this.process_content_;
		}
		
		public void SetProcess_content(string value){
			this.process_content_ = value;
		}
		public string GetTask_state_desc(){
			return this.task_state_desc_;
		}
		
		public void SetTask_state_desc(string value){
			this.task_state_desc_ = value;
		}
		public long? GetExpire_time(){
			return this.expire_time_;
		}
		
		public void SetExpire_time(long? value){
			this.expire_time_ = value;
		}
		public string GetExt_info(){
			return this.ext_info_;
		}
		
		public void SetExt_info(string value){
			this.ext_info_ = value;
		}
		public long? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(long? value){
			this.create_time_ = value;
		}
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		
	}
	
}