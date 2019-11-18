using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.jitx{
	
	
	public class JitXServiceHelper {
		
		
		
		public class createChangeWarehouseWorkflow_args {
			
			///<summary>
			/// 创建改仓请求
			///</summary>
			
			private vipapis.jitx.CreateChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_;
			
			public vipapis.jitx.CreateChangeWarehouseWorkflowReq GetChangeWarehouseWorkflowReq(){
				return this.changeWarehouseWorkflowReq_;
			}
			
			public void SetChangeWarehouseWorkflowReq(vipapis.jitx.CreateChangeWarehouseWorkflowReq value){
				this.changeWarehouseWorkflowReq_ = value;
			}
			
		}
		
		
		
		
		public class feedbackDeliveryResult_args {
			
			///<summary>
			/// 供应商id
			///</summary>
			
			private vipapis.jitx.FeedbackDeliveryResultRequest request_;
			
			public vipapis.jitx.FeedbackDeliveryResultRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.FeedbackDeliveryResultRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getChangeWarehouseWorkflows_args {
			
			///<summary>
			/// 获取改仓工单请求
			///</summary>
			
			private vipapis.jitx.GetChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_;
			
			public vipapis.jitx.GetChangeWarehouseWorkflowReq GetChangeWarehouseWorkflowReq(){
				return this.changeWarehouseWorkflowReq_;
			}
			
			public void SetChangeWarehouseWorkflowReq(vipapis.jitx.GetChangeWarehouseWorkflowReq value){
				this.changeWarehouseWorkflowReq_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrders_args {
			
			///<summary>
			/// 获取待寻仓订单请求
			///</summary>
			
			private vipapis.jitx.GetDeliveryOrdersRequest request_;
			
			public vipapis.jitx.GetDeliveryOrdersRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetDeliveryOrdersRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrdersForBelle_args {
			
			///<summary>
			/// 待寻仓订单请求
			///</summary>
			
			private vipapis.jitx.BelleDeliveryOrderRequest request_;
			
			public vipapis.jitx.BelleDeliveryOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.BelleDeliveryOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrdersForMutiSys_args {
			
			///<summary>
			/// 获多仓寻仓订单请求
			///</summary>
			
			private vipapis.jitx.MutilWarehousingOrderRequest request_;
			
			public vipapis.jitx.MutilWarehousingOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.MutilWarehousingOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getJitXOrdersForMutiSys_args {
			
			///<summary>
			/// 获取订单请求
			///</summary>
			
			private vipapis.jitx.OrderRequest request_;
			
			public vipapis.jitx.OrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.OrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLabel_args {
			
			///<summary>
			/// 获取面单请求
			///</summary>
			
			private vipapis.jitx.GetOrderLabelRequest request_;
			
			public vipapis.jitx.GetOrderLabelRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetOrderLabelRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLabelForBelle_args {
			
			///<summary>
			/// 获取面单请求
			///</summary>
			
			private vipapis.jitx.BelleOrderLabelRequest request_;
			
			public vipapis.jitx.BelleOrderLabelRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.BelleOrderLabelRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOrders_args {
			
			///<summary>
			/// 获取订单请求
			///</summary>
			
			private vipapis.jitx.GetOrdersRequest request_;
			
			public vipapis.jitx.GetOrdersRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetOrdersRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOrdersByOrderSn_args {
			
			///<summary>
			/// 获取订单请求
			///</summary>
			
			private vipapis.jitx.GetOrdersByOrderSnRequest request_;
			
			public vipapis.jitx.GetOrdersByOrderSnRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetOrdersByOrderSnRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOrdersForBelle_args {
			
			///<summary>
			/// 获取订单请求
			///</summary>
			
			private vipapis.jitx.BelleOrderRequest request_;
			
			public vipapis.jitx.BelleOrderRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.BelleOrderRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getPrintTemplate_args {
			
			///<summary>
			/// 获取面单请求
			///</summary>
			
			private vipapis.jitx.GetOrderLabelRequest request_;
			
			public vipapis.jitx.GetOrderLabelRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetOrderLabelRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNos_args {
			
			///<summary>
			/// 获取运单号请求
			///</summary>
			
			private vipapis.jitx.GetTransportNosRequest request_;
			
			public vipapis.jitx.GetTransportNosRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetTransportNosRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getWarehouses_args {
			
			///<summary>
			/// 获取仓库请求
			///</summary>
			
			private vipapis.jitx.GetWarehousesRequest request_;
			
			public vipapis.jitx.GetWarehousesRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.GetWarehousesRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class ship_args {
			
			///<summary>
			/// 发货请求
			///</summary>
			
			private vipapis.jitx.ShipRequest request_;
			
			public vipapis.jitx.ShipRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.jitx.ShipRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class createChangeWarehouseWorkflow_result {
			
			///<summary>
			///</summary>
			
			private vipapis.jitx.CreateWorkflowResp success_;
			
			public vipapis.jitx.CreateWorkflowResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.CreateWorkflowResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class feedbackDeliveryResult_result {
			
			///<summary>
			/// 反馈寻仓结果响应
			///</summary>
			
			private List<vipapis.jitx.FeedbackDeliveryResultResponse> success_;
			
			public List<vipapis.jitx.FeedbackDeliveryResultResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.jitx.FeedbackDeliveryResultResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getChangeWarehouseWorkflows_result {
			
			///<summary>
			///</summary>
			
			private vipapis.jitx.GetChangeWarehouseWorkflowResp success_;
			
			public vipapis.jitx.GetChangeWarehouseWorkflowResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.GetChangeWarehouseWorkflowResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrders_result {
			
			///<summary>
			/// 待寻仓订单列表
			///</summary>
			
			private vipapis.jitx.GetDeliveryOrdersResponse success_;
			
			public vipapis.jitx.GetDeliveryOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.GetDeliveryOrdersResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrdersForBelle_result {
			
			///<summary>
			/// 返回belle待寻仓订单列表
			///</summary>
			
			private vipapis.jitx.BelleDeliveryOrderResponse success_;
			
			public vipapis.jitx.BelleDeliveryOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.BelleDeliveryOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryOrdersForMutiSys_result {
			
			///<summary>
			/// 待寻仓多仓订单列表
			///</summary>
			
			private vipapis.jitx.MutilWarehousingOrderResponse success_;
			
			public vipapis.jitx.MutilWarehousingOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.MutilWarehousingOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getJitXOrdersForMutiSys_result {
			
			///<summary>
			/// 返回订单列表
			///</summary>
			
			private vipapis.jitx.GetOrdersResponse success_;
			
			public vipapis.jitx.GetOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.GetOrdersResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLabel_result {
			
			///<summary>
			/// 返回html面单
			///</summary>
			
			private List<vipapis.jitx.OrderLabel> success_;
			
			public List<vipapis.jitx.OrderLabel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.jitx.OrderLabel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderLabelForBelle_result {
			
			///<summary>
			/// 返回json面单
			///</summary>
			
			private List<vipapis.jitx.OrderLabel> success_;
			
			public List<vipapis.jitx.OrderLabel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.jitx.OrderLabel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrders_result {
			
			///<summary>
			/// 返回订单列表
			///</summary>
			
			private vipapis.jitx.GetOrdersResponse success_;
			
			public vipapis.jitx.GetOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.GetOrdersResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrdersByOrderSn_result {
			
			///<summary>
			/// 返回订单列表
			///</summary>
			
			private vipapis.jitx.GetOrdersResponse success_;
			
			public vipapis.jitx.GetOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.GetOrdersResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrdersForBelle_result {
			
			///<summary>
			/// 返回belle订单列表
			///</summary>
			
			private vipapis.jitx.BelleOrderResponse success_;
			
			public vipapis.jitx.BelleOrderResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.BelleOrderResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPrintTemplate_result {
			
			///<summary>
			/// 返回json面单
			///</summary>
			
			private List<vipapis.jitx.OrderLabel> success_;
			
			public List<vipapis.jitx.OrderLabel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.jitx.OrderLabel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTransportNos_result {
			
			///<summary>
			/// 返回可使用的运单号列表
			///</summary>
			
			private List<string> success_;
			
			public List<string> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<string> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getWarehouses_result {
			
			///<summary>
			/// 可用仓库列表
			///</summary>
			
			private List<vipapis.jitx.WarehouseInfo> success_;
			
			public List<vipapis.jitx.WarehouseInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.jitx.WarehouseInfo> value){
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
		
		
		
		
		public class ship_result {
			
			///<summary>
			/// true表示发货成功，false表示发货失败
			///</summary>
			
			private vipapis.jitx.ShipResponse success_;
			
			public vipapis.jitx.ShipResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.jitx.ShipResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class createChangeWarehouseWorkflow_argsHelper : TBeanSerializer<createChangeWarehouseWorkflow_args>
		{
			
			public static createChangeWarehouseWorkflow_argsHelper OBJ = new createChangeWarehouseWorkflow_argsHelper();
			
			public static createChangeWarehouseWorkflow_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createChangeWarehouseWorkflow_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.CreateChangeWarehouseWorkflowReq value;
					
					value = new vipapis.jitx.CreateChangeWarehouseWorkflowReq();
					vipapis.jitx.CreateChangeWarehouseWorkflowReqHelper.getInstance().Read(value, iprot);
					
					structs.SetChangeWarehouseWorkflowReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createChangeWarehouseWorkflow_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChangeWarehouseWorkflowReq() != null) {
					
					oprot.WriteFieldBegin("changeWarehouseWorkflowReq");
					
					vipapis.jitx.CreateChangeWarehouseWorkflowReqHelper.getInstance().Write(structs.GetChangeWarehouseWorkflowReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createChangeWarehouseWorkflow_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class feedbackDeliveryResult_argsHelper : TBeanSerializer<feedbackDeliveryResult_args>
		{
			
			public static feedbackDeliveryResult_argsHelper OBJ = new feedbackDeliveryResult_argsHelper();
			
			public static feedbackDeliveryResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(feedbackDeliveryResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.FeedbackDeliveryResultRequest value;
					
					value = new vipapis.jitx.FeedbackDeliveryResultRequest();
					vipapis.jitx.FeedbackDeliveryResultRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(feedbackDeliveryResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.FeedbackDeliveryResultRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(feedbackDeliveryResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChangeWarehouseWorkflows_argsHelper : TBeanSerializer<getChangeWarehouseWorkflows_args>
		{
			
			public static getChangeWarehouseWorkflows_argsHelper OBJ = new getChangeWarehouseWorkflows_argsHelper();
			
			public static getChangeWarehouseWorkflows_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChangeWarehouseWorkflows_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetChangeWarehouseWorkflowReq value;
					
					value = new vipapis.jitx.GetChangeWarehouseWorkflowReq();
					vipapis.jitx.GetChangeWarehouseWorkflowReqHelper.getInstance().Read(value, iprot);
					
					structs.SetChangeWarehouseWorkflowReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChangeWarehouseWorkflows_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetChangeWarehouseWorkflowReq() != null) {
					
					oprot.WriteFieldBegin("changeWarehouseWorkflowReq");
					
					vipapis.jitx.GetChangeWarehouseWorkflowReqHelper.getInstance().Write(structs.GetChangeWarehouseWorkflowReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChangeWarehouseWorkflows_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrders_argsHelper : TBeanSerializer<getDeliveryOrders_args>
		{
			
			public static getDeliveryOrders_argsHelper OBJ = new getDeliveryOrders_argsHelper();
			
			public static getDeliveryOrders_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrders_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetDeliveryOrdersRequest value;
					
					value = new vipapis.jitx.GetDeliveryOrdersRequest();
					vipapis.jitx.GetDeliveryOrdersRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrders_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetDeliveryOrdersRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrders_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrdersForBelle_argsHelper : TBeanSerializer<getDeliveryOrdersForBelle_args>
		{
			
			public static getDeliveryOrdersForBelle_argsHelper OBJ = new getDeliveryOrdersForBelle_argsHelper();
			
			public static getDeliveryOrdersForBelle_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrdersForBelle_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.BelleDeliveryOrderRequest value;
					
					value = new vipapis.jitx.BelleDeliveryOrderRequest();
					vipapis.jitx.BelleDeliveryOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrdersForBelle_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.BelleDeliveryOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrdersForBelle_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrdersForMutiSys_argsHelper : TBeanSerializer<getDeliveryOrdersForMutiSys_args>
		{
			
			public static getDeliveryOrdersForMutiSys_argsHelper OBJ = new getDeliveryOrdersForMutiSys_argsHelper();
			
			public static getDeliveryOrdersForMutiSys_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrdersForMutiSys_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.MutilWarehousingOrderRequest value;
					
					value = new vipapis.jitx.MutilWarehousingOrderRequest();
					vipapis.jitx.MutilWarehousingOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrdersForMutiSys_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.MutilWarehousingOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrdersForMutiSys_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getJitXOrdersForMutiSys_argsHelper : TBeanSerializer<getJitXOrdersForMutiSys_args>
		{
			
			public static getJitXOrdersForMutiSys_argsHelper OBJ = new getJitXOrdersForMutiSys_argsHelper();
			
			public static getJitXOrdersForMutiSys_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getJitXOrdersForMutiSys_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.OrderRequest value;
					
					value = new vipapis.jitx.OrderRequest();
					vipapis.jitx.OrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getJitXOrdersForMutiSys_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.OrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getJitXOrdersForMutiSys_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLabel_argsHelper : TBeanSerializer<getOrderLabel_args>
		{
			
			public static getOrderLabel_argsHelper OBJ = new getOrderLabel_argsHelper();
			
			public static getOrderLabel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLabel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrderLabelRequest value;
					
					value = new vipapis.jitx.GetOrderLabelRequest();
					vipapis.jitx.GetOrderLabelRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderLabel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetOrderLabelRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLabel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLabelForBelle_argsHelper : TBeanSerializer<getOrderLabelForBelle_args>
		{
			
			public static getOrderLabelForBelle_argsHelper OBJ = new getOrderLabelForBelle_argsHelper();
			
			public static getOrderLabelForBelle_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLabelForBelle_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.BelleOrderLabelRequest value;
					
					value = new vipapis.jitx.BelleOrderLabelRequest();
					vipapis.jitx.BelleOrderLabelRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderLabelForBelle_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.BelleOrderLabelRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLabelForBelle_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrders_argsHelper : TBeanSerializer<getOrders_args>
		{
			
			public static getOrders_argsHelper OBJ = new getOrders_argsHelper();
			
			public static getOrders_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrders_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrdersRequest value;
					
					value = new vipapis.jitx.GetOrdersRequest();
					vipapis.jitx.GetOrdersRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrders_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetOrdersRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrders_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrdersByOrderSn_argsHelper : TBeanSerializer<getOrdersByOrderSn_args>
		{
			
			public static getOrdersByOrderSn_argsHelper OBJ = new getOrdersByOrderSn_argsHelper();
			
			public static getOrdersByOrderSn_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrdersByOrderSn_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrdersByOrderSnRequest value;
					
					value = new vipapis.jitx.GetOrdersByOrderSnRequest();
					vipapis.jitx.GetOrdersByOrderSnRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrdersByOrderSn_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetOrdersByOrderSnRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrdersByOrderSn_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrdersForBelle_argsHelper : TBeanSerializer<getOrdersForBelle_args>
		{
			
			public static getOrdersForBelle_argsHelper OBJ = new getOrdersForBelle_argsHelper();
			
			public static getOrdersForBelle_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrdersForBelle_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.BelleOrderRequest value;
					
					value = new vipapis.jitx.BelleOrderRequest();
					vipapis.jitx.BelleOrderRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrdersForBelle_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.BelleOrderRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrdersForBelle_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPrintTemplate_argsHelper : TBeanSerializer<getPrintTemplate_args>
		{
			
			public static getPrintTemplate_argsHelper OBJ = new getPrintTemplate_argsHelper();
			
			public static getPrintTemplate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPrintTemplate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrderLabelRequest value;
					
					value = new vipapis.jitx.GetOrderLabelRequest();
					vipapis.jitx.GetOrderLabelRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPrintTemplate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetOrderLabelRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPrintTemplate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNos_argsHelper : TBeanSerializer<getTransportNos_args>
		{
			
			public static getTransportNos_argsHelper OBJ = new getTransportNos_argsHelper();
			
			public static getTransportNos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetTransportNosRequest value;
					
					value = new vipapis.jitx.GetTransportNosRequest();
					vipapis.jitx.GetTransportNosRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTransportNos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetTransportNosRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouses_argsHelper : TBeanSerializer<getWarehouses_args>
		{
			
			public static getWarehouses_argsHelper OBJ = new getWarehouses_argsHelper();
			
			public static getWarehouses_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouses_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetWarehousesRequest value;
					
					value = new vipapis.jitx.GetWarehousesRequest();
					vipapis.jitx.GetWarehousesRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getWarehouses_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.GetWarehousesRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouses_args bean){
				
				
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
		
		
		
		
		public class ship_argsHelper : TBeanSerializer<ship_args>
		{
			
			public static ship_argsHelper OBJ = new ship_argsHelper();
			
			public static ship_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(ship_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.ShipRequest value;
					
					value = new vipapis.jitx.ShipRequest();
					vipapis.jitx.ShipRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(ship_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.jitx.ShipRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(ship_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createChangeWarehouseWorkflow_resultHelper : TBeanSerializer<createChangeWarehouseWorkflow_result>
		{
			
			public static createChangeWarehouseWorkflow_resultHelper OBJ = new createChangeWarehouseWorkflow_resultHelper();
			
			public static createChangeWarehouseWorkflow_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createChangeWarehouseWorkflow_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.CreateWorkflowResp value;
					
					value = new vipapis.jitx.CreateWorkflowResp();
					vipapis.jitx.CreateWorkflowRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createChangeWarehouseWorkflow_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.CreateWorkflowRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createChangeWarehouseWorkflow_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class feedbackDeliveryResult_resultHelper : TBeanSerializer<feedbackDeliveryResult_result>
		{
			
			public static feedbackDeliveryResult_resultHelper OBJ = new feedbackDeliveryResult_resultHelper();
			
			public static feedbackDeliveryResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(feedbackDeliveryResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.jitx.FeedbackDeliveryResultResponse> value;
					
					value = new List<vipapis.jitx.FeedbackDeliveryResultResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.jitx.FeedbackDeliveryResultResponse elem0;
							
							elem0 = new vipapis.jitx.FeedbackDeliveryResultResponse();
							vipapis.jitx.FeedbackDeliveryResultResponseHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(feedbackDeliveryResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.jitx.FeedbackDeliveryResultResponse _item0 in structs.GetSuccess()){
						
						
						vipapis.jitx.FeedbackDeliveryResultResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(feedbackDeliveryResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getChangeWarehouseWorkflows_resultHelper : TBeanSerializer<getChangeWarehouseWorkflows_result>
		{
			
			public static getChangeWarehouseWorkflows_resultHelper OBJ = new getChangeWarehouseWorkflows_resultHelper();
			
			public static getChangeWarehouseWorkflows_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getChangeWarehouseWorkflows_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetChangeWarehouseWorkflowResp value;
					
					value = new vipapis.jitx.GetChangeWarehouseWorkflowResp();
					vipapis.jitx.GetChangeWarehouseWorkflowRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getChangeWarehouseWorkflows_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.GetChangeWarehouseWorkflowRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getChangeWarehouseWorkflows_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrders_resultHelper : TBeanSerializer<getDeliveryOrders_result>
		{
			
			public static getDeliveryOrders_resultHelper OBJ = new getDeliveryOrders_resultHelper();
			
			public static getDeliveryOrders_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrders_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetDeliveryOrdersResponse value;
					
					value = new vipapis.jitx.GetDeliveryOrdersResponse();
					vipapis.jitx.GetDeliveryOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrders_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.GetDeliveryOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrders_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrdersForBelle_resultHelper : TBeanSerializer<getDeliveryOrdersForBelle_result>
		{
			
			public static getDeliveryOrdersForBelle_resultHelper OBJ = new getDeliveryOrdersForBelle_resultHelper();
			
			public static getDeliveryOrdersForBelle_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrdersForBelle_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.BelleDeliveryOrderResponse value;
					
					value = new vipapis.jitx.BelleDeliveryOrderResponse();
					vipapis.jitx.BelleDeliveryOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrdersForBelle_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.BelleDeliveryOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrdersForBelle_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryOrdersForMutiSys_resultHelper : TBeanSerializer<getDeliveryOrdersForMutiSys_result>
		{
			
			public static getDeliveryOrdersForMutiSys_resultHelper OBJ = new getDeliveryOrdersForMutiSys_resultHelper();
			
			public static getDeliveryOrdersForMutiSys_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryOrdersForMutiSys_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.MutilWarehousingOrderResponse value;
					
					value = new vipapis.jitx.MutilWarehousingOrderResponse();
					vipapis.jitx.MutilWarehousingOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryOrdersForMutiSys_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.MutilWarehousingOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryOrdersForMutiSys_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getJitXOrdersForMutiSys_resultHelper : TBeanSerializer<getJitXOrdersForMutiSys_result>
		{
			
			public static getJitXOrdersForMutiSys_resultHelper OBJ = new getJitXOrdersForMutiSys_resultHelper();
			
			public static getJitXOrdersForMutiSys_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getJitXOrdersForMutiSys_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrdersResponse value;
					
					value = new vipapis.jitx.GetOrdersResponse();
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getJitXOrdersForMutiSys_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getJitXOrdersForMutiSys_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLabel_resultHelper : TBeanSerializer<getOrderLabel_result>
		{
			
			public static getOrderLabel_resultHelper OBJ = new getOrderLabel_resultHelper();
			
			public static getOrderLabel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLabel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.jitx.OrderLabel> value;
					
					value = new List<vipapis.jitx.OrderLabel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.jitx.OrderLabel elem0;
							
							elem0 = new vipapis.jitx.OrderLabel();
							vipapis.jitx.OrderLabelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getOrderLabel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.jitx.OrderLabel _item0 in structs.GetSuccess()){
						
						
						vipapis.jitx.OrderLabelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLabel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderLabelForBelle_resultHelper : TBeanSerializer<getOrderLabelForBelle_result>
		{
			
			public static getOrderLabelForBelle_resultHelper OBJ = new getOrderLabelForBelle_resultHelper();
			
			public static getOrderLabelForBelle_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderLabelForBelle_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.jitx.OrderLabel> value;
					
					value = new List<vipapis.jitx.OrderLabel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.jitx.OrderLabel elem1;
							
							elem1 = new vipapis.jitx.OrderLabel();
							vipapis.jitx.OrderLabelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
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
			
			
			public void Write(getOrderLabelForBelle_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.jitx.OrderLabel _item0 in structs.GetSuccess()){
						
						
						vipapis.jitx.OrderLabelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderLabelForBelle_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrders_resultHelper : TBeanSerializer<getOrders_result>
		{
			
			public static getOrders_resultHelper OBJ = new getOrders_resultHelper();
			
			public static getOrders_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrders_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrdersResponse value;
					
					value = new vipapis.jitx.GetOrdersResponse();
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrders_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrders_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrdersByOrderSn_resultHelper : TBeanSerializer<getOrdersByOrderSn_result>
		{
			
			public static getOrdersByOrderSn_resultHelper OBJ = new getOrdersByOrderSn_resultHelper();
			
			public static getOrdersByOrderSn_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrdersByOrderSn_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.GetOrdersResponse value;
					
					value = new vipapis.jitx.GetOrdersResponse();
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrdersByOrderSn_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.GetOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrdersByOrderSn_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrdersForBelle_resultHelper : TBeanSerializer<getOrdersForBelle_result>
		{
			
			public static getOrdersForBelle_resultHelper OBJ = new getOrdersForBelle_resultHelper();
			
			public static getOrdersForBelle_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrdersForBelle_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.BelleOrderResponse value;
					
					value = new vipapis.jitx.BelleOrderResponse();
					vipapis.jitx.BelleOrderResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrdersForBelle_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.BelleOrderResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrdersForBelle_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPrintTemplate_resultHelper : TBeanSerializer<getPrintTemplate_result>
		{
			
			public static getPrintTemplate_resultHelper OBJ = new getPrintTemplate_resultHelper();
			
			public static getPrintTemplate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPrintTemplate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.jitx.OrderLabel> value;
					
					value = new List<vipapis.jitx.OrderLabel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.jitx.OrderLabel elem0;
							
							elem0 = new vipapis.jitx.OrderLabel();
							vipapis.jitx.OrderLabelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getPrintTemplate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.jitx.OrderLabel _item0 in structs.GetSuccess()){
						
						
						vipapis.jitx.OrderLabelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPrintTemplate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTransportNos_resultHelper : TBeanSerializer<getTransportNos_result>
		{
			
			public static getTransportNos_resultHelper OBJ = new getTransportNos_resultHelper();
			
			public static getTransportNos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTransportNos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
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
			
			
			public void Write(getTransportNos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSuccess()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTransportNos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getWarehouses_resultHelper : TBeanSerializer<getWarehouses_result>
		{
			
			public static getWarehouses_resultHelper OBJ = new getWarehouses_resultHelper();
			
			public static getWarehouses_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getWarehouses_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.jitx.WarehouseInfo> value;
					
					value = new List<vipapis.jitx.WarehouseInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.jitx.WarehouseInfo elem1;
							
							elem1 = new vipapis.jitx.WarehouseInfo();
							vipapis.jitx.WarehouseInfoHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
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
			
			
			public void Write(getWarehouses_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.jitx.WarehouseInfo _item0 in structs.GetSuccess()){
						
						
						vipapis.jitx.WarehouseInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getWarehouses_result bean){
				
				
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
		
		
		
		
		public class ship_resultHelper : TBeanSerializer<ship_result>
		{
			
			public static ship_resultHelper OBJ = new ship_resultHelper();
			
			public static ship_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(ship_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.jitx.ShipResponse value;
					
					value = new vipapis.jitx.ShipResponse();
					vipapis.jitx.ShipResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(ship_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.jitx.ShipResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(ship_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class JitXServiceClient : OspRestStub , JitXService  {
			
			
			public JitXServiceClient():base("vipapis.jitx.JitXService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.jitx.CreateWorkflowResp createChangeWarehouseWorkflow(vipapis.jitx.CreateChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_) {
				
				send_createChangeWarehouseWorkflow(changeWarehouseWorkflowReq_);
				return recv_createChangeWarehouseWorkflow(); 
				
			}
			
			
			private void send_createChangeWarehouseWorkflow(vipapis.jitx.CreateChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_){
				
				InitInvocation("createChangeWarehouseWorkflow");
				
				createChangeWarehouseWorkflow_args args = new createChangeWarehouseWorkflow_args();
				args.SetChangeWarehouseWorkflowReq(changeWarehouseWorkflowReq_);
				
				SendBase(args, createChangeWarehouseWorkflow_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.CreateWorkflowResp recv_createChangeWarehouseWorkflow(){
				
				createChangeWarehouseWorkflow_result result = new createChangeWarehouseWorkflow_result();
				ReceiveBase(result, createChangeWarehouseWorkflow_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.jitx.FeedbackDeliveryResultResponse> feedbackDeliveryResult(vipapis.jitx.FeedbackDeliveryResultRequest request_) {
				
				send_feedbackDeliveryResult(request_);
				return recv_feedbackDeliveryResult(); 
				
			}
			
			
			private void send_feedbackDeliveryResult(vipapis.jitx.FeedbackDeliveryResultRequest request_){
				
				InitInvocation("feedbackDeliveryResult");
				
				feedbackDeliveryResult_args args = new feedbackDeliveryResult_args();
				args.SetRequest(request_);
				
				SendBase(args, feedbackDeliveryResult_argsHelper.getInstance());
			}
			
			
			private List<vipapis.jitx.FeedbackDeliveryResultResponse> recv_feedbackDeliveryResult(){
				
				feedbackDeliveryResult_result result = new feedbackDeliveryResult_result();
				ReceiveBase(result, feedbackDeliveryResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.GetChangeWarehouseWorkflowResp getChangeWarehouseWorkflows(vipapis.jitx.GetChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_) {
				
				send_getChangeWarehouseWorkflows(changeWarehouseWorkflowReq_);
				return recv_getChangeWarehouseWorkflows(); 
				
			}
			
			
			private void send_getChangeWarehouseWorkflows(vipapis.jitx.GetChangeWarehouseWorkflowReq changeWarehouseWorkflowReq_){
				
				InitInvocation("getChangeWarehouseWorkflows");
				
				getChangeWarehouseWorkflows_args args = new getChangeWarehouseWorkflows_args();
				args.SetChangeWarehouseWorkflowReq(changeWarehouseWorkflowReq_);
				
				SendBase(args, getChangeWarehouseWorkflows_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.GetChangeWarehouseWorkflowResp recv_getChangeWarehouseWorkflows(){
				
				getChangeWarehouseWorkflows_result result = new getChangeWarehouseWorkflows_result();
				ReceiveBase(result, getChangeWarehouseWorkflows_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.GetDeliveryOrdersResponse getDeliveryOrders(vipapis.jitx.GetDeliveryOrdersRequest request_) {
				
				send_getDeliveryOrders(request_);
				return recv_getDeliveryOrders(); 
				
			}
			
			
			private void send_getDeliveryOrders(vipapis.jitx.GetDeliveryOrdersRequest request_){
				
				InitInvocation("getDeliveryOrders");
				
				getDeliveryOrders_args args = new getDeliveryOrders_args();
				args.SetRequest(request_);
				
				SendBase(args, getDeliveryOrders_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.GetDeliveryOrdersResponse recv_getDeliveryOrders(){
				
				getDeliveryOrders_result result = new getDeliveryOrders_result();
				ReceiveBase(result, getDeliveryOrders_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.BelleDeliveryOrderResponse getDeliveryOrdersForBelle(vipapis.jitx.BelleDeliveryOrderRequest request_) {
				
				send_getDeliveryOrdersForBelle(request_);
				return recv_getDeliveryOrdersForBelle(); 
				
			}
			
			
			private void send_getDeliveryOrdersForBelle(vipapis.jitx.BelleDeliveryOrderRequest request_){
				
				InitInvocation("getDeliveryOrdersForBelle");
				
				getDeliveryOrdersForBelle_args args = new getDeliveryOrdersForBelle_args();
				args.SetRequest(request_);
				
				SendBase(args, getDeliveryOrdersForBelle_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.BelleDeliveryOrderResponse recv_getDeliveryOrdersForBelle(){
				
				getDeliveryOrdersForBelle_result result = new getDeliveryOrdersForBelle_result();
				ReceiveBase(result, getDeliveryOrdersForBelle_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.MutilWarehousingOrderResponse getDeliveryOrdersForMutiSys(vipapis.jitx.MutilWarehousingOrderRequest request_) {
				
				send_getDeliveryOrdersForMutiSys(request_);
				return recv_getDeliveryOrdersForMutiSys(); 
				
			}
			
			
			private void send_getDeliveryOrdersForMutiSys(vipapis.jitx.MutilWarehousingOrderRequest request_){
				
				InitInvocation("getDeliveryOrdersForMutiSys");
				
				getDeliveryOrdersForMutiSys_args args = new getDeliveryOrdersForMutiSys_args();
				args.SetRequest(request_);
				
				SendBase(args, getDeliveryOrdersForMutiSys_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.MutilWarehousingOrderResponse recv_getDeliveryOrdersForMutiSys(){
				
				getDeliveryOrdersForMutiSys_result result = new getDeliveryOrdersForMutiSys_result();
				ReceiveBase(result, getDeliveryOrdersForMutiSys_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.GetOrdersResponse getJitXOrdersForMutiSys(vipapis.jitx.OrderRequest request_) {
				
				send_getJitXOrdersForMutiSys(request_);
				return recv_getJitXOrdersForMutiSys(); 
				
			}
			
			
			private void send_getJitXOrdersForMutiSys(vipapis.jitx.OrderRequest request_){
				
				InitInvocation("getJitXOrdersForMutiSys");
				
				getJitXOrdersForMutiSys_args args = new getJitXOrdersForMutiSys_args();
				args.SetRequest(request_);
				
				SendBase(args, getJitXOrdersForMutiSys_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.GetOrdersResponse recv_getJitXOrdersForMutiSys(){
				
				getJitXOrdersForMutiSys_result result = new getJitXOrdersForMutiSys_result();
				ReceiveBase(result, getJitXOrdersForMutiSys_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.jitx.OrderLabel> getOrderLabel(vipapis.jitx.GetOrderLabelRequest request_) {
				
				send_getOrderLabel(request_);
				return recv_getOrderLabel(); 
				
			}
			
			
			private void send_getOrderLabel(vipapis.jitx.GetOrderLabelRequest request_){
				
				InitInvocation("getOrderLabel");
				
				getOrderLabel_args args = new getOrderLabel_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrderLabel_argsHelper.getInstance());
			}
			
			
			private List<vipapis.jitx.OrderLabel> recv_getOrderLabel(){
				
				getOrderLabel_result result = new getOrderLabel_result();
				ReceiveBase(result, getOrderLabel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.jitx.OrderLabel> getOrderLabelForBelle(vipapis.jitx.BelleOrderLabelRequest request_) {
				
				send_getOrderLabelForBelle(request_);
				return recv_getOrderLabelForBelle(); 
				
			}
			
			
			private void send_getOrderLabelForBelle(vipapis.jitx.BelleOrderLabelRequest request_){
				
				InitInvocation("getOrderLabelForBelle");
				
				getOrderLabelForBelle_args args = new getOrderLabelForBelle_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrderLabelForBelle_argsHelper.getInstance());
			}
			
			
			private List<vipapis.jitx.OrderLabel> recv_getOrderLabelForBelle(){
				
				getOrderLabelForBelle_result result = new getOrderLabelForBelle_result();
				ReceiveBase(result, getOrderLabelForBelle_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.GetOrdersResponse getOrders(vipapis.jitx.GetOrdersRequest request_) {
				
				send_getOrders(request_);
				return recv_getOrders(); 
				
			}
			
			
			private void send_getOrders(vipapis.jitx.GetOrdersRequest request_){
				
				InitInvocation("getOrders");
				
				getOrders_args args = new getOrders_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrders_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.GetOrdersResponse recv_getOrders(){
				
				getOrders_result result = new getOrders_result();
				ReceiveBase(result, getOrders_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.GetOrdersResponse getOrdersByOrderSn(vipapis.jitx.GetOrdersByOrderSnRequest request_) {
				
				send_getOrdersByOrderSn(request_);
				return recv_getOrdersByOrderSn(); 
				
			}
			
			
			private void send_getOrdersByOrderSn(vipapis.jitx.GetOrdersByOrderSnRequest request_){
				
				InitInvocation("getOrdersByOrderSn");
				
				getOrdersByOrderSn_args args = new getOrdersByOrderSn_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrdersByOrderSn_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.GetOrdersResponse recv_getOrdersByOrderSn(){
				
				getOrdersByOrderSn_result result = new getOrdersByOrderSn_result();
				ReceiveBase(result, getOrdersByOrderSn_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.jitx.BelleOrderResponse getOrdersForBelle(vipapis.jitx.BelleOrderRequest request_) {
				
				send_getOrdersForBelle(request_);
				return recv_getOrdersForBelle(); 
				
			}
			
			
			private void send_getOrdersForBelle(vipapis.jitx.BelleOrderRequest request_){
				
				InitInvocation("getOrdersForBelle");
				
				getOrdersForBelle_args args = new getOrdersForBelle_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrdersForBelle_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.BelleOrderResponse recv_getOrdersForBelle(){
				
				getOrdersForBelle_result result = new getOrdersForBelle_result();
				ReceiveBase(result, getOrdersForBelle_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.jitx.OrderLabel> getPrintTemplate(vipapis.jitx.GetOrderLabelRequest request_) {
				
				send_getPrintTemplate(request_);
				return recv_getPrintTemplate(); 
				
			}
			
			
			private void send_getPrintTemplate(vipapis.jitx.GetOrderLabelRequest request_){
				
				InitInvocation("getPrintTemplate");
				
				getPrintTemplate_args args = new getPrintTemplate_args();
				args.SetRequest(request_);
				
				SendBase(args, getPrintTemplate_argsHelper.getInstance());
			}
			
			
			private List<vipapis.jitx.OrderLabel> recv_getPrintTemplate(){
				
				getPrintTemplate_result result = new getPrintTemplate_result();
				ReceiveBase(result, getPrintTemplate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<string> getTransportNos(vipapis.jitx.GetTransportNosRequest request_) {
				
				send_getTransportNos(request_);
				return recv_getTransportNos(); 
				
			}
			
			
			private void send_getTransportNos(vipapis.jitx.GetTransportNosRequest request_){
				
				InitInvocation("getTransportNos");
				
				getTransportNos_args args = new getTransportNos_args();
				args.SetRequest(request_);
				
				SendBase(args, getTransportNos_argsHelper.getInstance());
			}
			
			
			private List<string> recv_getTransportNos(){
				
				getTransportNos_result result = new getTransportNos_result();
				ReceiveBase(result, getTransportNos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.jitx.WarehouseInfo> getWarehouses(vipapis.jitx.GetWarehousesRequest request_) {
				
				send_getWarehouses(request_);
				return recv_getWarehouses(); 
				
			}
			
			
			private void send_getWarehouses(vipapis.jitx.GetWarehousesRequest request_){
				
				InitInvocation("getWarehouses");
				
				getWarehouses_args args = new getWarehouses_args();
				args.SetRequest(request_);
				
				SendBase(args, getWarehouses_argsHelper.getInstance());
			}
			
			
			private List<vipapis.jitx.WarehouseInfo> recv_getWarehouses(){
				
				getWarehouses_result result = new getWarehouses_result();
				ReceiveBase(result, getWarehouses_resultHelper.getInstance());
				
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
			
			
			public vipapis.jitx.ShipResponse ship(vipapis.jitx.ShipRequest request_) {
				
				send_ship(request_);
				return recv_ship(); 
				
			}
			
			
			private void send_ship(vipapis.jitx.ShipRequest request_){
				
				InitInvocation("ship");
				
				ship_args args = new ship_args();
				args.SetRequest(request_);
				
				SendBase(args, ship_argsHelper.getInstance());
			}
			
			
			private vipapis.jitx.ShipResponse recv_ship(){
				
				ship_result result = new ship_result();
				ReceiveBase(result, ship_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}