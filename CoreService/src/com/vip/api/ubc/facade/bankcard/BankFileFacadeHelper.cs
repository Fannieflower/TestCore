using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	public class BankFileFacadeHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class receiveBankData_args {
			
			///<summary>
			/// 银行数据传输请求参数模型
			///</summary>
			
			private com.vip.api.ubc.facade.bankcard.BankDataRequest request_;
			
			public com.vip.api.ubc.facade.bankcard.BankDataRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.api.ubc.facade.bankcard.BankDataRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class receiveBankFile_args {
			
			///<summary>
			/// 银行文件传输请求参数模型
			///</summary>
			
			private com.vip.api.ubc.facade.bankcard.BankFileRequest request_;
			
			public com.vip.api.ubc.facade.bankcard.BankFileRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.api.ubc.facade.bankcard.BankFileRequest value){
				this.request_ = value;
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
		
		
		
		
		public class receiveBankData_result {
			
			///<summary>
			///</summary>
			
			private com.vip.api.ubc.facade.bankcard.BankDataResponse success_;
			
			public com.vip.api.ubc.facade.bankcard.BankDataResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.ubc.facade.bankcard.BankDataResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class receiveBankFile_result {
			
			///<summary>
			///</summary>
			
			private com.vip.api.ubc.facade.bankcard.BankFileResponse success_;
			
			public com.vip.api.ubc.facade.bankcard.BankFileResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.ubc.facade.bankcard.BankFileResponse value){
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
		
		
		
		
		public class receiveBankData_argsHelper : TBeanSerializer<receiveBankData_args>
		{
			
			public static receiveBankData_argsHelper OBJ = new receiveBankData_argsHelper();
			
			public static receiveBankData_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveBankData_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.ubc.facade.bankcard.BankDataRequest value;
					
					value = new com.vip.api.ubc.facade.bankcard.BankDataRequest();
					com.vip.api.ubc.facade.bankcard.BankDataRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveBankData_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.api.ubc.facade.bankcard.BankDataRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveBankData_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveBankFile_argsHelper : TBeanSerializer<receiveBankFile_args>
		{
			
			public static receiveBankFile_argsHelper OBJ = new receiveBankFile_argsHelper();
			
			public static receiveBankFile_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveBankFile_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.ubc.facade.bankcard.BankFileRequest value;
					
					value = new com.vip.api.ubc.facade.bankcard.BankFileRequest();
					com.vip.api.ubc.facade.bankcard.BankFileRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveBankFile_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.api.ubc.facade.bankcard.BankFileRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveBankFile_args bean){
				
				
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
		
		
		
		
		public class receiveBankData_resultHelper : TBeanSerializer<receiveBankData_result>
		{
			
			public static receiveBankData_resultHelper OBJ = new receiveBankData_resultHelper();
			
			public static receiveBankData_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveBankData_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.ubc.facade.bankcard.BankDataResponse value;
					
					value = new com.vip.api.ubc.facade.bankcard.BankDataResponse();
					com.vip.api.ubc.facade.bankcard.BankDataResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveBankData_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.ubc.facade.bankcard.BankDataResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveBankData_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveBankFile_resultHelper : TBeanSerializer<receiveBankFile_result>
		{
			
			public static receiveBankFile_resultHelper OBJ = new receiveBankFile_resultHelper();
			
			public static receiveBankFile_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveBankFile_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.ubc.facade.bankcard.BankFileResponse value;
					
					value = new com.vip.api.ubc.facade.bankcard.BankFileResponse();
					com.vip.api.ubc.facade.bankcard.BankFileResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveBankFile_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.ubc.facade.bankcard.BankFileResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveBankFile_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class BankFileFacadeClient : OspRestStub , BankFileFacade  {
			
			
			public BankFileFacadeClient():base("com.vip.api.ubc.facade.bankcard.BankFileFacade","1.0.0") {
				
				
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
			
			
			public com.vip.api.ubc.facade.bankcard.BankDataResponse receiveBankData(com.vip.api.ubc.facade.bankcard.BankDataRequest request_) {
				
				send_receiveBankData(request_);
				return recv_receiveBankData(); 
				
			}
			
			
			private void send_receiveBankData(com.vip.api.ubc.facade.bankcard.BankDataRequest request_){
				
				InitInvocation("receiveBankData");
				
				receiveBankData_args args = new receiveBankData_args();
				args.SetRequest(request_);
				
				SendBase(args, receiveBankData_argsHelper.getInstance());
			}
			
			
			private com.vip.api.ubc.facade.bankcard.BankDataResponse recv_receiveBankData(){
				
				receiveBankData_result result = new receiveBankData_result();
				ReceiveBase(result, receiveBankData_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.ubc.facade.bankcard.BankFileResponse receiveBankFile(com.vip.api.ubc.facade.bankcard.BankFileRequest request_) {
				
				send_receiveBankFile(request_);
				return recv_receiveBankFile(); 
				
			}
			
			
			private void send_receiveBankFile(com.vip.api.ubc.facade.bankcard.BankFileRequest request_){
				
				InitInvocation("receiveBankFile");
				
				receiveBankFile_args args = new receiveBankFile_args();
				args.SetRequest(request_);
				
				SendBase(args, receiveBankFile_argsHelper.getInstance());
			}
			
			
			private com.vip.api.ubc.facade.bankcard.BankFileResponse recv_receiveBankFile(){
				
				receiveBankFile_result result = new receiveBankFile_result();
				ReceiveBase(result, receiveBankFile_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}