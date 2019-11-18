using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.sims.erp{
	
	
	
	public class InventoryAdjustRspHelper : TBeanSerializer<InventoryAdjustRsp>
	{
		
		public static InventoryAdjustRspHelper OBJ = new InventoryAdjustRspHelper();
		
		public static InventoryAdjustRspHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InventoryAdjustRsp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("resCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.xstore.cc.sims.erp.RspCodeEnum? value;
						
						value = vipapis.xstore.cc.sims.erp.RspCodeEnumUtil.FindByName(iprot.ReadString());
						
						structs.SetResCode(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("poMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, int?> value;
						
						value = new Dictionary<string, int?>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key1;
								int _val1;
								_key1 = iprot.ReadString();
								
								_val1 = iprot.ReadI32(); 
								
								value.Add(_key1, _val1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetPoMap(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(InventoryAdjustRsp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seqNo can not be null!");
			}
			
			
			if(structs.GetResCode() != null) {
				
				oprot.WriteFieldBegin("resCode");
				oprot.WriteString(structs.GetResCode().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resCode can not be null!");
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoMap() != null) {
				
				oprot.WriteFieldBegin("poMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, int? > _ir0 in structs.GetPoMap()){
					
					string _key0 = _ir0.Key;
					int? _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteI32((int)_value0); 
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InventoryAdjustRsp bean){
			
			
		}
		
	}
	
}