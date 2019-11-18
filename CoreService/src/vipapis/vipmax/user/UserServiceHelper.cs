using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.vipmax.user{
	
	
	public class UserServiceHelper {
		
		
		
		public class getUserInfo_args {
			
			///<summary>
			/// 会员识别API入参
			///</summary>
			
			private vipapis.vipmax.user.GetUserInfoRequest getUserInfoRequest_;
			
			public vipapis.vipmax.user.GetUserInfoRequest GetGetUserInfoRequest(){
				return this.getUserInfoRequest_;
			}
			
			public void SetGetUserInfoRequest(vipapis.vipmax.user.GetUserInfoRequest value){
				this.getUserInfoRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getUserInfo_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.user.GetUserInfoResponse success_;
			
			public vipapis.vipmax.user.GetUserInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.user.GetUserInfoResponse value){
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
		
		
		
		
		
		public class getUserInfo_argsHelper : TBeanSerializer<getUserInfo_args>
		{
			
			public static getUserInfo_argsHelper OBJ = new getUserInfo_argsHelper();
			
			public static getUserInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.user.GetUserInfoRequest value;
					
					value = new vipapis.vipmax.user.GetUserInfoRequest();
					vipapis.vipmax.user.GetUserInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetGetUserInfoRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetUserInfoRequest() != null) {
					
					oprot.WriteFieldBegin("getUserInfoRequest");
					
					vipapis.vipmax.user.GetUserInfoRequestHelper.getInstance().Write(structs.GetGetUserInfoRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("getUserInfoRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserInfo_args bean){
				
				
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
		
		
		
		
		public class getUserInfo_resultHelper : TBeanSerializer<getUserInfo_result>
		{
			
			public static getUserInfo_resultHelper OBJ = new getUserInfo_resultHelper();
			
			public static getUserInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.user.GetUserInfoResponse value;
					
					value = new vipapis.vipmax.user.GetUserInfoResponse();
					vipapis.vipmax.user.GetUserInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.user.GetUserInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserInfo_result bean){
				
				
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
		
		
		
		
		public class UserServiceClient : OspRestStub , UserService  {
			
			
			public UserServiceClient():base("vipapis.vipmax.user.UserService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.vipmax.user.GetUserInfoResponse getUserInfo(vipapis.vipmax.user.GetUserInfoRequest getUserInfoRequest_) {
				
				send_getUserInfo(getUserInfoRequest_);
				return recv_getUserInfo(); 
				
			}
			
			
			private void send_getUserInfo(vipapis.vipmax.user.GetUserInfoRequest getUserInfoRequest_){
				
				InitInvocation("getUserInfo");
				
				getUserInfo_args args = new getUserInfo_args();
				args.SetGetUserInfoRequest(getUserInfoRequest_);
				
				SendBase(args, getUserInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.user.GetUserInfoResponse recv_getUserInfo(){
				
				getUserInfo_result result = new getUserInfo_result();
				ReceiveBase(result, getUserInfo_resultHelper.getInstance());
				
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
			
			
		}
		
		
	}
	
}