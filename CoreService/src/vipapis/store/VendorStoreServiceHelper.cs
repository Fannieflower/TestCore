using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.store{
	
	
	public class VendorStoreServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryAreaWarehouseStores_args {
			
			///<summary>
			/// 分区仓库门店请求参数
			///</summary>
			
			private vipapis.store.WarehouseStoreRequest warehouseStoreRequest_;
			
			public vipapis.store.WarehouseStoreRequest GetWarehouseStoreRequest(){
				return this.warehouseStoreRequest_;
			}
			
			public void SetWarehouseStoreRequest(vipapis.store.WarehouseStoreRequest value){
				this.warehouseStoreRequest_ = value;
			}
			
		}
		
		
		
		
		public class queryStores_args {
			
			///<summary>
			/// 门店信息查询参数
			///</summary>
			
			private vipapis.store.StoreQueryRequest storeQueryRequest_;
			
			public vipapis.store.StoreQueryRequest GetStoreQueryRequest(){
				return this.storeQueryRequest_;
			}
			
			public void SetStoreQueryRequest(vipapis.store.StoreQueryRequest value){
				this.storeQueryRequest_ = value;
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
		
		
		
		
		public class queryAreaWarehouseStores_result {
			
			///<summary>
			///</summary>
			
			private vipapis.store.WarehouseStoreResponse success_;
			
			public vipapis.store.WarehouseStoreResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.store.WarehouseStoreResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryStores_result {
			
			///<summary>
			///</summary>
			
			private vipapis.store.StoreQueryResponse success_;
			
			public vipapis.store.StoreQueryResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.store.StoreQueryResponse value){
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
		
		
		
		
		public class queryAreaWarehouseStores_argsHelper : TBeanSerializer<queryAreaWarehouseStores_args>
		{
			
			public static queryAreaWarehouseStores_argsHelper OBJ = new queryAreaWarehouseStores_argsHelper();
			
			public static queryAreaWarehouseStores_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryAreaWarehouseStores_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.store.WarehouseStoreRequest value;
					
					value = new vipapis.store.WarehouseStoreRequest();
					vipapis.store.WarehouseStoreRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetWarehouseStoreRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryAreaWarehouseStores_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWarehouseStoreRequest() != null) {
					
					oprot.WriteFieldBegin("warehouseStoreRequest");
					
					vipapis.store.WarehouseStoreRequestHelper.getInstance().Write(structs.GetWarehouseStoreRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("warehouseStoreRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryAreaWarehouseStores_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryStores_argsHelper : TBeanSerializer<queryStores_args>
		{
			
			public static queryStores_argsHelper OBJ = new queryStores_argsHelper();
			
			public static queryStores_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryStores_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.store.StoreQueryRequest value;
					
					value = new vipapis.store.StoreQueryRequest();
					vipapis.store.StoreQueryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetStoreQueryRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryStores_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStoreQueryRequest() != null) {
					
					oprot.WriteFieldBegin("storeQueryRequest");
					
					vipapis.store.StoreQueryRequestHelper.getInstance().Write(structs.GetStoreQueryRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storeQueryRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryStores_args bean){
				
				
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
		
		
		
		
		public class queryAreaWarehouseStores_resultHelper : TBeanSerializer<queryAreaWarehouseStores_result>
		{
			
			public static queryAreaWarehouseStores_resultHelper OBJ = new queryAreaWarehouseStores_resultHelper();
			
			public static queryAreaWarehouseStores_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryAreaWarehouseStores_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.store.WarehouseStoreResponse value;
					
					value = new vipapis.store.WarehouseStoreResponse();
					vipapis.store.WarehouseStoreResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryAreaWarehouseStores_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.store.WarehouseStoreResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryAreaWarehouseStores_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryStores_resultHelper : TBeanSerializer<queryStores_result>
		{
			
			public static queryStores_resultHelper OBJ = new queryStores_resultHelper();
			
			public static queryStores_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryStores_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.store.StoreQueryResponse value;
					
					value = new vipapis.store.StoreQueryResponse();
					vipapis.store.StoreQueryResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryStores_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.store.StoreQueryResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryStores_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class VendorStoreServiceClient : OspRestStub , VendorStoreService  {
			
			
			public VendorStoreServiceClient():base("vipapis.store.VendorStoreService","1.0.0") {
				
				
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
			
			
			public vipapis.store.WarehouseStoreResponse queryAreaWarehouseStores(vipapis.store.WarehouseStoreRequest warehouseStoreRequest_) {
				
				send_queryAreaWarehouseStores(warehouseStoreRequest_);
				return recv_queryAreaWarehouseStores(); 
				
			}
			
			
			private void send_queryAreaWarehouseStores(vipapis.store.WarehouseStoreRequest warehouseStoreRequest_){
				
				InitInvocation("queryAreaWarehouseStores");
				
				queryAreaWarehouseStores_args args = new queryAreaWarehouseStores_args();
				args.SetWarehouseStoreRequest(warehouseStoreRequest_);
				
				SendBase(args, queryAreaWarehouseStores_argsHelper.getInstance());
			}
			
			
			private vipapis.store.WarehouseStoreResponse recv_queryAreaWarehouseStores(){
				
				queryAreaWarehouseStores_result result = new queryAreaWarehouseStores_result();
				ReceiveBase(result, queryAreaWarehouseStores_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.store.StoreQueryResponse queryStores(vipapis.store.StoreQueryRequest storeQueryRequest_) {
				
				send_queryStores(storeQueryRequest_);
				return recv_queryStores(); 
				
			}
			
			
			private void send_queryStores(vipapis.store.StoreQueryRequest storeQueryRequest_){
				
				InitInvocation("queryStores");
				
				queryStores_args args = new queryStores_args();
				args.SetStoreQueryRequest(storeQueryRequest_);
				
				SendBase(args, queryStores_argsHelper.getInstance());
			}
			
			
			private vipapis.store.StoreQueryResponse recv_queryStores(){
				
				queryStores_result result = new queryStores_result();
				ReceiveBase(result, queryStores_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}