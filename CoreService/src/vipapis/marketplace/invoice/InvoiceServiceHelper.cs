using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.marketplace.invoice{
	
	
	public class InvoiceServiceHelper {
		
		
		
		public class confirmInvoice_args {
			
			///<summary>
			/// 请求实体
			///</summary>
			
			private vipapis.marketplace.invoice.ConfirmInvoiceRequest request_;
			
			public vipapis.marketplace.invoice.ConfirmInvoiceRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.invoice.ConfirmInvoiceRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getInvoices_args {
			
			///<summary>
			/// 请求实体
			///</summary>
			
			private vipapis.marketplace.invoice.GetInvoicesRequest request_;
			
			public vipapis.marketplace.invoice.GetInvoicesRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.invoice.GetInvoicesRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class confirmInvoice_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.invoice.ConfirmInvoiceResponse success_;
			
			public vipapis.marketplace.invoice.ConfirmInvoiceResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.invoice.ConfirmInvoiceResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getInvoices_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.invoice.GetInvoicesResponse success_;
			
			public vipapis.marketplace.invoice.GetInvoicesResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.invoice.GetInvoicesResponse value){
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
		
		
		
		
		
		public class confirmInvoice_argsHelper : TBeanSerializer<confirmInvoice_args>
		{
			
			public static confirmInvoice_argsHelper OBJ = new confirmInvoice_argsHelper();
			
			public static confirmInvoice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmInvoice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.invoice.ConfirmInvoiceRequest value;
					
					value = new vipapis.marketplace.invoice.ConfirmInvoiceRequest();
					vipapis.marketplace.invoice.ConfirmInvoiceRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmInvoice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.invoice.ConfirmInvoiceRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmInvoice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getInvoices_argsHelper : TBeanSerializer<getInvoices_args>
		{
			
			public static getInvoices_argsHelper OBJ = new getInvoices_argsHelper();
			
			public static getInvoices_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getInvoices_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.invoice.GetInvoicesRequest value;
					
					value = new vipapis.marketplace.invoice.GetInvoicesRequest();
					vipapis.marketplace.invoice.GetInvoicesRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getInvoices_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.invoice.GetInvoicesRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getInvoices_args bean){
				
				
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
		
		
		
		
		public class confirmInvoice_resultHelper : TBeanSerializer<confirmInvoice_result>
		{
			
			public static confirmInvoice_resultHelper OBJ = new confirmInvoice_resultHelper();
			
			public static confirmInvoice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmInvoice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.invoice.ConfirmInvoiceResponse value;
					
					value = new vipapis.marketplace.invoice.ConfirmInvoiceResponse();
					vipapis.marketplace.invoice.ConfirmInvoiceResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmInvoice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.invoice.ConfirmInvoiceResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmInvoice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getInvoices_resultHelper : TBeanSerializer<getInvoices_result>
		{
			
			public static getInvoices_resultHelper OBJ = new getInvoices_resultHelper();
			
			public static getInvoices_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getInvoices_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.invoice.GetInvoicesResponse value;
					
					value = new vipapis.marketplace.invoice.GetInvoicesResponse();
					vipapis.marketplace.invoice.GetInvoicesResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getInvoices_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.invoice.GetInvoicesResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getInvoices_result bean){
				
				
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
		
		
		
		
		public class InvoiceServiceClient : OspRestStub , InvoiceService  {
			
			
			public InvoiceServiceClient():base("vipapis.marketplace.invoice.InvoiceService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.marketplace.invoice.ConfirmInvoiceResponse confirmInvoice(vipapis.marketplace.invoice.ConfirmInvoiceRequest request_) {
				
				send_confirmInvoice(request_);
				return recv_confirmInvoice(); 
				
			}
			
			
			private void send_confirmInvoice(vipapis.marketplace.invoice.ConfirmInvoiceRequest request_){
				
				InitInvocation("confirmInvoice");
				
				confirmInvoice_args args = new confirmInvoice_args();
				args.SetRequest(request_);
				
				SendBase(args, confirmInvoice_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.invoice.ConfirmInvoiceResponse recv_confirmInvoice(){
				
				confirmInvoice_result result = new confirmInvoice_result();
				ReceiveBase(result, confirmInvoice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.marketplace.invoice.GetInvoicesResponse getInvoices(vipapis.marketplace.invoice.GetInvoicesRequest request_) {
				
				send_getInvoices(request_);
				return recv_getInvoices(); 
				
			}
			
			
			private void send_getInvoices(vipapis.marketplace.invoice.GetInvoicesRequest request_){
				
				InitInvocation("getInvoices");
				
				getInvoices_args args = new getInvoices_args();
				args.SetRequest(request_);
				
				SendBase(args, getInvoices_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.invoice.GetInvoicesResponse recv_getInvoices(){
				
				getInvoices_result result = new getInvoices_result();
				ReceiveBase(result, getInvoices_resultHelper.getInstance());
				
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