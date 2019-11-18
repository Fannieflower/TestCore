using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.track.service{
	
	
	public class CarrierLogisticTrackServiceHelper {
		
		
		
		public class acceptLogisticsTrack_args {
			
			///<summary>
			/// 接收推送轨迹服务
			///</summary>
			
			private com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest request_;
			
			public com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class acceptLogisticsTrack_result {
			
			///<summary>
			///</summary>
			
			private com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse success_;
			
			public com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse value){
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
		
		
		
		
		
		public class acceptLogisticsTrack_argsHelper : TBeanSerializer<acceptLogisticsTrack_args>
		{
			
			public static acceptLogisticsTrack_argsHelper OBJ = new acceptLogisticsTrack_argsHelper();
			
			public static acceptLogisticsTrack_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptLogisticsTrack_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest value;
					
					value = new com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest();
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptLogisticsTrack_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptLogisticsTrack_args bean){
				
				
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
		
		
		
		
		public class acceptLogisticsTrack_resultHelper : TBeanSerializer<acceptLogisticsTrack_result>
		{
			
			public static acceptLogisticsTrack_resultHelper OBJ = new acceptLogisticsTrack_resultHelper();
			
			public static acceptLogisticsTrack_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptLogisticsTrack_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse value;
					
					value = new com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse();
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptLogisticsTrack_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptLogisticsTrack_result bean){
				
				
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
		
		
		
		
		public class CarrierLogisticTrackServiceClient : OspRestStub , CarrierLogisticTrackService  {
			
			
			public CarrierLogisticTrackServiceClient():base("vipapis.track.service.CarrierLogisticTrackService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse acceptLogisticsTrack(com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest request_) {
				
				send_acceptLogisticsTrack(request_);
				return recv_acceptLogisticsTrack(); 
				
			}
			
			
			private void send_acceptLogisticsTrack(com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackRequest request_){
				
				InitInvocation("acceptLogisticsTrack");
				
				acceptLogisticsTrack_args args = new acceptLogisticsTrack_args();
				args.SetRequest(request_);
				
				SendBase(args, acceptLogisticsTrack_argsHelper.getInstance());
			}
			
			
			private com.vip.lbs.track.waybill.service.entity.LbsAcceptLogisticsTrackResponse recv_acceptLogisticsTrack(){
				
				acceptLogisticsTrack_result result = new acceptLogisticsTrack_result();
				ReceiveBase(result, acceptLogisticsTrack_resultHelper.getInstance());
				
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