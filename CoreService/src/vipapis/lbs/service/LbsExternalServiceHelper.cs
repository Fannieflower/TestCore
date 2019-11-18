using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.lbs.service{
	
	
	public class LbsExternalServiceHelper {
		
		
		
		public class getExplainedBarcodes_args {
			
			///<summary>
			///</summary>
			
			private com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest getExplainedBarcodesRequest_;
			
			public com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest GetGetExplainedBarcodesRequest(){
				return this.getExplainedBarcodesRequest_;
			}
			
			public void SetGetExplainedBarcodesRequest(com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest value){
				this.getExplainedBarcodesRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getExplainedBarcodes_result {
			
			///<summary>
			///</summary>
			
			private com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse success_;
			
			public com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse value){
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
		
		
		
		
		
		public class getExplainedBarcodes_argsHelper : TBeanSerializer<getExplainedBarcodes_args>
		{
			
			public static getExplainedBarcodes_argsHelper OBJ = new getExplainedBarcodes_argsHelper();
			
			public static getExplainedBarcodes_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getExplainedBarcodes_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest value;
					
					value = new com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest();
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetGetExplainedBarcodesRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getExplainedBarcodes_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetExplainedBarcodesRequest() != null) {
					
					oprot.WriteFieldBegin("getExplainedBarcodesRequest");
					
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequestHelper.getInstance().Write(structs.GetGetExplainedBarcodesRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getExplainedBarcodes_args bean){
				
				
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
		
		
		
		
		public class getExplainedBarcodes_resultHelper : TBeanSerializer<getExplainedBarcodes_result>
		{
			
			public static getExplainedBarcodes_resultHelper OBJ = new getExplainedBarcodes_resultHelper();
			
			public static getExplainedBarcodes_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getExplainedBarcodes_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse value;
					
					value = new com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse();
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getExplainedBarcodes_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getExplainedBarcodes_result bean){
				
				
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
		
		
		
		
		public class LbsExternalServiceClient : OspRestStub , LbsExternalService  {
			
			
			public LbsExternalServiceClient():base("vipapis.lbs.service.LbsExternalService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse getExplainedBarcodes(com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest getExplainedBarcodesRequest_) {
				
				send_getExplainedBarcodes(getExplainedBarcodesRequest_);
				return recv_getExplainedBarcodes(); 
				
			}
			
			
			private void send_getExplainedBarcodes(com.vip.lbs.lpc.service.entity.GetExplainedBarcodesRequest getExplainedBarcodesRequest_){
				
				InitInvocation("getExplainedBarcodes");
				
				getExplainedBarcodes_args args = new getExplainedBarcodes_args();
				args.SetGetExplainedBarcodesRequest(getExplainedBarcodesRequest_);
				
				SendBase(args, getExplainedBarcodes_argsHelper.getInstance());
			}
			
			
			private com.vip.lbs.lpc.service.entity.GetExplainedBarcodesResponse recv_getExplainedBarcodes(){
				
				getExplainedBarcodes_result result = new getExplainedBarcodes_result();
				ReceiveBase(result, getExplainedBarcodes_resultHelper.getInstance());
				
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