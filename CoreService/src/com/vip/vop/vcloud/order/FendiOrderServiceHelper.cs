using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.order{
	
	
	public class FendiOrderServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class pushCancelledOrderToFendi_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class pushNewOrderToFendi_args {
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			
		}
		
		
		
		
		public class pushShippedOrderToFendi_args {
			
			///<summary>
			/// 合作伙伴ID
			///</summary>
			
			private long? partnerId_;
			
			///<summary>
			/// 渠道ID
			///</summary>
			
			private long? channelId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
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
		
		
		
		
		public class pushCancelledOrderToFendi_result {
			
			
		}
		
		
		
		
		public class pushNewOrderToFendi_result {
			
			
		}
		
		
		
		
		public class pushShippedOrderToFendi_result {
			
			
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
		
		
		
		
		public class pushCancelledOrderToFendi_argsHelper : TBeanSerializer<pushCancelledOrderToFendi_args>
		{
			
			public static pushCancelledOrderToFendi_argsHelper OBJ = new pushCancelledOrderToFendi_argsHelper();
			
			public static pushCancelledOrderToFendi_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushCancelledOrderToFendi_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushCancelledOrderToFendi_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushCancelledOrderToFendi_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushNewOrderToFendi_argsHelper : TBeanSerializer<pushNewOrderToFendi_args>
		{
			
			public static pushNewOrderToFendi_argsHelper OBJ = new pushNewOrderToFendi_argsHelper();
			
			public static pushNewOrderToFendi_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushNewOrderToFendi_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushNewOrderToFendi_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushNewOrderToFendi_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushShippedOrderToFendi_argsHelper : TBeanSerializer<pushShippedOrderToFendi_args>
		{
			
			public static pushShippedOrderToFendi_argsHelper OBJ = new pushShippedOrderToFendi_argsHelper();
			
			public static pushShippedOrderToFendi_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushShippedOrderToFendi_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushShippedOrderToFendi_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushShippedOrderToFendi_args bean){
				
				
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
		
		
		
		
		public class pushCancelledOrderToFendi_resultHelper : TBeanSerializer<pushCancelledOrderToFendi_result>
		{
			
			public static pushCancelledOrderToFendi_resultHelper OBJ = new pushCancelledOrderToFendi_resultHelper();
			
			public static pushCancelledOrderToFendi_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushCancelledOrderToFendi_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushCancelledOrderToFendi_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushCancelledOrderToFendi_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushNewOrderToFendi_resultHelper : TBeanSerializer<pushNewOrderToFendi_result>
		{
			
			public static pushNewOrderToFendi_resultHelper OBJ = new pushNewOrderToFendi_resultHelper();
			
			public static pushNewOrderToFendi_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushNewOrderToFendi_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushNewOrderToFendi_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushNewOrderToFendi_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushShippedOrderToFendi_resultHelper : TBeanSerializer<pushShippedOrderToFendi_result>
		{
			
			public static pushShippedOrderToFendi_resultHelper OBJ = new pushShippedOrderToFendi_resultHelper();
			
			public static pushShippedOrderToFendi_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushShippedOrderToFendi_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushShippedOrderToFendi_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushShippedOrderToFendi_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class FendiOrderServiceClient : OspRestStub , FendiOrderService  {
			
			
			public FendiOrderServiceClient():base("com.vip.vop.vcloud.order.FendiOrderService","1.0.0") {
				
				
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
			
			
			public void pushCancelledOrderToFendi(long? partnerId_,long? channelId_) {
				
				send_pushCancelledOrderToFendi(partnerId_,channelId_);
				recv_pushCancelledOrderToFendi();
				
			}
			
			
			private void send_pushCancelledOrderToFendi(long? partnerId_,long? channelId_){
				
				InitInvocation("pushCancelledOrderToFendi");
				
				pushCancelledOrderToFendi_args args = new pushCancelledOrderToFendi_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				
				SendBase(args, pushCancelledOrderToFendi_argsHelper.getInstance());
			}
			
			
			private void recv_pushCancelledOrderToFendi(){
				
				pushCancelledOrderToFendi_result result = new pushCancelledOrderToFendi_result();
				ReceiveBase(result, pushCancelledOrderToFendi_resultHelper.getInstance());
				
				
			}
			
			
			public void pushNewOrderToFendi(long? channelId_,long? partnerId_) {
				
				send_pushNewOrderToFendi(channelId_,partnerId_);
				recv_pushNewOrderToFendi();
				
			}
			
			
			private void send_pushNewOrderToFendi(long? channelId_,long? partnerId_){
				
				InitInvocation("pushNewOrderToFendi");
				
				pushNewOrderToFendi_args args = new pushNewOrderToFendi_args();
				args.SetChannelId(channelId_);
				args.SetPartnerId(partnerId_);
				
				SendBase(args, pushNewOrderToFendi_argsHelper.getInstance());
			}
			
			
			private void recv_pushNewOrderToFendi(){
				
				pushNewOrderToFendi_result result = new pushNewOrderToFendi_result();
				ReceiveBase(result, pushNewOrderToFendi_resultHelper.getInstance());
				
				
			}
			
			
			public void pushShippedOrderToFendi(long? partnerId_,long? channelId_) {
				
				send_pushShippedOrderToFendi(partnerId_,channelId_);
				recv_pushShippedOrderToFendi();
				
			}
			
			
			private void send_pushShippedOrderToFendi(long? partnerId_,long? channelId_){
				
				InitInvocation("pushShippedOrderToFendi");
				
				pushShippedOrderToFendi_args args = new pushShippedOrderToFendi_args();
				args.SetPartnerId(partnerId_);
				args.SetChannelId(channelId_);
				
				SendBase(args, pushShippedOrderToFendi_argsHelper.getInstance());
			}
			
			
			private void recv_pushShippedOrderToFendi(){
				
				pushShippedOrderToFendi_result result = new pushShippedOrderToFendi_result();
				ReceiveBase(result, pushShippedOrderToFendi_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}