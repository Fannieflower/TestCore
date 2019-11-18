using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.inventory.service.wop{
	
	
	public class WopInventoryServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class inventoryAdjust_args {
			
			///<summary>
			/// WOP库存变动消息,最多20条
			///</summary>
			
			private List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> wopInvChgLogReqs_;
			
			public List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> GetWopInvChgLogReqs(){
				return this.wopInvChgLogReqs_;
			}
			
			public void SetWopInvChgLogReqs(List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> value){
				this.wopInvChgLogReqs_ = value;
			}
			
		}
		
		
		
		
		public class receiving_args {
			
			///<summary>
			/// 上抛流水列表，最多支持200条
			///</summary>
			
			private List<com.vip.xstore.inventory.service.wop.InventoryFlow> items_;
			
			public List<com.vip.xstore.inventory.service.wop.InventoryFlow> GetItems(){
				return this.items_;
			}
			
			public void SetItems(List<com.vip.xstore.inventory.service.wop.InventoryFlow> value){
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
		
		
		
		
		public class inventoryAdjust_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> success_;
			
			public Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class receiving_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> success_;
			
			public Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> value){
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
		
		
		
		
		public class inventoryAdjust_argsHelper : TBeanSerializer<inventoryAdjust_args>
		{
			
			public static inventoryAdjust_argsHelper OBJ = new inventoryAdjust_argsHelper();
			
			public static inventoryAdjust_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(inventoryAdjust_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> value;
					
					value = new List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.inventory.service.wop.WopInvChgLogReq elem0;
							
							elem0 = new com.vip.xstore.inventory.service.wop.WopInvChgLogReq();
							com.vip.xstore.inventory.service.wop.WopInvChgLogReqHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetWopInvChgLogReqs(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(inventoryAdjust_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetWopInvChgLogReqs() != null) {
					
					oprot.WriteFieldBegin("wopInvChgLogReqs");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.inventory.service.wop.WopInvChgLogReq _item0 in structs.GetWopInvChgLogReqs()){
						
						
						com.vip.xstore.inventory.service.wop.WopInvChgLogReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("wopInvChgLogReqs can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(inventoryAdjust_args bean){
				
				
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
					
					List<com.vip.xstore.inventory.service.wop.InventoryFlow> value;
					
					value = new List<com.vip.xstore.inventory.service.wop.InventoryFlow>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.inventory.service.wop.InventoryFlow elem1;
							
							elem1 = new com.vip.xstore.inventory.service.wop.InventoryFlow();
							com.vip.xstore.inventory.service.wop.InventoryFlowHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
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
					foreach(com.vip.xstore.inventory.service.wop.InventoryFlow _item0 in structs.GetItems()){
						
						
						com.vip.xstore.inventory.service.wop.InventoryFlowHelper.getInstance().Write(_item0, oprot);
						
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
		
		
		
		
		public class inventoryAdjust_resultHelper : TBeanSerializer<inventoryAdjust_result>
		{
			
			public static inventoryAdjust_resultHelper OBJ = new inventoryAdjust_resultHelper();
			
			public static inventoryAdjust_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(inventoryAdjust_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> value;
					
					value = new Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							com.vip.xstore.inventory.service.wop.WopInvChgRsp _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new com.vip.xstore.inventory.service.wop.WopInvChgRsp();
							com.vip.xstore.inventory.service.wop.WopInvChgRspHelper.getInstance().Read(_val0, iprot);
							
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
			
			
			public void Write(inventoryAdjust_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, com.vip.xstore.inventory.service.wop.WopInvChgRsp > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						com.vip.xstore.inventory.service.wop.WopInvChgRsp _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						com.vip.xstore.inventory.service.wop.WopInvChgRspHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(inventoryAdjust_result bean){
				
				
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
					
					Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> value;
					
					value = new Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							com.vip.xstore.inventory.service.wop.InventoryFlowResult _val1;
							_key1 = iprot.ReadString();
							
							
							_val1 = new com.vip.xstore.inventory.service.wop.InventoryFlowResult();
							com.vip.xstore.inventory.service.wop.InventoryFlowResultHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
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
					foreach(KeyValuePair< string, com.vip.xstore.inventory.service.wop.InventoryFlowResult > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						com.vip.xstore.inventory.service.wop.InventoryFlowResult _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						com.vip.xstore.inventory.service.wop.InventoryFlowResultHelper.getInstance().Write(_value0, oprot);
						
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
		
		
		
		
		public class WopInventoryServiceClient : OspRestStub , WopInventoryService  {
			
			
			public WopInventoryServiceClient():base("com.vip.xstore.inventory.service.wop.WopInventoryService","1.0.0") {
				
				
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
			
			
			public Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> inventoryAdjust(List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> wopInvChgLogReqs_) {
				
				send_inventoryAdjust(wopInvChgLogReqs_);
				return recv_inventoryAdjust(); 
				
			}
			
			
			private void send_inventoryAdjust(List<com.vip.xstore.inventory.service.wop.WopInvChgLogReq> wopInvChgLogReqs_){
				
				InitInvocation("inventoryAdjust");
				
				inventoryAdjust_args args = new inventoryAdjust_args();
				args.SetWopInvChgLogReqs(wopInvChgLogReqs_);
				
				SendBase(args, inventoryAdjust_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, com.vip.xstore.inventory.service.wop.WopInvChgRsp> recv_inventoryAdjust(){
				
				inventoryAdjust_result result = new inventoryAdjust_result();
				ReceiveBase(result, inventoryAdjust_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> receiving(List<com.vip.xstore.inventory.service.wop.InventoryFlow> items_) {
				
				send_receiving(items_);
				return recv_receiving(); 
				
			}
			
			
			private void send_receiving(List<com.vip.xstore.inventory.service.wop.InventoryFlow> items_){
				
				InitInvocation("receiving");
				
				receiving_args args = new receiving_args();
				args.SetItems(items_);
				
				SendBase(args, receiving_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, com.vip.xstore.inventory.service.wop.InventoryFlowResult> recv_receiving(){
				
				receiving_result result = new receiving_result();
				ReceiveBase(result, receiving_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}