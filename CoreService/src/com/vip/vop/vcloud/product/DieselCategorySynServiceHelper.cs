using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.product{
	
	
	public class DieselCategorySynServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class processCategoryItem_args {
			
			
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
		
		
		
		
		public class processCategoryItem_result {
			
			
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
		
		
		
		
		public class processCategoryItem_argsHelper : TBeanSerializer<processCategoryItem_args>
		{
			
			public static processCategoryItem_argsHelper OBJ = new processCategoryItem_argsHelper();
			
			public static processCategoryItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processCategoryItem_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processCategoryItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processCategoryItem_args bean){
				
				
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
		
		
		
		
		public class processCategoryItem_resultHelper : TBeanSerializer<processCategoryItem_result>
		{
			
			public static processCategoryItem_resultHelper OBJ = new processCategoryItem_resultHelper();
			
			public static processCategoryItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(processCategoryItem_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(processCategoryItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(processCategoryItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class DieselCategorySynServiceClient : OspRestStub , DieselCategorySynService  {
			
			
			public DieselCategorySynServiceClient():base("com.vip.vop.vcloud.product.DieselCategorySynService","1.0.0") {
				
				
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
			
			
			public void processCategoryItem() {
				
				send_processCategoryItem();
				recv_processCategoryItem();
				
			}
			
			
			private void send_processCategoryItem(){
				
				InitInvocation("processCategoryItem");
				
				processCategoryItem_args args = new processCategoryItem_args();
				
				SendBase(args, processCategoryItem_argsHelper.getInstance());
			}
			
			
			private void recv_processCategoryItem(){
				
				processCategoryItem_result result = new processCategoryItem_result();
				ReceiveBase(result, processCategoryItem_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}