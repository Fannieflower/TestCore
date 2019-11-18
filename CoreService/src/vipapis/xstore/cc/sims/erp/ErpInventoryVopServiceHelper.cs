using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.sims.erp{
	
	
	public class ErpInventoryVopServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class inventoryAdjust_args {
			
			///<summary>
			/// 库存变动消息
			///</summary>
			
			private List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> stockGainModelList_;
			
			public List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> GetStockGainModelList(){
				return this.stockGainModelList_;
			}
			
			public void SetStockGainModelList(List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> value){
				this.stockGainModelList_ = value;
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
			
			private Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> success_;
			
			public Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> value){
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
					
					List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> value;
					
					value = new List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.sims.erp.InventoryAdjustReq elem1;
							
							elem1 = new vipapis.xstore.cc.sims.erp.InventoryAdjustReq();
							vipapis.xstore.cc.sims.erp.InventoryAdjustReqHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetStockGainModelList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(inventoryAdjust_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetStockGainModelList() != null) {
					
					oprot.WriteFieldBegin("stockGainModelList");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.sims.erp.InventoryAdjustReq _item0 in structs.GetStockGainModelList()){
						
						
						vipapis.xstore.cc.sims.erp.InventoryAdjustReqHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("stockGainModelList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(inventoryAdjust_args bean){
				
				
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
					
					Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> value;
					
					value = new Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							vipapis.xstore.cc.sims.erp.InventoryAdjustRsp _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new vipapis.xstore.cc.sims.erp.InventoryAdjustRsp();
							vipapis.xstore.cc.sims.erp.InventoryAdjustRspHelper.getInstance().Read(_val0, iprot);
							
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
					foreach(KeyValuePair< string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.cc.sims.erp.InventoryAdjustRsp _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.cc.sims.erp.InventoryAdjustRspHelper.getInstance().Write(_value0, oprot);
						
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
		
		
		
		
		public class ErpInventoryVopServiceClient : OspRestStub , ErpInventoryVopService  {
			
			
			public ErpInventoryVopServiceClient():base("vipapis.xstore.cc.sims.erp.ErpInventoryVopService","1.0.0") {
				
				
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
			
			
			public Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> inventoryAdjust(List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> stockGainModelList_) {
				
				send_inventoryAdjust(stockGainModelList_);
				return recv_inventoryAdjust(); 
				
			}
			
			
			private void send_inventoryAdjust(List<vipapis.xstore.cc.sims.erp.InventoryAdjustReq> stockGainModelList_){
				
				InitInvocation("inventoryAdjust");
				
				inventoryAdjust_args args = new inventoryAdjust_args();
				args.SetStockGainModelList(stockGainModelList_);
				
				SendBase(args, inventoryAdjust_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.cc.sims.erp.InventoryAdjustRsp> recv_inventoryAdjust(){
				
				inventoryAdjust_result result = new inventoryAdjust_result();
				ReceiveBase(result, inventoryAdjust_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}