using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.platform.api.cipher{
	
	
	public class VopCipherServiceHelper {
		
		
		
		public class batchDecrypt_args {
			
			///<summary>
			/// 批量解密请求内容
			///</summary>
			
			private com.vip.platform.api.cipher.BatchDecryptReq req_;
			
			public com.vip.platform.api.cipher.BatchDecryptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.platform.api.cipher.BatchDecryptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class batchEncrypt_args {
			
			///<summary>
			/// 批量加密请求内容
			///</summary>
			
			private com.vip.platform.api.cipher.BatchEncryptReq req_;
			
			public com.vip.platform.api.cipher.BatchEncryptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.platform.api.cipher.BatchEncryptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class createAllStoreKey_args {
			
			
		}
		
		
		
		
		public class createKey_args {
			
			///<summary>
			/// 创建密钥请求内容
			///</summary>
			
			private com.vip.platform.api.cipher.CreateKeyReq req_;
			
			public com.vip.platform.api.cipher.CreateKeyReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.platform.api.cipher.CreateKeyReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class batchDecrypt_result {
			
			///<summary>
			///</summary>
			
			private com.vip.platform.api.cipher.BatchCipherResp success_;
			
			public com.vip.platform.api.cipher.BatchCipherResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.platform.api.cipher.BatchCipherResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchEncrypt_result {
			
			///<summary>
			///</summary>
			
			private com.vip.platform.api.cipher.BatchCipherResp success_;
			
			public com.vip.platform.api.cipher.BatchCipherResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.platform.api.cipher.BatchCipherResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createAllStoreKey_result {
			
			
		}
		
		
		
		
		public class createKey_result {
			
			///<summary>
			///</summary>
			
			private com.vip.platform.api.cipher.CreateKeyResp success_;
			
			public com.vip.platform.api.cipher.CreateKeyResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.platform.api.cipher.CreateKeyResp value){
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
		
		
		
		
		
		public class batchDecrypt_argsHelper : TBeanSerializer<batchDecrypt_args>
		{
			
			public static batchDecrypt_argsHelper OBJ = new batchDecrypt_argsHelper();
			
			public static batchDecrypt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchDecrypt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.BatchDecryptReq value;
					
					value = new com.vip.platform.api.cipher.BatchDecryptReq();
					com.vip.platform.api.cipher.BatchDecryptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchDecrypt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.platform.api.cipher.BatchDecryptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchDecrypt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchEncrypt_argsHelper : TBeanSerializer<batchEncrypt_args>
		{
			
			public static batchEncrypt_argsHelper OBJ = new batchEncrypt_argsHelper();
			
			public static batchEncrypt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchEncrypt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.BatchEncryptReq value;
					
					value = new com.vip.platform.api.cipher.BatchEncryptReq();
					com.vip.platform.api.cipher.BatchEncryptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchEncrypt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.platform.api.cipher.BatchEncryptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchEncrypt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createAllStoreKey_argsHelper : TBeanSerializer<createAllStoreKey_args>
		{
			
			public static createAllStoreKey_argsHelper OBJ = new createAllStoreKey_argsHelper();
			
			public static createAllStoreKey_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createAllStoreKey_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createAllStoreKey_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createAllStoreKey_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createKey_argsHelper : TBeanSerializer<createKey_args>
		{
			
			public static createKey_argsHelper OBJ = new createKey_argsHelper();
			
			public static createKey_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createKey_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.CreateKeyReq value;
					
					value = new com.vip.platform.api.cipher.CreateKeyReq();
					com.vip.platform.api.cipher.CreateKeyReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createKey_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.platform.api.cipher.CreateKeyReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createKey_args bean){
				
				
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
		
		
		
		
		public class batchDecrypt_resultHelper : TBeanSerializer<batchDecrypt_result>
		{
			
			public static batchDecrypt_resultHelper OBJ = new batchDecrypt_resultHelper();
			
			public static batchDecrypt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchDecrypt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.BatchCipherResp value;
					
					value = new com.vip.platform.api.cipher.BatchCipherResp();
					com.vip.platform.api.cipher.BatchCipherRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchDecrypt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.platform.api.cipher.BatchCipherRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchDecrypt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchEncrypt_resultHelper : TBeanSerializer<batchEncrypt_result>
		{
			
			public static batchEncrypt_resultHelper OBJ = new batchEncrypt_resultHelper();
			
			public static batchEncrypt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchEncrypt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.BatchCipherResp value;
					
					value = new com.vip.platform.api.cipher.BatchCipherResp();
					com.vip.platform.api.cipher.BatchCipherRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchEncrypt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.platform.api.cipher.BatchCipherRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchEncrypt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createAllStoreKey_resultHelper : TBeanSerializer<createAllStoreKey_result>
		{
			
			public static createAllStoreKey_resultHelper OBJ = new createAllStoreKey_resultHelper();
			
			public static createAllStoreKey_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createAllStoreKey_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createAllStoreKey_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createAllStoreKey_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createKey_resultHelper : TBeanSerializer<createKey_result>
		{
			
			public static createKey_resultHelper OBJ = new createKey_resultHelper();
			
			public static createKey_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createKey_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.platform.api.cipher.CreateKeyResp value;
					
					value = new com.vip.platform.api.cipher.CreateKeyResp();
					com.vip.platform.api.cipher.CreateKeyRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createKey_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.platform.api.cipher.CreateKeyRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createKey_result bean){
				
				
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
		
		
		
		
		public class VopCipherServiceClient : OspRestStub , VopCipherService  {
			
			
			public VopCipherServiceClient():base("com.vip.platform.api.cipher.VopCipherService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.platform.api.cipher.BatchCipherResp batchDecrypt(com.vip.platform.api.cipher.BatchDecryptReq req_) {
				
				send_batchDecrypt(req_);
				return recv_batchDecrypt(); 
				
			}
			
			
			private void send_batchDecrypt(com.vip.platform.api.cipher.BatchDecryptReq req_){
				
				InitInvocation("batchDecrypt");
				
				batchDecrypt_args args = new batchDecrypt_args();
				args.SetReq(req_);
				
				SendBase(args, batchDecrypt_argsHelper.getInstance());
			}
			
			
			private com.vip.platform.api.cipher.BatchCipherResp recv_batchDecrypt(){
				
				batchDecrypt_result result = new batchDecrypt_result();
				ReceiveBase(result, batchDecrypt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.platform.api.cipher.BatchCipherResp batchEncrypt(com.vip.platform.api.cipher.BatchEncryptReq req_) {
				
				send_batchEncrypt(req_);
				return recv_batchEncrypt(); 
				
			}
			
			
			private void send_batchEncrypt(com.vip.platform.api.cipher.BatchEncryptReq req_){
				
				InitInvocation("batchEncrypt");
				
				batchEncrypt_args args = new batchEncrypt_args();
				args.SetReq(req_);
				
				SendBase(args, batchEncrypt_argsHelper.getInstance());
			}
			
			
			private com.vip.platform.api.cipher.BatchCipherResp recv_batchEncrypt(){
				
				batchEncrypt_result result = new batchEncrypt_result();
				ReceiveBase(result, batchEncrypt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void createAllStoreKey() {
				
				send_createAllStoreKey();
				recv_createAllStoreKey();
				
			}
			
			
			private void send_createAllStoreKey(){
				
				InitInvocation("createAllStoreKey");
				
				createAllStoreKey_args args = new createAllStoreKey_args();
				
				SendBase(args, createAllStoreKey_argsHelper.getInstance());
			}
			
			
			private void recv_createAllStoreKey(){
				
				createAllStoreKey_result result = new createAllStoreKey_result();
				ReceiveBase(result, createAllStoreKey_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.platform.api.cipher.CreateKeyResp createKey(com.vip.platform.api.cipher.CreateKeyReq req_) {
				
				send_createKey(req_);
				return recv_createKey(); 
				
			}
			
			
			private void send_createKey(com.vip.platform.api.cipher.CreateKeyReq req_){
				
				InitInvocation("createKey");
				
				createKey_args args = new createKey_args();
				args.SetReq(req_);
				
				SendBase(args, createKey_argsHelper.getInstance());
			}
			
			
			private com.vip.platform.api.cipher.CreateKeyResp recv_createKey(){
				
				createKey_result result = new createKey_result();
				ReceiveBase(result, createKey_resultHelper.getInstance());
				
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