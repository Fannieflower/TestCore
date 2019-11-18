using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.store{
	
	
	
	public class GetWarehouseResponseHelper : TBeanSerializer<GetWarehouseResponse>
	{
		
		public static GetWarehouseResponseHelper OBJ = new GetWarehouseResponseHelper();
		
		public static GetWarehouseResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetWarehouseResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.store.Warehouse> value;
						
						value = new List<vipapis.marketplace.store.Warehouse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.store.Warehouse elem0;
								
								elem0 = new vipapis.marketplace.store.Warehouse();
								vipapis.marketplace.store.WarehouseHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWarehouse(value);
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
		
		
		public void Write(GetWarehouseResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.store.Warehouse _item0 in structs.GetWarehouse()){
					
					
					vipapis.marketplace.store.WarehouseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetWarehouseResponse bean){
			
			
		}
		
	}
	
}