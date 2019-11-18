using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.venus.closePo.service{
	
	
	public class PoServiceShutDownHelper {
		
		
		
		public class getGoodReceiveInfoByPo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.venus.closePo.service.PoGoodReceiveInfoParam param_;
			
			public com.vip.venus.closePo.service.PoGoodReceiveInfoParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.venus.closePo.service.PoGoodReceiveInfoParam value){
				this.param_ = value;
			}
			
		}
		
		
		
		
		public class getPoCloseForWms_args {
			
			///<summary>
			///</summary>
			
			private com.vip.venus.closePo.service.PoCloseForWmsParam param_;
			
			public com.vip.venus.closePo.service.PoCloseForWmsParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.venus.closePo.service.PoCloseForWmsParam value){
				this.param_ = value;
			}
			
		}
		
		
		
		
		public class getPoCloseListByWarehouseCode_args {
			
			///<summary>
			/// 拉取开始节点
			///</summary>
			
			private long? maxId_;
			
			///<summary>
			/// 步长
			///</summary>
			
			private long? count_;
			
			///<summary>
			/// 仓库编码
			///</summary>
			
			private string warehouseCode_;
			
			public long? GetMaxId(){
				return this.maxId_;
			}
			
			public void SetMaxId(long? value){
				this.maxId_ = value;
			}
			public long? GetCount(){
				return this.count_;
			}
			
			public void SetCount(long? value){
				this.count_ = value;
			}
			public string GetWarehouseCode(){
				return this.warehouseCode_;
			}
			
			public void SetWarehouseCode(string value){
				this.warehouseCode_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class shutDownPo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.venus.closePo.service.ShutDownPoParam param_;
			
			public com.vip.venus.closePo.service.ShutDownPoParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.venus.closePo.service.ShutDownPoParam value){
				this.param_ = value;
			}
			
		}
		
		
		
		
		public class timedTasks_args {
			
			
		}
		
		
		
		
		public class getGoodReceiveInfoByPo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.venus.closePo.service.PoGoodReceiveInfoResult success_;
			
			public com.vip.venus.closePo.service.PoGoodReceiveInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.venus.closePo.service.PoGoodReceiveInfoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoCloseForWms_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.closePo.service.PoCloseForWmsReturn> success_;
			
			public List<com.vip.venus.closePo.service.PoCloseForWmsReturn> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.closePo.service.PoCloseForWmsReturn> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoCloseListByWarehouseCode_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.closePo.service.PoCloseMsg> success_;
			
			public List<com.vip.venus.closePo.service.PoCloseMsg> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.closePo.service.PoCloseMsg> value){
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
		
		
		
		
		public class shutDownPo_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class timedTasks_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getGoodReceiveInfoByPo_argsHelper : TBeanSerializer<getGoodReceiveInfoByPo_args>
		{
			
			public static getGoodReceiveInfoByPo_argsHelper OBJ = new getGoodReceiveInfoByPo_argsHelper();
			
			public static getGoodReceiveInfoByPo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGoodReceiveInfoByPo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.venus.closePo.service.PoGoodReceiveInfoParam value;
					
					value = new com.vip.venus.closePo.service.PoGoodReceiveInfoParam();
					com.vip.venus.closePo.service.PoGoodReceiveInfoParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getGoodReceiveInfoByPo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.venus.closePo.service.PoGoodReceiveInfoParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("param can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGoodReceiveInfoByPo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoCloseForWms_argsHelper : TBeanSerializer<getPoCloseForWms_args>
		{
			
			public static getPoCloseForWms_argsHelper OBJ = new getPoCloseForWms_argsHelper();
			
			public static getPoCloseForWms_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoCloseForWms_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.venus.closePo.service.PoCloseForWmsParam value;
					
					value = new com.vip.venus.closePo.service.PoCloseForWmsParam();
					com.vip.venus.closePo.service.PoCloseForWmsParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoCloseForWms_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.venus.closePo.service.PoCloseForWmsParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("param can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoCloseForWms_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoCloseListByWarehouseCode_argsHelper : TBeanSerializer<getPoCloseListByWarehouseCode_args>
		{
			
			public static getPoCloseListByWarehouseCode_argsHelper OBJ = new getPoCloseListByWarehouseCode_argsHelper();
			
			public static getPoCloseListByWarehouseCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoCloseListByWarehouseCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaxId(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetCount(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouseCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoCloseListByWarehouseCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaxId() != null) {
					
					oprot.WriteFieldBegin("maxId");
					oprot.WriteI64((long)structs.GetMaxId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("maxId can not be null!");
				}
				
				
				if(structs.GetCount() != null) {
					
					oprot.WriteFieldBegin("count");
					oprot.WriteI64((long)structs.GetCount()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("count can not be null!");
				}
				
				
				if(structs.GetWarehouseCode() != null) {
					
					oprot.WriteFieldBegin("warehouseCode");
					oprot.WriteString(structs.GetWarehouseCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("warehouseCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoCloseListByWarehouseCode_args bean){
				
				
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
		
		
		
		
		public class shutDownPo_argsHelper : TBeanSerializer<shutDownPo_args>
		{
			
			public static shutDownPo_argsHelper OBJ = new shutDownPo_argsHelper();
			
			public static shutDownPo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(shutDownPo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.venus.closePo.service.ShutDownPoParam value;
					
					value = new com.vip.venus.closePo.service.ShutDownPoParam();
					com.vip.venus.closePo.service.ShutDownPoParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(shutDownPo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.venus.closePo.service.ShutDownPoParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("param can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(shutDownPo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class timedTasks_argsHelper : TBeanSerializer<timedTasks_args>
		{
			
			public static timedTasks_argsHelper OBJ = new timedTasks_argsHelper();
			
			public static timedTasks_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(timedTasks_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(timedTasks_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(timedTasks_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getGoodReceiveInfoByPo_resultHelper : TBeanSerializer<getGoodReceiveInfoByPo_result>
		{
			
			public static getGoodReceiveInfoByPo_resultHelper OBJ = new getGoodReceiveInfoByPo_resultHelper();
			
			public static getGoodReceiveInfoByPo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGoodReceiveInfoByPo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.venus.closePo.service.PoGoodReceiveInfoResult value;
					
					value = new com.vip.venus.closePo.service.PoGoodReceiveInfoResult();
					com.vip.venus.closePo.service.PoGoodReceiveInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getGoodReceiveInfoByPo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.venus.closePo.service.PoGoodReceiveInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGoodReceiveInfoByPo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoCloseForWms_resultHelper : TBeanSerializer<getPoCloseForWms_result>
		{
			
			public static getPoCloseForWms_resultHelper OBJ = new getPoCloseForWms_resultHelper();
			
			public static getPoCloseForWms_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoCloseForWms_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.closePo.service.PoCloseForWmsReturn> value;
					
					value = new List<com.vip.venus.closePo.service.PoCloseForWmsReturn>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.closePo.service.PoCloseForWmsReturn elem0;
							
							elem0 = new com.vip.venus.closePo.service.PoCloseForWmsReturn();
							com.vip.venus.closePo.service.PoCloseForWmsReturnHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getPoCloseForWms_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.closePo.service.PoCloseForWmsReturn _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.closePo.service.PoCloseForWmsReturnHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoCloseForWms_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoCloseListByWarehouseCode_resultHelper : TBeanSerializer<getPoCloseListByWarehouseCode_result>
		{
			
			public static getPoCloseListByWarehouseCode_resultHelper OBJ = new getPoCloseListByWarehouseCode_resultHelper();
			
			public static getPoCloseListByWarehouseCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoCloseListByWarehouseCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.closePo.service.PoCloseMsg> value;
					
					value = new List<com.vip.venus.closePo.service.PoCloseMsg>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.closePo.service.PoCloseMsg elem1;
							
							elem1 = new com.vip.venus.closePo.service.PoCloseMsg();
							com.vip.venus.closePo.service.PoCloseMsgHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getPoCloseListByWarehouseCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.closePo.service.PoCloseMsg _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.closePo.service.PoCloseMsgHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoCloseListByWarehouseCode_result bean){
				
				
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
		
		
		
		
		public class shutDownPo_resultHelper : TBeanSerializer<shutDownPo_result>
		{
			
			public static shutDownPo_resultHelper OBJ = new shutDownPo_resultHelper();
			
			public static shutDownPo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(shutDownPo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(shutDownPo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(shutDownPo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class timedTasks_resultHelper : TBeanSerializer<timedTasks_result>
		{
			
			public static timedTasks_resultHelper OBJ = new timedTasks_resultHelper();
			
			public static timedTasks_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(timedTasks_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(timedTasks_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(timedTasks_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PoServiceShutDownClient : OspRestStub , PoServiceShutDown  {
			
			
			public PoServiceShutDownClient():base("com.vip.venus.closePo.service.PoServiceShutDown","1.0.0") {
				
				
			}
			
			
			
			public com.vip.venus.closePo.service.PoGoodReceiveInfoResult getGoodReceiveInfoByPo(com.vip.venus.closePo.service.PoGoodReceiveInfoParam param_) {
				
				send_getGoodReceiveInfoByPo(param_);
				return recv_getGoodReceiveInfoByPo(); 
				
			}
			
			
			private void send_getGoodReceiveInfoByPo(com.vip.venus.closePo.service.PoGoodReceiveInfoParam param_){
				
				InitInvocation("getGoodReceiveInfoByPo");
				
				getGoodReceiveInfoByPo_args args = new getGoodReceiveInfoByPo_args();
				args.SetParam(param_);
				
				SendBase(args, getGoodReceiveInfoByPo_argsHelper.getInstance());
			}
			
			
			private com.vip.venus.closePo.service.PoGoodReceiveInfoResult recv_getGoodReceiveInfoByPo(){
				
				getGoodReceiveInfoByPo_result result = new getGoodReceiveInfoByPo_result();
				ReceiveBase(result, getGoodReceiveInfoByPo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.venus.closePo.service.PoCloseForWmsReturn> getPoCloseForWms(com.vip.venus.closePo.service.PoCloseForWmsParam param_) {
				
				send_getPoCloseForWms(param_);
				return recv_getPoCloseForWms(); 
				
			}
			
			
			private void send_getPoCloseForWms(com.vip.venus.closePo.service.PoCloseForWmsParam param_){
				
				InitInvocation("getPoCloseForWms");
				
				getPoCloseForWms_args args = new getPoCloseForWms_args();
				args.SetParam(param_);
				
				SendBase(args, getPoCloseForWms_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.closePo.service.PoCloseForWmsReturn> recv_getPoCloseForWms(){
				
				getPoCloseForWms_result result = new getPoCloseForWms_result();
				ReceiveBase(result, getPoCloseForWms_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.venus.closePo.service.PoCloseMsg> getPoCloseListByWarehouseCode(long maxId_,long count_,string warehouseCode_) {
				
				send_getPoCloseListByWarehouseCode(maxId_,count_,warehouseCode_);
				return recv_getPoCloseListByWarehouseCode(); 
				
			}
			
			
			private void send_getPoCloseListByWarehouseCode(long maxId_,long count_,string warehouseCode_){
				
				InitInvocation("getPoCloseListByWarehouseCode");
				
				getPoCloseListByWarehouseCode_args args = new getPoCloseListByWarehouseCode_args();
				args.SetMaxId(maxId_);
				args.SetCount(count_);
				args.SetWarehouseCode(warehouseCode_);
				
				SendBase(args, getPoCloseListByWarehouseCode_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.closePo.service.PoCloseMsg> recv_getPoCloseListByWarehouseCode(){
				
				getPoCloseListByWarehouseCode_result result = new getPoCloseListByWarehouseCode_result();
				ReceiveBase(result, getPoCloseListByWarehouseCode_resultHelper.getInstance());
				
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
			
			
			public string shutDownPo(com.vip.venus.closePo.service.ShutDownPoParam param_) {
				
				send_shutDownPo(param_);
				return recv_shutDownPo(); 
				
			}
			
			
			private void send_shutDownPo(com.vip.venus.closePo.service.ShutDownPoParam param_){
				
				InitInvocation("shutDownPo");
				
				shutDownPo_args args = new shutDownPo_args();
				args.SetParam(param_);
				
				SendBase(args, shutDownPo_argsHelper.getInstance());
			}
			
			
			private string recv_shutDownPo(){
				
				shutDownPo_result result = new shutDownPo_result();
				ReceiveBase(result, shutDownPo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string timedTasks() {
				
				send_timedTasks();
				return recv_timedTasks(); 
				
			}
			
			
			private void send_timedTasks(){
				
				InitInvocation("timedTasks");
				
				timedTasks_args args = new timedTasks_args();
				
				SendBase(args, timedTasks_argsHelper.getInstance());
			}
			
			
			private string recv_timedTasks(){
				
				timedTasks_result result = new timedTasks_result();
				ReceiveBase(result, timedTasks_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}