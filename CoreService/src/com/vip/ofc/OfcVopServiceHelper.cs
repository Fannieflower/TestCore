using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.ofc{
	
	
	public class OfcVopServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class wmsUpdateOrderStatus_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.ofc.vo.VopRequestHeader header_;
			
			///<summary>
			/// WMS客户订单状态反馈接口请求结构体
			///</summary>
			
			private com.vip.ofc.request.vop.WmsUpdateOrderStatusReq req_;
			
			public com.vip.ofc.vo.VopRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.ofc.vo.VopRequestHeader value){
				this.header_ = value;
			}
			public com.vip.ofc.request.vop.WmsUpdateOrderStatusReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.ofc.request.vop.WmsUpdateOrderStatusReq value){
				this.req_ = value;
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
		
		
		
		
		public class wmsUpdateOrderStatus_result {
			
			///<summary>
			///</summary>
			
			private com.vip.ofc.response.vop.WmsUpdateOrderStatusResp success_;
			
			public com.vip.ofc.response.vop.WmsUpdateOrderStatusResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.ofc.response.vop.WmsUpdateOrderStatusResp value){
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
		
		
		
		
		public class wmsUpdateOrderStatus_argsHelper : TBeanSerializer<wmsUpdateOrderStatus_args>
		{
			
			public static wmsUpdateOrderStatus_argsHelper OBJ = new wmsUpdateOrderStatus_argsHelper();
			
			public static wmsUpdateOrderStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(wmsUpdateOrderStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.ofc.vo.VopRequestHeader value;
					
					value = new com.vip.ofc.vo.VopRequestHeader();
					com.vip.ofc.vo.VopRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.ofc.request.vop.WmsUpdateOrderStatusReq value;
					
					value = new com.vip.ofc.request.vop.WmsUpdateOrderStatusReq();
					com.vip.ofc.request.vop.WmsUpdateOrderStatusReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(wmsUpdateOrderStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.ofc.vo.VopRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.ofc.request.vop.WmsUpdateOrderStatusReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(wmsUpdateOrderStatus_args bean){
				
				
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
		
		
		
		
		public class wmsUpdateOrderStatus_resultHelper : TBeanSerializer<wmsUpdateOrderStatus_result>
		{
			
			public static wmsUpdateOrderStatus_resultHelper OBJ = new wmsUpdateOrderStatus_resultHelper();
			
			public static wmsUpdateOrderStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(wmsUpdateOrderStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.ofc.response.vop.WmsUpdateOrderStatusResp value;
					
					value = new com.vip.ofc.response.vop.WmsUpdateOrderStatusResp();
					com.vip.ofc.response.vop.WmsUpdateOrderStatusRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(wmsUpdateOrderStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.ofc.response.vop.WmsUpdateOrderStatusRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(wmsUpdateOrderStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class OfcVopServiceClient : OspRestStub , OfcVopService  {
			
			
			public OfcVopServiceClient():base("com.vip.ofc.OfcVopService","1.0.0") {
				
				
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
			
			
			public com.vip.ofc.response.vop.WmsUpdateOrderStatusResp wmsUpdateOrderStatus(com.vip.ofc.vo.VopRequestHeader header_,com.vip.ofc.request.vop.WmsUpdateOrderStatusReq req_) {
				
				send_wmsUpdateOrderStatus(header_,req_);
				return recv_wmsUpdateOrderStatus(); 
				
			}
			
			
			private void send_wmsUpdateOrderStatus(com.vip.ofc.vo.VopRequestHeader header_,com.vip.ofc.request.vop.WmsUpdateOrderStatusReq req_){
				
				InitInvocation("wmsUpdateOrderStatus");
				
				wmsUpdateOrderStatus_args args = new wmsUpdateOrderStatus_args();
				args.SetHeader(header_);
				args.SetReq(req_);
				
				SendBase(args, wmsUpdateOrderStatus_argsHelper.getInstance());
			}
			
			
			private com.vip.ofc.response.vop.WmsUpdateOrderStatusResp recv_wmsUpdateOrderStatus(){
				
				wmsUpdateOrderStatus_result result = new wmsUpdateOrderStatus_result();
				ReceiveBase(result, wmsUpdateOrderStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}