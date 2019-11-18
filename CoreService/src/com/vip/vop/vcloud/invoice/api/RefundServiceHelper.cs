using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	public class RefundServiceHelper {
		
		
		
		public class dealRefund_args {
			
			///<summary>
			/// 退款信息
			///</summary>
			
			private com.vip.vop.vcloud.invoice.api.Refund refund_;
			
			public com.vip.vop.vcloud.invoice.api.Refund GetRefund(){
				return this.refund_;
			}
			
			public void SetRefund(com.vip.vop.vcloud.invoice.api.Refund value){
				this.refund_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class matchReturnApplication_args {
			
			///<summary>
			/// 查询请求
			///</summary>
			
			private com.vip.vop.vcloud.invoice.api.QueryRefundReq req_;
			
			public com.vip.vop.vcloud.invoice.api.QueryRefundReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.invoice.api.QueryRefundReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class pullRefundFromVdg_args {
			
			///<summary>
			/// 开始时间(格式:yyyy-MM-dd HH:mm:ss)
			/// @sampleValue lastUpdateTime 2018-01-01 00:00:00
			///</summary>
			
			private System.DateTime? lastUpdateTime_;
			
			public System.DateTime? GetLastUpdateTime(){
				return this.lastUpdateTime_;
			}
			
			public void SetLastUpdateTime(System.DateTime? value){
				this.lastUpdateTime_ = value;
			}
			
		}
		
		
		
		
		public class queryRefunds_args {
			
			///<summary>
			/// 查询请求
			///</summary>
			
			private com.vip.vop.vcloud.invoice.api.QueryRefundReq req_;
			
			public com.vip.vop.vcloud.invoice.api.QueryRefundReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.vop.vcloud.invoice.api.QueryRefundReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class receiveRefund_args {
			
			///<summary>
			/// 退款信息
			///</summary>
			
			private com.vip.vop.vcloud.invoice.api.Refund refund_;
			
			public com.vip.vop.vcloud.invoice.api.Refund GetRefund(){
				return this.refund_;
			}
			
			public void SetRefund(com.vip.vop.vcloud.invoice.api.Refund value){
				this.refund_ = value;
			}
			
		}
		
		
		
		
		public class updateDealType_args {
			
			///<summary>
			/// id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class dealRefund_result {
			
			
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
		
		
		
		
		public class matchReturnApplication_result {
			
			///<summary>
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class pullRefundFromVdg_result {
			
			
		}
		
		
		
		
		public class queryRefunds_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.vcloud.invoice.api.QueryRefundRes success_;
			
			public com.vip.vop.vcloud.invoice.api.QueryRefundRes GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.vcloud.invoice.api.QueryRefundRes value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class receiveRefund_result {
			
			
		}
		
		
		
		
		public class updateDealType_result {
			
			
		}
		
		
		
		
		
		public class dealRefund_argsHelper : TBeanSerializer<dealRefund_args>
		{
			
			public static dealRefund_argsHelper OBJ = new dealRefund_argsHelper();
			
			public static dealRefund_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(dealRefund_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.invoice.api.Refund value;
					
					value = new com.vip.vop.vcloud.invoice.api.Refund();
					com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Read(value, iprot);
					
					structs.SetRefund(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(dealRefund_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRefund() != null) {
					
					oprot.WriteFieldBegin("refund");
					
					com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Write(structs.GetRefund(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(dealRefund_args bean){
				
				
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
		
		
		
		
		public class matchReturnApplication_argsHelper : TBeanSerializer<matchReturnApplication_args>
		{
			
			public static matchReturnApplication_argsHelper OBJ = new matchReturnApplication_argsHelper();
			
			public static matchReturnApplication_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchReturnApplication_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.invoice.api.QueryRefundReq value;
					
					value = new com.vip.vop.vcloud.invoice.api.QueryRefundReq();
					com.vip.vop.vcloud.invoice.api.QueryRefundReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchReturnApplication_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.invoice.api.QueryRefundReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchReturnApplication_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pullRefundFromVdg_argsHelper : TBeanSerializer<pullRefundFromVdg_args>
		{
			
			public static pullRefundFromVdg_argsHelper OBJ = new pullRefundFromVdg_argsHelper();
			
			public static pullRefundFromVdg_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullRefundFromVdg_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetLastUpdateTime(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pullRefundFromVdg_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetLastUpdateTime() != null) {
					
					oprot.WriteFieldBegin("lastUpdateTime");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetLastUpdateTime())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullRefundFromVdg_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryRefunds_argsHelper : TBeanSerializer<queryRefunds_args>
		{
			
			public static queryRefunds_argsHelper OBJ = new queryRefunds_argsHelper();
			
			public static queryRefunds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryRefunds_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.invoice.api.QueryRefundReq value;
					
					value = new com.vip.vop.vcloud.invoice.api.QueryRefundReq();
					com.vip.vop.vcloud.invoice.api.QueryRefundReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryRefunds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.vop.vcloud.invoice.api.QueryRefundReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryRefunds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveRefund_argsHelper : TBeanSerializer<receiveRefund_args>
		{
			
			public static receiveRefund_argsHelper OBJ = new receiveRefund_argsHelper();
			
			public static receiveRefund_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveRefund_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.invoice.api.Refund value;
					
					value = new com.vip.vop.vcloud.invoice.api.Refund();
					com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Read(value, iprot);
					
					structs.SetRefund(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveRefund_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRefund() != null) {
					
					oprot.WriteFieldBegin("refund");
					
					com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Write(structs.GetRefund(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveRefund_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateDealType_argsHelper : TBeanSerializer<updateDealType_args>
		{
			
			public static updateDealType_argsHelper OBJ = new updateDealType_argsHelper();
			
			public static updateDealType_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateDealType_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateDealType_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateDealType_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class dealRefund_resultHelper : TBeanSerializer<dealRefund_result>
		{
			
			public static dealRefund_resultHelper OBJ = new dealRefund_resultHelper();
			
			public static dealRefund_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(dealRefund_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(dealRefund_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(dealRefund_result bean){
				
				
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
		
		
		
		
		public class matchReturnApplication_resultHelper : TBeanSerializer<matchReturnApplication_result>
		{
			
			public static matchReturnApplication_resultHelper OBJ = new matchReturnApplication_resultHelper();
			
			public static matchReturnApplication_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(matchReturnApplication_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(matchReturnApplication_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(matchReturnApplication_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pullRefundFromVdg_resultHelper : TBeanSerializer<pullRefundFromVdg_result>
		{
			
			public static pullRefundFromVdg_resultHelper OBJ = new pullRefundFromVdg_resultHelper();
			
			public static pullRefundFromVdg_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullRefundFromVdg_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pullRefundFromVdg_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullRefundFromVdg_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryRefunds_resultHelper : TBeanSerializer<queryRefunds_result>
		{
			
			public static queryRefunds_resultHelper OBJ = new queryRefunds_resultHelper();
			
			public static queryRefunds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryRefunds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.invoice.api.QueryRefundRes value;
					
					value = new com.vip.vop.vcloud.invoice.api.QueryRefundRes();
					com.vip.vop.vcloud.invoice.api.QueryRefundResHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryRefunds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.vcloud.invoice.api.QueryRefundResHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryRefunds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiveRefund_resultHelper : TBeanSerializer<receiveRefund_result>
		{
			
			public static receiveRefund_resultHelper OBJ = new receiveRefund_resultHelper();
			
			public static receiveRefund_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiveRefund_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiveRefund_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiveRefund_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateDealType_resultHelper : TBeanSerializer<updateDealType_result>
		{
			
			public static updateDealType_resultHelper OBJ = new updateDealType_resultHelper();
			
			public static updateDealType_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateDealType_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateDealType_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateDealType_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class RefundServiceClient : OspRestStub , RefundService  {
			
			
			public RefundServiceClient():base("com.vip.vop.vcloud.invoice.api.RefundService","1.0.0") {
				
				
			}
			
			
			
			public void dealRefund(com.vip.vop.vcloud.invoice.api.Refund refund_) {
				
				send_dealRefund(refund_);
				recv_dealRefund();
				
			}
			
			
			private void send_dealRefund(com.vip.vop.vcloud.invoice.api.Refund refund_){
				
				InitInvocation("dealRefund");
				
				dealRefund_args args = new dealRefund_args();
				args.SetRefund(refund_);
				
				SendBase(args, dealRefund_argsHelper.getInstance());
			}
			
			
			private void recv_dealRefund(){
				
				dealRefund_result result = new dealRefund_result();
				ReceiveBase(result, dealRefund_resultHelper.getInstance());
				
				
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
			
			
			public long? matchReturnApplication(com.vip.vop.vcloud.invoice.api.QueryRefundReq req_) {
				
				send_matchReturnApplication(req_);
				return recv_matchReturnApplication(); 
				
			}
			
			
			private void send_matchReturnApplication(com.vip.vop.vcloud.invoice.api.QueryRefundReq req_){
				
				InitInvocation("matchReturnApplication");
				
				matchReturnApplication_args args = new matchReturnApplication_args();
				args.SetReq(req_);
				
				SendBase(args, matchReturnApplication_argsHelper.getInstance());
			}
			
			
			private long? recv_matchReturnApplication(){
				
				matchReturnApplication_result result = new matchReturnApplication_result();
				ReceiveBase(result, matchReturnApplication_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void pullRefundFromVdg(System.DateTime? lastUpdateTime_) {
				
				send_pullRefundFromVdg(lastUpdateTime_);
				recv_pullRefundFromVdg();
				
			}
			
			
			private void send_pullRefundFromVdg(System.DateTime? lastUpdateTime_){
				
				InitInvocation("pullRefundFromVdg");
				
				pullRefundFromVdg_args args = new pullRefundFromVdg_args();
				args.SetLastUpdateTime(lastUpdateTime_);
				
				SendBase(args, pullRefundFromVdg_argsHelper.getInstance());
			}
			
			
			private void recv_pullRefundFromVdg(){
				
				pullRefundFromVdg_result result = new pullRefundFromVdg_result();
				ReceiveBase(result, pullRefundFromVdg_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.vop.vcloud.invoice.api.QueryRefundRes queryRefunds(com.vip.vop.vcloud.invoice.api.QueryRefundReq req_) {
				
				send_queryRefunds(req_);
				return recv_queryRefunds(); 
				
			}
			
			
			private void send_queryRefunds(com.vip.vop.vcloud.invoice.api.QueryRefundReq req_){
				
				InitInvocation("queryRefunds");
				
				queryRefunds_args args = new queryRefunds_args();
				args.SetReq(req_);
				
				SendBase(args, queryRefunds_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.vcloud.invoice.api.QueryRefundRes recv_queryRefunds(){
				
				queryRefunds_result result = new queryRefunds_result();
				ReceiveBase(result, queryRefunds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void receiveRefund(com.vip.vop.vcloud.invoice.api.Refund refund_) {
				
				send_receiveRefund(refund_);
				recv_receiveRefund();
				
			}
			
			
			private void send_receiveRefund(com.vip.vop.vcloud.invoice.api.Refund refund_){
				
				InitInvocation("receiveRefund");
				
				receiveRefund_args args = new receiveRefund_args();
				args.SetRefund(refund_);
				
				SendBase(args, receiveRefund_argsHelper.getInstance());
			}
			
			
			private void recv_receiveRefund(){
				
				receiveRefund_result result = new receiveRefund_result();
				ReceiveBase(result, receiveRefund_resultHelper.getInstance());
				
				
			}
			
			
			public void updateDealType(long id_) {
				
				send_updateDealType(id_);
				recv_updateDealType();
				
			}
			
			
			private void send_updateDealType(long id_){
				
				InitInvocation("updateDealType");
				
				updateDealType_args args = new updateDealType_args();
				args.SetId(id_);
				
				SendBase(args, updateDealType_argsHelper.getInstance());
			}
			
			
			private void recv_updateDealType(){
				
				updateDealType_result result = new updateDealType_result();
				ReceiveBase(result, updateDealType_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}