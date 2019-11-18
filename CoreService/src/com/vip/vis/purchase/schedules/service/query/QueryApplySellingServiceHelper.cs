using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	public class QueryApplySellingServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryApplySellingData_args {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam queryApplySellingParam_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam GetQueryApplySellingParam(){
				return this.queryApplySellingParam_;
			}
			
			public void SetQueryApplySellingParam(com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam value){
				this.queryApplySellingParam_ = value;
			}
			
		}
		
		
		
		
		public class queryScheduleInfoData_args {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam queryScheduleInfoApiParam_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam GetQueryScheduleInfoApiParam(){
				return this.queryScheduleInfoApiParam_;
			}
			
			public void SetQueryScheduleInfoApiParam(com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam value){
				this.queryScheduleInfoApiParam_ = value;
			}
			
		}
		
		
		
		
		public class querySchedulesByShopCode_args {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam queryScheduleByShopCodeParam_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam GetQueryScheduleByShopCodeParam(){
				return this.queryScheduleByShopCodeParam_;
			}
			
			public void SetQueryScheduleByShopCodeParam(com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam value){
				this.queryScheduleByShopCodeParam_ = value;
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
		
		
		
		
		public class queryApplySellingData_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse success_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryScheduleInfoData_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse success_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class querySchedulesByShopCode_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse success_;
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse value){
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
		
		
		
		
		public class queryApplySellingData_argsHelper : TBeanSerializer<queryApplySellingData_args>
		{
			
			public static queryApplySellingData_argsHelper OBJ = new queryApplySellingData_argsHelper();
			
			public static queryApplySellingData_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryApplySellingData_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam();
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryApplySellingParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryApplySellingData_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryApplySellingParam() != null) {
					
					oprot.WriteFieldBegin("queryApplySellingParam");
					
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingParamHelper.getInstance().Write(structs.GetQueryApplySellingParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryApplySellingParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryApplySellingData_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryScheduleInfoData_argsHelper : TBeanSerializer<queryScheduleInfoData_args>
		{
			
			public static queryScheduleInfoData_argsHelper OBJ = new queryScheduleInfoData_argsHelper();
			
			public static queryScheduleInfoData_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryScheduleInfoData_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam();
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryScheduleInfoApiParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryScheduleInfoData_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryScheduleInfoApiParam() != null) {
					
					oprot.WriteFieldBegin("queryScheduleInfoApiParam");
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParamHelper.getInstance().Write(structs.GetQueryScheduleInfoApiParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryScheduleInfoApiParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryScheduleInfoData_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class querySchedulesByShopCode_argsHelper : TBeanSerializer<querySchedulesByShopCode_args>
		{
			
			public static querySchedulesByShopCode_argsHelper OBJ = new querySchedulesByShopCode_argsHelper();
			
			public static querySchedulesByShopCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(querySchedulesByShopCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam();
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryScheduleByShopCodeParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(querySchedulesByShopCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryScheduleByShopCodeParam() != null) {
					
					oprot.WriteFieldBegin("queryScheduleByShopCodeParam");
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParamHelper.getInstance().Write(structs.GetQueryScheduleByShopCodeParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryScheduleByShopCodeParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(querySchedulesByShopCode_args bean){
				
				
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
		
		
		
		
		public class queryApplySellingData_resultHelper : TBeanSerializer<queryApplySellingData_result>
		{
			
			public static queryApplySellingData_resultHelper OBJ = new queryApplySellingData_resultHelper();
			
			public static queryApplySellingData_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryApplySellingData_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse();
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryApplySellingData_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryApplySellingData_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryScheduleInfoData_resultHelper : TBeanSerializer<queryScheduleInfoData_result>
		{
			
			public static queryScheduleInfoData_resultHelper OBJ = new queryScheduleInfoData_resultHelper();
			
			public static queryScheduleInfoData_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryScheduleInfoData_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse();
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryScheduleInfoData_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryScheduleInfoData_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class querySchedulesByShopCode_resultHelper : TBeanSerializer<querySchedulesByShopCode_result>
		{
			
			public static querySchedulesByShopCode_resultHelper OBJ = new querySchedulesByShopCode_resultHelper();
			
			public static querySchedulesByShopCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(querySchedulesByShopCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse value;
					
					value = new com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse();
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(querySchedulesByShopCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(querySchedulesByShopCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class QueryApplySellingServiceClient : OspRestStub , QueryApplySellingService  {
			
			
			public QueryApplySellingServiceClient():base("com.vip.vis.purchase.schedules.service.query.QueryApplySellingService","1.0.0") {
				
				
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
			
			
			public com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse queryApplySellingData(com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam queryApplySellingParam_) {
				
				send_queryApplySellingData(queryApplySellingParam_);
				return recv_queryApplySellingData(); 
				
			}
			
			
			private void send_queryApplySellingData(com.vip.vis.purchase.schedules.service.query.QueryApplySellingParam queryApplySellingParam_){
				
				InitInvocation("queryApplySellingData");
				
				queryApplySellingData_args args = new queryApplySellingData_args();
				args.SetQueryApplySellingParam(queryApplySellingParam_);
				
				SendBase(args, queryApplySellingData_argsHelper.getInstance());
			}
			
			
			private com.vip.vis.purchase.schedules.service.query.QueryApplySellingResponse recv_queryApplySellingData(){
				
				queryApplySellingData_result result = new queryApplySellingData_result();
				ReceiveBase(result, queryApplySellingData_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse queryScheduleInfoData(com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam queryScheduleInfoApiParam_) {
				
				send_queryScheduleInfoData(queryScheduleInfoApiParam_);
				return recv_queryScheduleInfoData(); 
				
			}
			
			
			private void send_queryScheduleInfoData(com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoApiParam queryScheduleInfoApiParam_){
				
				InitInvocation("queryScheduleInfoData");
				
				queryScheduleInfoData_args args = new queryScheduleInfoData_args();
				args.SetQueryScheduleInfoApiParam(queryScheduleInfoApiParam_);
				
				SendBase(args, queryScheduleInfoData_argsHelper.getInstance());
			}
			
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleInfoResponse recv_queryScheduleInfoData(){
				
				queryScheduleInfoData_result result = new queryScheduleInfoData_result();
				ReceiveBase(result, queryScheduleInfoData_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse querySchedulesByShopCode(com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam queryScheduleByShopCodeParam_) {
				
				send_querySchedulesByShopCode(queryScheduleByShopCodeParam_);
				return recv_querySchedulesByShopCode(); 
				
			}
			
			
			private void send_querySchedulesByShopCode(com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeParam queryScheduleByShopCodeParam_){
				
				InitInvocation("querySchedulesByShopCode");
				
				querySchedulesByShopCode_args args = new querySchedulesByShopCode_args();
				args.SetQueryScheduleByShopCodeParam(queryScheduleByShopCodeParam_);
				
				SendBase(args, querySchedulesByShopCode_argsHelper.getInstance());
			}
			
			
			private com.vip.vis.purchase.schedules.service.query.QueryScheduleByShopCodeResponse recv_querySchedulesByShopCode(){
				
				querySchedulesByShopCode_result result = new querySchedulesByShopCode_result();
				ReceiveBase(result, querySchedulesByShopCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}