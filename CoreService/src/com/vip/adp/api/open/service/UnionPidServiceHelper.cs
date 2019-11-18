using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.adp.api.open.service{
	
	
	public class UnionPidServiceHelper {
		
		
		
		public class genPid_args {
			
			///<summary>
			/// 推广位创建请求信息
			///</summary>
			
			private com.vip.adp.api.open.service.PidGenRequest pidGenRequest_;
			
			public com.vip.adp.api.open.service.PidGenRequest GetPidGenRequest(){
				return this.pidGenRequest_;
			}
			
			public void SetPidGenRequest(com.vip.adp.api.open.service.PidGenRequest value){
				this.pidGenRequest_ = value;
			}
			
		}
		
		
		
		
		public class genPidWithOauth_args {
			
			///<summary>
			/// 推广位创建请求信息
			///</summary>
			
			private com.vip.adp.api.open.service.PidGenRequest pidGenRequest_;
			
			public com.vip.adp.api.open.service.PidGenRequest GetPidGenRequest(){
				return this.pidGenRequest_;
			}
			
			public void SetPidGenRequest(com.vip.adp.api.open.service.PidGenRequest value){
				this.pidGenRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryPid_args {
			
			///<summary>
			/// 推广位查询请求信息
			///</summary>
			
			private com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_;
			
			public com.vip.adp.api.open.service.PidQueryRequest GetPidQueryRequest(){
				return this.pidQueryRequest_;
			}
			
			public void SetPidQueryRequest(com.vip.adp.api.open.service.PidQueryRequest value){
				this.pidQueryRequest_ = value;
			}
			
		}
		
		
		
		
		public class queryPidWithOauth_args {
			
			///<summary>
			/// 推广位查询请求信息
			///</summary>
			
			private com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_;
			
			public com.vip.adp.api.open.service.PidQueryRequest GetPidQueryRequest(){
				return this.pidQueryRequest_;
			}
			
			public void SetPidQueryRequest(com.vip.adp.api.open.service.PidQueryRequest value){
				this.pidQueryRequest_ = value;
			}
			
		}
		
		
		
		
		public class genPid_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.CpsUnionPidGenResponse success_;
			
			public com.vip.adp.api.open.service.CpsUnionPidGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.CpsUnionPidGenResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class genPidWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.CpsUnionPidGenResponse success_;
			
			public com.vip.adp.api.open.service.CpsUnionPidGenResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.CpsUnionPidGenResponse value){
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
		
		
		
		
		public class queryPid_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.CpsUnionPidQueryResponse success_;
			
			public com.vip.adp.api.open.service.CpsUnionPidQueryResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.CpsUnionPidQueryResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPidWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.CpsUnionPidQueryResponse success_;
			
			public com.vip.adp.api.open.service.CpsUnionPidQueryResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.CpsUnionPidQueryResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class genPid_argsHelper : TBeanSerializer<genPid_args>
		{
			
			public static genPid_argsHelper OBJ = new genPid_argsHelper();
			
			public static genPid_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genPid_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.PidGenRequest value;
					
					value = new com.vip.adp.api.open.service.PidGenRequest();
					com.vip.adp.api.open.service.PidGenRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPidGenRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genPid_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPidGenRequest() != null) {
					
					oprot.WriteFieldBegin("pidGenRequest");
					
					com.vip.adp.api.open.service.PidGenRequestHelper.getInstance().Write(structs.GetPidGenRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genPid_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genPidWithOauth_argsHelper : TBeanSerializer<genPidWithOauth_args>
		{
			
			public static genPidWithOauth_argsHelper OBJ = new genPidWithOauth_argsHelper();
			
			public static genPidWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genPidWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.PidGenRequest value;
					
					value = new com.vip.adp.api.open.service.PidGenRequest();
					com.vip.adp.api.open.service.PidGenRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPidGenRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genPidWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPidGenRequest() != null) {
					
					oprot.WriteFieldBegin("pidGenRequest");
					
					com.vip.adp.api.open.service.PidGenRequestHelper.getInstance().Write(structs.GetPidGenRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genPidWithOauth_args bean){
				
				
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
		
		
		
		
		public class queryPid_argsHelper : TBeanSerializer<queryPid_args>
		{
			
			public static queryPid_argsHelper OBJ = new queryPid_argsHelper();
			
			public static queryPid_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPid_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.PidQueryRequest value;
					
					value = new com.vip.adp.api.open.service.PidQueryRequest();
					com.vip.adp.api.open.service.PidQueryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPidQueryRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPid_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPidQueryRequest() != null) {
					
					oprot.WriteFieldBegin("pidQueryRequest");
					
					com.vip.adp.api.open.service.PidQueryRequestHelper.getInstance().Write(structs.GetPidQueryRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPid_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPidWithOauth_argsHelper : TBeanSerializer<queryPidWithOauth_args>
		{
			
			public static queryPidWithOauth_argsHelper OBJ = new queryPidWithOauth_argsHelper();
			
			public static queryPidWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPidWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.PidQueryRequest value;
					
					value = new com.vip.adp.api.open.service.PidQueryRequest();
					com.vip.adp.api.open.service.PidQueryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPidQueryRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPidWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPidQueryRequest() != null) {
					
					oprot.WriteFieldBegin("pidQueryRequest");
					
					com.vip.adp.api.open.service.PidQueryRequestHelper.getInstance().Write(structs.GetPidQueryRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPidWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genPid_resultHelper : TBeanSerializer<genPid_result>
		{
			
			public static genPid_resultHelper OBJ = new genPid_resultHelper();
			
			public static genPid_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genPid_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.CpsUnionPidGenResponse value;
					
					value = new com.vip.adp.api.open.service.CpsUnionPidGenResponse();
					com.vip.adp.api.open.service.CpsUnionPidGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genPid_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.CpsUnionPidGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genPid_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class genPidWithOauth_resultHelper : TBeanSerializer<genPidWithOauth_result>
		{
			
			public static genPidWithOauth_resultHelper OBJ = new genPidWithOauth_resultHelper();
			
			public static genPidWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(genPidWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.CpsUnionPidGenResponse value;
					
					value = new com.vip.adp.api.open.service.CpsUnionPidGenResponse();
					com.vip.adp.api.open.service.CpsUnionPidGenResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(genPidWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.CpsUnionPidGenResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(genPidWithOauth_result bean){
				
				
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
		
		
		
		
		public class queryPid_resultHelper : TBeanSerializer<queryPid_result>
		{
			
			public static queryPid_resultHelper OBJ = new queryPid_resultHelper();
			
			public static queryPid_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPid_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.CpsUnionPidQueryResponse value;
					
					value = new com.vip.adp.api.open.service.CpsUnionPidQueryResponse();
					com.vip.adp.api.open.service.CpsUnionPidQueryResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPid_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.CpsUnionPidQueryResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPid_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPidWithOauth_resultHelper : TBeanSerializer<queryPidWithOauth_result>
		{
			
			public static queryPidWithOauth_resultHelper OBJ = new queryPidWithOauth_resultHelper();
			
			public static queryPidWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPidWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.CpsUnionPidQueryResponse value;
					
					value = new com.vip.adp.api.open.service.CpsUnionPidQueryResponse();
					com.vip.adp.api.open.service.CpsUnionPidQueryResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPidWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.CpsUnionPidQueryResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPidWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class UnionPidServiceClient : OspRestStub , UnionPidService  {
			
			
			public UnionPidServiceClient():base("com.vip.adp.api.open.service.UnionPidService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.adp.api.open.service.CpsUnionPidGenResponse genPid(com.vip.adp.api.open.service.PidGenRequest pidGenRequest_) {
				
				send_genPid(pidGenRequest_);
				return recv_genPid(); 
				
			}
			
			
			private void send_genPid(com.vip.adp.api.open.service.PidGenRequest pidGenRequest_){
				
				InitInvocation("genPid");
				
				genPid_args args = new genPid_args();
				args.SetPidGenRequest(pidGenRequest_);
				
				SendBase(args, genPid_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.CpsUnionPidGenResponse recv_genPid(){
				
				genPid_result result = new genPid_result();
				ReceiveBase(result, genPid_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.CpsUnionPidGenResponse genPidWithOauth(com.vip.adp.api.open.service.PidGenRequest pidGenRequest_) {
				
				send_genPidWithOauth(pidGenRequest_);
				return recv_genPidWithOauth(); 
				
			}
			
			
			private void send_genPidWithOauth(com.vip.adp.api.open.service.PidGenRequest pidGenRequest_){
				
				InitInvocation("genPidWithOauth");
				
				genPidWithOauth_args args = new genPidWithOauth_args();
				args.SetPidGenRequest(pidGenRequest_);
				
				SendBase(args, genPidWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.CpsUnionPidGenResponse recv_genPidWithOauth(){
				
				genPidWithOauth_result result = new genPidWithOauth_result();
				ReceiveBase(result, genPidWithOauth_resultHelper.getInstance());
				
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
			
			
			public com.vip.adp.api.open.service.CpsUnionPidQueryResponse queryPid(com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_) {
				
				send_queryPid(pidQueryRequest_);
				return recv_queryPid(); 
				
			}
			
			
			private void send_queryPid(com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_){
				
				InitInvocation("queryPid");
				
				queryPid_args args = new queryPid_args();
				args.SetPidQueryRequest(pidQueryRequest_);
				
				SendBase(args, queryPid_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.CpsUnionPidQueryResponse recv_queryPid(){
				
				queryPid_result result = new queryPid_result();
				ReceiveBase(result, queryPid_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.CpsUnionPidQueryResponse queryPidWithOauth(com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_) {
				
				send_queryPidWithOauth(pidQueryRequest_);
				return recv_queryPidWithOauth(); 
				
			}
			
			
			private void send_queryPidWithOauth(com.vip.adp.api.open.service.PidQueryRequest pidQueryRequest_){
				
				InitInvocation("queryPidWithOauth");
				
				queryPidWithOauth_args args = new queryPidWithOauth_args();
				args.SetPidQueryRequest(pidQueryRequest_);
				
				SendBase(args, queryPidWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.CpsUnionPidQueryResponse recv_queryPidWithOauth(){
				
				queryPidWithOauth_result result = new queryPidWithOauth_result();
				ReceiveBase(result, queryPidWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}