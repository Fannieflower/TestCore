using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.inventory{
	
	
	public class InventoryFlowServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class pushUnknownFlows_args {
			
			///<summary>
			/// 流水ID
			///</summary>
			
			private long? id_;
			
			///<summary>
			/// 主体
			///</summary>
			
			private string companyCode_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			
		}
		
		
		
		
		public class receiving_args {
			
			///<summary>
			/// 上抛流水列表，最多支持500条
			///</summary>
			
			private List<vipapis.xstore.inventory.InventoryFlow> items_;
			
			public List<vipapis.xstore.inventory.InventoryFlow> GetItems(){
				return this.items_;
			}
			
			public void SetItems(List<vipapis.xstore.inventory.InventoryFlow> value){
				this.items_ = value;
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
		
		
		
		
		public class pushUnknownFlows_result {
			
			///<summary>
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class receiving_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> success_;
			
			public Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> value){
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
		
		
		
		
		public class pushUnknownFlows_argsHelper : TBeanSerializer<pushUnknownFlows_args>
		{
			
			public static pushUnknownFlows_argsHelper OBJ = new pushUnknownFlows_argsHelper();
			
			public static pushUnknownFlows_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushUnknownFlows_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushUnknownFlows_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("companyCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushUnknownFlows_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiving_argsHelper : TBeanSerializer<receiving_args>
		{
			
			public static receiving_argsHelper OBJ = new receiving_argsHelper();
			
			public static receiving_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiving_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.inventory.InventoryFlow> value;
					
					value = new List<vipapis.xstore.inventory.InventoryFlow>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.inventory.InventoryFlow elem0;
							
							elem0 = new vipapis.xstore.inventory.InventoryFlow();
							vipapis.xstore.inventory.InventoryFlowHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetItems(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiving_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetItems() != null) {
					
					oprot.WriteFieldBegin("items");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.inventory.InventoryFlow _item0 in structs.GetItems()){
						
						
						vipapis.xstore.inventory.InventoryFlowHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("items can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiving_args bean){
				
				
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
		
		
		
		
		public class pushUnknownFlows_resultHelper : TBeanSerializer<pushUnknownFlows_result>
		{
			
			public static pushUnknownFlows_resultHelper OBJ = new pushUnknownFlows_resultHelper();
			
			public static pushUnknownFlows_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushUnknownFlows_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushUnknownFlows_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushUnknownFlows_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receiving_resultHelper : TBeanSerializer<receiving_result>
		{
			
			public static receiving_resultHelper OBJ = new receiving_resultHelper();
			
			public static receiving_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receiving_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> value;
					
					value = new Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							vipapis.xstore.inventory.InventoryFlowResult _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new vipapis.xstore.inventory.InventoryFlowResult();
							vipapis.xstore.inventory.InventoryFlowResultHelper.getInstance().Read(_val0, iprot);
							
							value.Add(_key0, _val0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receiving_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, vipapis.xstore.inventory.InventoryFlowResult > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.inventory.InventoryFlowResult _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.inventory.InventoryFlowResultHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receiving_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class InventoryFlowServiceClient : OspRestStub , InventoryFlowService  {
			
			
			public InventoryFlowServiceClient():base("vipapis.xstore.inventory.InventoryFlowService","1.0.0") {
				
				
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
			
			
			public long? pushUnknownFlows(long id_,string companyCode_) {
				
				send_pushUnknownFlows(id_,companyCode_);
				return recv_pushUnknownFlows(); 
				
			}
			
			
			private void send_pushUnknownFlows(long id_,string companyCode_){
				
				InitInvocation("pushUnknownFlows");
				
				pushUnknownFlows_args args = new pushUnknownFlows_args();
				args.SetId(id_);
				args.SetCompanyCode(companyCode_);
				
				SendBase(args, pushUnknownFlows_argsHelper.getInstance());
			}
			
			
			private long? recv_pushUnknownFlows(){
				
				pushUnknownFlows_result result = new pushUnknownFlows_result();
				ReceiveBase(result, pushUnknownFlows_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> receiving(List<vipapis.xstore.inventory.InventoryFlow> items_) {
				
				send_receiving(items_);
				return recv_receiving(); 
				
			}
			
			
			private void send_receiving(List<vipapis.xstore.inventory.InventoryFlow> items_){
				
				InitInvocation("receiving");
				
				receiving_args args = new receiving_args();
				args.SetItems(items_);
				
				SendBase(args, receiving_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.inventory.InventoryFlowResult> recv_receiving(){
				
				receiving_result result = new receiving_result();
				ReceiveBase(result, receiving_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}