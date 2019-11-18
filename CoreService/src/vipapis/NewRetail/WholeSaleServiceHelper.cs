using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.NewRetail{
	
	
	public class WholeSaleServiceHelper {
		
		
		
		public class getAfterSaleApplyId_args {
			
			///<summary>
			/// 查询时间段的开始时间,只能查询最近30天的数据
			///</summary>
			
			private System.DateTime? st_query_time_;
			
			///<summary>
			/// 查询时间段的结束时间,默认值为当前接口调用的时间，截止时间必须晚于开始时间, 不传默认为当前时间
			///
			///</summary>
			
			private System.DateTime? et_query_time_;
			
			///<summary>
			/// 当前页码（不传默认为：1）
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录条数（不传默认为：100，最大值：100）
			///</summary>
			
			private int? limit_;
			
			public System.DateTime? GetSt_query_time(){
				return this.st_query_time_;
			}
			
			public void SetSt_query_time(System.DateTime? value){
				this.st_query_time_ = value;
			}
			public System.DateTime? GetEt_query_time(){
				return this.et_query_time_;
			}
			
			public void SetEt_query_time(System.DateTime? value){
				this.et_query_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			
		}
		
		
		
		
		public class getAfterSaleDetail_args {
			
			///<summary>
			/// 售后申请单id列表,最大个数不超过10
			///</summary>
			
			private List<long?> apply_ids_;
			
			public List<long?> GetApply_ids(){
				return this.apply_ids_;
			}
			
			public void SetApply_ids(List<long?> value){
				this.apply_ids_ = value;
			}
			
		}
		
		
		
		
		public class getOrder_args {
			
			///<summary>
			/// 查询时间段的开始时间,只能查询最近30天的数据
			///</summary>
			
			private System.DateTime? st_query_time_;
			
			///<summary>
			/// 查询时间段的结束时间,默认值为当前接口调用的时间，截止时间必须晚于开始时间,不传默认赋值当前时间
			///</summary>
			
			private System.DateTime? et_query_time_;
			
			///<summary>
			/// 当前页码（不传默认为：1）
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录条数（不传默认为：100，最大值：100）
			///</summary>
			
			private int? limit_;
			
			public System.DateTime? GetSt_query_time(){
				return this.st_query_time_;
			}
			
			public void SetSt_query_time(System.DateTime? value){
				this.st_query_time_ = value;
			}
			public System.DateTime? GetEt_query_time(){
				return this.et_query_time_;
			}
			
			public void SetEt_query_time(System.DateTime? value){
				this.et_query_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			
		}
		
		
		
		
		public class getOrderDetail_args {
			
			///<summary>
			/// 订单编码列表，最大个数不超过10
			///</summary>
			
			private List<string> order_ids_;
			
			public List<string> GetOrder_ids(){
				return this.order_ids_;
			}
			
			public void SetOrder_ids(List<string> value){
				this.order_ids_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getAfterSaleApplyId_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse success_;
			
			public com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getAfterSaleDetail_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.newretail.AfterSaleDetail> success_;
			
			public List<com.vip.vop.cup.api.newretail.AfterSaleDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.newretail.AfterSaleDetail> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.newretail.GetOrdersResponse success_;
			
			public com.vip.vop.cup.api.newretail.GetOrdersResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.newretail.GetOrdersResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOrderDetail_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.newretail.OrderDetail> success_;
			
			public List<com.vip.vop.cup.api.newretail.OrderDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.newretail.OrderDetail> value){
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
		
		
		
		
		
		public class getAfterSaleApplyId_argsHelper : TBeanSerializer<getAfterSaleApplyId_args>
		{
			
			public static getAfterSaleApplyId_argsHelper OBJ = new getAfterSaleApplyId_argsHelper();
			
			public static getAfterSaleApplyId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAfterSaleApplyId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetSt_query_time(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEt_query_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAfterSaleApplyId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSt_query_time() != null) {
					
					oprot.WriteFieldBegin("st_query_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSt_query_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("st_query_time can not be null!");
				}
				
				
				if(structs.GetEt_query_time() != null) {
					
					oprot.WriteFieldBegin("et_query_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEt_query_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAfterSaleApplyId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAfterSaleDetail_argsHelper : TBeanSerializer<getAfterSaleDetail_args>
		{
			
			public static getAfterSaleDetail_argsHelper OBJ = new getAfterSaleDetail_argsHelper();
			
			public static getAfterSaleDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAfterSaleDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem0;
							elem0 = iprot.ReadI64(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetApply_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAfterSaleDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetApply_ids() != null) {
					
					oprot.WriteFieldBegin("apply_ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetApply_ids()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("apply_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAfterSaleDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrder_argsHelper : TBeanSerializer<getOrder_args>
		{
			
			public static getOrder_argsHelper OBJ = new getOrder_argsHelper();
			
			public static getOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetSt_query_time(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEt_query_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSt_query_time() != null) {
					
					oprot.WriteFieldBegin("st_query_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSt_query_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("st_query_time can not be null!");
				}
				
				
				if(structs.GetEt_query_time() != null) {
					
					oprot.WriteFieldBegin("et_query_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEt_query_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderDetail_argsHelper : TBeanSerializer<getOrderDetail_args>
		{
			
			public static getOrderDetail_argsHelper OBJ = new getOrderDetail_argsHelper();
			
			public static getOrderDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetOrder_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrder_ids() != null) {
					
					oprot.WriteFieldBegin("order_ids");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetOrder_ids()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("order_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderDetail_args bean){
				
				
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
		
		
		
		
		public class getAfterSaleApplyId_resultHelper : TBeanSerializer<getAfterSaleApplyId_result>
		{
			
			public static getAfterSaleApplyId_resultHelper OBJ = new getAfterSaleApplyId_resultHelper();
			
			public static getAfterSaleApplyId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAfterSaleApplyId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse value;
					
					value = new com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse();
					com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAfterSaleApplyId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAfterSaleApplyId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAfterSaleDetail_resultHelper : TBeanSerializer<getAfterSaleDetail_result>
		{
			
			public static getAfterSaleDetail_resultHelper OBJ = new getAfterSaleDetail_resultHelper();
			
			public static getAfterSaleDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAfterSaleDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.newretail.AfterSaleDetail> value;
					
					value = new List<com.vip.vop.cup.api.newretail.AfterSaleDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.newretail.AfterSaleDetail elem0;
							
							elem0 = new com.vip.vop.cup.api.newretail.AfterSaleDetail();
							com.vip.vop.cup.api.newretail.AfterSaleDetailHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getAfterSaleDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.newretail.AfterSaleDetail _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.newretail.AfterSaleDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAfterSaleDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrder_resultHelper : TBeanSerializer<getOrder_result>
		{
			
			public static getOrder_resultHelper OBJ = new getOrder_resultHelper();
			
			public static getOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.newretail.GetOrdersResponse value;
					
					value = new com.vip.vop.cup.api.newretail.GetOrdersResponse();
					com.vip.vop.cup.api.newretail.GetOrdersResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.newretail.GetOrdersResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderDetail_resultHelper : TBeanSerializer<getOrderDetail_result>
		{
			
			public static getOrderDetail_resultHelper OBJ = new getOrderDetail_resultHelper();
			
			public static getOrderDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.newretail.OrderDetail> value;
					
					value = new List<com.vip.vop.cup.api.newretail.OrderDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.newretail.OrderDetail elem0;
							
							elem0 = new com.vip.vop.cup.api.newretail.OrderDetail();
							com.vip.vop.cup.api.newretail.OrderDetailHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getOrderDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.newretail.OrderDetail _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.newretail.OrderDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderDetail_result bean){
				
				
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
		
		
		
		
		public class WholeSaleServiceClient : OspRestStub , WholeSaleService  {
			
			
			public WholeSaleServiceClient():base("vipapis.NewRetail.WholeSaleService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse getAfterSaleApplyId(System.DateTime st_query_time_,System.DateTime? et_query_time_,int? page_,int? limit_) {
				
				send_getAfterSaleApplyId(st_query_time_,et_query_time_,page_,limit_);
				return recv_getAfterSaleApplyId(); 
				
			}
			
			
			private void send_getAfterSaleApplyId(System.DateTime st_query_time_,System.DateTime? et_query_time_,int? page_,int? limit_){
				
				InitInvocation("getAfterSaleApplyId");
				
				getAfterSaleApplyId_args args = new getAfterSaleApplyId_args();
				args.SetSt_query_time(st_query_time_);
				args.SetEt_query_time(et_query_time_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				
				SendBase(args, getAfterSaleApplyId_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.newretail.GetAfterSaleApplyIdsResponse recv_getAfterSaleApplyId(){
				
				getAfterSaleApplyId_result result = new getAfterSaleApplyId_result();
				ReceiveBase(result, getAfterSaleApplyId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.newretail.AfterSaleDetail> getAfterSaleDetail(List<long?> apply_ids_) {
				
				send_getAfterSaleDetail(apply_ids_);
				return recv_getAfterSaleDetail(); 
				
			}
			
			
			private void send_getAfterSaleDetail(List<long?> apply_ids_){
				
				InitInvocation("getAfterSaleDetail");
				
				getAfterSaleDetail_args args = new getAfterSaleDetail_args();
				args.SetApply_ids(apply_ids_);
				
				SendBase(args, getAfterSaleDetail_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.newretail.AfterSaleDetail> recv_getAfterSaleDetail(){
				
				getAfterSaleDetail_result result = new getAfterSaleDetail_result();
				ReceiveBase(result, getAfterSaleDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.newretail.GetOrdersResponse getOrder(System.DateTime st_query_time_,System.DateTime? et_query_time_,int? page_,int? limit_) {
				
				send_getOrder(st_query_time_,et_query_time_,page_,limit_);
				return recv_getOrder(); 
				
			}
			
			
			private void send_getOrder(System.DateTime st_query_time_,System.DateTime? et_query_time_,int? page_,int? limit_){
				
				InitInvocation("getOrder");
				
				getOrder_args args = new getOrder_args();
				args.SetSt_query_time(st_query_time_);
				args.SetEt_query_time(et_query_time_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				
				SendBase(args, getOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.newretail.GetOrdersResponse recv_getOrder(){
				
				getOrder_result result = new getOrder_result();
				ReceiveBase(result, getOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.newretail.OrderDetail> getOrderDetail(List<string> order_ids_) {
				
				send_getOrderDetail(order_ids_);
				return recv_getOrderDetail(); 
				
			}
			
			
			private void send_getOrderDetail(List<string> order_ids_){
				
				InitInvocation("getOrderDetail");
				
				getOrderDetail_args args = new getOrderDetail_args();
				args.SetOrder_ids(order_ids_);
				
				SendBase(args, getOrderDetail_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.newretail.OrderDetail> recv_getOrderDetail(){
				
				getOrderDetail_result result = new getOrderDetail_result();
				ReceiveBase(result, getOrderDetail_resultHelper.getInstance());
				
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