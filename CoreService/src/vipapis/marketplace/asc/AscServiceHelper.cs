using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.marketplace.asc{
	
	
	public class AscServiceHelper {
		
		
		
		public class applyRefund_args {
			
			///<summary>
			/// 售后申请单同意退款请求参数
			///</summary>
			
			private vipapis.marketplace.asc.ApplyRefundRequest request_;
			
			public vipapis.marketplace.asc.ApplyRefundRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.ApplyRefundRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class approveAsc_args {
			
			///<summary>
			/// 售后申请单通过的请求参数
			///</summary>
			
			private vipapis.marketplace.asc.ApproveAscRequest request_;
			
			public vipapis.marketplace.asc.ApproveAscRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.ApproveAscRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class cancelAsc_args {
			
			///<summary>
			/// 售后申请单驳回的请求参数
			///</summary>
			
			private vipapis.marketplace.asc.CancelAscRequest request_;
			
			public vipapis.marketplace.asc.CancelAscRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.CancelAscRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class confirmRefund_args {
			
			///<summary>
			/// 拒收单确认退款请求参数
			///</summary>
			
			private vipapis.marketplace.asc.RejectApplyRefundRequest request_;
			
			public vipapis.marketplace.asc.RejectApplyRefundRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.RejectApplyRefundRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getAscInfo_args {
			
			///<summary>
			/// 售后申请单信息的列表查询接口的请求参数
			///</summary>
			
			private vipapis.marketplace.asc.GetAscInfoRequest request_;
			
			public vipapis.marketplace.asc.GetAscInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.GetAscInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getAscs_args {
			
			///<summary>
			/// 售后申请单信息的列表查询接口的请求参数
			///</summary>
			
			private vipapis.marketplace.asc.GetAscsRequest request_;
			
			public vipapis.marketplace.asc.GetAscsRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.GetAscsRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class refuseRefund_args {
			
			///<summary>
			/// 售后申请单拒绝退款请求参数
			///</summary>
			
			private vipapis.marketplace.asc.RefuseRefundRequest request_;
			
			public vipapis.marketplace.asc.RefuseRefundRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.asc.RefuseRefundRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class applyRefund_result {
			
			
		}
		
		
		
		
		public class approveAsc_result {
			
			
		}
		
		
		
		
		public class cancelAsc_result {
			
			
		}
		
		
		
		
		public class confirmRefund_result {
			
			
		}
		
		
		
		
		public class getAscInfo_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.asc.GetAscInfoResponse success_;
			
			public vipapis.marketplace.asc.GetAscInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.asc.GetAscInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getAscs_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.asc.GetAscsResponse success_;
			
			public vipapis.marketplace.asc.GetAscsResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.asc.GetAscsResponse value){
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
		
		
		
		
		public class refuseRefund_result {
			
			
		}
		
		
		
		
		
		public class applyRefund_argsHelper : TBeanSerializer<applyRefund_args>
		{
			
			public static applyRefund_argsHelper OBJ = new applyRefund_argsHelper();
			
			public static applyRefund_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(applyRefund_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.ApplyRefundRequest value;
					
					value = new vipapis.marketplace.asc.ApplyRefundRequest();
					vipapis.marketplace.asc.ApplyRefundRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(applyRefund_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.ApplyRefundRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(applyRefund_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class approveAsc_argsHelper : TBeanSerializer<approveAsc_args>
		{
			
			public static approveAsc_argsHelper OBJ = new approveAsc_argsHelper();
			
			public static approveAsc_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(approveAsc_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.ApproveAscRequest value;
					
					value = new vipapis.marketplace.asc.ApproveAscRequest();
					vipapis.marketplace.asc.ApproveAscRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(approveAsc_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.ApproveAscRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(approveAsc_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelAsc_argsHelper : TBeanSerializer<cancelAsc_args>
		{
			
			public static cancelAsc_argsHelper OBJ = new cancelAsc_argsHelper();
			
			public static cancelAsc_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelAsc_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.CancelAscRequest value;
					
					value = new vipapis.marketplace.asc.CancelAscRequest();
					vipapis.marketplace.asc.CancelAscRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelAsc_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.CancelAscRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelAsc_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmRefund_argsHelper : TBeanSerializer<confirmRefund_args>
		{
			
			public static confirmRefund_argsHelper OBJ = new confirmRefund_argsHelper();
			
			public static confirmRefund_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmRefund_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.RejectApplyRefundRequest value;
					
					value = new vipapis.marketplace.asc.RejectApplyRefundRequest();
					vipapis.marketplace.asc.RejectApplyRefundRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmRefund_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.RejectApplyRefundRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmRefund_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAscInfo_argsHelper : TBeanSerializer<getAscInfo_args>
		{
			
			public static getAscInfo_argsHelper OBJ = new getAscInfo_argsHelper();
			
			public static getAscInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAscInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.GetAscInfoRequest value;
					
					value = new vipapis.marketplace.asc.GetAscInfoRequest();
					vipapis.marketplace.asc.GetAscInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAscInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.GetAscInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAscInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAscs_argsHelper : TBeanSerializer<getAscs_args>
		{
			
			public static getAscs_argsHelper OBJ = new getAscs_argsHelper();
			
			public static getAscs_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAscs_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.GetAscsRequest value;
					
					value = new vipapis.marketplace.asc.GetAscsRequest();
					vipapis.marketplace.asc.GetAscsRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAscs_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.GetAscsRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAscs_args bean){
				
				
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
		
		
		
		
		public class refuseRefund_argsHelper : TBeanSerializer<refuseRefund_args>
		{
			
			public static refuseRefund_argsHelper OBJ = new refuseRefund_argsHelper();
			
			public static refuseRefund_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refuseRefund_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.RefuseRefundRequest value;
					
					value = new vipapis.marketplace.asc.RefuseRefundRequest();
					vipapis.marketplace.asc.RefuseRefundRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refuseRefund_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.asc.RefuseRefundRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refuseRefund_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class applyRefund_resultHelper : TBeanSerializer<applyRefund_result>
		{
			
			public static applyRefund_resultHelper OBJ = new applyRefund_resultHelper();
			
			public static applyRefund_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(applyRefund_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(applyRefund_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(applyRefund_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class approveAsc_resultHelper : TBeanSerializer<approveAsc_result>
		{
			
			public static approveAsc_resultHelper OBJ = new approveAsc_resultHelper();
			
			public static approveAsc_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(approveAsc_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(approveAsc_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(approveAsc_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelAsc_resultHelper : TBeanSerializer<cancelAsc_result>
		{
			
			public static cancelAsc_resultHelper OBJ = new cancelAsc_resultHelper();
			
			public static cancelAsc_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelAsc_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelAsc_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelAsc_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmRefund_resultHelper : TBeanSerializer<confirmRefund_result>
		{
			
			public static confirmRefund_resultHelper OBJ = new confirmRefund_resultHelper();
			
			public static confirmRefund_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmRefund_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmRefund_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmRefund_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAscInfo_resultHelper : TBeanSerializer<getAscInfo_result>
		{
			
			public static getAscInfo_resultHelper OBJ = new getAscInfo_resultHelper();
			
			public static getAscInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAscInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.GetAscInfoResponse value;
					
					value = new vipapis.marketplace.asc.GetAscInfoResponse();
					vipapis.marketplace.asc.GetAscInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAscInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.asc.GetAscInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAscInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAscs_resultHelper : TBeanSerializer<getAscs_result>
		{
			
			public static getAscs_resultHelper OBJ = new getAscs_resultHelper();
			
			public static getAscs_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAscs_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.asc.GetAscsResponse value;
					
					value = new vipapis.marketplace.asc.GetAscsResponse();
					vipapis.marketplace.asc.GetAscsResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAscs_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.asc.GetAscsResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAscs_result bean){
				
				
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
		
		
		
		
		public class refuseRefund_resultHelper : TBeanSerializer<refuseRefund_result>
		{
			
			public static refuseRefund_resultHelper OBJ = new refuseRefund_resultHelper();
			
			public static refuseRefund_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refuseRefund_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refuseRefund_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refuseRefund_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class AscServiceClient : OspRestStub , AscService  {
			
			
			public AscServiceClient():base("vipapis.marketplace.asc.AscService","1.0.0") {
				
				
			}
			
			
			
			public void applyRefund(vipapis.marketplace.asc.ApplyRefundRequest request_) {
				
				send_applyRefund(request_);
				recv_applyRefund();
				
			}
			
			
			private void send_applyRefund(vipapis.marketplace.asc.ApplyRefundRequest request_){
				
				InitInvocation("applyRefund");
				
				applyRefund_args args = new applyRefund_args();
				args.SetRequest(request_);
				
				SendBase(args, applyRefund_argsHelper.getInstance());
			}
			
			
			private void recv_applyRefund(){
				
				applyRefund_result result = new applyRefund_result();
				ReceiveBase(result, applyRefund_resultHelper.getInstance());
				
				
			}
			
			
			public void approveAsc(vipapis.marketplace.asc.ApproveAscRequest request_) {
				
				send_approveAsc(request_);
				recv_approveAsc();
				
			}
			
			
			private void send_approveAsc(vipapis.marketplace.asc.ApproveAscRequest request_){
				
				InitInvocation("approveAsc");
				
				approveAsc_args args = new approveAsc_args();
				args.SetRequest(request_);
				
				SendBase(args, approveAsc_argsHelper.getInstance());
			}
			
			
			private void recv_approveAsc(){
				
				approveAsc_result result = new approveAsc_result();
				ReceiveBase(result, approveAsc_resultHelper.getInstance());
				
				
			}
			
			
			public void cancelAsc(vipapis.marketplace.asc.CancelAscRequest request_) {
				
				send_cancelAsc(request_);
				recv_cancelAsc();
				
			}
			
			
			private void send_cancelAsc(vipapis.marketplace.asc.CancelAscRequest request_){
				
				InitInvocation("cancelAsc");
				
				cancelAsc_args args = new cancelAsc_args();
				args.SetRequest(request_);
				
				SendBase(args, cancelAsc_argsHelper.getInstance());
			}
			
			
			private void recv_cancelAsc(){
				
				cancelAsc_result result = new cancelAsc_result();
				ReceiveBase(result, cancelAsc_resultHelper.getInstance());
				
				
			}
			
			
			public void confirmRefund(vipapis.marketplace.asc.RejectApplyRefundRequest request_) {
				
				send_confirmRefund(request_);
				recv_confirmRefund();
				
			}
			
			
			private void send_confirmRefund(vipapis.marketplace.asc.RejectApplyRefundRequest request_){
				
				InitInvocation("confirmRefund");
				
				confirmRefund_args args = new confirmRefund_args();
				args.SetRequest(request_);
				
				SendBase(args, confirmRefund_argsHelper.getInstance());
			}
			
			
			private void recv_confirmRefund(){
				
				confirmRefund_result result = new confirmRefund_result();
				ReceiveBase(result, confirmRefund_resultHelper.getInstance());
				
				
			}
			
			
			public vipapis.marketplace.asc.GetAscInfoResponse getAscInfo(vipapis.marketplace.asc.GetAscInfoRequest request_) {
				
				send_getAscInfo(request_);
				return recv_getAscInfo(); 
				
			}
			
			
			private void send_getAscInfo(vipapis.marketplace.asc.GetAscInfoRequest request_){
				
				InitInvocation("getAscInfo");
				
				getAscInfo_args args = new getAscInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, getAscInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.asc.GetAscInfoResponse recv_getAscInfo(){
				
				getAscInfo_result result = new getAscInfo_result();
				ReceiveBase(result, getAscInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.marketplace.asc.GetAscsResponse getAscs(vipapis.marketplace.asc.GetAscsRequest request_) {
				
				send_getAscs(request_);
				return recv_getAscs(); 
				
			}
			
			
			private void send_getAscs(vipapis.marketplace.asc.GetAscsRequest request_){
				
				InitInvocation("getAscs");
				
				getAscs_args args = new getAscs_args();
				args.SetRequest(request_);
				
				SendBase(args, getAscs_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.asc.GetAscsResponse recv_getAscs(){
				
				getAscs_result result = new getAscs_result();
				ReceiveBase(result, getAscs_resultHelper.getInstance());
				
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
			
			
			public void refuseRefund(vipapis.marketplace.asc.RefuseRefundRequest request_) {
				
				send_refuseRefund(request_);
				recv_refuseRefund();
				
			}
			
			
			private void send_refuseRefund(vipapis.marketplace.asc.RefuseRefundRequest request_){
				
				InitInvocation("refuseRefund");
				
				refuseRefund_args args = new refuseRefund_args();
				args.SetRequest(request_);
				
				SendBase(args, refuseRefund_argsHelper.getInstance());
			}
			
			
			private void recv_refuseRefund(){
				
				refuseRefund_result result = new refuseRefund_result();
				ReceiveBase(result, refuseRefund_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}