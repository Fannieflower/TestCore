using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.omni.logistics{
	
	
	public class OmniLogisticsServiceHelper {
		
		
		
		public class getOrderLogisticsTrack_args {
			
			///<summary>
			/// 订单物流轨迹查询请求
			///</summary>
			
			private com.vip.vop.omni.logistics.LogisticsTrackRequest trackRequest_;
			
			public com.vip.vop.omni.logistics.LogisticsTrackRequest GetTrackRequest(){
				return this.trackRequest_;
			}
			
			public void SetTrackRequest(com.vip.vop.omni.logistics.LogisticsTrackRequest value){
				this.trackRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class receiveMaxSpeedRouteInfo_args {
			
			///<summary>
			/// 极速达配送状态信息
			///</summary>
			
			private com.vip.vop.omni.logistics.MaxSpeedRouteInfo maxSpeedRouteInfo_;
			
			public com.vip.vop.omni.logistics.MaxSpeedRouteInfo GetMaxSpeedRouteInfo(){
				return this.maxSpeedRouteInfo_;
			}
			
			public void SetMaxSpeedRouteInfo(com.vip.vop.omni.logistics.MaxSpeedRouteInfo value){
				this.maxSpeedRouteInfo_ = value;
			}
			
		}
		
		
		
		
		public class receiveRouteInfo_args {
			
			///<summary>
			/// 订单物流轨迹查询请求
			///</summary>
			
			private com.vip.vop.omni.logistics.WaybillRoute waybillRoute_;
			
			public com.vip.vop.omni.logistics.WaybillRoute GetWaybillRoute(){
				return this.waybillRoute_;
			}
			
			public void SetWaybillRoute(com.vip.vop.omni.logistics.WaybillRoute value){
				this.waybillRoute_ = value;
			}
			
		}
		
		
		
		
		public class receiveYtoRouteInfo_args {
			
			///<summary>
			/// 圆通配送状态信息
			///</summary>
			
			private com.vip.vop.omni.logistics.YtoRouteInfo ytoRouteInfo_;
			
			public com.vip.vop.omni.logistics.YtoRouteInfo GetYtoRouteInfo(){
				return this.ytoRouteInfo_;
			}
			
			public void SetYtoRouteInfo(com.vip.vop.omni.logistics.YtoRouteInfo value){
				this.ytoRouteInfo_ = value;
			}
			
		}
		
		
		
		
		public class receiveZtoRouteInfo_args {
			
			///<summary>
			/// 中通配送状态信息
			///</summary>
			
			private com.vip.vop.omni.logistics.ZtoRouteInfo ztoRouteInfo_;
			
			public com.vip.vop.omni.logistics.ZtoRouteInfo GetZtoRouteInfo(){
				return this.ztoRouteInfo_;
			}
			
			public void SetZtoRouteInfo(com.vip.vop.omni.logistics.ZtoRouteInfo value){
				this.ztoRouteInfo_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLogisticsTrack_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.omni.logistics.LogisticsTrackResponse success_;
			
			public com.vip.vop.omni.logistics.LogisticsTrackResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.omni.logistics.LogisticsTrackResponse value){
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
		
		
		
		
		public class receiveMaxSpeedRouteInfo_result {
			
			
		}
		
		
		
		
		public class receiveRouteInfo_result {
			
			
		}
		
		
		
		
		public class receiveYtoRouteInfo_result {
			
			
		}
		
		
		
		
		public class receiveZtoRouteInfo_result {
			
			
		}
		
		
		
		
		
		public class getOrderLogisticsTrack_argsHelper : TBeanSerializer<getOrderLogisticsTrack_args>
		{
			
			public static getOrderLogisticsTrack_argsHelper OBJ = new getOrderLogisticsTrack_argsHelper();
			
			public static getOrderLogisticsTrack_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLogisticsTrack_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.LogisticsTrackRequest value;
					
					value = new com.vip.vop.omni.logistics.LogisticsTrackRequest();
					com.vip.vop.omni.logistics.LogisticsTrackRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetTrackRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderLogisticsTrack_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTrackRequest() != null) {
					
					oprot.WriteFieldBegin("trackRequest");
					
					com.vip.vop.omni.logistics.LogisticsTrackRequestHelper.getInstance().Write(structs.GetTrackRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("trackRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLogisticsTrack_args bean){
				
				
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
		
		
		
		
		public class receiveMaxSpeedRouteInfo_argsHelper : TBeanSerializer<receiveMaxSpeedRouteInfo_args>
		{
			
			public static receiveMaxSpeedRouteInfo_argsHelper OBJ = new receiveMaxSpeedRouteInfo_argsHelper();
			
			public static receiveMaxSpeedRouteInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveMaxSpeedRouteInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.MaxSpeedRouteInfo value;
					
					value = new com.vip.vop.omni.logistics.MaxSpeedRouteInfo();
					com.vip.vop.omni.logistics.MaxSpeedRouteInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetMaxSpeedRouteInfo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveMaxSpeedRouteInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaxSpeedRouteInfo() != null) {
					
					oprot.WriteFieldBegin("maxSpeedRouteInfo");
					
					com.vip.vop.omni.logistics.MaxSpeedRouteInfoHelper.getInstance().Write(structs.GetMaxSpeedRouteInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("maxSpeedRouteInfo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveMaxSpeedRouteInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveRouteInfo_argsHelper : TBeanSerializer<receiveRouteInfo_args>
		{
			
			public static receiveRouteInfo_argsHelper OBJ = new receiveRouteInfo_argsHelper();
			
			public static receiveRouteInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveRouteInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.WaybillRoute value;
					
					value = new com.vip.vop.omni.logistics.WaybillRoute();
					com.vip.vop.omni.logistics.WaybillRouteHelper.getInstance().Read(value, iprot);
					
					structs.SetWaybillRoute(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveRouteInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWaybillRoute() != null) {
					
					oprot.WriteFieldBegin("waybillRoute");
					
					com.vip.vop.omni.logistics.WaybillRouteHelper.getInstance().Write(structs.GetWaybillRoute(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("waybillRoute can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveRouteInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveYtoRouteInfo_argsHelper : TBeanSerializer<receiveYtoRouteInfo_args>
		{
			
			public static receiveYtoRouteInfo_argsHelper OBJ = new receiveYtoRouteInfo_argsHelper();
			
			public static receiveYtoRouteInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveYtoRouteInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.YtoRouteInfo value;
					
					value = new com.vip.vop.omni.logistics.YtoRouteInfo();
					com.vip.vop.omni.logistics.YtoRouteInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetYtoRouteInfo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveYtoRouteInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetYtoRouteInfo() != null) {
					
					oprot.WriteFieldBegin("ytoRouteInfo");
					
					com.vip.vop.omni.logistics.YtoRouteInfoHelper.getInstance().Write(structs.GetYtoRouteInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("ytoRouteInfo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveYtoRouteInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveZtoRouteInfo_argsHelper : TBeanSerializer<receiveZtoRouteInfo_args>
		{
			
			public static receiveZtoRouteInfo_argsHelper OBJ = new receiveZtoRouteInfo_argsHelper();
			
			public static receiveZtoRouteInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveZtoRouteInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.ZtoRouteInfo value;
					
					value = new com.vip.vop.omni.logistics.ZtoRouteInfo();
					com.vip.vop.omni.logistics.ZtoRouteInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetZtoRouteInfo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveZtoRouteInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetZtoRouteInfo() != null) {
					
					oprot.WriteFieldBegin("ztoRouteInfo");
					
					com.vip.vop.omni.logistics.ZtoRouteInfoHelper.getInstance().Write(structs.GetZtoRouteInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("ztoRouteInfo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveZtoRouteInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLogisticsTrack_resultHelper : TBeanSerializer<getOrderLogisticsTrack_result>
		{
			
			public static getOrderLogisticsTrack_resultHelper OBJ = new getOrderLogisticsTrack_resultHelper();
			
			public static getOrderLogisticsTrack_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLogisticsTrack_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.omni.logistics.LogisticsTrackResponse value;
					
					value = new com.vip.vop.omni.logistics.LogisticsTrackResponse();
					com.vip.vop.omni.logistics.LogisticsTrackResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderLogisticsTrack_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.omni.logistics.LogisticsTrackResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLogisticsTrack_result bean){
				
				
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
		
		
		
		
		public class receiveMaxSpeedRouteInfo_resultHelper : TBeanSerializer<receiveMaxSpeedRouteInfo_result>
		{
			
			public static receiveMaxSpeedRouteInfo_resultHelper OBJ = new receiveMaxSpeedRouteInfo_resultHelper();
			
			public static receiveMaxSpeedRouteInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveMaxSpeedRouteInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveMaxSpeedRouteInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveMaxSpeedRouteInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveRouteInfo_resultHelper : TBeanSerializer<receiveRouteInfo_result>
		{
			
			public static receiveRouteInfo_resultHelper OBJ = new receiveRouteInfo_resultHelper();
			
			public static receiveRouteInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveRouteInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveRouteInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveRouteInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveYtoRouteInfo_resultHelper : TBeanSerializer<receiveYtoRouteInfo_result>
		{
			
			public static receiveYtoRouteInfo_resultHelper OBJ = new receiveYtoRouteInfo_resultHelper();
			
			public static receiveYtoRouteInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveYtoRouteInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveYtoRouteInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveYtoRouteInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveZtoRouteInfo_resultHelper : TBeanSerializer<receiveZtoRouteInfo_result>
		{
			
			public static receiveZtoRouteInfo_resultHelper OBJ = new receiveZtoRouteInfo_resultHelper();
			
			public static receiveZtoRouteInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveZtoRouteInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveZtoRouteInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveZtoRouteInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class OmniLogisticsServiceClient : OspRestStub , OmniLogisticsService  {
			
			
			public OmniLogisticsServiceClient():base("com.vip.vop.omni.logistics.OmniLogisticsService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.omni.logistics.LogisticsTrackResponse getOrderLogisticsTrack(com.vip.vop.omni.logistics.LogisticsTrackRequest trackRequest_) {
				
				send_getOrderLogisticsTrack(trackRequest_);
				return recv_getOrderLogisticsTrack(); 
				
			}
			
			
			private void send_getOrderLogisticsTrack(com.vip.vop.omni.logistics.LogisticsTrackRequest trackRequest_){
				
				InitInvocation("getOrderLogisticsTrack");
				
				getOrderLogisticsTrack_args args = new getOrderLogisticsTrack_args();
				args.SetTrackRequest(trackRequest_);
				
				SendBase(args, getOrderLogisticsTrack_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.omni.logistics.LogisticsTrackResponse recv_getOrderLogisticsTrack(){
				
				getOrderLogisticsTrack_result result = new getOrderLogisticsTrack_result();
				ReceiveBase(result, getOrderLogisticsTrack_resultHelper.getInstance());
				
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
			
			
			public void receiveMaxSpeedRouteInfo(com.vip.vop.omni.logistics.MaxSpeedRouteInfo maxSpeedRouteInfo_) {
				
				send_receiveMaxSpeedRouteInfo(maxSpeedRouteInfo_);
				recv_receiveMaxSpeedRouteInfo();
				
			}
			
			
			private void send_receiveMaxSpeedRouteInfo(com.vip.vop.omni.logistics.MaxSpeedRouteInfo maxSpeedRouteInfo_){
				
				InitInvocation("receiveMaxSpeedRouteInfo");
				
				receiveMaxSpeedRouteInfo_args args = new receiveMaxSpeedRouteInfo_args();
				args.SetMaxSpeedRouteInfo(maxSpeedRouteInfo_);
				
				SendBase(args, receiveMaxSpeedRouteInfo_argsHelper.getInstance());
			}
			
			
			private void recv_receiveMaxSpeedRouteInfo(){
				
				receiveMaxSpeedRouteInfo_result result = new receiveMaxSpeedRouteInfo_result();
				ReceiveBase(result, receiveMaxSpeedRouteInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void receiveRouteInfo(com.vip.vop.omni.logistics.WaybillRoute waybillRoute_) {
				
				send_receiveRouteInfo(waybillRoute_);
				recv_receiveRouteInfo();
				
			}
			
			
			private void send_receiveRouteInfo(com.vip.vop.omni.logistics.WaybillRoute waybillRoute_){
				
				InitInvocation("receiveRouteInfo");
				
				receiveRouteInfo_args args = new receiveRouteInfo_args();
				args.SetWaybillRoute(waybillRoute_);
				
				SendBase(args, receiveRouteInfo_argsHelper.getInstance());
			}
			
			
			private void recv_receiveRouteInfo(){
				
				receiveRouteInfo_result result = new receiveRouteInfo_result();
				ReceiveBase(result, receiveRouteInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void receiveYtoRouteInfo(com.vip.vop.omni.logistics.YtoRouteInfo ytoRouteInfo_) {
				
				send_receiveYtoRouteInfo(ytoRouteInfo_);
				recv_receiveYtoRouteInfo();
				
			}
			
			
			private void send_receiveYtoRouteInfo(com.vip.vop.omni.logistics.YtoRouteInfo ytoRouteInfo_){
				
				InitInvocation("receiveYtoRouteInfo");
				
				receiveYtoRouteInfo_args args = new receiveYtoRouteInfo_args();
				args.SetYtoRouteInfo(ytoRouteInfo_);
				
				SendBase(args, receiveYtoRouteInfo_argsHelper.getInstance());
			}
			
			
			private void recv_receiveYtoRouteInfo(){
				
				receiveYtoRouteInfo_result result = new receiveYtoRouteInfo_result();
				ReceiveBase(result, receiveYtoRouteInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void receiveZtoRouteInfo(com.vip.vop.omni.logistics.ZtoRouteInfo ztoRouteInfo_) {
				
				send_receiveZtoRouteInfo(ztoRouteInfo_);
				recv_receiveZtoRouteInfo();
				
			}
			
			
			private void send_receiveZtoRouteInfo(com.vip.vop.omni.logistics.ZtoRouteInfo ztoRouteInfo_){
				
				InitInvocation("receiveZtoRouteInfo");
				
				receiveZtoRouteInfo_args args = new receiveZtoRouteInfo_args();
				args.SetZtoRouteInfo(ztoRouteInfo_);
				
				SendBase(args, receiveZtoRouteInfo_argsHelper.getInstance());
			}
			
			
			private void recv_receiveZtoRouteInfo(){
				
				receiveZtoRouteInfo_result result = new receiveZtoRouteInfo_result();
				ReceiveBase(result, receiveZtoRouteInfo_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}