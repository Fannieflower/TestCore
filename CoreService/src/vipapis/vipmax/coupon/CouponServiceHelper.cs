using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.vipmax.coupon{
	
	
	public class CouponServiceHelper {
		
		
		
		public class checkCouponInfo_args {
			
			///<summary>
			/// 优惠券有效性查询入参
			///</summary>
			
			private vipapis.vipmax.coupon.CheckCouponInfoRequest request_;
			
			public vipapis.vipmax.coupon.CheckCouponInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.coupon.CheckCouponInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class returnCoupon_args {
			
			///<summary>
			/// 取消订单退券入参
			///</summary>
			
			private vipapis.vipmax.coupon.ReturnCouponRequest request_;
			
			public vipapis.vipmax.coupon.ReturnCouponRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.coupon.ReturnCouponRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class rollbackUseCoupon_args {
			
			///<summary>
			/// 异常订单退券入参
			///</summary>
			
			private vipapis.vipmax.coupon.RollbackCouponRequest request_;
			
			public vipapis.vipmax.coupon.RollbackCouponRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.coupon.RollbackCouponRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class submitCouponInfo_args {
			
			///<summary>
			/// 优惠券核销入参
			///</summary>
			
			private vipapis.vipmax.coupon.SubmitCouponInfoRequest request_;
			
			public vipapis.vipmax.coupon.SubmitCouponInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.vipmax.coupon.SubmitCouponInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class checkCouponInfo_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.coupon.CheckCouponInfoResponse success_;
			
			public vipapis.vipmax.coupon.CheckCouponInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.coupon.CheckCouponInfoResponse value){
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
		
		
		
		
		public class returnCoupon_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.coupon.ReturnCouponResponse success_;
			
			public vipapis.vipmax.coupon.ReturnCouponResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.coupon.ReturnCouponResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class rollbackUseCoupon_result {
			
			
		}
		
		
		
		
		public class submitCouponInfo_result {
			
			///<summary>
			///</summary>
			
			private vipapis.vipmax.coupon.SubmitCouponInfoResponse success_;
			
			public vipapis.vipmax.coupon.SubmitCouponInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.vipmax.coupon.SubmitCouponInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class checkCouponInfo_argsHelper : TBeanSerializer<checkCouponInfo_args>
		{
			
			public static checkCouponInfo_argsHelper OBJ = new checkCouponInfo_argsHelper();
			
			public static checkCouponInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkCouponInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.CheckCouponInfoRequest value;
					
					value = new vipapis.vipmax.coupon.CheckCouponInfoRequest();
					vipapis.vipmax.coupon.CheckCouponInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkCouponInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.coupon.CheckCouponInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkCouponInfo_args bean){
				
				
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
		
		
		
		
		public class returnCoupon_argsHelper : TBeanSerializer<returnCoupon_args>
		{
			
			public static returnCoupon_argsHelper OBJ = new returnCoupon_argsHelper();
			
			public static returnCoupon_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(returnCoupon_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.ReturnCouponRequest value;
					
					value = new vipapis.vipmax.coupon.ReturnCouponRequest();
					vipapis.vipmax.coupon.ReturnCouponRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(returnCoupon_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.coupon.ReturnCouponRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(returnCoupon_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class rollbackUseCoupon_argsHelper : TBeanSerializer<rollbackUseCoupon_args>
		{
			
			public static rollbackUseCoupon_argsHelper OBJ = new rollbackUseCoupon_argsHelper();
			
			public static rollbackUseCoupon_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(rollbackUseCoupon_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.RollbackCouponRequest value;
					
					value = new vipapis.vipmax.coupon.RollbackCouponRequest();
					vipapis.vipmax.coupon.RollbackCouponRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(rollbackUseCoupon_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.coupon.RollbackCouponRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(rollbackUseCoupon_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitCouponInfo_argsHelper : TBeanSerializer<submitCouponInfo_args>
		{
			
			public static submitCouponInfo_argsHelper OBJ = new submitCouponInfo_argsHelper();
			
			public static submitCouponInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitCouponInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.SubmitCouponInfoRequest value;
					
					value = new vipapis.vipmax.coupon.SubmitCouponInfoRequest();
					vipapis.vipmax.coupon.SubmitCouponInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitCouponInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.vipmax.coupon.SubmitCouponInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitCouponInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkCouponInfo_resultHelper : TBeanSerializer<checkCouponInfo_result>
		{
			
			public static checkCouponInfo_resultHelper OBJ = new checkCouponInfo_resultHelper();
			
			public static checkCouponInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkCouponInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.CheckCouponInfoResponse value;
					
					value = new vipapis.vipmax.coupon.CheckCouponInfoResponse();
					vipapis.vipmax.coupon.CheckCouponInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkCouponInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.coupon.CheckCouponInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkCouponInfo_result bean){
				
				
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
		
		
		
		
		public class returnCoupon_resultHelper : TBeanSerializer<returnCoupon_result>
		{
			
			public static returnCoupon_resultHelper OBJ = new returnCoupon_resultHelper();
			
			public static returnCoupon_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(returnCoupon_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.ReturnCouponResponse value;
					
					value = new vipapis.vipmax.coupon.ReturnCouponResponse();
					vipapis.vipmax.coupon.ReturnCouponResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(returnCoupon_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.coupon.ReturnCouponResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(returnCoupon_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class rollbackUseCoupon_resultHelper : TBeanSerializer<rollbackUseCoupon_result>
		{
			
			public static rollbackUseCoupon_resultHelper OBJ = new rollbackUseCoupon_resultHelper();
			
			public static rollbackUseCoupon_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(rollbackUseCoupon_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(rollbackUseCoupon_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(rollbackUseCoupon_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitCouponInfo_resultHelper : TBeanSerializer<submitCouponInfo_result>
		{
			
			public static submitCouponInfo_resultHelper OBJ = new submitCouponInfo_resultHelper();
			
			public static submitCouponInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitCouponInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.vipmax.coupon.SubmitCouponInfoResponse value;
					
					value = new vipapis.vipmax.coupon.SubmitCouponInfoResponse();
					vipapis.vipmax.coupon.SubmitCouponInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitCouponInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.vipmax.coupon.SubmitCouponInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitCouponInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class CouponServiceClient : OspRestStub , CouponService  {
			
			
			public CouponServiceClient():base("vipapis.vipmax.coupon.CouponService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.vipmax.coupon.CheckCouponInfoResponse checkCouponInfo(vipapis.vipmax.coupon.CheckCouponInfoRequest request_) {
				
				send_checkCouponInfo(request_);
				return recv_checkCouponInfo(); 
				
			}
			
			
			private void send_checkCouponInfo(vipapis.vipmax.coupon.CheckCouponInfoRequest request_){
				
				InitInvocation("checkCouponInfo");
				
				checkCouponInfo_args args = new checkCouponInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, checkCouponInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.coupon.CheckCouponInfoResponse recv_checkCouponInfo(){
				
				checkCouponInfo_result result = new checkCouponInfo_result();
				ReceiveBase(result, checkCouponInfo_resultHelper.getInstance());
				
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
			
			
			public vipapis.vipmax.coupon.ReturnCouponResponse returnCoupon(vipapis.vipmax.coupon.ReturnCouponRequest request_) {
				
				send_returnCoupon(request_);
				return recv_returnCoupon(); 
				
			}
			
			
			private void send_returnCoupon(vipapis.vipmax.coupon.ReturnCouponRequest request_){
				
				InitInvocation("returnCoupon");
				
				returnCoupon_args args = new returnCoupon_args();
				args.SetRequest(request_);
				
				SendBase(args, returnCoupon_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.coupon.ReturnCouponResponse recv_returnCoupon(){
				
				returnCoupon_result result = new returnCoupon_result();
				ReceiveBase(result, returnCoupon_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void rollbackUseCoupon(vipapis.vipmax.coupon.RollbackCouponRequest request_) {
				
				send_rollbackUseCoupon(request_);
				recv_rollbackUseCoupon();
				
			}
			
			
			private void send_rollbackUseCoupon(vipapis.vipmax.coupon.RollbackCouponRequest request_){
				
				InitInvocation("rollbackUseCoupon");
				
				rollbackUseCoupon_args args = new rollbackUseCoupon_args();
				args.SetRequest(request_);
				
				SendBase(args, rollbackUseCoupon_argsHelper.getInstance());
			}
			
			
			private void recv_rollbackUseCoupon(){
				
				rollbackUseCoupon_result result = new rollbackUseCoupon_result();
				ReceiveBase(result, rollbackUseCoupon_resultHelper.getInstance());
				
				
			}
			
			
			public vipapis.vipmax.coupon.SubmitCouponInfoResponse submitCouponInfo(vipapis.vipmax.coupon.SubmitCouponInfoRequest request_) {
				
				send_submitCouponInfo(request_);
				return recv_submitCouponInfo(); 
				
			}
			
			
			private void send_submitCouponInfo(vipapis.vipmax.coupon.SubmitCouponInfoRequest request_){
				
				InitInvocation("submitCouponInfo");
				
				submitCouponInfo_args args = new submitCouponInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, submitCouponInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.vipmax.coupon.SubmitCouponInfoResponse recv_submitCouponInfo(){
				
				submitCouponInfo_result result = new submitCouponInfo_result();
				ReceiveBase(result, submitCouponInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}