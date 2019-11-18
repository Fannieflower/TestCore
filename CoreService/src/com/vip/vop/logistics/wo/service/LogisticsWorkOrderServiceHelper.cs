using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.logistics.wo.service{
	
	
	public class LogisticsWorkOrderServiceHelper {
		
		
		
		public class createWorkOrder_args {
			
			///<summary>
			/// 创建工单请求
			///</summary>
			
			private com.vip.vop.logistics.wo.CreateWorkOrderReq createWorkOrderReq_;
			
			public com.vip.vop.logistics.wo.CreateWorkOrderReq GetCreateWorkOrderReq(){
				return this.createWorkOrderReq_;
			}
			
			public void SetCreateWorkOrderReq(com.vip.vop.logistics.wo.CreateWorkOrderReq value){
				this.createWorkOrderReq_ = value;
			}
			
		}
		
		
		
		
		public class getWorkOrders_args {
			
			///<summary>
			/// 工单查询请求
			///</summary>
			
			private com.vip.vop.logistics.wo.WorkOrderQueryReq workOrderQueryReq_;
			
			public com.vip.vop.logistics.wo.WorkOrderQueryReq GetWorkOrderQueryReq(){
				return this.workOrderQueryReq_;
			}
			
			public void SetWorkOrderQueryReq(com.vip.vop.logistics.wo.WorkOrderQueryReq value){
				this.workOrderQueryReq_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class replyProcessResult_args {
			
			///<summary>
			/// 工单处理结果
			///</summary>
			
			private com.vip.vop.logistics.wo.WorkOrderProcessResult processResult_;
			
			public com.vip.vop.logistics.wo.WorkOrderProcessResult GetProcessResult(){
				return this.processResult_;
			}
			
			public void SetProcessResult(com.vip.vop.logistics.wo.WorkOrderProcessResult value){
				this.processResult_ = value;
			}
			
		}
		
		
		
		
		public class replyRecheckResult_args {
			
			///<summary>
			/// 工单复核结果
			///</summary>
			
			private com.vip.vop.logistics.wo.WorkOrderRecheckResult rechekResult_;
			
			public com.vip.vop.logistics.wo.WorkOrderRecheckResult GetRechekResult(){
				return this.rechekResult_;
			}
			
			public void SetRechekResult(com.vip.vop.logistics.wo.WorkOrderRecheckResult value){
				this.rechekResult_ = value;
			}
			
		}
		
		
		
		
		public class createWorkOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.wo.CreateWorkOrderResp success_;
			
			public com.vip.vop.logistics.wo.CreateWorkOrderResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.wo.CreateWorkOrderResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getWorkOrders_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.wo.WorkOrder> success_;
			
			public List<com.vip.vop.logistics.wo.WorkOrder> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.wo.WorkOrder> value){
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
		
		
		
		
		public class replyProcessResult_result {
			
			
		}
		
		
		
		
		public class replyRecheckResult_result {
			
			
		}
		
		
		
		
		
		public class createWorkOrder_argsHelper : TBeanSerializer<createWorkOrder_args>
		{
			
			public static createWorkOrder_argsHelper OBJ = new createWorkOrder_argsHelper();
			
			public static createWorkOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createWorkOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.wo.CreateWorkOrderReq value;
					
					value = new com.vip.vop.logistics.wo.CreateWorkOrderReq();
					com.vip.vop.logistics.wo.CreateWorkOrderReqHelper.getInstance().Read(value, iprot);
					
					structs.SetCreateWorkOrderReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createWorkOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreateWorkOrderReq() != null) {
					
					oprot.WriteFieldBegin("createWorkOrderReq");
					
					com.vip.vop.logistics.wo.CreateWorkOrderReqHelper.getInstance().Write(structs.GetCreateWorkOrderReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("createWorkOrderReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createWorkOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWorkOrders_argsHelper : TBeanSerializer<getWorkOrders_args>
		{
			
			public static getWorkOrders_argsHelper OBJ = new getWorkOrders_argsHelper();
			
			public static getWorkOrders_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWorkOrders_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.wo.WorkOrderQueryReq value;
					
					value = new com.vip.vop.logistics.wo.WorkOrderQueryReq();
					com.vip.vop.logistics.wo.WorkOrderQueryReqHelper.getInstance().Read(value, iprot);
					
					structs.SetWorkOrderQueryReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWorkOrders_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWorkOrderQueryReq() != null) {
					
					oprot.WriteFieldBegin("workOrderQueryReq");
					
					com.vip.vop.logistics.wo.WorkOrderQueryReqHelper.getInstance().Write(structs.GetWorkOrderQueryReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("workOrderQueryReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWorkOrders_args bean){
				
				
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
		
		
		
		
		public class replyProcessResult_argsHelper : TBeanSerializer<replyProcessResult_args>
		{
			
			public static replyProcessResult_argsHelper OBJ = new replyProcessResult_argsHelper();
			
			public static replyProcessResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(replyProcessResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.wo.WorkOrderProcessResult value;
					
					value = new com.vip.vop.logistics.wo.WorkOrderProcessResult();
					com.vip.vop.logistics.wo.WorkOrderProcessResultHelper.getInstance().Read(value, iprot);
					
					structs.SetProcessResult(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(replyProcessResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProcessResult() != null) {
					
					oprot.WriteFieldBegin("processResult");
					
					com.vip.vop.logistics.wo.WorkOrderProcessResultHelper.getInstance().Write(structs.GetProcessResult(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("processResult can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(replyProcessResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class replyRecheckResult_argsHelper : TBeanSerializer<replyRecheckResult_args>
		{
			
			public static replyRecheckResult_argsHelper OBJ = new replyRecheckResult_argsHelper();
			
			public static replyRecheckResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(replyRecheckResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.wo.WorkOrderRecheckResult value;
					
					value = new com.vip.vop.logistics.wo.WorkOrderRecheckResult();
					com.vip.vop.logistics.wo.WorkOrderRecheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetRechekResult(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(replyRecheckResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRechekResult() != null) {
					
					oprot.WriteFieldBegin("rechekResult");
					
					com.vip.vop.logistics.wo.WorkOrderRecheckResultHelper.getInstance().Write(structs.GetRechekResult(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("rechekResult can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(replyRecheckResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createWorkOrder_resultHelper : TBeanSerializer<createWorkOrder_result>
		{
			
			public static createWorkOrder_resultHelper OBJ = new createWorkOrder_resultHelper();
			
			public static createWorkOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createWorkOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.wo.CreateWorkOrderResp value;
					
					value = new com.vip.vop.logistics.wo.CreateWorkOrderResp();
					com.vip.vop.logistics.wo.CreateWorkOrderRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createWorkOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.wo.CreateWorkOrderRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createWorkOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWorkOrders_resultHelper : TBeanSerializer<getWorkOrders_result>
		{
			
			public static getWorkOrders_resultHelper OBJ = new getWorkOrders_resultHelper();
			
			public static getWorkOrders_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWorkOrders_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.wo.WorkOrder> value;
					
					value = new List<com.vip.vop.logistics.wo.WorkOrder>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.wo.WorkOrder elem0;
							
							elem0 = new com.vip.vop.logistics.wo.WorkOrder();
							com.vip.vop.logistics.wo.WorkOrderHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getWorkOrders_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.wo.WorkOrder _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.wo.WorkOrderHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWorkOrders_result bean){
				
				
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
		
		
		
		
		public class replyProcessResult_resultHelper : TBeanSerializer<replyProcessResult_result>
		{
			
			public static replyProcessResult_resultHelper OBJ = new replyProcessResult_resultHelper();
			
			public static replyProcessResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(replyProcessResult_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(replyProcessResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(replyProcessResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class replyRecheckResult_resultHelper : TBeanSerializer<replyRecheckResult_result>
		{
			
			public static replyRecheckResult_resultHelper OBJ = new replyRecheckResult_resultHelper();
			
			public static replyRecheckResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(replyRecheckResult_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(replyRecheckResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(replyRecheckResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class LogisticsWorkOrderServiceClient : OspRestStub , LogisticsWorkOrderService  {
			
			
			public LogisticsWorkOrderServiceClient():base("com.vip.vop.logistics.wo.service.LogisticsWorkOrderService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.logistics.wo.CreateWorkOrderResp createWorkOrder(com.vip.vop.logistics.wo.CreateWorkOrderReq createWorkOrderReq_) {
				
				send_createWorkOrder(createWorkOrderReq_);
				return recv_createWorkOrder(); 
				
			}
			
			
			private void send_createWorkOrder(com.vip.vop.logistics.wo.CreateWorkOrderReq createWorkOrderReq_){
				
				InitInvocation("createWorkOrder");
				
				createWorkOrder_args args = new createWorkOrder_args();
				args.SetCreateWorkOrderReq(createWorkOrderReq_);
				
				SendBase(args, createWorkOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.wo.CreateWorkOrderResp recv_createWorkOrder(){
				
				createWorkOrder_result result = new createWorkOrder_result();
				ReceiveBase(result, createWorkOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.logistics.wo.WorkOrder> getWorkOrders(com.vip.vop.logistics.wo.WorkOrderQueryReq workOrderQueryReq_) {
				
				send_getWorkOrders(workOrderQueryReq_);
				return recv_getWorkOrders(); 
				
			}
			
			
			private void send_getWorkOrders(com.vip.vop.logistics.wo.WorkOrderQueryReq workOrderQueryReq_){
				
				InitInvocation("getWorkOrders");
				
				getWorkOrders_args args = new getWorkOrders_args();
				args.SetWorkOrderQueryReq(workOrderQueryReq_);
				
				SendBase(args, getWorkOrders_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.wo.WorkOrder> recv_getWorkOrders(){
				
				getWorkOrders_result result = new getWorkOrders_result();
				ReceiveBase(result, getWorkOrders_resultHelper.getInstance());
				
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
			
			
			public void replyProcessResult(com.vip.vop.logistics.wo.WorkOrderProcessResult processResult_) {
				
				send_replyProcessResult(processResult_);
				recv_replyProcessResult();
				
			}
			
			
			private void send_replyProcessResult(com.vip.vop.logistics.wo.WorkOrderProcessResult processResult_){
				
				InitInvocation("replyProcessResult");
				
				replyProcessResult_args args = new replyProcessResult_args();
				args.SetProcessResult(processResult_);
				
				SendBase(args, replyProcessResult_argsHelper.getInstance());
			}
			
			
			private void recv_replyProcessResult(){
				
				replyProcessResult_result result = new replyProcessResult_result();
				ReceiveBase(result, replyProcessResult_resultHelper.getInstance());
				
				
			}
			
			
			public void replyRecheckResult(com.vip.vop.logistics.wo.WorkOrderRecheckResult rechekResult_) {
				
				send_replyRecheckResult(rechekResult_);
				recv_replyRecheckResult();
				
			}
			
			
			private void send_replyRecheckResult(com.vip.vop.logistics.wo.WorkOrderRecheckResult rechekResult_){
				
				InitInvocation("replyRecheckResult");
				
				replyRecheckResult_args args = new replyRecheckResult_args();
				args.SetRechekResult(rechekResult_);
				
				SendBase(args, replyRecheckResult_argsHelper.getInstance());
			}
			
			
			private void recv_replyRecheckResult(){
				
				replyRecheckResult_result result = new replyRecheckResult_result();
				ReceiveBase(result, replyRecheckResult_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}