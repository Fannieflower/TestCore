using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.ordererp.api{
	
	
	public class OfcErpServiceHelper {
		
		
		
		public class addInfErpOrderInfo_args {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq req_;
			
			public vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class addInfErpOrderInfo_result {
			
			///<summary>
			/// 插入ERP订单数据,专门提供给erp同步其线下订单至唯品会, 单次调用不能超过50个订单。
			///</summary>
			
			private vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp success_;
			
			public vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp value){
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
		
		
		
		
		
		public class addInfErpOrderInfo_argsHelper : TBeanSerializer<addInfErpOrderInfo_args>
		{
			
			public static addInfErpOrderInfo_argsHelper OBJ = new addInfErpOrderInfo_argsHelper();
			
			public static addInfErpOrderInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addInfErpOrderInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq value;
					
					value = new vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq();
					vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addInfErpOrderInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addInfErpOrderInfo_args bean){
				
				
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
		
		
		
		
		public class addInfErpOrderInfo_resultHelper : TBeanSerializer<addInfErpOrderInfo_result>
		{
			
			public static addInfErpOrderInfo_resultHelper OBJ = new addInfErpOrderInfo_resultHelper();
			
			public static addInfErpOrderInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addInfErpOrderInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp value;
					
					value = new vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp();
					vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addInfErpOrderInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addInfErpOrderInfo_result bean){
				
				
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
		
		
		
		
		public class OfcErpServiceClient : OspRestStub , OfcErpService  {
			
			
			public OfcErpServiceClient():base("vipapis.xstore.cc.ordererp.api.OfcErpService","1.0.5") {
				
				
			}
			
			
			
			public vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp addInfErpOrderInfo(vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq req_) {
				
				send_addInfErpOrderInfo(req_);
				return recv_addInfErpOrderInfo(); 
				
			}
			
			
			private void send_addInfErpOrderInfo(vipapis.xstore.cc.ordererp.api.request.AddInfErpOrderInfoReq req_){
				
				InitInvocation("addInfErpOrderInfo");
				
				addInfErpOrderInfo_args args = new addInfErpOrderInfo_args();
				args.SetReq(req_);
				
				SendBase(args, addInfErpOrderInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.ordererp.api.response.AddInfErpOrderInfoResp recv_addInfErpOrderInfo(){
				
				addInfErpOrderInfo_result result = new addInfErpOrderInfo_result();
				ReceiveBase(result, addInfErpOrderInfo_resultHelper.getInstance());
				
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