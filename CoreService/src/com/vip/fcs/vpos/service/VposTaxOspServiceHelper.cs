using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.fcs.vpos.service{
	
	
	public class VposTaxOspServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryOrder_args {
			
			///<summary>
			/// vpos零售单号
			///</summary>
			
			private string vposOrderNum_;
			
			public string GetVposOrderNum(){
				return this.vposOrderNum_;
			}
			
			public void SetVposOrderNum(string value){
				this.vposOrderNum_ = value;
			}
			
		}
		
		
		
		
		public class syncTaxInfo_args {
			
			///<summary>
			/// 开票信息
			///</summary>
			
			private com.vip.fcs.vpos.service.TaxInfo taxInfo_;
			
			public com.vip.fcs.vpos.service.TaxInfo GetTaxInfo(){
				return this.taxInfo_;
			}
			
			public void SetTaxInfo(com.vip.fcs.vpos.service.TaxInfo value){
				this.taxInfo_ = value;
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
		
		
		
		
		public class queryOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vpos.service.TaxOrderRespone success_;
			
			public com.vip.fcs.vpos.service.TaxOrderRespone GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vpos.service.TaxOrderRespone value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncTaxInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vpos.service.TaxInfoRespone success_;
			
			public com.vip.fcs.vpos.service.TaxInfoRespone GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vpos.service.TaxInfoRespone value){
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
		
		
		
		
		public class queryOrder_argsHelper : TBeanSerializer<queryOrder_args>
		{
			
			public static queryOrder_argsHelper OBJ = new queryOrder_argsHelper();
			
			public static queryOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVposOrderNum(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetVposOrderNum() != null) {
					
					oprot.WriteFieldBegin("vposOrderNum");
					oprot.WriteString(structs.GetVposOrderNum());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncTaxInfo_argsHelper : TBeanSerializer<syncTaxInfo_args>
		{
			
			public static syncTaxInfo_argsHelper OBJ = new syncTaxInfo_argsHelper();
			
			public static syncTaxInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncTaxInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vpos.service.TaxInfo value;
					
					value = new com.vip.fcs.vpos.service.TaxInfo();
					com.vip.fcs.vpos.service.TaxInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetTaxInfo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncTaxInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTaxInfo() != null) {
					
					oprot.WriteFieldBegin("taxInfo");
					
					com.vip.fcs.vpos.service.TaxInfoHelper.getInstance().Write(structs.GetTaxInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncTaxInfo_args bean){
				
				
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
		
		
		
		
		public class queryOrder_resultHelper : TBeanSerializer<queryOrder_result>
		{
			
			public static queryOrder_resultHelper OBJ = new queryOrder_resultHelper();
			
			public static queryOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vpos.service.TaxOrderRespone value;
					
					value = new com.vip.fcs.vpos.service.TaxOrderRespone();
					com.vip.fcs.vpos.service.TaxOrderResponeHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vpos.service.TaxOrderResponeHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncTaxInfo_resultHelper : TBeanSerializer<syncTaxInfo_result>
		{
			
			public static syncTaxInfo_resultHelper OBJ = new syncTaxInfo_resultHelper();
			
			public static syncTaxInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncTaxInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vpos.service.TaxInfoRespone value;
					
					value = new com.vip.fcs.vpos.service.TaxInfoRespone();
					com.vip.fcs.vpos.service.TaxInfoResponeHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncTaxInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vpos.service.TaxInfoResponeHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncTaxInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class VposTaxOspServiceClient : OspRestStub , VposTaxOspService  {
			
			
			public VposTaxOspServiceClient():base("com.vip.fcs.vpos.service.VposTaxOspService","1.0.0") {
				
				
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
			
			
			public com.vip.fcs.vpos.service.TaxOrderRespone queryOrder(string vposOrderNum_) {
				
				send_queryOrder(vposOrderNum_);
				return recv_queryOrder(); 
				
			}
			
			
			private void send_queryOrder(string vposOrderNum_){
				
				InitInvocation("queryOrder");
				
				queryOrder_args args = new queryOrder_args();
				args.SetVposOrderNum(vposOrderNum_);
				
				SendBase(args, queryOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vpos.service.TaxOrderRespone recv_queryOrder(){
				
				queryOrder_result result = new queryOrder_result();
				ReceiveBase(result, queryOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.vpos.service.TaxInfoRespone syncTaxInfo(com.vip.fcs.vpos.service.TaxInfo taxInfo_) {
				
				send_syncTaxInfo(taxInfo_);
				return recv_syncTaxInfo(); 
				
			}
			
			
			private void send_syncTaxInfo(com.vip.fcs.vpos.service.TaxInfo taxInfo_){
				
				InitInvocation("syncTaxInfo");
				
				syncTaxInfo_args args = new syncTaxInfo_args();
				args.SetTaxInfo(taxInfo_);
				
				SendBase(args, syncTaxInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vpos.service.TaxInfoRespone recv_syncTaxInfo(){
				
				syncTaxInfo_result result = new syncTaxInfo_result();
				ReceiveBase(result, syncTaxInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}