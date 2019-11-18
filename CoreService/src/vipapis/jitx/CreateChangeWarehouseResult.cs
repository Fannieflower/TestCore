using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class CreateChangeWarehouseResult {
		
		///<summary>
		/// 处理结果 SUCCESS / FAILED
		///</summary>
		
		private string result_;
		
		///<summary>
		/// 工单号: SUCCESS时为非空,FAILED时为空
		///</summary>
		
		private string workflow_sn_;
		
		///<summary>
		/// 请求流水号
		///</summary>
		
		private string request_id_;
		
		///<summary>
		/// 创建结果
		///</summary>
		
		private string error_code_;
		
		///<summary>
		/// 成功/失败编码 SUCCESS时不写,FAILED时写对应的原因编码
		///</summary>
		
		private string error_msg_;
		
		public string GetResult(){
			return this.result_;
		}
		
		public void SetResult(string value){
			this.result_ = value;
		}
		public string GetWorkflow_sn(){
			return this.workflow_sn_;
		}
		
		public void SetWorkflow_sn(string value){
			this.workflow_sn_ = value;
		}
		public string GetRequest_id(){
			return this.request_id_;
		}
		
		public void SetRequest_id(string value){
			this.request_id_ = value;
		}
		public string GetError_code(){
			return this.error_code_;
		}
		
		public void SetError_code(string value){
			this.error_code_ = value;
		}
		public string GetError_msg(){
			return this.error_msg_;
		}
		
		public void SetError_msg(string value){
			this.error_msg_ = value;
		}
		
	}
	
}