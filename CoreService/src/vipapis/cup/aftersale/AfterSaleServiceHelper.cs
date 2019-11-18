using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.aftersale{
	
	
	public class AfterSaleServiceHelper {
		
		
		
		public class createReturnApply_args {
			
			///<summary>
			/// 创建售后申请单请求列表
			///</summary>
			
			private List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> req_list_;
			
			public List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> GetReq_list(){
				return this.req_list_;
			}
			
			public void SetReq_list(List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> value){
				this.req_list_ = value;
			}
			
		}
		
		
		
		
		public class getReturnApplyStatus_args {
			
			///<summary>
			/// 开始时间，精确到秒，格式：yyyy-MM-dd HH:mm:ss，最大长度20
			///</summary>
			
			private string start_time_;
			
			///<summary>
			/// 结束时间，精确到秒，格式：yyyy-MM-dd HH:mm:ss，最大长度20
			///</summary>
			
			private string end_time_;
			
			///<summary>
			/// 页编号，默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页的数量，默认50
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
		
		
		
		
		public class updateReturnApplyStatus_args {
			
			///<summary>
			/// 更新售后申请单状态请求列表
			///</summary>
			
			private List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> req_list_;
			
			public List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> GetReq_list(){
				return this.req_list_;
			}
			
			public void SetReq_list(List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> value){
				this.req_list_ = value;
			}
			
		}
		
		
		
		
		public class updateReturnRefundResult_args {
			
			///<summary>
			/// 更新退货单退款结果请求列表
			///</summary>
			
			private List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> req_list_;
			
			public List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> GetReq_list(){
				return this.req_list_;
			}
			
			public void SetReq_list(List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> value){
				this.req_list_ = value;
			}
			
		}
		
		
		
		
		public class createReturnApply_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.aftersale.CreateReturnApplyResp success_;
			
			public com.vip.vop.cup.api.aftersale.CreateReturnApplyResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.aftersale.CreateReturnApplyResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getReturnApplyStatus_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp success_;
			
			public com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp value){
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
		
		
		
		
		public class updateReturnApplyStatus_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp success_;
			
			public com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateReturnRefundResult_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp success_;
			
			public com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class createReturnApply_argsHelper : TBeanSerializer<createReturnApply_args>
		{
			
			public static createReturnApply_argsHelper OBJ = new createReturnApply_argsHelper();
			
			public static createReturnApply_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createReturnApply_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> value;
					
					value = new List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.aftersale.CreateReturnApplyReq elem1;
							
							elem1 = new com.vip.vop.cup.api.aftersale.CreateReturnApplyReq();
							com.vip.vop.cup.api.aftersale.CreateReturnApplyReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReq_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createReturnApply_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq_list() != null) {
					
					oprot.WriteFieldBegin("req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.aftersale.CreateReturnApplyReq _item0 in structs.GetReq_list()){
						
						
						com.vip.vop.cup.api.aftersale.CreateReturnApplyReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createReturnApply_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnApplyStatus_argsHelper : TBeanSerializer<getReturnApplyStatus_args>
		{
			
			public static getReturnApplyStatus_argsHelper OBJ = new getReturnApplyStatus_argsHelper();
			
			public static getReturnApplyStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnApplyStatus_args structs, Protocol iprot){
				
				
				
				
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
			
			
			public void Write(getReturnApplyStatus_args structs, Protocol oprot){
				
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
			
			
			public void Validate(getReturnApplyStatus_args bean){
				
				
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
		
		
		
		
		public class updateReturnApplyStatus_argsHelper : TBeanSerializer<updateReturnApplyStatus_args>
		{
			
			public static updateReturnApplyStatus_argsHelper OBJ = new updateReturnApplyStatus_argsHelper();
			
			public static updateReturnApplyStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateReturnApplyStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> value;
					
					value = new List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq elem0;
							
							elem0 = new com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq();
							com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReqHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReq_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateReturnApplyStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq_list() != null) {
					
					oprot.WriteFieldBegin("req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq _item0 in structs.GetReq_list()){
						
						
						com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateReturnApplyStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateReturnRefundResult_argsHelper : TBeanSerializer<updateReturnRefundResult_args>
		{
			
			public static updateReturnRefundResult_argsHelper OBJ = new updateReturnRefundResult_argsHelper();
			
			public static updateReturnRefundResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateReturnRefundResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> value;
					
					value = new List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq elem1;
							
							elem1 = new com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq();
							com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetReq_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateReturnRefundResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq_list() != null) {
					
					oprot.WriteFieldBegin("req_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq _item0 in structs.GetReq_list()){
						
						
						com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateReturnRefundResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createReturnApply_resultHelper : TBeanSerializer<createReturnApply_result>
		{
			
			public static createReturnApply_resultHelper OBJ = new createReturnApply_resultHelper();
			
			public static createReturnApply_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createReturnApply_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.aftersale.CreateReturnApplyResp value;
					
					value = new com.vip.vop.cup.api.aftersale.CreateReturnApplyResp();
					com.vip.vop.cup.api.aftersale.CreateReturnApplyRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createReturnApply_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.aftersale.CreateReturnApplyRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createReturnApply_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnApplyStatus_resultHelper : TBeanSerializer<getReturnApplyStatus_result>
		{
			
			public static getReturnApplyStatus_resultHelper OBJ = new getReturnApplyStatus_resultHelper();
			
			public static getReturnApplyStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnApplyStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp value;
					
					value = new com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp();
					com.vip.vop.cup.api.aftersale.GetReturnApplyStatusRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getReturnApplyStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.aftersale.GetReturnApplyStatusRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getReturnApplyStatus_result bean){
				
				
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
		
		
		
		
		public class updateReturnApplyStatus_resultHelper : TBeanSerializer<updateReturnApplyStatus_result>
		{
			
			public static updateReturnApplyStatus_resultHelper OBJ = new updateReturnApplyStatus_resultHelper();
			
			public static updateReturnApplyStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateReturnApplyStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp value;
					
					value = new com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp();
					com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateReturnApplyStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateReturnApplyStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateReturnRefundResult_resultHelper : TBeanSerializer<updateReturnRefundResult_result>
		{
			
			public static updateReturnRefundResult_resultHelper OBJ = new updateReturnRefundResult_resultHelper();
			
			public static updateReturnRefundResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateReturnRefundResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp value;
					
					value = new com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp();
					com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateReturnRefundResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateReturnRefundResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class AfterSaleServiceClient : OspRestStub , AfterSaleService  {
			
			
			public AfterSaleServiceClient():base("vipapis.cup.aftersale.AfterSaleService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.cup.api.aftersale.CreateReturnApplyResp createReturnApply(List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> req_list_) {
				
				send_createReturnApply(req_list_);
				return recv_createReturnApply(); 
				
			}
			
			
			private void send_createReturnApply(List<com.vip.vop.cup.api.aftersale.CreateReturnApplyReq> req_list_){
				
				InitInvocation("createReturnApply");
				
				createReturnApply_args args = new createReturnApply_args();
				args.SetReq_list(req_list_);
				
				SendBase(args, createReturnApply_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.aftersale.CreateReturnApplyResp recv_createReturnApply(){
				
				createReturnApply_result result = new createReturnApply_result();
				ReceiveBase(result, createReturnApply_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp getReturnApplyStatus(string start_time_,string end_time_,int? page_,int? page_size_) {
				
				send_getReturnApplyStatus(start_time_,end_time_,page_,page_size_);
				return recv_getReturnApplyStatus(); 
				
			}
			
			
			private void send_getReturnApplyStatus(string start_time_,string end_time_,int? page_,int? page_size_){
				
				InitInvocation("getReturnApplyStatus");
				
				getReturnApplyStatus_args args = new getReturnApplyStatus_args();
				args.SetStart_time(start_time_);
				args.SetEnd_time(end_time_);
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				
				SendBase(args, getReturnApplyStatus_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.aftersale.GetReturnApplyStatusResp recv_getReturnApplyStatus(){
				
				getReturnApplyStatus_result result = new getReturnApplyStatus_result();
				ReceiveBase(result, getReturnApplyStatus_resultHelper.getInstance());
				
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
			
			
			public com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp updateReturnApplyStatus(List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> req_list_) {
				
				send_updateReturnApplyStatus(req_list_);
				return recv_updateReturnApplyStatus(); 
				
			}
			
			
			private void send_updateReturnApplyStatus(List<com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusReq> req_list_){
				
				InitInvocation("updateReturnApplyStatus");
				
				updateReturnApplyStatus_args args = new updateReturnApplyStatus_args();
				args.SetReq_list(req_list_);
				
				SendBase(args, updateReturnApplyStatus_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.aftersale.UpdateReturnApplyStatusResp recv_updateReturnApplyStatus(){
				
				updateReturnApplyStatus_result result = new updateReturnApplyStatus_result();
				ReceiveBase(result, updateReturnApplyStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp updateReturnRefundResult(List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> req_list_) {
				
				send_updateReturnRefundResult(req_list_);
				return recv_updateReturnRefundResult(); 
				
			}
			
			
			private void send_updateReturnRefundResult(List<com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultReq> req_list_){
				
				InitInvocation("updateReturnRefundResult");
				
				updateReturnRefundResult_args args = new updateReturnRefundResult_args();
				args.SetReq_list(req_list_);
				
				SendBase(args, updateReturnRefundResult_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.aftersale.UpdateReturnRefundResultResp recv_updateReturnRefundResult(){
				
				updateReturnRefundResult_result result = new updateReturnRefundResult_result();
				ReceiveBase(result, updateReturnRefundResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}