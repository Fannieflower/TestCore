using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.marketplace.store{
	
	
	public class StoreInfoServiceHelper {
		
		
		
		public class getStoreInfo_args {
			
			
		}
		
		
		
		
		public class getWarehouse_args {
			
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getStoreInfo_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.store.GetStoreInfoResponse success_;
			
			public vipapis.marketplace.store.GetStoreInfoResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.store.GetStoreInfoResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getWarehouse_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.store.GetWarehouseResponse success_;
			
			public vipapis.marketplace.store.GetWarehouseResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.store.GetWarehouseResponse value){
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
		
		
		
		
		
		public class getStoreInfo_argsHelper : TBeanSerializer<getStoreInfo_args>
		{
			
			public static getStoreInfo_argsHelper OBJ = new getStoreInfo_argsHelper();
			
			public static getStoreInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getStoreInfo_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getStoreInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getStoreInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouse_argsHelper : TBeanSerializer<getWarehouse_args>
		{
			
			public static getWarehouse_argsHelper OBJ = new getWarehouse_argsHelper();
			
			public static getWarehouse_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouse_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWarehouse_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouse_args bean){
				
				
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
		
		
		
		
		public class getStoreInfo_resultHelper : TBeanSerializer<getStoreInfo_result>
		{
			
			public static getStoreInfo_resultHelper OBJ = new getStoreInfo_resultHelper();
			
			public static getStoreInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getStoreInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.store.GetStoreInfoResponse value;
					
					value = new vipapis.marketplace.store.GetStoreInfoResponse();
					vipapis.marketplace.store.GetStoreInfoResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getStoreInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.store.GetStoreInfoResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getStoreInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouse_resultHelper : TBeanSerializer<getWarehouse_result>
		{
			
			public static getWarehouse_resultHelper OBJ = new getWarehouse_resultHelper();
			
			public static getWarehouse_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouse_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.store.GetWarehouseResponse value;
					
					value = new vipapis.marketplace.store.GetWarehouseResponse();
					vipapis.marketplace.store.GetWarehouseResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWarehouse_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.store.GetWarehouseResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouse_result bean){
				
				
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
		
		
		
		
		public class StoreInfoServiceClient : OspRestStub , StoreInfoService  {
			
			
			public StoreInfoServiceClient():base("vipapis.marketplace.store.StoreInfoService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.marketplace.store.GetStoreInfoResponse getStoreInfo() {
				
				send_getStoreInfo();
				return recv_getStoreInfo(); 
				
			}
			
			
			private void send_getStoreInfo(){
				
				InitInvocation("getStoreInfo");
				
				getStoreInfo_args args = new getStoreInfo_args();
				
				SendBase(args, getStoreInfo_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.store.GetStoreInfoResponse recv_getStoreInfo(){
				
				getStoreInfo_result result = new getStoreInfo_result();
				ReceiveBase(result, getStoreInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.marketplace.store.GetWarehouseResponse getWarehouse() {
				
				send_getWarehouse();
				return recv_getWarehouse(); 
				
			}
			
			
			private void send_getWarehouse(){
				
				InitInvocation("getWarehouse");
				
				getWarehouse_args args = new getWarehouse_args();
				
				SendBase(args, getWarehouse_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.store.GetWarehouseResponse recv_getWarehouse(){
				
				getWarehouse_result result = new getWarehouse_result();
				ReceiveBase(result, getWarehouse_resultHelper.getInstance());
				
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