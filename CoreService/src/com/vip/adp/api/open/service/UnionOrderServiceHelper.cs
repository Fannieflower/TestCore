using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.adp.api.open.service{
	
	
	public class UnionOrderServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class orderList_args {
			
			///<summary>
			/// 联盟订单请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.OrderQueryModel queryModel_;
			
			public com.vip.adp.api.open.service.OrderQueryModel GetQueryModel(){
				return this.queryModel_;
			}
			
			public void SetQueryModel(com.vip.adp.api.open.service.OrderQueryModel value){
				this.queryModel_ = value;
			}
			
		}
		
		
		
		
		public class orderListWithOauth_args {
			
			///<summary>
			/// 联盟订单请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.OrderQueryModel queryModel_;
			
			public com.vip.adp.api.open.service.OrderQueryModel GetQueryModel(){
				return this.queryModel_;
			}
			
			public void SetQueryModel(com.vip.adp.api.open.service.OrderQueryModel value){
				this.queryModel_ = value;
			}
			
		}
		
		
		
		
		public class refundOrderList_args {
			
			///<summary>
			/// 联盟维权订单请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.RefundOrderRequest request_;
			
			public com.vip.adp.api.open.service.RefundOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.RefundOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class refundOrderListWithOauth_args {
			
			///<summary>
			/// 联盟维权订单请求参数
			///</summary>
			
			private com.vip.adp.api.open.service.RefundOrderRequest request_;
			
			public com.vip.adp.api.open.service.RefundOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.adp.api.open.service.RefundOrderRequest value){
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
		
		
		
		
		public class orderList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.OrderResponse success_;
			
			public com.vip.adp.api.open.service.OrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.OrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class orderListWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.OrderResponse success_;
			
			public com.vip.adp.api.open.service.OrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.OrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class refundOrderList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.RefundOrderResponse success_;
			
			public com.vip.adp.api.open.service.RefundOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.RefundOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class refundOrderListWithOauth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.adp.api.open.service.RefundOrderResponse success_;
			
			public com.vip.adp.api.open.service.RefundOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.adp.api.open.service.RefundOrderResponse value){
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
		
		
		
		
		public class orderList_argsHelper : TBeanSerializer<orderList_args>
		{
			
			public static orderList_argsHelper OBJ = new orderList_argsHelper();
			
			public static orderList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(orderList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.OrderQueryModel value;
					
					value = new com.vip.adp.api.open.service.OrderQueryModel();
					com.vip.adp.api.open.service.OrderQueryModelHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(orderList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryModel() != null) {
					
					oprot.WriteFieldBegin("queryModel");
					
					com.vip.adp.api.open.service.OrderQueryModelHelper.getInstance().Write(structs.GetQueryModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(orderList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class orderListWithOauth_argsHelper : TBeanSerializer<orderListWithOauth_args>
		{
			
			public static orderListWithOauth_argsHelper OBJ = new orderListWithOauth_argsHelper();
			
			public static orderListWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(orderListWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.OrderQueryModel value;
					
					value = new com.vip.adp.api.open.service.OrderQueryModel();
					com.vip.adp.api.open.service.OrderQueryModelHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(orderListWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryModel() != null) {
					
					oprot.WriteFieldBegin("queryModel");
					
					com.vip.adp.api.open.service.OrderQueryModelHelper.getInstance().Write(structs.GetQueryModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(orderListWithOauth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refundOrderList_argsHelper : TBeanSerializer<refundOrderList_args>
		{
			
			public static refundOrderList_argsHelper OBJ = new refundOrderList_argsHelper();
			
			public static refundOrderList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refundOrderList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.RefundOrderRequest value;
					
					value = new com.vip.adp.api.open.service.RefundOrderRequest();
					com.vip.adp.api.open.service.RefundOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refundOrderList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.RefundOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refundOrderList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refundOrderListWithOauth_argsHelper : TBeanSerializer<refundOrderListWithOauth_args>
		{
			
			public static refundOrderListWithOauth_argsHelper OBJ = new refundOrderListWithOauth_argsHelper();
			
			public static refundOrderListWithOauth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refundOrderListWithOauth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.RefundOrderRequest value;
					
					value = new com.vip.adp.api.open.service.RefundOrderRequest();
					com.vip.adp.api.open.service.RefundOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refundOrderListWithOauth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.adp.api.open.service.RefundOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refundOrderListWithOauth_args bean){
				
				
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
		
		
		
		
		public class orderList_resultHelper : TBeanSerializer<orderList_result>
		{
			
			public static orderList_resultHelper OBJ = new orderList_resultHelper();
			
			public static orderList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(orderList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.OrderResponse value;
					
					value = new com.vip.adp.api.open.service.OrderResponse();
					com.vip.adp.api.open.service.OrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(orderList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.OrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(orderList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class orderListWithOauth_resultHelper : TBeanSerializer<orderListWithOauth_result>
		{
			
			public static orderListWithOauth_resultHelper OBJ = new orderListWithOauth_resultHelper();
			
			public static orderListWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(orderListWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.OrderResponse value;
					
					value = new com.vip.adp.api.open.service.OrderResponse();
					com.vip.adp.api.open.service.OrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(orderListWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.OrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(orderListWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refundOrderList_resultHelper : TBeanSerializer<refundOrderList_result>
		{
			
			public static refundOrderList_resultHelper OBJ = new refundOrderList_resultHelper();
			
			public static refundOrderList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refundOrderList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.RefundOrderResponse value;
					
					value = new com.vip.adp.api.open.service.RefundOrderResponse();
					com.vip.adp.api.open.service.RefundOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refundOrderList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.RefundOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refundOrderList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refundOrderListWithOauth_resultHelper : TBeanSerializer<refundOrderListWithOauth_result>
		{
			
			public static refundOrderListWithOauth_resultHelper OBJ = new refundOrderListWithOauth_resultHelper();
			
			public static refundOrderListWithOauth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refundOrderListWithOauth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.adp.api.open.service.RefundOrderResponse value;
					
					value = new com.vip.adp.api.open.service.RefundOrderResponse();
					com.vip.adp.api.open.service.RefundOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refundOrderListWithOauth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.adp.api.open.service.RefundOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refundOrderListWithOauth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class UnionOrderServiceClient : OspRestStub , UnionOrderService  {
			
			
			public UnionOrderServiceClient():base("com.vip.adp.api.open.service.UnionOrderService","1.0.0") {
				
				
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
			
			
			public com.vip.adp.api.open.service.OrderResponse orderList(com.vip.adp.api.open.service.OrderQueryModel queryModel_) {
				
				send_orderList(queryModel_);
				return recv_orderList(); 
				
			}
			
			
			private void send_orderList(com.vip.adp.api.open.service.OrderQueryModel queryModel_){
				
				InitInvocation("orderList");
				
				orderList_args args = new orderList_args();
				args.SetQueryModel(queryModel_);
				
				SendBase(args, orderList_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.OrderResponse recv_orderList(){
				
				orderList_result result = new orderList_result();
				ReceiveBase(result, orderList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.OrderResponse orderListWithOauth(com.vip.adp.api.open.service.OrderQueryModel queryModel_) {
				
				send_orderListWithOauth(queryModel_);
				return recv_orderListWithOauth(); 
				
			}
			
			
			private void send_orderListWithOauth(com.vip.adp.api.open.service.OrderQueryModel queryModel_){
				
				InitInvocation("orderListWithOauth");
				
				orderListWithOauth_args args = new orderListWithOauth_args();
				args.SetQueryModel(queryModel_);
				
				SendBase(args, orderListWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.OrderResponse recv_orderListWithOauth(){
				
				orderListWithOauth_result result = new orderListWithOauth_result();
				ReceiveBase(result, orderListWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.RefundOrderResponse refundOrderList(com.vip.adp.api.open.service.RefundOrderRequest request_) {
				
				send_refundOrderList(request_);
				return recv_refundOrderList(); 
				
			}
			
			
			private void send_refundOrderList(com.vip.adp.api.open.service.RefundOrderRequest request_){
				
				InitInvocation("refundOrderList");
				
				refundOrderList_args args = new refundOrderList_args();
				args.SetRequest(request_);
				
				SendBase(args, refundOrderList_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.RefundOrderResponse recv_refundOrderList(){
				
				refundOrderList_result result = new refundOrderList_result();
				ReceiveBase(result, refundOrderList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.adp.api.open.service.RefundOrderResponse refundOrderListWithOauth(com.vip.adp.api.open.service.RefundOrderRequest request_) {
				
				send_refundOrderListWithOauth(request_);
				return recv_refundOrderListWithOauth(); 
				
			}
			
			
			private void send_refundOrderListWithOauth(com.vip.adp.api.open.service.RefundOrderRequest request_){
				
				InitInvocation("refundOrderListWithOauth");
				
				refundOrderListWithOauth_args args = new refundOrderListWithOauth_args();
				args.SetRequest(request_);
				
				SendBase(args, refundOrderListWithOauth_argsHelper.getInstance());
			}
			
			
			private com.vip.adp.api.open.service.RefundOrderResponse recv_refundOrderListWithOauth(){
				
				refundOrderListWithOauth_result result = new refundOrderListWithOauth_result();
				ReceiveBase(result, refundOrderListWithOauth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}