using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.vipmax.order{
	
	
	public class OrderServiceHelper {
		
		
		
		public class getVipmaxOders_args {
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private vipapis.vipmax.order.GetVipmaxOrdersRequest request_;
			
			public vipapis.vipmax.order.GetVipmaxOrdersRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.order.GetVipmaxOrdersRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class syncOrder_args {
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private vipapis.vipmax.order.SyncOrderRequest request_;
			
			public vipapis.vipmax.order.SyncOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.order.SyncOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class syncRefundOrder_args {
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private vipapis.vipmax.order.SyncRefundOrderRequest request_;
			
			public vipapis.vipmax.order.SyncRefundOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.order.SyncRefundOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getVipmaxOders_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.order.GetVipmaxOrdersResponse success_;
			
			public vipapis.vipmax.order.GetVipmaxOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.order.GetVipmaxOrdersResponse value){
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
		
		
		
		
		public class syncOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.order.SyncOrderResponse success_;
			
			public vipapis.vipmax.order.SyncOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.order.SyncOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncRefundOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.order.SyncRefundOrderResponse success_;
			
			public vipapis.vipmax.order.SyncRefundOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.order.SyncRefundOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getVipmaxOders_argsHelper : TBeanSerializer<getVipmaxOders_args>
		{
			
			public static getVipmaxOders_argsHelper OBJ = new getVipmaxOders_argsHelper();
			
			public static getVipmaxOders_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVipmaxOders_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.GetVipmaxOrdersRequest value;
					
					value = new vipapis.vipmax.order.GetVipmaxOrdersRequest();
					vipapis.vipmax.order.GetVipmaxOrdersRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVipmaxOders_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.order.GetVipmaxOrdersRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVipmaxOders_args bean){
				
				
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
		
		
		
		
		public class syncOrder_argsHelper : TBeanSerializer<syncOrder_args>
		{
			
			public static syncOrder_argsHelper OBJ = new syncOrder_argsHelper();
			
			public static syncOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.SyncOrderRequest value;
					
					value = new vipapis.vipmax.order.SyncOrderRequest();
					vipapis.vipmax.order.SyncOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.order.SyncOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncRefundOrder_argsHelper : TBeanSerializer<syncRefundOrder_args>
		{
			
			public static syncRefundOrder_argsHelper OBJ = new syncRefundOrder_argsHelper();
			
			public static syncRefundOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncRefundOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.SyncRefundOrderRequest value;
					
					value = new vipapis.vipmax.order.SyncRefundOrderRequest();
					vipapis.vipmax.order.SyncRefundOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncRefundOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.order.SyncRefundOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncRefundOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVipmaxOders_resultHelper : TBeanSerializer<getVipmaxOders_result>
		{
			
			public static getVipmaxOders_resultHelper OBJ = new getVipmaxOders_resultHelper();
			
			public static getVipmaxOders_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVipmaxOders_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.GetVipmaxOrdersResponse value;
					
					value = new vipapis.vipmax.order.GetVipmaxOrdersResponse();
					vipapis.vipmax.order.GetVipmaxOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVipmaxOders_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.order.GetVipmaxOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVipmaxOders_result bean){
				
				
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
		
		
		
		
		public class syncOrder_resultHelper : TBeanSerializer<syncOrder_result>
		{
			
			public static syncOrder_resultHelper OBJ = new syncOrder_resultHelper();
			
			public static syncOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.SyncOrderResponse value;
					
					value = new vipapis.vipmax.order.SyncOrderResponse();
					vipapis.vipmax.order.SyncOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.order.SyncOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncRefundOrder_resultHelper : TBeanSerializer<syncRefundOrder_result>
		{
			
			public static syncRefundOrder_resultHelper OBJ = new syncRefundOrder_resultHelper();
			
			public static syncRefundOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncRefundOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.order.SyncRefundOrderResponse value;
					
					value = new vipapis.vipmax.order.SyncRefundOrderResponse();
					vipapis.vipmax.order.SyncRefundOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncRefundOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.order.SyncRefundOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncRefundOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class OrderServiceClient : OspRestStub , OrderService  {
			
			
			public OrderServiceClient():base("vipapis.vipmax.order.OrderService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.vipmax.order.GetVipmaxOrdersResponse getVipmaxOders(vipapis.vipmax.order.GetVipmaxOrdersRequest request_) {
				
				send_getVipmaxOders(request_);
				return recv_getVipmaxOders(); 
				
			}
			
			
			private void send_getVipmaxOders(vipapis.vipmax.order.GetVipmaxOrdersRequest request_){
				
				InitInvocation("getVipmaxOders");
				
				getVipmaxOders_args args = new getVipmaxOders_args();
				args.SetRequest(request_);
				
				SendBase(args, getVipmaxOders_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.order.GetVipmaxOrdersResponse recv_getVipmaxOders(){
				
				getVipmaxOders_result result = new getVipmaxOders_result();
				ReceiveBase(result, getVipmaxOders_resultHelper.getInstance());
				
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
			
			
			public vipapis.vipmax.order.SyncOrderResponse syncOrder(vipapis.vipmax.order.SyncOrderRequest request_) {
				
				send_syncOrder(request_);
				return recv_syncOrder(); 
				
			}
			
			
			private void send_syncOrder(vipapis.vipmax.order.SyncOrderRequest request_){
				
				InitInvocation("syncOrder");
				
				syncOrder_args args = new syncOrder_args();
				args.SetRequest(request_);
				
				SendBase(args, syncOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.order.SyncOrderResponse recv_syncOrder(){
				
				syncOrder_result result = new syncOrder_result();
				ReceiveBase(result, syncOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.vipmax.order.SyncRefundOrderResponse syncRefundOrder(vipapis.vipmax.order.SyncRefundOrderRequest request_) {
				
				send_syncRefundOrder(request_);
				return recv_syncRefundOrder(); 
				
			}
			
			
			private void send_syncRefundOrder(vipapis.vipmax.order.SyncRefundOrderRequest request_){
				
				InitInvocation("syncRefundOrder");
				
				syncRefundOrder_args args = new syncRefundOrder_args();
				args.SetRequest(request_);
				
				SendBase(args, syncRefundOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.order.SyncRefundOrderResponse recv_syncRefundOrder(){
				
				syncRefundOrder_result result = new syncRefundOrder_result();
				ReceiveBase(result, syncRefundOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}