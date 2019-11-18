using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.user.face.service.photorecord{
	
	
	public class XstorePhotoRecordServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class uploadPhotos_args {
			
			///<summary>
			/// 入参对象
			///</summary>
			
			private com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest request_;
			
			public com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest value){
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
		
		
		
		
		public class uploadPhotos_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse success_;
			
			public com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse value){
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
		
		
		
		
		public class uploadPhotos_argsHelper : TBeanSerializer<uploadPhotos_args>
		{
			
			public static uploadPhotos_argsHelper OBJ = new uploadPhotos_argsHelper();
			
			public static uploadPhotos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadPhotos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest value;
					
					value = new com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest();
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadPhotos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadPhotos_args bean){
				
				
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
		
		
		
		
		public class uploadPhotos_resultHelper : TBeanSerializer<uploadPhotos_result>
		{
			
			public static uploadPhotos_resultHelper OBJ = new uploadPhotos_resultHelper();
			
			public static uploadPhotos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadPhotos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse value;
					
					value = new com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse();
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadPhotos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadPhotos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class XstorePhotoRecordServiceClient : OspRestStub , XstorePhotoRecordService  {
			
			
			public XstorePhotoRecordServiceClient():base("com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordService","1.0.0") {
				
				
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
			
			
			public com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse uploadPhotos(com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest request_) {
				
				send_uploadPhotos(request_);
				return recv_uploadPhotos(); 
				
			}
			
			
			private void send_uploadPhotos(com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest request_){
				
				InitInvocation("uploadPhotos");
				
				uploadPhotos_args args = new uploadPhotos_args();
				args.SetRequest(request_);
				
				SendBase(args, uploadPhotos_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse recv_uploadPhotos(){
				
				uploadPhotos_result result = new uploadPhotos_result();
				ReceiveBase(result, uploadPhotos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}