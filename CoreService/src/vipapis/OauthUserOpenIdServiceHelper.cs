using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis{
	
	
	public class OauthUserOpenIdServiceHelper {
		
		
		
		public class getOpenIdByUserId_args {
			
			///<summary>
			///</summary>
			
			private int? userId_;
			
			public int? GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(int? value){
				this.userId_ = value;
			}
			
		}
		
		
		
		
		public class getUserIdByOpenId_args {
			
			///<summary>
			///</summary>
			
			private string openId_;
			
			public string GetOpenId(){
				return this.openId_;
			}
			
			public void SetOpenId(string value){
				this.openId_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getOpenIdByUserId_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getUserIdByOpenId_result {
			
			///<summary>
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
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
		
		
		
		
		
		public class getOpenIdByUserId_argsHelper : TBeanSerializer<getOpenIdByUserId_args>
		{
			
			public static getOpenIdByUserId_argsHelper OBJ = new getOpenIdByUserId_argsHelper();
			
			public static getOpenIdByUserId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpenIdByUserId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetUserId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpenIdByUserId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteI32((int)structs.GetUserId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("userId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpenIdByUserId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getUserIdByOpenId_argsHelper : TBeanSerializer<getUserIdByOpenId_args>
		{
			
			public static getUserIdByOpenId_argsHelper OBJ = new getUserIdByOpenId_argsHelper();
			
			public static getUserIdByOpenId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserIdByOpenId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOpenId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserIdByOpenId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOpenId() != null) {
					
					oprot.WriteFieldBegin("openId");
					oprot.WriteString(structs.GetOpenId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("openId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserIdByOpenId_args bean){
				
				
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
		
		
		
		
		public class getOpenIdByUserId_resultHelper : TBeanSerializer<getOpenIdByUserId_result>
		{
			
			public static getOpenIdByUserId_resultHelper OBJ = new getOpenIdByUserId_resultHelper();
			
			public static getOpenIdByUserId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpenIdByUserId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpenIdByUserId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpenIdByUserId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getUserIdByOpenId_resultHelper : TBeanSerializer<getUserIdByOpenId_result>
		{
			
			public static getUserIdByOpenId_resultHelper OBJ = new getUserIdByOpenId_resultHelper();
			
			public static getUserIdByOpenId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserIdByOpenId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserIdByOpenId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserIdByOpenId_result bean){
				
				
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
		
		
		
		
		public class OauthUserOpenIdServiceClient : OspRestStub , OauthUserOpenIdService  {
			
			
			public OauthUserOpenIdServiceClient():base("vipapis.OauthUserOpenIdService","1.0.0") {
				
				
			}
			
			
			
			public string getOpenIdByUserId(int userId_) {
				
				send_getOpenIdByUserId(userId_);
				return recv_getOpenIdByUserId(); 
				
			}
			
			
			private void send_getOpenIdByUserId(int userId_){
				
				InitInvocation("getOpenIdByUserId");
				
				getOpenIdByUserId_args args = new getOpenIdByUserId_args();
				args.SetUserId(userId_);
				
				SendBase(args, getOpenIdByUserId_argsHelper.getInstance());
			}
			
			
			private string recv_getOpenIdByUserId(){
				
				getOpenIdByUserId_result result = new getOpenIdByUserId_result();
				ReceiveBase(result, getOpenIdByUserId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public long? getUserIdByOpenId(string openId_) {
				
				send_getUserIdByOpenId(openId_);
				return recv_getUserIdByOpenId(); 
				
			}
			
			
			private void send_getUserIdByOpenId(string openId_){
				
				InitInvocation("getUserIdByOpenId");
				
				getUserIdByOpenId_args args = new getUserIdByOpenId_args();
				args.SetOpenId(openId_);
				
				SendBase(args, getUserIdByOpenId_argsHelper.getInstance());
			}
			
			
			private long? recv_getUserIdByOpenId(){
				
				getUserIdByOpenId_result result = new getUserIdByOpenId_result();
				ReceiveBase(result, getUserIdByOpenId_resultHelper.getInstance());
				
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