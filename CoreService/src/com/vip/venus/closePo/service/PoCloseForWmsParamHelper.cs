using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.closePo.service{
	
	
	
	public class PoCloseForWmsParamHelper : TBeanSerializer<PoCloseForWmsParam>
	{
		
		public static PoCloseForWmsParamHelper OBJ = new PoCloseForWmsParamHelper();
		
		public static PoCloseForWmsParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoCloseForWmsParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("maxId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMaxId(value);
					}
					
					
					
					
					
					if ("count".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCount(value);
					}
					
					
					
					
					
					if ("saleAreaList".Equals(schemeField.Trim())){
						
						needSkip = false;
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
						
						structs.SetSaleAreaList(value);
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
		
		
		public void Write(PoCloseForWmsParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMaxId() != null) {
				
				oprot.WriteFieldBegin("maxId");
				oprot.WriteI64((long)structs.GetMaxId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCount() != null) {
				
				oprot.WriteFieldBegin("count");
				oprot.WriteI64((long)structs.GetCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleAreaList() != null) {
				
				oprot.WriteFieldBegin("saleAreaList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSaleAreaList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoCloseForWmsParam bean){
			
			
		}
		
	}
	
}