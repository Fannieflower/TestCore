using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.common.process.template{
	
	
	public class ProcessTemplateServiceHelper {
		
		
		
		public class createProcessTemplate_args {
			
			///<summary>
			/// 创建流程模板请求
			///</summary>
			
			private com.vip.vop.common.process.template.CreateProcessTemplateReq createProcessTemplateReq_;
			
			public com.vip.vop.common.process.template.CreateProcessTemplateReq GetCreateProcessTemplateReq(){
				return this.createProcessTemplateReq_;
			}
			
			public void SetCreateProcessTemplateReq(com.vip.vop.common.process.template.CreateProcessTemplateReq value){
				this.createProcessTemplateReq_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updateProcessTemplate_args {
			
			///<summary>
			/// 更新流程模板请求
			///</summary>
			
			private com.vip.vop.common.process.template.UpdateProcessTemplateReq updateProcessTemplateReq_;
			
			public com.vip.vop.common.process.template.UpdateProcessTemplateReq GetUpdateProcessTemplateReq(){
				return this.updateProcessTemplateReq_;
			}
			
			public void SetUpdateProcessTemplateReq(com.vip.vop.common.process.template.UpdateProcessTemplateReq value){
				this.updateProcessTemplateReq_ = value;
			}
			
		}
		
		
		
		
		public class createProcessTemplate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.common.process.template.CreateProcessTemplateResp success_;
			
			public com.vip.vop.common.process.template.CreateProcessTemplateResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.common.process.template.CreateProcessTemplateResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateProcessTemplate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.common.process.template.UpdateProcessTemplateResp success_;
			
			public com.vip.vop.common.process.template.UpdateProcessTemplateResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.common.process.template.UpdateProcessTemplateResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class createProcessTemplate_argsHelper : TBeanSerializer<createProcessTemplate_args>
		{
			
			public static createProcessTemplate_argsHelper OBJ = new createProcessTemplate_argsHelper();
			
			public static createProcessTemplate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createProcessTemplate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.process.template.CreateProcessTemplateReq value;
					
					value = new com.vip.vop.common.process.template.CreateProcessTemplateReq();
					com.vip.vop.common.process.template.CreateProcessTemplateReqHelper.getInstance().Read(value, iprot);
					
					structs.SetCreateProcessTemplateReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createProcessTemplate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreateProcessTemplateReq() != null) {
					
					oprot.WriteFieldBegin("createProcessTemplateReq");
					
					com.vip.vop.common.process.template.CreateProcessTemplateReqHelper.getInstance().Write(structs.GetCreateProcessTemplateReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createProcessTemplate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProcessTemplate_argsHelper : TBeanSerializer<updateProcessTemplate_args>
		{
			
			public static updateProcessTemplate_argsHelper OBJ = new updateProcessTemplate_argsHelper();
			
			public static updateProcessTemplate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProcessTemplate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.process.template.UpdateProcessTemplateReq value;
					
					value = new com.vip.vop.common.process.template.UpdateProcessTemplateReq();
					com.vip.vop.common.process.template.UpdateProcessTemplateReqHelper.getInstance().Read(value, iprot);
					
					structs.SetUpdateProcessTemplateReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProcessTemplate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUpdateProcessTemplateReq() != null) {
					
					oprot.WriteFieldBegin("updateProcessTemplateReq");
					
					com.vip.vop.common.process.template.UpdateProcessTemplateReqHelper.getInstance().Write(structs.GetUpdateProcessTemplateReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProcessTemplate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createProcessTemplate_resultHelper : TBeanSerializer<createProcessTemplate_result>
		{
			
			public static createProcessTemplate_resultHelper OBJ = new createProcessTemplate_resultHelper();
			
			public static createProcessTemplate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createProcessTemplate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.process.template.CreateProcessTemplateResp value;
					
					value = new com.vip.vop.common.process.template.CreateProcessTemplateResp();
					com.vip.vop.common.process.template.CreateProcessTemplateRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createProcessTemplate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.common.process.template.CreateProcessTemplateRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createProcessTemplate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProcessTemplate_resultHelper : TBeanSerializer<updateProcessTemplate_result>
		{
			
			public static updateProcessTemplate_resultHelper OBJ = new updateProcessTemplate_resultHelper();
			
			public static updateProcessTemplate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProcessTemplate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.process.template.UpdateProcessTemplateResp value;
					
					value = new com.vip.vop.common.process.template.UpdateProcessTemplateResp();
					com.vip.vop.common.process.template.UpdateProcessTemplateRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProcessTemplate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.common.process.template.UpdateProcessTemplateRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProcessTemplate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProcessTemplateServiceClient : OspRestStub , ProcessTemplateService  {
			
			
			public ProcessTemplateServiceClient():base("com.vip.vop.common.process.template.ProcessTemplateService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.common.process.template.CreateProcessTemplateResp createProcessTemplate(com.vip.vop.common.process.template.CreateProcessTemplateReq createProcessTemplateReq_) {
				
				send_createProcessTemplate(createProcessTemplateReq_);
				return recv_createProcessTemplate(); 
				
			}
			
			
			private void send_createProcessTemplate(com.vip.vop.common.process.template.CreateProcessTemplateReq createProcessTemplateReq_){
				
				InitInvocation("createProcessTemplate");
				
				createProcessTemplate_args args = new createProcessTemplate_args();
				args.SetCreateProcessTemplateReq(createProcessTemplateReq_);
				
				SendBase(args, createProcessTemplate_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.common.process.template.CreateProcessTemplateResp recv_createProcessTemplate(){
				
				createProcessTemplate_result result = new createProcessTemplate_result();
				ReceiveBase(result, createProcessTemplate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.common.process.template.UpdateProcessTemplateResp updateProcessTemplate(com.vip.vop.common.process.template.UpdateProcessTemplateReq updateProcessTemplateReq_) {
				
				send_updateProcessTemplate(updateProcessTemplateReq_);
				return recv_updateProcessTemplate(); 
				
			}
			
			
			private void send_updateProcessTemplate(com.vip.vop.common.process.template.UpdateProcessTemplateReq updateProcessTemplateReq_){
				
				InitInvocation("updateProcessTemplate");
				
				updateProcessTemplate_args args = new updateProcessTemplate_args();
				args.SetUpdateProcessTemplateReq(updateProcessTemplateReq_);
				
				SendBase(args, updateProcessTemplate_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.common.process.template.UpdateProcessTemplateResp recv_updateProcessTemplate(){
				
				updateProcessTemplate_result result = new updateProcessTemplate_result();
				ReceiveBase(result, updateProcessTemplate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}