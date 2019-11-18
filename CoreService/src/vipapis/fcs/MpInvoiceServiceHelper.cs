using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.fcs{
	
	
	public class MpInvoiceServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class receiveMpInvoiceIssueResult_args {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel pushMpInvoiceIssueResultRequestModel_;
			
			public com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel GetPushMpInvoiceIssueResultRequestModel(){
				return this.pushMpInvoiceIssueResultRequestModel_;
			}
			
			public void SetPushMpInvoiceIssueResultRequestModel(com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel value){
				this.pushMpInvoiceIssueResultRequestModel_ = value;
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
		
		
		
		
		public class receiveMpInvoiceIssueResult_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel success_;
			
			public com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel value){
				this.success_ = value;
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
		
		
		
		
		public class receiveMpInvoiceIssueResult_argsHelper : TBeanSerializer<receiveMpInvoiceIssueResult_args>
		{
			
			public static receiveMpInvoiceIssueResult_argsHelper OBJ = new receiveMpInvoiceIssueResult_argsHelper();
			
			public static receiveMpInvoiceIssueResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveMpInvoiceIssueResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel value;
					
					value = new com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel();
					com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetPushMpInvoiceIssueResultRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveMpInvoiceIssueResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPushMpInvoiceIssueResultRequestModel() != null) {
					
					oprot.WriteFieldBegin("pushMpInvoiceIssueResultRequestModel");
					
					com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModelHelper.getInstance().Write(structs.GetPushMpInvoiceIssueResultRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveMpInvoiceIssueResult_args bean){
				
				
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
		
		
		
		
		public class receiveMpInvoiceIssueResult_resultHelper : TBeanSerializer<receiveMpInvoiceIssueResult_result>
		{
			
			public static receiveMpInvoiceIssueResult_resultHelper OBJ = new receiveMpInvoiceIssueResult_resultHelper();
			
			public static receiveMpInvoiceIssueResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveMpInvoiceIssueResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel value;
					
					value = new com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel();
					com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveMpInvoiceIssueResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveMpInvoiceIssueResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class MpInvoiceServiceClient : OspRestStub , MpInvoiceService  {
			
			
			public MpInvoiceServiceClient():base("vipapis.fcs.MpInvoiceService","1.0.0") {
				
				
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
			
			
			public com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel receiveMpInvoiceIssueResult(com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel pushMpInvoiceIssueResultRequestModel_) {
				
				send_receiveMpInvoiceIssueResult(pushMpInvoiceIssueResultRequestModel_);
				return recv_receiveMpInvoiceIssueResult(); 
				
			}
			
			
			private void send_receiveMpInvoiceIssueResult(com.vip.fcs.vei.service.MpInvoiceIssueResultRequestModel pushMpInvoiceIssueResultRequestModel_){
				
				InitInvocation("receiveMpInvoiceIssueResult");
				
				receiveMpInvoiceIssueResult_args args = new receiveMpInvoiceIssueResult_args();
				args.SetPushMpInvoiceIssueResultRequestModel(pushMpInvoiceIssueResultRequestModel_);
				
				SendBase(args, receiveMpInvoiceIssueResult_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vei.service.MpInvoiceIssueResultResponseModel recv_receiveMpInvoiceIssueResult(){
				
				receiveMpInvoiceIssueResult_result result = new receiveMpInvoiceIssueResult_result();
				ReceiveBase(result, receiveMpInvoiceIssueResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}