using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.fcs{
	
	
	public class TrusteeshipInfoServiceHelper {
		
		
		
		public class createTrusteeshipInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel createTrusteeshipInfoRequestModel_;
			
			public com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel GetCreateTrusteeshipInfoRequestModel(){
				return this.createTrusteeshipInfoRequestModel_;
			}
			
			public void SetCreateTrusteeshipInfoRequestModel(com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel value){
				this.createTrusteeshipInfoRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class getTrusteeshipInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel getTrusteeshipInfoRequestModel_;
			
			public com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel GetGetTrusteeshipInfoRequestModel(){
				return this.getTrusteeshipInfoRequestModel_;
			}
			
			public void SetGetTrusteeshipInfoRequestModel(com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel value){
				this.getTrusteeshipInfoRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updateTrusteeshipInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel updateTrusteeshipInfoRequestModel_;
			
			public com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel GetUpdateTrusteeshipInfoRequestModel(){
				return this.updateTrusteeshipInfoRequestModel_;
			}
			
			public void SetUpdateTrusteeshipInfoRequestModel(com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel value){
				this.updateTrusteeshipInfoRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class createTrusteeshipInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel success_;
			
			public com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTrusteeshipInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel success_;
			
			public com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel value){
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
		
		
		
		
		public class updateTrusteeshipInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel success_;
			
			public com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class createTrusteeshipInfo_argsHelper : TBeanSerializer<createTrusteeshipInfo_args>
		{
			
			public static createTrusteeshipInfo_argsHelper OBJ = new createTrusteeshipInfo_argsHelper();
			
			public static createTrusteeshipInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createTrusteeshipInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel value;
					
					value = new com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel();
					com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetCreateTrusteeshipInfoRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createTrusteeshipInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreateTrusteeshipInfoRequestModel() != null) {
					
					oprot.WriteFieldBegin("createTrusteeshipInfoRequestModel");
					
					com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModelHelper.getInstance().Write(structs.GetCreateTrusteeshipInfoRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createTrusteeshipInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTrusteeshipInfo_argsHelper : TBeanSerializer<getTrusteeshipInfo_args>
		{
			
			public static getTrusteeshipInfo_argsHelper OBJ = new getTrusteeshipInfo_argsHelper();
			
			public static getTrusteeshipInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTrusteeshipInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel value;
					
					value = new com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel();
					com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetGetTrusteeshipInfoRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTrusteeshipInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetTrusteeshipInfoRequestModel() != null) {
					
					oprot.WriteFieldBegin("getTrusteeshipInfoRequestModel");
					
					com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModelHelper.getInstance().Write(structs.GetGetTrusteeshipInfoRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTrusteeshipInfo_args bean){
				
				
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
		
		
		
		
		public class updateTrusteeshipInfo_argsHelper : TBeanSerializer<updateTrusteeshipInfo_args>
		{
			
			public static updateTrusteeshipInfo_argsHelper OBJ = new updateTrusteeshipInfo_argsHelper();
			
			public static updateTrusteeshipInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTrusteeshipInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel value;
					
					value = new com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel();
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetUpdateTrusteeshipInfoRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTrusteeshipInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUpdateTrusteeshipInfoRequestModel() != null) {
					
					oprot.WriteFieldBegin("updateTrusteeshipInfoRequestModel");
					
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModelHelper.getInstance().Write(structs.GetUpdateTrusteeshipInfoRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTrusteeshipInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createTrusteeshipInfo_resultHelper : TBeanSerializer<createTrusteeshipInfo_result>
		{
			
			public static createTrusteeshipInfo_resultHelper OBJ = new createTrusteeshipInfo_resultHelper();
			
			public static createTrusteeshipInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createTrusteeshipInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel value;
					
					value = new com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel();
					com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createTrusteeshipInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createTrusteeshipInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTrusteeshipInfo_resultHelper : TBeanSerializer<getTrusteeshipInfo_result>
		{
			
			public static getTrusteeshipInfo_resultHelper OBJ = new getTrusteeshipInfo_resultHelper();
			
			public static getTrusteeshipInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTrusteeshipInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel value;
					
					value = new com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel();
					com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTrusteeshipInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTrusteeshipInfo_result bean){
				
				
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
		
		
		
		
		public class updateTrusteeshipInfo_resultHelper : TBeanSerializer<updateTrusteeshipInfo_result>
		{
			
			public static updateTrusteeshipInfo_resultHelper OBJ = new updateTrusteeshipInfo_resultHelper();
			
			public static updateTrusteeshipInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateTrusteeshipInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel value;
					
					value = new com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel();
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateTrusteeshipInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateTrusteeshipInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class TrusteeshipInfoServiceClient : OspRestStub , TrusteeshipInfoService  {
			
			
			public TrusteeshipInfoServiceClient():base("vipapis.fcs.TrusteeshipInfoService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel createTrusteeshipInfo(com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel createTrusteeshipInfoRequestModel_) {
				
				send_createTrusteeshipInfo(createTrusteeshipInfoRequestModel_);
				return recv_createTrusteeshipInfo(); 
				
			}
			
			
			private void send_createTrusteeshipInfo(com.vip.fcs.vei.service.CreateTrusteeshipInfoRequestModel createTrusteeshipInfoRequestModel_){
				
				InitInvocation("createTrusteeshipInfo");
				
				createTrusteeshipInfo_args args = new createTrusteeshipInfo_args();
				args.SetCreateTrusteeshipInfoRequestModel(createTrusteeshipInfoRequestModel_);
				
				SendBase(args, createTrusteeshipInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vei.service.CreateTrusteeshipInfoResponseModel recv_createTrusteeshipInfo(){
				
				createTrusteeshipInfo_result result = new createTrusteeshipInfo_result();
				ReceiveBase(result, createTrusteeshipInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel getTrusteeshipInfo(com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel getTrusteeshipInfoRequestModel_) {
				
				send_getTrusteeshipInfo(getTrusteeshipInfoRequestModel_);
				return recv_getTrusteeshipInfo(); 
				
			}
			
			
			private void send_getTrusteeshipInfo(com.vip.fcs.vei.service.GetTrusteeshipInfoRequestModel getTrusteeshipInfoRequestModel_){
				
				InitInvocation("getTrusteeshipInfo");
				
				getTrusteeshipInfo_args args = new getTrusteeshipInfo_args();
				args.SetGetTrusteeshipInfoRequestModel(getTrusteeshipInfoRequestModel_);
				
				SendBase(args, getTrusteeshipInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vei.service.GetTrusteeshipInfoResponseModel recv_getTrusteeshipInfo(){
				
				getTrusteeshipInfo_result result = new getTrusteeshipInfo_result();
				ReceiveBase(result, getTrusteeshipInfo_resultHelper.getInstance());
				
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
			
			
			public com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel updateTrusteeshipInfo(com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel updateTrusteeshipInfoRequestModel_) {
				
				send_updateTrusteeshipInfo(updateTrusteeshipInfoRequestModel_);
				return recv_updateTrusteeshipInfo(); 
				
			}
			
			
			private void send_updateTrusteeshipInfo(com.vip.fcs.vei.service.UpdateTrusteeshipInfoRequestModel updateTrusteeshipInfoRequestModel_){
				
				InitInvocation("updateTrusteeshipInfo");
				
				updateTrusteeshipInfo_args args = new updateTrusteeshipInfo_args();
				args.SetUpdateTrusteeshipInfoRequestModel(updateTrusteeshipInfoRequestModel_);
				
				SendBase(args, updateTrusteeshipInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vei.service.UpdateTrusteeshipInfoResponseModel recv_updateTrusteeshipInfo(){
				
				updateTrusteeshipInfo_result result = new updateTrusteeshipInfo_result();
				ReceiveBase(result, updateTrusteeshipInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}