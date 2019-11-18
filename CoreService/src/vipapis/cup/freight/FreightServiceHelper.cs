using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.freight{
	
	
	public class FreightServiceHelper {
		
		
		
		public class getOrderFreight_args {
			
			///<summary>
			/// 查询订单运费请求信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.freight.GetOrderFreightReq> get_order_freight_req_list_;
			
			public List<com.vip.vop.cup.api.freight.GetOrderFreightReq> GetGet_order_freight_req_list(){
				return this.get_order_freight_req_list_;
			}
			
			public void SetGet_order_freight_req_list(List<com.vip.vop.cup.api.freight.GetOrderFreightReq> value){
				this.get_order_freight_req_list_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getOrderFreight_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.freight.GetOrderFreightResult success_;
			
			public com.vip.vop.cup.api.freight.GetOrderFreightResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.freight.GetOrderFreightResult value){
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
		
		
		
		
		
		public class getOrderFreight_argsHelper : TBeanSerializer<getOrderFreight_args>
		{
			
			public static getOrderFreight_argsHelper OBJ = new getOrderFreight_argsHelper();
			
			public static getOrderFreight_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderFreight_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.freight.GetOrderFreightReq> value;
					
					value = new List<com.vip.vop.cup.api.freight.GetOrderFreightReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.freight.GetOrderFreightReq elem1;
							
							elem1 = new com.vip.vop.cup.api.freight.GetOrderFreightReq();
							com.vip.vop.cup.api.freight.GetOrderFreightReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetGet_order_freight_req_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderFreight_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGet_order_freight_req_list() != null) {
					
					oprot.WriteFieldBegin("get_order_freight_req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.freight.GetOrderFreightReq _item0 in structs.GetGet_order_freight_req_list()){
						
						
						com.vip.vop.cup.api.freight.GetOrderFreightReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("get_order_freight_req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderFreight_args bean){
				
				
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
		
		
		
		
		public class getOrderFreight_resultHelper : TBeanSerializer<getOrderFreight_result>
		{
			
			public static getOrderFreight_resultHelper OBJ = new getOrderFreight_resultHelper();
			
			public static getOrderFreight_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderFreight_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.freight.GetOrderFreightResult value;
					
					value = new com.vip.vop.cup.api.freight.GetOrderFreightResult();
					com.vip.vop.cup.api.freight.GetOrderFreightResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderFreight_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.freight.GetOrderFreightResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderFreight_result bean){
				
				
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
		
		
		
		
		public class FreightServiceClient : OspRestStub , FreightService  {
			
			
			public FreightServiceClient():base("vipapis.cup.freight.FreightService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.cup.api.freight.GetOrderFreightResult getOrderFreight(List<com.vip.vop.cup.api.freight.GetOrderFreightReq> get_order_freight_req_list_) {
				
				send_getOrderFreight(get_order_freight_req_list_);
				return recv_getOrderFreight(); 
				
			}
			
			
			private void send_getOrderFreight(List<com.vip.vop.cup.api.freight.GetOrderFreightReq> get_order_freight_req_list_){
				
				InitInvocation("getOrderFreight");
				
				getOrderFreight_args args = new getOrderFreight_args();
				args.SetGet_order_freight_req_list(get_order_freight_req_list_);
				
				SendBase(args, getOrderFreight_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.freight.GetOrderFreightResult recv_getOrderFreight(){
				
				getOrderFreight_result result = new getOrderFreight_result();
				ReceiveBase(result, getOrderFreight_resultHelper.getInstance());
				
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