using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.order{
	
	
	public class OrderServiceHelper {
		
		
		
		public class cancelOrder_args {
			
			///<summary>
			/// 取消订单请求信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.order.CancelOrderReq> cancel_order_req_list_;
			
			public List<com.vip.vop.cup.api.order.CancelOrderReq> GetCancel_order_req_list(){
				return this.cancel_order_req_list_;
			}
			
			public void SetCancel_order_req_list(List<com.vip.vop.cup.api.order.CancelOrderReq> value){
				this.cancel_order_req_list_ = value;
			}
			
		}
		
		
		
		
		public class createOrder_args {
			
			///<summary>
			/// 创建订单请求信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.order.CreateOrderReq> create_order_req_list_;
			
			public List<com.vip.vop.cup.api.order.CreateOrderReq> GetCreate_order_req_list(){
				return this.create_order_req_list_;
			}
			
			public void SetCreate_order_req_list(List<com.vip.vop.cup.api.order.CreateOrderReq> value){
				this.create_order_req_list_ = value;
			}
			
		}
		
		
		
		
		public class getOrderStatus_args {
			
			///<summary>
			/// 开始时间，精确到秒（包含），格式：yyyy-MM-dd HH:mm:ss
			///</summary>
			
			private string start_time_;
			
			///<summary>
			/// 结束时间，精确到秒（不包含），格式：yyyy-MM-dd HH:mm:ss
			///</summary>
			
			private string end_time_;
			
			///<summary>
			/// 当前页数, 拉取多页时需填，默认为1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页查询的数量，不填的话使用默认值50
			///</summary>
			
			private int? page_size_;
			
			public string GetStart_time(){
				return this.start_time_;
			}
			
			public void SetStart_time(string value){
				this.start_time_ = value;
			}
			public string GetEnd_time(){
				return this.end_time_;
			}
			
			public void SetEnd_time(string value){
				this.end_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class getOrderTransportInfo_args {
			
			///<summary>
			/// 申请单创建时间范围（包含）.格式：yyyy-MM-dd HH:mm:ss
			///</summary>
			
			private string start_time_;
			
			///<summary>
			/// 申请单修改时间范围（不包含）.格式：yyyy-MM-dd HH:mm:ss
			///</summary>
			
			private string end_time_;
			
			///<summary>
			/// 当前页，有分页时需填写。默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页的数量，不填的话按默认值拉取。默认50
			///</summary>
			
			private int? page_size_;
			
			public string GetStart_time(){
				return this.start_time_;
			}
			
			public void SetStart_time(string value){
				this.start_time_ = value;
			}
			public string GetEnd_time(){
				return this.end_time_;
			}
			
			public void SetEnd_time(string value){
				this.end_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updateCancelOrderRefundResult_args {
			
			///<summary>
			/// 更新取消单退款结果请求信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> update_cancel_order_refund_result_req_list_;
			
			public List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> GetUpdate_cancel_order_refund_result_req_list(){
				return this.update_cancel_order_refund_result_req_list_;
			}
			
			public void SetUpdate_cancel_order_refund_result_req_list(List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> value){
				this.update_cancel_order_refund_result_req_list_ = value;
			}
			
		}
		
		
		
		
		public class updateOrderStatus_args {
			
			///<summary>
			/// 更新订单状态请求信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> update_order_status_req_list_;
			
			public List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> GetUpdate_order_status_req_list(){
				return this.update_order_status_req_list_;
			}
			
			public void SetUpdate_order_status_req_list(List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> value){
				this.update_order_status_req_list_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.OrderOpResult success_;
			
			public com.vip.vop.cup.api.order.OrderOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.OrderOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.OrderOpResult success_;
			
			public com.vip.vop.cup.api.order.OrderOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.OrderOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderStatus_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.GetOrderStatusResult success_;
			
			public com.vip.vop.cup.api.order.GetOrderStatusResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.GetOrderStatusResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderTransportInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.GetOrderTransportInfoResult success_;
			
			public com.vip.vop.cup.api.order.GetOrderTransportInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.GetOrderTransportInfoResult value){
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
		
		
		
		
		public class updateCancelOrderRefundResult_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.OrderOpResult success_;
			
			public com.vip.vop.cup.api.order.OrderOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.OrderOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateOrderStatus_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.order.OrderOpResult success_;
			
			public com.vip.vop.cup.api.order.OrderOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.order.OrderOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class cancelOrder_argsHelper : TBeanSerializer<cancelOrder_args>
		{
			
			public static cancelOrder_argsHelper OBJ = new cancelOrder_argsHelper();
			
			public static cancelOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.order.CancelOrderReq> value;
					
					value = new List<com.vip.vop.cup.api.order.CancelOrderReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.order.CancelOrderReq elem1;
							
							elem1 = new com.vip.vop.cup.api.order.CancelOrderReq();
							com.vip.vop.cup.api.order.CancelOrderReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCancel_order_req_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCancel_order_req_list() != null) {
					
					oprot.WriteFieldBegin("cancel_order_req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.order.CancelOrderReq _item0 in structs.GetCancel_order_req_list()){
						
						
						com.vip.vop.cup.api.order.CancelOrderReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("cancel_order_req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createOrder_argsHelper : TBeanSerializer<createOrder_args>
		{
			
			public static createOrder_argsHelper OBJ = new createOrder_argsHelper();
			
			public static createOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.order.CreateOrderReq> value;
					
					value = new List<com.vip.vop.cup.api.order.CreateOrderReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.order.CreateOrderReq elem1;
							
							elem1 = new com.vip.vop.cup.api.order.CreateOrderReq();
							com.vip.vop.cup.api.order.CreateOrderReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCreate_order_req_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCreate_order_req_list() != null) {
					
					oprot.WriteFieldBegin("create_order_req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.order.CreateOrderReq _item0 in structs.GetCreate_order_req_list()){
						
						
						com.vip.vop.cup.api.order.CreateOrderReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("create_order_req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderStatus_argsHelper : TBeanSerializer<getOrderStatus_args>
		{
			
			public static getOrderStatus_argsHelper OBJ = new getOrderStatus_argsHelper();
			
			public static getOrderStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStart_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEnd_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStart_time() != null) {
					
					oprot.WriteFieldBegin("start_time");
					oprot.WriteString(structs.GetStart_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("start_time can not be null!");
				}
				
				
				if(structs.GetEnd_time() != null) {
					
					oprot.WriteFieldBegin("end_time");
					oprot.WriteString(structs.GetEnd_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("end_time can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderTransportInfo_argsHelper : TBeanSerializer<getOrderTransportInfo_args>
		{
			
			public static getOrderTransportInfo_argsHelper OBJ = new getOrderTransportInfo_argsHelper();
			
			public static getOrderTransportInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderTransportInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStart_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEnd_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderTransportInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStart_time() != null) {
					
					oprot.WriteFieldBegin("start_time");
					oprot.WriteString(structs.GetStart_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("start_time can not be null!");
				}
				
				
				if(structs.GetEnd_time() != null) {
					
					oprot.WriteFieldBegin("end_time");
					oprot.WriteString(structs.GetEnd_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("end_time can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderTransportInfo_args bean){
				
				
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
		
		
		
		
		public class updateCancelOrderRefundResult_argsHelper : TBeanSerializer<updateCancelOrderRefundResult_args>
		{
			
			public static updateCancelOrderRefundResult_argsHelper OBJ = new updateCancelOrderRefundResult_argsHelper();
			
			public static updateCancelOrderRefundResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateCancelOrderRefundResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> value;
					
					value = new List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq elem0;
							
							elem0 = new com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq();
							com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReqHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetUpdate_cancel_order_refund_result_req_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateCancelOrderRefundResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUpdate_cancel_order_refund_result_req_list() != null) {
					
					oprot.WriteFieldBegin("update_cancel_order_refund_result_req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq _item0 in structs.GetUpdate_cancel_order_refund_result_req_list()){
						
						
						com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("update_cancel_order_refund_result_req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateCancelOrderRefundResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateOrderStatus_argsHelper : TBeanSerializer<updateOrderStatus_args>
		{
			
			public static updateOrderStatus_argsHelper OBJ = new updateOrderStatus_argsHelper();
			
			public static updateOrderStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateOrderStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> value;
					
					value = new List<com.vip.vop.cup.api.order.UpdateOrderStatusReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.order.UpdateOrderStatusReq elem1;
							
							elem1 = new com.vip.vop.cup.api.order.UpdateOrderStatusReq();
							com.vip.vop.cup.api.order.UpdateOrderStatusReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetUpdate_order_status_req_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateOrderStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUpdate_order_status_req_list() != null) {
					
					oprot.WriteFieldBegin("update_order_status_req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.order.UpdateOrderStatusReq _item0 in structs.GetUpdate_order_status_req_list()){
						
						
						com.vip.vop.cup.api.order.UpdateOrderStatusReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("update_order_status_req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateOrderStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrder_resultHelper : TBeanSerializer<cancelOrder_result>
		{
			
			public static cancelOrder_resultHelper OBJ = new cancelOrder_resultHelper();
			
			public static cancelOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.OrderOpResult value;
					
					value = new com.vip.vop.cup.api.order.OrderOpResult();
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createOrder_resultHelper : TBeanSerializer<createOrder_result>
		{
			
			public static createOrder_resultHelper OBJ = new createOrder_resultHelper();
			
			public static createOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.OrderOpResult value;
					
					value = new com.vip.vop.cup.api.order.OrderOpResult();
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderStatus_resultHelper : TBeanSerializer<getOrderStatus_result>
		{
			
			public static getOrderStatus_resultHelper OBJ = new getOrderStatus_resultHelper();
			
			public static getOrderStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.GetOrderStatusResult value;
					
					value = new com.vip.vop.cup.api.order.GetOrderStatusResult();
					com.vip.vop.cup.api.order.GetOrderStatusResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.GetOrderStatusResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderTransportInfo_resultHelper : TBeanSerializer<getOrderTransportInfo_result>
		{
			
			public static getOrderTransportInfo_resultHelper OBJ = new getOrderTransportInfo_resultHelper();
			
			public static getOrderTransportInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderTransportInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.GetOrderTransportInfoResult value;
					
					value = new com.vip.vop.cup.api.order.GetOrderTransportInfoResult();
					com.vip.vop.cup.api.order.GetOrderTransportInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderTransportInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.GetOrderTransportInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderTransportInfo_result bean){
				
				
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
		
		
		
		
		public class updateCancelOrderRefundResult_resultHelper : TBeanSerializer<updateCancelOrderRefundResult_result>
		{
			
			public static updateCancelOrderRefundResult_resultHelper OBJ = new updateCancelOrderRefundResult_resultHelper();
			
			public static updateCancelOrderRefundResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateCancelOrderRefundResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.OrderOpResult value;
					
					value = new com.vip.vop.cup.api.order.OrderOpResult();
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateCancelOrderRefundResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateCancelOrderRefundResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateOrderStatus_resultHelper : TBeanSerializer<updateOrderStatus_result>
		{
			
			public static updateOrderStatus_resultHelper OBJ = new updateOrderStatus_resultHelper();
			
			public static updateOrderStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateOrderStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.order.OrderOpResult value;
					
					value = new com.vip.vop.cup.api.order.OrderOpResult();
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateOrderStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.order.OrderOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateOrderStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class OrderServiceClient : OspRestStub , OrderService  {
			
			
			public OrderServiceClient():base("vipapis.cup.order.OrderService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.cup.api.order.OrderOpResult cancelOrder(List<com.vip.vop.cup.api.order.CancelOrderReq> cancel_order_req_list_) {
				
				send_cancelOrder(cancel_order_req_list_);
				return recv_cancelOrder(); 
				
			}
			
			
			private void send_cancelOrder(List<com.vip.vop.cup.api.order.CancelOrderReq> cancel_order_req_list_){
				
				InitInvocation("cancelOrder");
				
				cancelOrder_args args = new cancelOrder_args();
				args.SetCancel_order_req_list(cancel_order_req_list_);
				
				SendBase(args, cancelOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.OrderOpResult recv_cancelOrder(){
				
				cancelOrder_result result = new cancelOrder_result();
				ReceiveBase(result, cancelOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.order.OrderOpResult createOrder(List<com.vip.vop.cup.api.order.CreateOrderReq> create_order_req_list_) {
				
				send_createOrder(create_order_req_list_);
				return recv_createOrder(); 
				
			}
			
			
			private void send_createOrder(List<com.vip.vop.cup.api.order.CreateOrderReq> create_order_req_list_){
				
				InitInvocation("createOrder");
				
				createOrder_args args = new createOrder_args();
				args.SetCreate_order_req_list(create_order_req_list_);
				
				SendBase(args, createOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.OrderOpResult recv_createOrder(){
				
				createOrder_result result = new createOrder_result();
				ReceiveBase(result, createOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.order.GetOrderStatusResult getOrderStatus(string start_time_,string end_time_,int? page_,int? page_size_) {
				
				send_getOrderStatus(start_time_,end_time_,page_,page_size_);
				return recv_getOrderStatus(); 
				
			}
			
			
			private void send_getOrderStatus(string start_time_,string end_time_,int? page_,int? page_size_){
				
				InitInvocation("getOrderStatus");
				
				getOrderStatus_args args = new getOrderStatus_args();
				args.SetStart_time(start_time_);
				args.SetEnd_time(end_time_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, getOrderStatus_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.GetOrderStatusResult recv_getOrderStatus(){
				
				getOrderStatus_result result = new getOrderStatus_result();
				ReceiveBase(result, getOrderStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.order.GetOrderTransportInfoResult getOrderTransportInfo(string start_time_,string end_time_,int? page_,int? page_size_) {
				
				send_getOrderTransportInfo(start_time_,end_time_,page_,page_size_);
				return recv_getOrderTransportInfo(); 
				
			}
			
			
			private void send_getOrderTransportInfo(string start_time_,string end_time_,int? page_,int? page_size_){
				
				InitInvocation("getOrderTransportInfo");
				
				getOrderTransportInfo_args args = new getOrderTransportInfo_args();
				args.SetStart_time(start_time_);
				args.SetEnd_time(end_time_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, getOrderTransportInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.GetOrderTransportInfoResult recv_getOrderTransportInfo(){
				
				getOrderTransportInfo_result result = new getOrderTransportInfo_result();
				ReceiveBase(result, getOrderTransportInfo_resultHelper.getInstance());
				
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
			
			
			public com.vip.vop.cup.api.order.OrderOpResult updateCancelOrderRefundResult(List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> update_cancel_order_refund_result_req_list_) {
				
				send_updateCancelOrderRefundResult(update_cancel_order_refund_result_req_list_);
				return recv_updateCancelOrderRefundResult(); 
				
			}
			
			
			private void send_updateCancelOrderRefundResult(List<com.vip.vop.cup.api.order.UpdateCancelOrderRefundResultReq> update_cancel_order_refund_result_req_list_){
				
				InitInvocation("updateCancelOrderRefundResult");
				
				updateCancelOrderRefundResult_args args = new updateCancelOrderRefundResult_args();
				args.SetUpdate_cancel_order_refund_result_req_list(update_cancel_order_refund_result_req_list_);
				
				SendBase(args, updateCancelOrderRefundResult_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.OrderOpResult recv_updateCancelOrderRefundResult(){
				
				updateCancelOrderRefundResult_result result = new updateCancelOrderRefundResult_result();
				ReceiveBase(result, updateCancelOrderRefundResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.order.OrderOpResult updateOrderStatus(List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> update_order_status_req_list_) {
				
				send_updateOrderStatus(update_order_status_req_list_);
				return recv_updateOrderStatus(); 
				
			}
			
			
			private void send_updateOrderStatus(List<com.vip.vop.cup.api.order.UpdateOrderStatusReq> update_order_status_req_list_){
				
				InitInvocation("updateOrderStatus");
				
				updateOrderStatus_args args = new updateOrderStatus_args();
				args.SetUpdate_order_status_req_list(update_order_status_req_list_);
				
				SendBase(args, updateOrderStatus_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.order.OrderOpResult recv_updateOrderStatus(){
				
				updateOrderStatus_result result = new updateOrderStatus_result();
				ReceiveBase(result, updateOrderStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}