using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.activity{
	
	
	public class ActivityServiceHelper {
		
		
		
		public class checkIn_args {
			
			///<summary>
			/// 活动id
			///</summary>
			
			private string activityId_;
			
			///<summary>
			/// 登记手机号码
			///</summary>
			
			private string mobile_;
			
			public string GetActivityId(){
				return this.activityId_;
			}
			
			public void SetActivityId(string value){
				this.activityId_ = value;
			}
			public string GetMobile(){
				return this.mobile_;
			}
			
			public void SetMobile(string value){
				this.mobile_ = value;
			}
			
		}
		
		
		
		
		public class checkInV2_args {
			
			///<summary>
			/// 活动id
			///</summary>
			
			private string activityId_;
			
			///<summary>
			/// 登记手机号码
			///</summary>
			
			private string mobile_;
			
			public string GetActivityId(){
				return this.activityId_;
			}
			
			public void SetActivityId(string value){
				this.activityId_ = value;
			}
			public string GetMobile(){
				return this.mobile_;
			}
			
			public void SetMobile(string value){
				this.mobile_ = value;
			}
			
		}
		
		
		
		
		public class checkInV3_args {
			
			///<summary>
			/// 活动id
			///</summary>
			
			private string activityId_;
			
			///<summary>
			/// 登记手机号码(加密)
			///</summary>
			
			private string mobile_;
			
			public string GetActivityId(){
				return this.activityId_;
			}
			
			public void SetActivityId(string value){
				this.activityId_ = value;
			}
			public string GetMobile(){
				return this.mobile_;
			}
			
			public void SetMobile(string value){
				this.mobile_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class checkIn_result {
			
			///<summary>
			/// 登记手机领券返回结果
			///</summary>
			
			private List<vipapis.activity.Coupon> success_;
			
			public List<vipapis.activity.Coupon> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.activity.Coupon> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class checkInV2_result {
			
			///<summary>
			/// 登记手机领券返回结果
			///</summary>
			
			private vipapis.activity.CheckInResult success_;
			
			public vipapis.activity.CheckInResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.activity.CheckInResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class checkInV3_result {
			
			///<summary>
			/// 登记手机领券返回结果
			///</summary>
			
			private vipapis.activity.CheckInResult success_;
			
			public vipapis.activity.CheckInResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.activity.CheckInResult value){
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
		
		
		
		
		
		public class checkIn_argsHelper : TBeanSerializer<checkIn_args>
		{
			
			public static checkIn_argsHelper OBJ = new checkIn_argsHelper();
			
			public static checkIn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkIn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetActivityId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetMobile(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkIn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityId() != null) {
					
					oprot.WriteFieldBegin("activityId");
					oprot.WriteString(structs.GetActivityId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityId can not be null!");
				}
				
				
				if(structs.GetMobile() != null) {
					
					oprot.WriteFieldBegin("mobile");
					oprot.WriteString(structs.GetMobile());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mobile can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkIn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkInV2_argsHelper : TBeanSerializer<checkInV2_args>
		{
			
			public static checkInV2_argsHelper OBJ = new checkInV2_argsHelper();
			
			public static checkInV2_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkInV2_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetActivityId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetMobile(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkInV2_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityId() != null) {
					
					oprot.WriteFieldBegin("activityId");
					oprot.WriteString(structs.GetActivityId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityId can not be null!");
				}
				
				
				if(structs.GetMobile() != null) {
					
					oprot.WriteFieldBegin("mobile");
					oprot.WriteString(structs.GetMobile());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mobile can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkInV2_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkInV3_argsHelper : TBeanSerializer<checkInV3_args>
		{
			
			public static checkInV3_argsHelper OBJ = new checkInV3_argsHelper();
			
			public static checkInV3_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkInV3_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetActivityId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetMobile(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkInV3_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityId() != null) {
					
					oprot.WriteFieldBegin("activityId");
					oprot.WriteString(structs.GetActivityId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityId can not be null!");
				}
				
				
				if(structs.GetMobile() != null) {
					
					oprot.WriteFieldBegin("mobile");
					oprot.WriteString(structs.GetMobile());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mobile can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkInV3_args bean){
				
				
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
		
		
		
		
		public class checkIn_resultHelper : TBeanSerializer<checkIn_result>
		{
			
			public static checkIn_resultHelper OBJ = new checkIn_resultHelper();
			
			public static checkIn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkIn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.activity.Coupon> value;
					
					value = new List<vipapis.activity.Coupon>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.activity.Coupon elem0;
							
							elem0 = new vipapis.activity.Coupon();
							vipapis.activity.CouponHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkIn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.activity.Coupon _item0 in structs.GetSuccess()){
						
						
						vipapis.activity.CouponHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkIn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkInV2_resultHelper : TBeanSerializer<checkInV2_result>
		{
			
			public static checkInV2_resultHelper OBJ = new checkInV2_resultHelper();
			
			public static checkInV2_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkInV2_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.activity.CheckInResult value;
					
					value = new vipapis.activity.CheckInResult();
					vipapis.activity.CheckInResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkInV2_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.activity.CheckInResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkInV2_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkInV3_resultHelper : TBeanSerializer<checkInV3_result>
		{
			
			public static checkInV3_resultHelper OBJ = new checkInV3_resultHelper();
			
			public static checkInV3_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkInV3_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.activity.CheckInResult value;
					
					value = new vipapis.activity.CheckInResult();
					vipapis.activity.CheckInResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkInV3_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.activity.CheckInResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkInV3_result bean){
				
				
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
		
		
		
		
		public class ActivityServiceClient : OspRestStub , ActivityService  {
			
			
			public ActivityServiceClient():base("vipapis.activity.ActivityService","1.0.0") {
				
				
			}
			
			
			
			public List<vipapis.activity.Coupon> checkIn(string activityId_,string mobile_) {
				
				send_checkIn(activityId_,mobile_);
				return recv_checkIn(); 
				
			}
			
			
			private void send_checkIn(string activityId_,string mobile_){
				
				InitInvocation("checkIn");
				
				checkIn_args args = new checkIn_args();
				args.SetActivityId(activityId_);
				args.SetMobile(mobile_);
				
				SendBase(args, checkIn_argsHelper.getInstance());
			}
			
			
			private List<vipapis.activity.Coupon> recv_checkIn(){
				
				checkIn_result result = new checkIn_result();
				ReceiveBase(result, checkIn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.activity.CheckInResult checkInV2(string activityId_,string mobile_) {
				
				send_checkInV2(activityId_,mobile_);
				return recv_checkInV2(); 
				
			}
			
			
			private void send_checkInV2(string activityId_,string mobile_){
				
				InitInvocation("checkInV2");
				
				checkInV2_args args = new checkInV2_args();
				args.SetActivityId(activityId_);
				args.SetMobile(mobile_);
				
				SendBase(args, checkInV2_argsHelper.getInstance());
			}
			
			
			private vipapis.activity.CheckInResult recv_checkInV2(){
				
				checkInV2_result result = new checkInV2_result();
				ReceiveBase(result, checkInV2_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.activity.CheckInResult checkInV3(string activityId_,string mobile_) {
				
				send_checkInV3(activityId_,mobile_);
				return recv_checkInV3(); 
				
			}
			
			
			private void send_checkInV3(string activityId_,string mobile_){
				
				InitInvocation("checkInV3");
				
				checkInV3_args args = new checkInV3_args();
				args.SetActivityId(activityId_);
				args.SetMobile(mobile_);
				
				SendBase(args, checkInV3_argsHelper.getInstance());
			}
			
			
			private vipapis.activity.CheckInResult recv_checkInV3(){
				
				checkInV3_result result = new checkInV3_result();
				ReceiveBase(result, checkInV3_resultHelper.getInstance());
				
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